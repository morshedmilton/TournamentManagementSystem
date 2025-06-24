using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tournament_Management_System.View; // View ফোল্ডারটিকে রেফারেন্স করার জন্য এই লাইনটি জরুরি

namespace Tournament_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // এখানে new Form1() এর পরিবর্তে new LoginForm() লেখা হয়েছে
            Application.Run(new LoginForm());
        }
    }
}