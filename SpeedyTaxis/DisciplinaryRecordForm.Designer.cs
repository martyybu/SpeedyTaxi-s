namespace SpeedyTaxis
{
    partial class DisciplinaryRecordForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DisciplinaryRecordNameLabel = new System.Windows.Forms.Label();
            this.DisciplinaryRecordExplanation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.ForeColor = System.Drawing.Color.Gold;
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(61, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "NameLabel";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.ForeColor = System.Drawing.Color.Gold;
            this.DateLabel.Location = new System.Drawing.Point(12, 33);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(56, 13);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "DateLabel";
            // 
            // DisciplinaryRecordNameLabel
            // 
            this.DisciplinaryRecordNameLabel.AutoSize = true;
            this.DisciplinaryRecordNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.DisciplinaryRecordNameLabel.ForeColor = System.Drawing.Color.Gold;
            this.DisciplinaryRecordNameLabel.Location = new System.Drawing.Point(12, 60);
            this.DisciplinaryRecordNameLabel.Name = "DisciplinaryRecordNameLabel";
            this.DisciplinaryRecordNameLabel.Size = new System.Drawing.Size(149, 13);
            this.DisciplinaryRecordNameLabel.TabIndex = 2;
            this.DisciplinaryRecordNameLabel.Text = "DisciplinaryRecordNameLabel";
            // 
            // DisciplinaryRecordExplanation
            // 
            this.DisciplinaryRecordExplanation.BackColor = System.Drawing.Color.Transparent;
            this.DisciplinaryRecordExplanation.ForeColor = System.Drawing.Color.Gold;
            this.DisciplinaryRecordExplanation.Location = new System.Drawing.Point(12, 87);
            this.DisciplinaryRecordExplanation.Name = "DisciplinaryRecordExplanation";
            this.DisciplinaryRecordExplanation.Size = new System.Drawing.Size(316, 152);
            this.DisciplinaryRecordExplanation.TabIndex = 3;
            this.DisciplinaryRecordExplanation.Text = "DisciplinaryRecordExplanation";
            // 
            // DisciplinaryRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 248);
            this.Controls.Add(this.DisciplinaryRecordExplanation);
            this.Controls.Add(this.DisciplinaryRecordNameLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "DisciplinaryRecordForm";
            this.Text = "Speedy Taxis Disciplinary Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.Label DateLabel;
        public System.Windows.Forms.Label DisciplinaryRecordNameLabel;
        public System.Windows.Forms.Label DisciplinaryRecordExplanation;
    }
}