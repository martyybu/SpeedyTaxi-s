namespace SpeedyTaxis
{
    partial class AddForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.AddQualificationsComboBox = new System.Windows.Forms.ComboBox();
            this.AddQualificationsGridView = new System.Windows.Forms.DataGridView();
            this.RemoveQualificationButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new PhoneNumberTextBoxMartynas.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.AddQualificationsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(13, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Qualifications";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(117, 32);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTextBox.TabIndex = 5;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(117, 60);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTextBox.TabIndex = 6;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.Location = new System.Drawing.Point(142, 419);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AddQualificationsComboBox
            // 
            this.AddQualificationsComboBox.FormattingEnabled = true;
            this.AddQualificationsComboBox.Location = new System.Drawing.Point(117, 140);
            this.AddQualificationsComboBox.Name = "AddQualificationsComboBox";
            this.AddQualificationsComboBox.Size = new System.Drawing.Size(242, 21);
            this.AddQualificationsComboBox.TabIndex = 9;
            this.AddQualificationsComboBox.SelectedIndexChanged += new System.EventHandler(this.QualificationsComboBoxAdd_SelectedIndexChanged);
            // 
            // AddQualificationsGridView
            // 
            this.AddQualificationsGridView.AllowUserToAddRows = false;
            this.AddQualificationsGridView.AllowUserToDeleteRows = false;
            this.AddQualificationsGridView.AllowUserToResizeColumns = false;
            this.AddQualificationsGridView.AllowUserToResizeRows = false;
            this.AddQualificationsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddQualificationsGridView.Location = new System.Drawing.Point(19, 198);
            this.AddQualificationsGridView.Name = "AddQualificationsGridView";
            this.AddQualificationsGridView.ReadOnly = true;
            this.AddQualificationsGridView.RowHeadersVisible = false;
            this.AddQualificationsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AddQualificationsGridView.Size = new System.Drawing.Size(340, 125);
            this.AddQualificationsGridView.TabIndex = 10;
            // 
            // RemoveQualificationButton
            // 
            this.RemoveQualificationButton.BackColor = System.Drawing.Color.Transparent;
            this.RemoveQualificationButton.Location = new System.Drawing.Point(19, 329);
            this.RemoveQualificationButton.Name = "RemoveQualificationButton";
            this.RemoveQualificationButton.Size = new System.Drawing.Size(151, 23);
            this.RemoveQualificationButton.TabIndex = 11;
            this.RemoveQualificationButton.Text = "Remove Qualification";
            this.RemoveQualificationButton.UseVisualStyleBackColor = false;
            this.RemoveQualificationButton.Click += new System.EventHandler(this.RemoveQualificationButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Phone Number";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(117, 92);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(160, 18);
            this.PhoneNumberTextBox.TabIndex = 14;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 454);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RemoveQualificationButton);
            this.Controls.Add(this.AddQualificationsGridView);
            this.Controls.Add(this.AddQualificationsComboBox);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.Text = "Speedy Taxis Add A Driver";
            ((System.ComponentModel.ISupportInitialize)(this.AddQualificationsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox AddQualificationsComboBox;
        private System.Windows.Forms.DataGridView AddQualificationsGridView;
        private System.Windows.Forms.Button RemoveQualificationButton;
        private System.Windows.Forms.Label label3;
        private PhoneNumberTextBoxMartynas.UserControl1 PhoneNumberTextBox;
    }
}