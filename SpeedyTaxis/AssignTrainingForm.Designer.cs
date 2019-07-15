namespace SpeedyTaxis
{
    partial class AssignTrainingForm
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
            this.ATnameLabel = new System.Windows.Forms.Label();
            this.ATidLabel = new System.Windows.Forms.Label();
            this.ATdataGridViewAvailabeSessions = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveTrainingBtn = new System.Windows.Forms.Button();
            this.AssignTrainingBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ATDataGridViewAssignedSessions = new System.Windows.Forms.DataGridView();
            this.AddTrainingBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ATdataGridViewAvailabeSessions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATDataGridViewAssignedSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // ATnameLabel
            // 
            this.ATnameLabel.AutoSize = true;
            this.ATnameLabel.Location = new System.Drawing.Point(66, 46);
            this.ATnameLabel.Name = "ATnameLabel";
            this.ATnameLabel.Size = new System.Drawing.Size(0, 13);
            this.ATnameLabel.TabIndex = 2;
            // 
            // ATidLabel
            // 
            this.ATidLabel.AutoSize = true;
            this.ATidLabel.Location = new System.Drawing.Point(66, 20);
            this.ATidLabel.Name = "ATidLabel";
            this.ATidLabel.Size = new System.Drawing.Size(0, 13);
            this.ATidLabel.TabIndex = 4;
            // 
            // ATdataGridViewAvailabeSessions
            // 
            this.ATdataGridViewAvailabeSessions.AllowUserToAddRows = false;
            this.ATdataGridViewAvailabeSessions.AllowUserToDeleteRows = false;
            this.ATdataGridViewAvailabeSessions.AllowUserToResizeColumns = false;
            this.ATdataGridViewAvailabeSessions.AllowUserToResizeRows = false;
            this.ATdataGridViewAvailabeSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ATdataGridViewAvailabeSessions.Location = new System.Drawing.Point(12, 91);
            this.ATdataGridViewAvailabeSessions.MultiSelect = false;
            this.ATdataGridViewAvailabeSessions.Name = "ATdataGridViewAvailabeSessions";
            this.ATdataGridViewAvailabeSessions.ReadOnly = true;
            this.ATdataGridViewAvailabeSessions.RowHeadersVisible = false;
            this.ATdataGridViewAvailabeSessions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ATdataGridViewAvailabeSessions.Size = new System.Drawing.Size(440, 113);
            this.ATdataGridViewAvailabeSessions.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Available Sessions";
            // 
            // RemoveTrainingBtn
            // 
            this.RemoveTrainingBtn.Location = new System.Drawing.Point(15, 380);
            this.RemoveTrainingBtn.Name = "RemoveTrainingBtn";
            this.RemoveTrainingBtn.Size = new System.Drawing.Size(113, 23);
            this.RemoveTrainingBtn.TabIndex = 8;
            this.RemoveTrainingBtn.Text = "Remove Training";
            this.RemoveTrainingBtn.UseVisualStyleBackColor = true;
            this.RemoveTrainingBtn.Click += new System.EventHandler(this.RemoveTrainingBtn_Click_1);
            // 
            // AssignTrainingBtn
            // 
            this.AssignTrainingBtn.Location = new System.Drawing.Point(178, 403);
            this.AssignTrainingBtn.Name = "AssignTrainingBtn";
            this.AssignTrainingBtn.Size = new System.Drawing.Size(109, 23);
            this.AssignTrainingBtn.TabIndex = 9;
            this.AssignTrainingBtn.Text = "Assign Training";
            this.AssignTrainingBtn.UseVisualStyleBackColor = true;
            this.AssignTrainingBtn.Click += new System.EventHandler(this.AssignTrainingBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(12, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Assigned Sessions";
            // 
            // ATDataGridViewAssignedSessions
            // 
            this.ATDataGridViewAssignedSessions.AllowUserToAddRows = false;
            this.ATDataGridViewAssignedSessions.AllowUserToDeleteRows = false;
            this.ATDataGridViewAssignedSessions.AllowUserToResizeColumns = false;
            this.ATDataGridViewAssignedSessions.AllowUserToResizeRows = false;
            this.ATDataGridViewAssignedSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ATDataGridViewAssignedSessions.Location = new System.Drawing.Point(15, 257);
            this.ATDataGridViewAssignedSessions.MultiSelect = false;
            this.ATDataGridViewAssignedSessions.Name = "ATDataGridViewAssignedSessions";
            this.ATDataGridViewAssignedSessions.ReadOnly = true;
            this.ATDataGridViewAssignedSessions.RowHeadersVisible = false;
            this.ATDataGridViewAssignedSessions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ATDataGridViewAssignedSessions.Size = new System.Drawing.Size(437, 117);
            this.ATDataGridViewAssignedSessions.TabIndex = 2;
            // 
            // AddTrainingBtn
            // 
            this.AddTrainingBtn.Location = new System.Drawing.Point(12, 210);
            this.AddTrainingBtn.Name = "AddTrainingBtn";
            this.AddTrainingBtn.Size = new System.Drawing.Size(113, 23);
            this.AddTrainingBtn.TabIndex = 12;
            this.AddTrainingBtn.Text = "Add Training";
            this.AddTrainingBtn.UseVisualStyleBackColor = true;
            this.AddTrainingBtn.Click += new System.EventHandler(this.AddTrainingBtn_Click);
            // 
            // AssignTrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.AddTrainingBtn);
            this.Controls.Add(this.ATDataGridViewAssignedSessions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AssignTrainingBtn);
            this.Controls.Add(this.RemoveTrainingBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ATdataGridViewAvailabeSessions);
            this.Controls.Add(this.ATidLabel);
            this.Controls.Add(this.ATnameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AssignTrainingForm";
            this.Text = "Speedy Taxis Assign Training";
            ((System.ComponentModel.ISupportInitialize)(this.ATdataGridViewAvailabeSessions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATDataGridViewAssignedSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label ATnameLabel;
        public System.Windows.Forms.Label ATidLabel;
        private System.Windows.Forms.DataGridView ATdataGridViewAvailabeSessions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RemoveTrainingBtn;
        private System.Windows.Forms.Button AssignTrainingBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ATDataGridViewAssignedSessions;
        private System.Windows.Forms.Button AddTrainingBtn;
    }
}