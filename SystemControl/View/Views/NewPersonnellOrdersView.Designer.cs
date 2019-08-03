namespace View.Views
{
    partial class NewPersonnellOrdersView
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
            this.AddPersonnelOrderButton = new System.Windows.Forms.Button();
            this.CancelPersonnelOrderButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddPersonnelOrderButton
            // 
            this.AddPersonnelOrderButton.Location = new System.Drawing.Point(30, 203);
            this.AddPersonnelOrderButton.Name = "AddPersonnelOrderButton";
            this.AddPersonnelOrderButton.Size = new System.Drawing.Size(75, 23);
            this.AddPersonnelOrderButton.TabIndex = 0;
            this.AddPersonnelOrderButton.Text = "Добавить";
            this.AddPersonnelOrderButton.UseVisualStyleBackColor = true;
            this.AddPersonnelOrderButton.Click += new System.EventHandler(this.AddPersonnelOrderButton_Click);
            // 
            // CancelPersonnelOrderButton
            // 
            this.CancelPersonnelOrderButton.Location = new System.Drawing.Point(157, 203);
            this.CancelPersonnelOrderButton.Name = "CancelPersonnelOrderButton";
            this.CancelPersonnelOrderButton.Size = new System.Drawing.Size(75, 23);
            this.CancelPersonnelOrderButton.TabIndex = 1;
            this.CancelPersonnelOrderButton.Text = "Отмена";
            this.CancelPersonnelOrderButton.UseVisualStyleBackColor = true;
            this.CancelPersonnelOrderButton.Click += new System.EventHandler(this.CancelPersonnelOrderButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(132, 35);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Location = new System.Drawing.Point(132, 61);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(100, 20);
            this.PositionTextBox.TabIndex = 4;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(132, 87);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FullNameTextBox.TabIndex = 6;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(132, 113);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(100, 20);
            this.DateTextBox.TabIndex = 8;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(132, 143);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.StatusTextBox.TabIndex = 10;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(27, 40);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(57, 13);
            this.NameLabel.TabIndex = 11;
            this.NameLabel.Text = "Название";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(27, 68);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(65, 13);
            this.PositionLabel.TabIndex = 13;
            this.PositionLabel.Text = "Должность";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(27, 94);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(34, 13);
            this.FullNameLabel.TabIndex = 15;
            this.FullNameLabel.Text = "ФИО";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(27, 120);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(33, 13);
            this.DateLabel.TabIndex = 17;
            this.DateLabel.Text = "Дата";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(27, 146);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(41, 13);
            this.StatusLabel.TabIndex = 19;
            this.StatusLabel.Text = "Статус";
            // 
            // NewPersonnellOrdersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 251);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CancelPersonnelOrderButton);
            this.Controls.Add(this.AddPersonnelOrderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewPersonnellOrdersView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый приказ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPersonnelOrderButton;
        private System.Windows.Forms.Button CancelPersonnelOrderButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label StatusLabel;
    }
}