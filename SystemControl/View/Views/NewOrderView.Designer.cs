namespace View.Views
{
    partial class NewOrderView
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
            this.AddNewOrderButton = new System.Windows.Forms.Button();
            this.CancelAddingOrderButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNewOrderButton
            // 
            this.AddNewOrderButton.Location = new System.Drawing.Point(26, 204);
            this.AddNewOrderButton.Name = "AddNewOrderButton";
            this.AddNewOrderButton.Size = new System.Drawing.Size(75, 23);
            this.AddNewOrderButton.TabIndex = 0;
            this.AddNewOrderButton.Text = "Добавить";
            this.AddNewOrderButton.UseVisualStyleBackColor = true;
            this.AddNewOrderButton.Click += new System.EventHandler(this.AddNewOrderButton_Click);
            // 
            // CancelAddingOrderButton
            // 
            this.CancelAddingOrderButton.Location = new System.Drawing.Point(170, 204);
            this.CancelAddingOrderButton.Name = "CancelAddingOrderButton";
            this.CancelAddingOrderButton.Size = new System.Drawing.Size(75, 23);
            this.CancelAddingOrderButton.TabIndex = 1;
            this.CancelAddingOrderButton.Text = "Отменить";
            this.CancelAddingOrderButton.UseVisualStyleBackColor = true;
            this.CancelAddingOrderButton.Click += new System.EventHandler(this.CancelAddingOrderButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(145, 24);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 3;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(145, 63);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FullNameTextBox.TabIndex = 4;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(145, 147);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.StatusTextBox.TabIndex = 6;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(145, 104);
            this.DateTextBox.Mask = "00/00/0000";
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(100, 20);
            this.DateTextBox.TabIndex = 7;
            this.DateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(23, 31);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(57, 13);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Название";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(23, 70);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(34, 13);
            this.FullNameLabel.TabIndex = 10;
            this.FullNameLabel.Text = "ФИО";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(23, 111);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(33, 13);
            this.DateLabel.TabIndex = 11;
            this.DateLabel.Text = "Дата";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(23, 154);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(41, 13);
            this.StatusLabel.TabIndex = 12;
            this.StatusLabel.Text = "Статус";
            // 
            // NewOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 255);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CancelAddingOrderButton);
            this.Controls.Add(this.AddNewOrderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewOrderView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый приказ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewOrderButton;
        private System.Windows.Forms.Button CancelAddingOrderButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.MaskedTextBox DateTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label StatusLabel;
    }
}