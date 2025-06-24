namespace Tournament_Management_System.View
{
    partial class ManageGamesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gameIdTextBox = new System.Windows.Forms.TextBox();
            this.gameNameTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.gamesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "GameID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "GameName";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genre";
            // 
            // gameIdTextBox
            // 
            this.gameIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameIdTextBox.Location = new System.Drawing.Point(327, 49);
            this.gameIdTextBox.Multiline = true;
            this.gameIdTextBox.Name = "gameIdTextBox";
            this.gameIdTextBox.Size = new System.Drawing.Size(245, 46);
            this.gameIdTextBox.TabIndex = 3;
            // 
            // gameNameTextBox
            // 
            this.gameNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameNameTextBox.Location = new System.Drawing.Point(327, 122);
            this.gameNameTextBox.Multiline = true;
            this.gameNameTextBox.Name = "gameNameTextBox";
            this.gameNameTextBox.Size = new System.Drawing.Size(245, 46);
            this.gameNameTextBox.TabIndex = 4;
            // 
            // genreTextBox
            // 
            this.genreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genreTextBox.Location = new System.Drawing.Point(327, 206);
            this.genreTextBox.Multiline = true;
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(245, 46);
            this.genreTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(166, 319);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(121, 47);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(327, 319);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(121, 47);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(486, 319);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(121, 47);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(651, 319);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(121, 47);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(48, 619);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(127, 64);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back To Admin Dashboard";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // gamesDataGridView
            // 
            this.gamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gamesDataGridView.Location = new System.Drawing.Point(48, 415);
            this.gamesDataGridView.Name = "gamesDataGridView";
            this.gamesDataGridView.RowHeadersWidth = 51;
            this.gamesDataGridView.RowTemplate.Height = 24;
            this.gamesDataGridView.Size = new System.Drawing.Size(819, 170);
            this.gamesDataGridView.TabIndex = 12;
            this.gamesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ManageGamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 710);
            this.Controls.Add(this.gamesDataGridView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.gameNameTextBox);
            this.Controls.Add(this.gameIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageGamesForm";
            this.Text = "ManageGamesForm";
            this.Load += new System.EventHandler(this.ManageGamesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gameIdTextBox;
        private System.Windows.Forms.TextBox gameNameTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView gamesDataGridView;
    }
}