namespace prjStudySessionTracker_Practice.Forms
{
    partial class frmStudySessionDE
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
            this.txtSubjName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTaskCompleted = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDurHours = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSaveAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dtpStudydate = new System.Windows.Forms.DateTimePicker();
            this.cbActType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Study Session Data Entry";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject Name:";
            // 
            // txtSubjName
            // 
            this.txtSubjName.Location = new System.Drawing.Point(16, 114);
            this.txtSubjName.Name = "txtSubjName";
            this.txtSubjName.Size = new System.Drawing.Size(229, 29);
            this.txtSubjName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Activity Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Study Date:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(251, 181);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(229, 148);
            this.txtNotes.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Notes:";
            // 
            // txtTaskCompleted
            // 
            this.txtTaskCompleted.Location = new System.Drawing.Point(251, 114);
            this.txtTaskCompleted.Name = "txtTaskCompleted";
            this.txtTaskCompleted.Size = new System.Drawing.Size(229, 29);
            this.txtTaskCompleted.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Task Completed";
            // 
            // txtDurHours
            // 
            this.txtDurHours.Location = new System.Drawing.Point(16, 300);
            this.txtDurHours.Name = "txtDurHours";
            this.txtDurHours.Size = new System.Drawing.Size(229, 29);
            this.txtDurHours.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Duration Hours:";
            // 
            // btnSaveAdd
            // 
            this.btnSaveAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveAdd.Location = new System.Drawing.Point(16, 353);
            this.btnSaveAdd.Name = "btnSaveAdd";
            this.btnSaveAdd.Size = new System.Drawing.Size(229, 60);
            this.btnSaveAdd.TabIndex = 14;
            this.btnSaveAdd.Text = "Save";
            this.btnSaveAdd.UseVisualStyleBackColor = false;
            this.btnSaveAdd.Click += new System.EventHandler(this.btnSaveAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(251, 353);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(229, 60);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dtpStudydate
            // 
            this.dtpStudydate.Checked = false;
            this.dtpStudydate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpStudydate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStudydate.Location = new System.Drawing.Point(16, 244);
            this.dtpStudydate.Name = "dtpStudydate";
            this.dtpStudydate.ShowCheckBox = true;
            this.dtpStudydate.Size = new System.Drawing.Size(229, 29);
            this.dtpStudydate.TabIndex = 16;
            // 
            // cbActType
            // 
            this.cbActType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActType.FormattingEnabled = true;
            this.cbActType.Items.AddRange(new object[] {
            "Hands On",
            "Review",
            "Code Review",
            "Memorizing Code"});
            this.cbActType.Location = new System.Drawing.Point(12, 181);
            this.cbActType.Name = "cbActType";
            this.cbActType.Size = new System.Drawing.Size(229, 29);
            this.cbActType.TabIndex = 17;
            // 
            // frmStudySessionDE
            // 
            this.AcceptButton = this.btnSaveAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 426);
            this.Controls.Add(this.cbActType);
            this.Controls.Add(this.dtpStudydate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveAdd);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTaskCompleted);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDurHours);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubjName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudySessionDE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Entry";
            this.Load += new System.EventHandler(this.frmStudySessionDE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubjName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTaskCompleted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDurHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dtpStudydate;
        private System.Windows.Forms.ComboBox cbActType;
    }
}