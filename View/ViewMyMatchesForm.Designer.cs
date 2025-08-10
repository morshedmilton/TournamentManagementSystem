namespace Tournament_Management_System.View
{
    partial class ViewMyMatchesForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tournamentsComboBox = new System.Windows.Forms.ComboBox();
            this.matchesDataGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matchesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select a Tournament You\'ve Joined:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "View My Matches";
            // 
            // tournamentsComboBox
            // 
            this.tournamentsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tournamentsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tournamentsComboBox.FormattingEnabled = true;
            this.tournamentsComboBox.Location = new System.Drawing.Point(505, 113);
            this.tournamentsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.tournamentsComboBox.Name = "tournamentsComboBox";
            this.tournamentsComboBox.Size = new System.Drawing.Size(254, 28);
            this.tournamentsComboBox.TabIndex = 2;
            // 
            // matchesDataGridView
            // 
            this.matchesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matchesDataGridView.Location = new System.Drawing.Point(13, 178);
            this.matchesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.matchesDataGridView.Name = "matchesDataGridView";
            this.matchesDataGridView.RowHeadersWidth = 51;
            this.matchesDataGridView.RowTemplate.Height = 24;
            this.matchesDataGridView.Size = new System.Drawing.Size(899, 431);
            this.matchesDataGridView.TabIndex = 3;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(13, 629);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(175, 58);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back to Dashboard";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // ViewMyMatchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 710);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.matchesDataGridView);
            this.Controls.Add(this.tournamentsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewMyMatchesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View My Matches";
            ((System.ComponentModel.ISupportInitialize)(this.matchesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tournamentsComboBox;
        private System.Windows.Forms.DataGridView matchesDataGridView;
        private System.Windows.Forms.Button backButton;
    }
}
