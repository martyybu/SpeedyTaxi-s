namespace SpeedyTaxis
{
    partial class CreateSessionForm
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
            this.ATDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ATComboBox = new System.Windows.Forms.ComboBox();
            this.CreateSessionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Training Type";
            // 
            // ATDateTimePicker
            // 
            this.ATDateTimePicker.Location = new System.Drawing.Point(81, 26);
            this.ATDateTimePicker.MinDate = new System.DateTime(2019, 3, 10, 0, 0, 0, 0);
            this.ATDateTimePicker.Name = "ATDateTimePicker";
            this.ATDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ATDateTimePicker.TabIndex = 3;
            // 
            // ATComboBox
            // 
            this.ATComboBox.FormattingEnabled = true;
            this.ATComboBox.Location = new System.Drawing.Point(123, 65);
            this.ATComboBox.Name = "ATComboBox";
            this.ATComboBox.Size = new System.Drawing.Size(197, 21);
            this.ATComboBox.TabIndex = 4;
            // 
            // CreateSessionBtn
            // 
            this.CreateSessionBtn.Location = new System.Drawing.Point(123, 123);
            this.CreateSessionBtn.Name = "CreateSessionBtn";
            this.CreateSessionBtn.Size = new System.Drawing.Size(100, 23);
            this.CreateSessionBtn.TabIndex = 5;
            this.CreateSessionBtn.Text = "Create a session";
            this.CreateSessionBtn.UseVisualStyleBackColor = true;
            this.CreateSessionBtn.Click += new System.EventHandler(this.CreateSessionBtn_Click);
            // 
            // CreateSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 220);
            this.Controls.Add(this.CreateSessionBtn);
            this.Controls.Add(this.ATComboBox);
            this.Controls.Add(this.ATDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateSessionForm";
            this.Text = "Speedy Taxis Create A Session";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ATDateTimePicker;
        private System.Windows.Forms.ComboBox ATComboBox;
        private System.Windows.Forms.Button CreateSessionBtn;
    }
}