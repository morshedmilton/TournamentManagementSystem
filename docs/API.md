### Tournament Management System - Public API and Usage Guide

This document describes the public APIs, classes, controllers, forms (user flows), and data access in the Tournament Management System WinForms application. It includes examples and usage instructions for developers extending or integrating with the codebase.

## Technology Stack
- Backend: .NET Framework 4.8.1 (WinForms)
- UI: Windows Forms (`System.Windows.Forms`)
- Data Access: ADO.NET (`System.Data.SqlClient`)
- Database: SQL Server (connection via App.config/`SqlDbDataAccess`)

Connection string (see `App.config` and `Model/SqlDbDataAccess.cs`):
```xml
<add name="Tournament_Management_System.Properties.Settings.OnlineTournamentDBConnectionString"
     connectionString="Data Source=DESKTOP-U1DM5HA;Initial Catalog=OnlineTournamentDB;Integrated Security=True;Encrypt=False"
     providerName="System.Data.SqlClient" />
```

## Application Entry Point
```1:23:/workspace/Program.cs
using System.Windows.Forms;
using Tournament_Management_System.View;

namespace Tournament_Management_System
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
```

## Database Schema (effective)
- Users: `UserID (PK), Username, PasswordHash, Email, Role, IsActive`
- Players: `PlayerID (PK), Player_FName, Player_LName, DateOfBirth, UserID (FK Users), TeamID (nullable FK Teams)`
- Teams: `TeamID (PK), TeamName, Date_Created, Captain_PlayerID (nullable FK Players)`
- Games: `GameID (PK), GameName, Genre`
- Tournaments: `TournamentID (PK), TournamentName, TournamentStartDate, TournamentEndDate, Status, GameID (FK Games), Organizer_UserID (FK Users)`
- TournamentRegistrations: `RegistrationID (PK), TournamentID (FK Tournaments), TeamID (FK Teams)`
- Matches: `MatchID (PK), Match_Round_Number, Match_DateTime, Status, Team1_Score, Team2_Score, TournamentID (FK), Team1_ID (FK Teams), Team2_ID (FK Teams), WinnerTeamID (nullable FK Teams)`

Relationships (summary):
- User 1–1 Player (via `Players.UserID`), Player 0..1–1 Team (`TeamID`)
- Team 0..* TournamentRegistration 0..* Tournament
- Tournament 1–* Match; Match references two Teams
- Team 0..1 Captain (via `Teams.Captain_PlayerID` -> Players)

## Authentication and Roles
- Authentication: Username + password hashed with SHA-256 in UI before lookup.
- Roles: `Admin`, `Player`.
- Account activation: `Users.IsActive` must be true for access.

Login flow (excerpt):
```42:86:/workspace/View/LoginForm.cs
string hashedPassword = ComputeSha256Hash(password);
UserController uc = new UserController();
User user = uc.SearchUser(username, hashedPassword);
if (user != null && user.IsActive) {
    if (user.Role.Equals("Admin")) new AdminDashboard(user).Show();
    else if (user.Role.Equals("Player")) new PlayerDashboard(user).Show();
}
```

Registration flow assigns `Player` role and active status:
```27:86:/workspace/View/RegistrationForm.cs
PlayerController playerController = new PlayerController();
playerController.AddPlayer(userId, username, password, email, playerId, fName, lName, dob);
```

## Models (POCOs)

### User (`Model/User.cs`)
Properties: `UserID:int`, `Username:string`, `PasswordHash:string`, `Email:string`, `Role:string`, `IsActive:bool`.
Constructors: default; `(int userId, string username, string passwordHash, string email, string role, bool isActive)`.

Example:
```csharp
var user = new User(1001, "alice", sha256("p@ss"), "alice@example.com", "Player", true);
```

### Player (`Model/Player.cs`)
Properties: `PlayerID:int`, `Player_FName:string`, `Player_LName:string`, `DateOfBirth:DateTime`, `UserID:int`, `TeamID:int?`.

### Team (`Model/Team.cs`)
Properties: `TeamID:int`, `TeamName:string`, `Date_Created:DateTime`, `Captain_PlayerID:int?`.

### Game (`Model/Game.cs`)
Properties: `GameID:int`, `GameName:string`, `Genre:string`.

### Tournament (`Model/Tournament.cs`)
Properties: `TournamentID:int`, `TournamentName:string`, `TournamentStartDate:DateTime`, `TournamentEndDate:DateTime`, `Status:string`, `GameID:int`, `Organizer_UserID:int`.

### Match (`Model/Match.cs`)
Properties: `MatchID:int`, `Match_Round_Number:string`, `Match_DateTime:DateTime`, `Status:string`, `Team1_Score:int`, `Team2_Score:int`, `TournamentID:int`, `Team1_ID:int`, `Team2_ID:int`, `WinnerTeamID:int?`.

### TournamentRegistration (`Model/TournamentRegistration.cs`)
Properties: `RegistrationID:int`, `TournamentID:int`, `TeamID:int`.

