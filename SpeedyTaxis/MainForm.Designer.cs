namespace SpeedyTaxis
{
    partial class MainForm
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
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.DriverDataGridView = new System.Windows.Forms.DataGridView();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.AssignTrainingButton = new System.Windows.Forms.Button();
            this.CreateSessionBtn = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DriverDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(414, 73);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(85, 20);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(367, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(-1, -1);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(116, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add A Driver";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // DriverDataGridView
            // 
            this.DriverDataGridView.AllowUserToAddRows = false;
            this.DriverDataGridView.AllowUserToDeleteRows = false;
            this.DriverDataGridView.AllowUserToResizeColumns = false;
            this.DriverDataGridView.AllowUserToResizeRows = false;
            this.DriverDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriverDataGridView.Location = new System.Drawing.Point(12, 99);
            this.DriverDataGridView.Name = "DriverDataGridView";
            this.DriverDataGridView.ReadOnly = true;
            this.DriverDataGridView.RowHeadersVisible = false;
            this.DriverDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DriverDataGridView.Size = new System.Drawing.Size(487, 216);
            this.DriverDataGridView.TabIndex = 4;
            this.DriverDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DriverDataGridView_CellDoubleClick);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(330, -1);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(136, 23);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update Driver\'s Records";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateFormButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(134, 75);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(112, 23);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete A Driver";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(12, 75);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(116, 23);
            this.RefreshButton.TabIndex = 7;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // AssignTrainingButton
            // 
            this.AssignTrainingButton.Location = new System.Drawing.Point(222, -1);
            this.AssignTrainingButton.Name = "AssignTrainingButton";
            this.AssignTrainingButton.Size = new System.Drawing.Size(112, 23);
            this.AssignTrainingButton.TabIndex = 8;
            this.AssignTrainingButton.Text = "Assign Training";
            this.AssignTrainingButton.UseVisualStyleBackColor = true;
            this.AssignTrainingButton.Click += new System.EventHandler(this.AssignTrainingButton_Click);
            // 
            // CreateSessionBtn
            // 
            this.CreateSessionBtn.Location = new System.Drawing.Point(109, -1);
            this.CreateSessionBtn.Name = "CreateSessionBtn";
            this.CreateSessionBtn.Size = new System.Drawing.Size(116, 23);
            this.CreateSessionBtn.TabIndex = 9;
            this.CreateSessionBtn.Text = "Create A Session";
            this.CreateSessionBtn.UseVisualStyleBackColor = true;
            this.CreateSessionBtn.Click += new System.EventHandler(this.CreateSessionBtn_Click);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(464, -1);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(107, 23);
            this.Log.TabIndex = 10;
            this.Log.Text = "Log";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.Log_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 383);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.CreateSessionBtn);
            this.Controls.Add(this.AssignTrainingButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DriverDataGridView);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTextBox);
            this.Name = "MainForm";
            this.Text = "Speedy Taxis";
            ((System.ComponentModel.ISupportInitialize)(this.DriverDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button RefreshButton;
        public System.Windows.Forms.DataGridView DriverDataGridView;
        private System.Windows.Forms.Button AssignTrainingButton;
        private System.Windows.Forms.Button CreateSessionBtn;
        private System.Windows.Forms.Button Log;
    }
}