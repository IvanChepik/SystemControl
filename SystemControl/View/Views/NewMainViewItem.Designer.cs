namespace View.Views
{
    partial class NewMainViewItem
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
            this.AddNewMainItemButton = new System.Windows.Forms.Button();
            this.CancelNewMainItemButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.ItemNumberTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.ActNumberTextBox = new System.Windows.Forms.TextBox();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNewMainItemButton
            // 
            this.AddNewMainItemButton.Location = new System.Drawing.Point(30, 207);
            this.AddNewMainItemButton.Name = "AddNewMainItemButton";
            this.AddNewMainItemButton.Size = new System.Drawing.Size(75, 23);
            this.AddNewMainItemButton.TabIndex = 1;
            this.AddNewMainItemButton.Text = "Добавить";
            this.AddNewMainItemButton.UseVisualStyleBackColor = true;
            this.AddNewMainItemButton.Click += new System.EventHandler(this.AddNewMainItemButton_Click);
            // 
            // CancelNewMainItemButton
            // 
            this.CancelNewMainItemButton.Location = new System.Drawing.Point(194, 207);
            this.CancelNewMainItemButton.Name = "CancelNewMainItemButton";
            this.CancelNewMainItemButton.Size = new System.Drawing.Size(75, 25);
            this.CancelNewMainItemButton.TabIndex = 2;
            this.CancelNewMainItemButton.Text = "Отмена";
            this.CancelNewMainItemButton.UseVisualStyleBackColor = true;
            this.CancelNewMainItemButton.Click += new System.EventHandler(this.CancelNewMainItemButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(169, 21);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 3;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(169, 99);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(100, 20);
            this.DateTextBox.TabIndex = 5;
            // 
            // ItemNumberTextBox
            // 
            this.ItemNumberTextBox.Location = new System.Drawing.Point(169, 47);
            this.ItemNumberTextBox.Name = "ItemNumberTextBox";
            this.ItemNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemNumberTextBox.TabIndex = 5;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(169, 73);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.QuantityTextBox.TabIndex = 7;
            // 
            // ActNumberTextBox
            // 
            this.ActNumberTextBox.Location = new System.Drawing.Point(169, 125);
            this.ActNumberTextBox.Name = "ActNumberTextBox";
            this.ActNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.ActNumberTextBox.TabIndex = 9;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(169, 151);
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(100, 20);
            this.NoteTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Инвентарный номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Номер акта списания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Количество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Дата";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Примечание";
            // 
            // NewMainViewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 259);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.ActNumberTextBox);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.ItemNumberTextBox);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CancelNewMainItemButton);
            this.Controls.Add(this.AddNewMainItemButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewMainViewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый журнал учета списанных предметов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewMainItemButton;
        private System.Windows.Forms.Button CancelNewMainItemButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox ItemNumberTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox ActNumberTextBox;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}