## Data Access (Repositories)
ADO.NET repositories encapsulate CRUD operations. All use `SqlDbDataAccess.GetQuery(string)` to create commands with a shared connection string.

Common pattern:
```1:25:/workspace/Model/SqlDbDataAccess.cs
public SqlCommand GetQuery(string query) {
    var connection = new SqlConnection(connectionString);
    SqlCommand cmd = new SqlCommand(query);
    cmd.Connection = connection;
    return cmd;
}
```

### Users (`Model/Users.cs`)
- `void AddUser(User user)`
- `void UpdateUser(User user)`
- `void DeleteUser(int userId)`
- `User SearchUser(string username, string passwordHash)`
- `User SearchUserById(int userId)`
- `User SearchUserByUsername(string username)`
- `List<User> GetAllUsers()`
- `bool IsUserIdTaken(int userId)`
- `bool IsUsernameTaken(string username)`
- `bool IsEmailTaken(string email)`

Usage:
```csharp
var usersRepo = new Users();
var found = usersRepo.SearchUser("alice", sha256("p@ss"));
```

### Players (`Model/Players.cs`)
- `void AddPlayer(Player player)`
- `void UpdatePlayer(Player player)`
- `void DeletePlayer(int playerId)`
- `Player SearchPlayerByUserId(int userId)`
- `Player SearchPlayerById(int playerId)`
- `int GetPlayerCountByTeam(int teamId)`
- `List<Player> GetAllPlayers()`

### Teams (`Model/Teams.cs`)
- `void AddTeam(Team team)`
- `void UpdateTeam(Team team)`
- `void DeleteTeam(int teamId)`
- `Team SearchTeamById(int teamId)`
- `List<Team> GetAllTeams()`

### Games (`Model/Games.cs`)
- `void AddGame(Game game)`
- `void UpdateGame(Game game)`
- `void DeleteGame(int gameId)`
- `Game SearchGameById(int gameId)`
- `List<Game> GetAllGames()`

### Tournaments (`Model/Tournaments.cs`)
- `int AddTournament(Tournament tournament)` returns new `TournamentID` (via `SCOPE_IDENTITY()`)
- `void UpdateTournament(Tournament tournament)`
- `void DeleteTournament(int tournamentId)`
- `Tournament SearchTournamentById(int tournamentId)`
- `List<Tournament> GetAllTournaments()`

### TournamentRegistrations (`Model/TournamentRegistrations.cs`)
- `void AddRegistration(TournamentRegistration reg)`
- `void UpdateRegistration(TournamentRegistration reg)`
- `void DeleteRegistration(int regId)`
- `void DeleteRegistrationsByTournament(int tournamentId)`
- `bool IsTeamRegistered(int tournamentId, int teamId)`
- `int GetRegistrationCountByTeam(int teamId)`
- `TournamentRegistration SearchRegistrationById(int regId)`
- `List<TournamentRegistration> GetAllRegistrations()`
- `List<TournamentRegistration> GetRegistrationsByTournament(int tournamentId)`
- `List<TournamentRegistration> GetRegistrationsByTeam(int teamId)`

### Matches (`Model/Matches.cs`)
- `void AddMatch(Match match)`
- `void AddMatches(List<Match> matches)`
- `void UpdateMatchResult(Match match)`
- `void DeleteMatch(int matchId)`
- `void DeleteMatchesByTournament(int tournamentId)`
- `Match SearchMatchById(int matchId)`
- `List<Match> GetMatchesByTournament(int tournamentId)`
- `List<Match> GetMatchesByTournamentAndTeam(int tournamentId, int teamId)`
- `int GetMatchCountByTeam(int teamId)`

## Controllers (Service Layer)
Controllers are thin wrappers around repositories used by forms. They expose the app’s public operations.

### UserController
```1:76:/workspace/Controller/UserController.cs
public void AddUser(User user)
public void UpdateUser(User user)
public void DeleteUser(int userId)
public User SearchUser(string username, string password)
public User SearchUserByUsername(string username)
public User SearchUserById(int userId)
public List<User> GetAllUsers()
public bool IsUserIdTaken(int userId)
public bool IsUsernameTaken(string username)
public bool IsEmailTaken(string email)
```

Usage:
```csharp
var uc = new UserController();
var user = uc.SearchUser("alice", sha256("p@ss"));
```

### PlayerController
```1:84:/workspace/Controller/PlayerController.cs
public void AddPlayer(int userId, string username, string password, string email, int playerId, string fName, string lName, DateTime dob)
public void UpdatePlayer(Player player)
public void DeletePlayer(int playerId)
public Player SearchPlayerByUserId(int userId)
public List<Player> GetAllPlayers()
public int GetPlayerCountByTeam(int teamId)
public Player SearchPlayerById(int playerId)
```

Notes: `AddPlayer` hashes the password using SHA-256 and creates both `User` and `Player` records with role "Player" and `IsActive=true`.

### TeamController
```1:44:/workspace/Controller/TeamController.cs
public void AddTeam(Team team)
public void UpdateTeam(Team team)
public void DeleteTeam(int teamId)
public List<Team> GetAllTeams()
public Team SearchTeamById(int teamId)
```

