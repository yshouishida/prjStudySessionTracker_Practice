namespace prjStudySessionTracker_Practice.Forms
{
    partial class frmChangePwd
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
            this.btnChangePwd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRPwd = new System.Windows.Forms.TextBox();
            this.cbShowPwd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChangePwd.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePwd.ForeColor = System.Drawing.Color.White;
            this.btnChangePwd.Location = new System.Drawing.Point(12, 307);
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Size = new System.Drawing.Size(310, 66);
            this.btnChangePwd.TabIndex = 0;
            this.btnChangePwd.Text = "Change Password";
            this.btnChangePwd.UseVisualStyleBackColor = false;
            this.btnChangePwd.Click += new System.EventHandler(this.btnChangePwd_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change your password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Old password:";
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Location = new System.Drawing.Point(16, 115);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.Size = new System.Drawing.Size(306, 29);
            this.txtOldPwd.TabIndex = 3;
            this.txtOldPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOldPwd.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password:";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(16, 176);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(306, 29);
            this.txtNewPwd.TabIndex = 3;
            this.txtNewPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewPwd.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Re-enter Password:";
            // 
            // txtRPwd
            // 
            this.txtRPwd.Location = new System.Drawing.Point(16, 241);
            this.txtRPwd.Name = "txtRPwd";
            this.txtRPwd.Size = new System.Drawing.Size(306, 29);
            this.txtRPwd.TabIndex = 3;
            this.txtRPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRPwd.UseSystemPasswordChar = true;
            // 
            // cbShowPwd
            // 
            this.cbShowPwd.AutoSize = true;
            this.cbShowPwd.Location = new System.Drawing.Point(16, 276);
            this.cbShowPwd.Name = "cbShowPwd";
            this.cbShowPwd.Size = new System.Drawing.Size(138, 25);
            this.cbShowPwd.TabIndex = 4;
            this.cbShowPwd.Text = "Show Password";
            this.cbShowPwd.UseVisualStyleBackColor = true;
            this.cbShowPwd.CheckedChanged += new System.EventHandler(this.cbShowPwd_CheckedChanged);
            // 
            // frmChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 382);
            this.Controls.Add(this.cbShowPwd);
            this.Controls.Add(this.txtRPwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOldPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangePwd);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChangePwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form | Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangePwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRPwd;
        private System.Windows.Forms.CheckBox cbShowPwd;
    }
}