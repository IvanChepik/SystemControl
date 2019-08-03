namespace View.Views
{
    partial class NewMainViewOrder
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
            this.AddNewMainOrderButton = new System.Windows.Forms.Button();
            this.CancelNewMainOrderButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNewMainOrderButton
            // 
            this.AddNewMainOrderButton.Location = new System.Drawing.Point(12, 207);
            this.AddNewMainOrderButton.Name = "AddNewMainOrderButton";
            this.AddNewMainOrderButton.Size = new System.Drawing.Size(75, 23);
            this.AddNewMainOrderButton.TabIndex = 1;
            this.AddNewMainOrderButton.Text = "Добавить";
            this.AddNewMainOrderButton.UseVisualStyleBackColor = true;
            this.AddNewMainOrderButton.Click += new System.EventHandler(this.AddNewMainOrderButton_Click);
            // 
            // CancelNewMainOrderButton
            // 
            this.CancelNewMainOrderButton.Location = new System.Drawing.Point(166, 207);
            this.CancelNewMainOrderButton.Name = "CancelNewMainOrderButton";
            this.CancelNewMainOrderButton.Size = new System.Drawing.Size(75, 23);
            this.CancelNewMainOrderButton.TabIndex = 2;
            this.CancelNewMainOrderButton.Text = "Отмена";
            this.CancelNewMainOrderButton.UseVisualStyleBackColor = true;
            this.CancelNewMainOrderButton.Click += new System.EventHandler(this.CancelNewMainOrderButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(141, 38);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 3;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(141, 81);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(100, 20);
            this.DateTextBox.TabIndex = 4;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(141, 126);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.StatusTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Статус";
            // 
            // NewMainViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 260);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CancelNewMainOrderButton);
            this.Controls.Add(this.AddNewMainOrderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewMainViewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый приказ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewMainOrderButton;
        private System.Windows.Forms.Button CancelNewMainOrderButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}