### GameController
```1:44:/workspace/Controller/GameController.cs
public void AddGame(Game game)
public void UpdateGame(Game game)
public void DeleteGame(int gameId)
public List<Game> GetAllGames()
public Game SearchGameById(int gameId)
```

### TournamentController
```1:45:/workspace/Controller/TournamentController.cs
public int AddTournament(Tournament tournament)
public void UpdateTournament(Tournament tournament)
public void DeleteTournament(int tournamentId)
public List<Tournament> GetAllTournaments()
public Tournament SearchTournamentById(int tournamentId)
```

### TournamentRegistrationController
```1:69:/workspace/Controller/TournamentRegistrationController.cs
public void AddRegistration(TournamentRegistration reg)
public void UpdateRegistration(TournamentRegistration reg)
public void DeleteRegistration(int regId)
public void DeleteRegistrationsByTournament(int tournamentId)
public bool IsTeamRegistered(int tournamentId, int teamId)
public int GetRegistrationCountByTeam(int teamId)
public TournamentRegistration SearchRegistrationById(int regId)
public List<TournamentRegistration> GetAllRegistrations()
public List<TournamentRegistration> GetRegistrationsByTeam(int teamId)
```

### MatchController
```1:69:/workspace/Controller/MatchController.cs
public void AddMatch(Match match)
public void AddMatches(List<Match> matches)
public void UpdateMatchResult(Match match)
public void DeleteMatch(int matchId)
public void DeleteMatchesByTournament(int tournamentId)
public int GetMatchCountByTeam(int teamId)
public Match SearchMatchById(int matchId)
public List<Match> GetMatchesByTournament(int tournamentId)
public List<Match> GetMatchesByTournamentAndTeam(int tournamentId, int teamId)
```

## UI Workflows (Forms)
These illustrate how controllers are used.

### AdminDashboard
- Manage tournaments: opens `ManageTournamentsAndMatchesForm`
- Manage users/teams: opens `ManageUsersAndTeamsForm`
- Manage games: opens `ManageGamesForm`

### ManageTournamentsAndMatchesForm
- Create/Update/Delete tournaments via `TournamentController`
- Generate round-robin matches across all teams for a selected tournament
- Update match results, set winner

Generate matches logic:
```315:339:/workspace/View/ManageTournamentsAndMatchesForm.cs
for (int i = 0; i < teams.Count; i++)
{
    for (int j = i + 1; j < teams.Count; j++)
    {
        var newMatch = new Match { TournamentID = selectedTournament.TournamentID, Team1_ID = teams[i].TeamID, Team2_ID = teams[j].TeamID, Match_Round_Number = "Round 1", Match_DateTime = selectedTournament.TournamentStartDate.AddDays(i), Status = "Scheduled", Team1_Score = 0, Team2_Score = 0, WinnerTeamID = null };
        matchesToCreate.Add(newMatch);
    }
}
```

### ManageUsersAndTeamsForm
- Activate/deactivate player accounts (updates `Users.IsActive`)
- Create/Update/Delete teams with captain assignment
- Add/Remove players to/from teams with validation (prevent duplicates; clear captain if removed)

### PlayerDashboard
- View tournaments (`ViewTournamentsForm`)
- View matches (`ViewMyMatchesForm`)
- Manage team (if captain) (`ManageTeamForm`)
- View/update profile (`PlayerProfileForm`)

### ViewTournamentsForm
- Lists all tournaments
- Register current player’s team to selected tournament (checks duplicates)

## Usage Examples

Create a team:
```csharp
var teamController = new TeamController();
teamController.AddTeam(new Team { TeamName = "Eagles", Date_Created = DateTime.Now });
```

Create a tournament:
```csharp
var tController = new TournamentController();
var tId = tController.AddTournament(new Tournament {
    TournamentName = "Spring Cup",
    TournamentStartDate = DateTime.Today,
    TournamentEndDate = DateTime.Today.AddDays(7),
    Status = "Scheduled",
    GameID = 1,
    Organizer_UserID = 1
});
```

Register a team:
```csharp
var trController = new TournamentRegistrationController();
if (!trController.IsTeamRegistered(tId, 5)) {
    trController.AddRegistration(new TournamentRegistration { TournamentID = tId, TeamID = 5 });
}
```

Update a match result:
```csharp
var mController = new MatchController();
var match = mController.SearchMatchById(42);
match.Team1_Score = 2;
match.Team2_Score = 1;
match.Status = "Completed";
match.WinnerTeamID = match.Team1_ID;
mController.UpdateMatchResult(match);
```

## Notes and Constraints
- IDs: Some tables auto-generate keys (e.g., `Tournaments.TournamentID` via identity on insert in repo). Others require explicit IDs in inserts (`Games`, `Players`, `Users`).
- Passwords: UI hashes with SHA-256 before lookup; salts are not used.
- RBAC: Enforced in UI navigation (Admin vs Player dashboards) rather than at repository level.
- Connection: Update `SqlDbDataAccess.connectionString`/`App.config` to match your SQL Server instance.

