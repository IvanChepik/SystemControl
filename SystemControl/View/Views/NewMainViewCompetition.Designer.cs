namespace View.Views
{
    partial class NewMainViewCompetition
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
            this.AddNewMainCompetitionButton = new System.Windows.Forms.Button();
            this.CancelNewMaiCompetitionButton = new System.Windows.Forms.Button();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.FullnameTextBox = new System.Windows.Forms.TextBox();
            this.GroupTextBox = new System.Windows.Forms.TextBox();
            this.NameCompTextBox = new System.Windows.Forms.TextBox();
            this.StorageTextBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.FullnameLabel = new System.Windows.Forms.Label();
            this.StorageLabel = new System.Windows.Forms.Label();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNewMainCompetitionButton
            // 
            this.AddNewMainCompetitionButton.Location = new System.Drawing.Point(24, 262);
            this.AddNewMainCompetitionButton.Name = "AddNewMainCompetitionButton";
            this.AddNewMainCompetitionButton.Size = new System.Drawing.Size(75, 23);
            this.AddNewMainCompetitionButton.TabIndex = 1;
            this.AddNewMainCompetitionButton.Text = "Добавить";
            this.AddNewMainCompetitionButton.UseVisualStyleBackColor = true;
            this.AddNewMainCompetitionButton.Click += new System.EventHandler(this.AddNewMainCompetitionButton_Click);
            // 
            // CancelNewMaiCompetitionButton
            // 
            this.CancelNewMaiCompetitionButton.Location = new System.Drawing.Point(186, 262);
            this.CancelNewMaiCompetitionButton.Name = "CancelNewMaiCompetitionButton";
            this.CancelNewMaiCompetitionButton.Size = new System.Drawing.Size(75, 23);
            this.CancelNewMaiCompetitionButton.TabIndex = 2;
            this.CancelNewMaiCompetitionButton.Text = "Отмена";
            this.CancelNewMaiCompetitionButton.UseVisualStyleBackColor = true;
            this.CancelNewMaiCompetitionButton.Click += new System.EventHandler(this.CancelNewMaiCompetitionButton_Click);
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(161, 34);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(100, 20);
            this.DateTextBox.TabIndex = 3;
            // 
            // FullnameTextBox
            // 
            this.FullnameTextBox.Location = new System.Drawing.Point(161, 75);
            this.FullnameTextBox.Name = "FullnameTextBox";
            this.FullnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FullnameTextBox.TabIndex = 5;
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.Location = new System.Drawing.Point(161, 112);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(100, 20);
            this.GroupTextBox.TabIndex = 7;
            // 
            // NameCompTextBox
            // 
            this.NameCompTextBox.Location = new System.Drawing.Point(161, 150);
            this.NameCompTextBox.Name = "NameCompTextBox";
            this.NameCompTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameCompTextBox.TabIndex = 5;
            // 
            // StorageTextBox
            // 
            this.StorageTextBox.Location = new System.Drawing.Point(161, 189);
            this.StorageTextBox.Name = "StorageTextBox";
            this.StorageTextBox.Size = new System.Drawing.Size(100, 20);
            this.StorageTextBox.TabIndex = 9;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(35, 41);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(33, 13);
            this.DateLabel.TabIndex = 10;
            this.DateLabel.Text = "Дата";
            // 
            // FullnameLabel
            // 
            this.FullnameLabel.AutoSize = true;
            this.FullnameLabel.Location = new System.Drawing.Point(35, 82);
            this.FullnameLabel.Name = "FullnameLabel";
            this.FullnameLabel.Size = new System.Drawing.Size(34, 13);
            this.FullnameLabel.TabIndex = 12;
            this.FullnameLabel.Text = "ФИО";
            // 
            // StorageLabel
            // 
            this.StorageLabel.AutoSize = true;
            this.StorageLabel.Location = new System.Drawing.Point(35, 189);
            this.StorageLabel.Name = "StorageLabel";
            this.StorageLabel.Size = new System.Drawing.Size(89, 13);
            this.StorageLabel.TabIndex = 14;
            this.StorageLabel.Text = "Место хранения";
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Location = new System.Drawing.Point(35, 119);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(42, 13);
            this.GroupLabel.TabIndex = 14;
            this.GroupLabel.Text = "Группа";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(35, 150);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(57, 13);
            this.NameLabel.TabIndex = 16;
            this.NameLabel.Text = "Название";
            // 
            // NewMainViewCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 324);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.GroupLabel);
            this.Controls.Add(this.StorageLabel);
            this.Controls.Add(this.FullnameLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.StorageTextBox);
            this.Controls.Add(this.GroupTextBox);
            this.Controls.Add(this.FullnameTextBox);
            this.Controls.Add(this.NameCompTextBox);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.CancelNewMaiCompetitionButton);
            this.Controls.Add(this.AddNewMainCompetitionButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewMainViewCompetition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая конкурсная работа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewMainCompetitionButton;
        private System.Windows.Forms.Button CancelNewMaiCompetitionButton;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox FullnameTextBox;
        private System.Windows.Forms.TextBox GroupTextBox;
        private System.Windows.Forms.TextBox NameCompTextBox;
        private System.Windows.Forms.TextBox StorageTextBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label FullnameLabel;
        private System.Windows.Forms.Label StorageLabel;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.Label NameLabel;
    }
}