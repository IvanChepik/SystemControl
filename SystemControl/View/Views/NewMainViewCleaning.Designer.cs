namespace View.Views
{
    partial class NewMainViewCleaning
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
            this.AddNewMainCleaningButton = new System.Windows.Forms.Button();
            this.CancelNewMainCleaningButton = new System.Windows.Forms.Button();
            this.PlaceTextBox = new System.Windows.Forms.TextBox();
            this.ExecutorTextBox = new System.Windows.Forms.TextBox();
            this.PlannedDateTextBox = new System.Windows.Forms.TextBox();
            this.DisinfectantTextBox = new System.Windows.Forms.TextBox();
            this.FactDateTextBox = new System.Windows.Forms.TextBox();
            this.PlaceLabel = new System.Windows.Forms.Label();
            this.PlannedDateLabel = new System.Windows.Forms.Label();
            this.DisinfectantLabel1 = new System.Windows.Forms.Label();
            this.DisinfectantLabel2 = new System.Windows.Forms.Label();
            this.FactDateLabel = new System.Windows.Forms.Label();
            this.ExecutorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNewMainCleaningButton
            // 
            this.AddNewMainCleaningButton.Location = new System.Drawing.Point(36, 248);
            this.AddNewMainCleaningButton.Name = "AddNewMainCleaningButton";
            this.AddNewMainCleaningButton.Size = new System.Drawing.Size(75, 23);
            this.AddNewMainCleaningButton.TabIndex = 1;
            this.AddNewMainCleaningButton.Text = "Добавить";
            this.AddNewMainCleaningButton.UseVisualStyleBackColor = true;
            this.AddNewMainCleaningButton.Click += new System.EventHandler(this.AddNewMainCleaningButton_Click);
            // 
            // CancelNewMainCleaningButton
            // 
            this.CancelNewMainCleaningButton.Location = new System.Drawing.Point(194, 248);
            this.CancelNewMainCleaningButton.Name = "CancelNewMainCleaningButton";
            this.CancelNewMainCleaningButton.Size = new System.Drawing.Size(75, 23);
            this.CancelNewMainCleaningButton.TabIndex = 2;
            this.CancelNewMainCleaningButton.Text = "Отмена";
            this.CancelNewMainCleaningButton.UseVisualStyleBackColor = true;
            this.CancelNewMainCleaningButton.Click += new System.EventHandler(this.CancelNewMainCleaningButton_Click);
            // 
            // PlaceTextBox
            // 
            this.PlaceTextBox.Location = new System.Drawing.Point(212, 25);
            this.PlaceTextBox.Name = "PlaceTextBox";
            this.PlaceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PlaceTextBox.TabIndex = 3;
            // 
            // ExecutorTextBox
            // 
            this.ExecutorTextBox.Location = new System.Drawing.Point(212, 179);
            this.ExecutorTextBox.Name = "ExecutorTextBox";
            this.ExecutorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ExecutorTextBox.TabIndex = 5;
            // 
            // PlannedDateTextBox
            // 
            this.PlannedDateTextBox.Location = new System.Drawing.Point(212, 64);
            this.PlannedDateTextBox.Name = "PlannedDateTextBox";
            this.PlannedDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.PlannedDateTextBox.TabIndex = 5;
            // 
            // DisinfectantTextBox
            // 
            this.DisinfectantTextBox.Location = new System.Drawing.Point(212, 107);
            this.DisinfectantTextBox.Name = "DisinfectantTextBox";
            this.DisinfectantTextBox.Size = new System.Drawing.Size(100, 20);
            this.DisinfectantTextBox.TabIndex = 5;
            // 
            // FactDateTextBox
            // 
            this.FactDateTextBox.Location = new System.Drawing.Point(212, 140);
            this.FactDateTextBox.Name = "FactDateTextBox";
            this.FactDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.FactDateTextBox.TabIndex = 7;
            // 
            // PlaceLabel
            // 
            this.PlaceLabel.AutoSize = true;
            this.PlaceLabel.Location = new System.Drawing.Point(37, 32);
            this.PlaceLabel.Name = "PlaceLabel";
            this.PlaceLabel.Size = new System.Drawing.Size(102, 13);
            this.PlaceLabel.TabIndex = 8;
            this.PlaceLabel.Text = "Место проведения";
            // 
            // PlannedDateLabel
            // 
            this.PlannedDateLabel.AutoSize = true;
            this.PlannedDateLabel.Location = new System.Drawing.Point(37, 71);
            this.PlannedDateLabel.Name = "PlannedDateLabel";
            this.PlannedDateLabel.Size = new System.Drawing.Size(102, 13);
            this.PlannedDateLabel.TabIndex = 10;
            this.PlannedDateLabel.Text = "Планируемая дата";
            // 
            // DisinfectantLabel1
            // 
            this.DisinfectantLabel1.AutoSize = true;
            this.DisinfectantLabel1.Location = new System.Drawing.Point(37, 107);
            this.DisinfectantLabel1.Name = "DisinfectantLabel1";
            this.DisinfectantLabel1.Size = new System.Drawing.Size(169, 13);
            this.DisinfectantLabel1.TabIndex = 12;
            this.DisinfectantLabel1.Text = "Наименования и концентрация ";
            // 
            // DisinfectantLabel2
            // 
            this.DisinfectantLabel2.AutoSize = true;
            this.DisinfectantLabel2.Location = new System.Drawing.Point(37, 124);
            this.DisinfectantLabel2.Name = "DisinfectantLabel2";
            this.DisinfectantLabel2.Size = new System.Drawing.Size(239, 13);
            this.DisinfectantLabel2.TabIndex = 14;
            this.DisinfectantLabel2.Text = "используемого дизенфицирующего средства";
            // 
            // FactDateLabel
            // 
            this.FactDateLabel.AutoSize = true;
            this.FactDateLabel.Location = new System.Drawing.Point(37, 147);
            this.FactDateLabel.Name = "FactDateLabel";
            this.FactDateLabel.Size = new System.Drawing.Size(165, 13);
            this.FactDateLabel.TabIndex = 16;
            this.FactDateLabel.Text = "Фактическая дата проведения";
            // 
            // ExecutorLabel
            // 
            this.ExecutorLabel.AutoSize = true;
            this.ExecutorLabel.Location = new System.Drawing.Point(37, 182);
            this.ExecutorLabel.Name = "ExecutorLabel";
            this.ExecutorLabel.Size = new System.Drawing.Size(74, 13);
            this.ExecutorLabel.TabIndex = 17;
            this.ExecutorLabel.Text = "Исполнитель";
            // 
            // NewMainViewCleaning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 310);
            this.Controls.Add(this.ExecutorLabel);
            this.Controls.Add(this.FactDateLabel);
            this.Controls.Add(this.DisinfectantLabel2);
            this.Controls.Add(this.DisinfectantLabel1);
            this.Controls.Add(this.PlannedDateLabel);
            this.Controls.Add(this.PlaceLabel);
            this.Controls.Add(this.FactDateTextBox);
            this.Controls.Add(this.PlannedDateTextBox);
            this.Controls.Add(this.DisinfectantTextBox);
            this.Controls.Add(this.ExecutorTextBox);
            this.Controls.Add(this.PlaceTextBox);
            this.Controls.Add(this.CancelNewMainCleaningButton);
            this.Controls.Add(this.AddNewMainCleaningButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewMainViewCleaning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая генеральная уборка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewMainCleaningButton;
        private System.Windows.Forms.Button CancelNewMainCleaningButton;
        private System.Windows.Forms.TextBox PlaceTextBox;
        private System.Windows.Forms.TextBox ExecutorTextBox;
        private System.Windows.Forms.TextBox PlannedDateTextBox;
        private System.Windows.Forms.TextBox DisinfectantTextBox;
        private System.Windows.Forms.TextBox FactDateTextBox;
        private System.Windows.Forms.Label PlaceLabel;
        private System.Windows.Forms.Label PlannedDateLabel;
        private System.Windows.Forms.Label DisinfectantLabel1;
        private System.Windows.Forms.Label DisinfectantLabel2;
        private System.Windows.Forms.Label FactDateLabel;
        private System.Windows.Forms.Label ExecutorLabel;
    }
}