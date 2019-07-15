namespace SpeedyTaxis
{
    partial class UpdateForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.QualificationsLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.UpdateQualificationsComboBox = new System.Windows.Forms.ComboBox();
            this.Label55 = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.UpdateQualificationsDGV = new System.Windows.Forms.DataGridView();
            this.RemoveQualificationButton = new System.Windows.Forms.Button();
            this.PhoneNumberTextBox = new PhoneNumberTextBoxMartynas.UserControl1();
            this.label1 = new System.Windows.Forms.Label();
            this.UFAssignedTrainingDGV = new System.Windows.Forms.DataGridView();
            this.UFAssignedTrainingComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UFDisciplinaryRecordsDGV = new System.Windows.Forms.DataGridView();
            this.AddDRecordButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.dateTimePickerDR = new System.Windows.Forms.DateTimePicker();
            this.DisciplinaryRecordLabel = new System.Windows.Forms.Label();
            this.DRExplanationRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DRTextBox = new System.Windows.Forms.TextBox();
            this.ExplanationLabel = new System.Windows.Forms.Label();
            this.AddARecordButtonMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateQualificationsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFAssignedTrainingDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFDisciplinaryRecordsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.ForeColor = System.Drawing.Color.Gold;
            this.nameLabel.Location = new System.Drawing.Point(58, 34);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.surnameLabel.ForeColor = System.Drawing.Color.Gold;
            this.surnameLabel.Location = new System.Drawing.Point(44, 62);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(49, 13);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Surname";
            // 
            // QualificationsLabel
            // 
            this.QualificationsLabel.AutoSize = true;
            this.QualificationsLabel.BackColor = System.Drawing.Color.Transparent;
            this.QualificationsLabel.ForeColor = System.Drawing.Color.Gold;
            this.QualificationsLabel.Location = new System.Drawing.Point(28, 129);
            this.QualificationsLabel.Name = "QualificationsLabel";
            this.QualificationsLabel.Size = new System.Drawing.Size(70, 13);
            this.QualificationsLabel.TabIndex = 3;
            this.QualificationsLabel.Text = "Qualifications";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(121, 31);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 4;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(121, 59);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SurnameTextBox.TabIndex = 5;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(173, 641);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UpdateQualificationsComboBox
            // 
            this.UpdateQualificationsComboBox.FormattingEnabled = true;
            this.UpdateQualificationsComboBox.Location = new System.Drawing.Point(112, 126);
            this.UpdateQualificationsComboBox.Name = "UpdateQualificationsComboBox";
            this.UpdateQualificationsComboBox.Size = new System.Drawing.Size(191, 21);
            this.UpdateQualificationsComboBox.TabIndex = 8;
            this.UpdateQualificationsComboBox.SelectedIndexChanged += new System.EventHandler(this.UpdateQualificationsBox_SelectedIndexChanged);
            // 
            // Label55
            // 
            this.Label55.AutoSize = true;
            this.Label55.BackColor = System.Drawing.Color.Transparent;
            this.Label55.ForeColor = System.Drawing.Color.Gold;
            this.Label55.Location = new System.Drawing.Point(69, 9);
            this.Label55.Name = "Label55";
            this.Label55.Size = new System.Drawing.Size(24, 13);
            this.Label55.TabIndex = 9;
            this.Label55.Text = "ID: ";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.BackColor = System.Drawing.Color.Transparent;
            this.IDLabel.ForeColor = System.Drawing.Color.Gold;
            this.IDLabel.Location = new System.Drawing.Point(118, 9);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(18, 13);
            this.IDLabel.TabIndex = 10;
            this.IDLabel.Text = "ID";
            // 
            // UpdateQualificationsDGV
            // 
            this.UpdateQualificationsDGV.AllowUserToAddRows = false;
            this.UpdateQualificationsDGV.AllowUserToDeleteRows = false;
            this.UpdateQualificationsDGV.AllowUserToResizeColumns = false;
            this.UpdateQualificationsDGV.AllowUserToResizeRows = false;
            this.UpdateQualificationsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UpdateQualificationsDGV.Location = new System.Drawing.Point(15, 153);
            this.UpdateQualificationsDGV.Name = "UpdateQualificationsDGV";
            this.UpdateQualificationsDGV.RowHeadersVisible = false;
            this.UpdateQualificationsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UpdateQualificationsDGV.Size = new System.Drawing.Size(288, 132);
            this.UpdateQualificationsDGV.TabIndex = 11;
            // 
            // RemoveQualificationButton
            // 
            this.RemoveQualificationButton.Location = new System.Drawing.Point(15, 291);
            this.RemoveQualificationButton.Name = "RemoveQualificationButton";
            this.RemoveQualificationButton.Size = new System.Drawing.Size(126, 23);
            this.RemoveQualificationButton.TabIndex = 12;
            this.RemoveQualificationButton.Text = "Remove Qualification";
            this.RemoveQualificationButton.UseVisualStyleBackColor = true;
            this.RemoveQualificationButton.Click += new System.EventHandler(this.RemoveQualificationBtn_Click);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(112, 92);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(180, 20);
            this.PhoneNumberTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(20, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Phone Number";
            // 
            // UFAssignedTrainingDGV
            // 
            this.UFAssignedTrainingDGV.AllowUserToAddRows = false;
            this.UFAssignedTrainingDGV.AllowUserToDeleteRows = false;
            this.UFAssignedTrainingDGV.AllowUserToResizeColumns = false;
            this.UFAssignedTrainingDGV.AllowUserToResizeRows = false;
            this.UFAssignedTrainingDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UFAssignedTrainingDGV.Location = new System.Drawing.Point(15, 346);
            this.UFAssignedTrainingDGV.Name = "UFAssignedTrainingDGV";
            this.UFAssignedTrainingDGV.RowHeadersVisible = false;
            this.UFAssignedTrainingDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UFAssignedTrainingDGV.Size = new System.Drawing.Size(436, 150);
            this.UFAssignedTrainingDGV.TabIndex = 15;
            this.UFAssignedTrainingDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.UFAssignedTrainingDGV_CellFormatting);
            this.UFAssignedTrainingDGV.SelectionChanged += new System.EventHandler(this.UFAssignedTrainingDGV_SelectionChanged);
            // 
            // UFAssignedTrainingComboBox
            // 
            this.UFAssignedTrainingComboBox.FormattingEnabled = true;
            this.UFAssignedTrainingComboBox.Location = new System.Drawing.Point(147, 319);
            this.UFAssignedTrainingComboBox.Name = "UFAssignedTrainingComboBox";
            this.UFAssignedTrainingComboBox.Size = new System.Drawing.Size(128, 21);
            this.UFAssignedTrainingComboBox.TabIndex = 16;
            this.UFAssignedTrainingComboBox.SelectedIndexChanged += new System.EventHandler(this.UFAssignedTrainingComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(17, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Assign Training Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(15, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Disciplinary Records";
            // 
            // UFDisciplinaryRecordsDGV
            // 
            this.UFDisciplinaryRecordsDGV.AllowUserToAddRows = false;
            this.UFDisciplinaryRecordsDGV.AllowUserToDeleteRows = false;
            this.UFDisciplinaryRecordsDGV.AllowUserToResizeColumns = false;
            this.UFDisciplinaryRecordsDGV.AllowUserToResizeRows = false;
            this.UFDisciplinaryRecordsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UFDisciplinaryRecordsDGV.Location = new System.Drawing.Point(15, 520);
            this.UFDisciplinaryRecordsDGV.Name = "UFDisciplinaryRecordsDGV";
            this.UFDisciplinaryRecordsDGV.RowHeadersVisible = false;
            this.UFDisciplinaryRecordsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UFDisciplinaryRecordsDGV.Size = new System.Drawing.Size(439, 87);
            this.UFDisciplinaryRecordsDGV.TabIndex = 19;
            this.UFDisciplinaryRecordsDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UFDisciplinaryRecordsDGV_CellDoubleClick);
            // 
            // AddDRecordButton
            // 
            this.AddDRecordButton.Location = new System.Drawing.Point(15, 614);
            this.AddDRecordButton.Name = "AddDRecordButton";
            this.AddDRecordButton.Size = new System.Drawing.Size(141, 23);
            this.AddDRecordButton.TabIndex = 20;
            this.AddDRecordButton.Text = "Add A Disciplinary Record";
            this.AddDRecordButton.UseVisualStyleBackColor = true;
            this.AddDRecordButton.Click += new System.EventHandler(this.AddDRecordButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(476, 391);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 21;
            this.DateLabel.Text = "Date";
            // 
            // dateTimePickerDR
            // 
            this.dateTimePickerDR.Location = new System.Drawing.Point(510, 385);
            this.dateTimePickerDR.Name = "dateTimePickerDR";
            this.dateTimePickerDR.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDR.TabIndex = 22;
            // 
            // DisciplinaryRecordLabel
            // 
            this.DisciplinaryRecordLabel.AutoSize = true;
            this.DisciplinaryRecordLabel.Location = new System.Drawing.Point(476, 408);
            this.DisciplinaryRecordLabel.Name = "DisciplinaryRecordLabel";
            this.DisciplinaryRecordLabel.Size = new System.Drawing.Size(98, 13);
            this.DisciplinaryRecordLabel.TabIndex = 23;
            this.DisciplinaryRecordLabel.Text = "Disciplinary Record";
            // 
            // DRExplanationRichTextBox
            // 
            this.DRExplanationRichTextBox.Location = new System.Drawing.Point(473, 464);
            this.DRExplanationRichTextBox.Name = "DRExplanationRichTextBox";
            this.DRExplanationRichTextBox.Size = new System.Drawing.Size(237, 109);
            this.DRExplanationRichTextBox.TabIndex = 24;
            this.DRExplanationRichTextBox.Text = "";
            // 
            // DRTextBox
            // 
            this.DRTextBox.Location = new System.Drawing.Point(479, 424);
            this.DRTextBox.Name = "DRTextBox";
            this.DRTextBox.Size = new System.Drawing.Size(231, 20);
            this.DRTextBox.TabIndex = 25;
            // 
            // ExplanationLabel
            // 
            this.ExplanationLabel.AutoSize = true;
            this.ExplanationLabel.Location = new System.Drawing.Point(476, 447);
            this.ExplanationLabel.Name = "ExplanationLabel";
            this.ExplanationLabel.Size = new System.Drawing.Size(62, 13);
            this.ExplanationLabel.TabIndex = 26;
            this.ExplanationLabel.Text = "Explanation";
            // 
            // AddARecordButtonMain
            // 
            this.AddARecordButtonMain.Location = new System.Drawing.Point(520, 584);
            this.AddARecordButtonMain.Name = "AddARecordButtonMain";
            this.AddARecordButtonMain.Size = new System.Drawing.Size(99, 23);
            this.AddARecordButtonMain.TabIndex = 27;
            this.AddARecordButtonMain.Text = "Add A Record";
            this.AddARecordButtonMain.UseVisualStyleBackColor = true;
            this.AddARecordButtonMain.Click += new System.EventHandler(this.AddARecordButtonMain_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 676);
            this.Controls.Add(this.AddARecordButtonMain);
            this.Controls.Add(this.ExplanationLabel);
            this.Controls.Add(this.DRTextBox);
            this.Controls.Add(this.DRExplanationRichTextBox);
            this.Controls.Add(this.DisciplinaryRecordLabel);
            this.Controls.Add(this.dateTimePickerDR);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.AddDRecordButton);
            this.Controls.Add(this.UFDisciplinaryRecordsDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UFAssignedTrainingComboBox);
            this.Controls.Add(this.UFAssignedTrainingDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.RemoveQualificationButton);
            this.Controls.Add(this.UpdateQualificationsDGV);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.Label55);
            this.Controls.Add(this.UpdateQualificationsComboBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.QualificationsLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "UpdateForm";
            this.Text = "Speedy Taxis Update Driver\'s Records";
            ((System.ComponentModel.ISupportInitialize)(this.UpdateQualificationsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFAssignedTrainingDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFDisciplinaryRecordsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label QualificationsLabel;
        public System.Windows.Forms.TextBox NameTextBox;
        public System.Windows.Forms.Label IDLabel;
        public System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ComboBox UpdateQualificationsComboBox;
        private System.Windows.Forms.Label Label55;
        private System.Windows.Forms.DataGridView UpdateQualificationsDGV;
        private System.Windows.Forms.Button RemoveQualificationButton;
        private PhoneNumberTextBoxMartynas.UserControl1 PhoneNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView UFAssignedTrainingDGV;
        private System.Windows.Forms.ComboBox UFAssignedTrainingComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView UFDisciplinaryRecordsDGV;
        private System.Windows.Forms.Button AddDRecordButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerDR;
        private System.Windows.Forms.Label DisciplinaryRecordLabel;
        private System.Windows.Forms.RichTextBox DRExplanationRichTextBox;
        private System.Windows.Forms.TextBox DRTextBox;
        private System.Windows.Forms.Label ExplanationLabel;
        private System.Windows.Forms.Button AddARecordButtonMain;
    }
}