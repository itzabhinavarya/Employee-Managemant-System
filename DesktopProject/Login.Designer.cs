
namespace DesktopProject
{
    partial class Login
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
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Label();
            this.backToHome = new System.Windows.Forms.Button();
            this.LoginAccount = new System.Windows.Forms.Button();
            this.LoginEmail = new System.Windows.Forms.TextBox();
            this.empEmail = new System.Windows.Forms.Label();
            this.mainHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginPassword
            // 
            this.LoginPassword.Location = new System.Drawing.Point(583, 243);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Size = new System.Drawing.Size(349, 26);
            this.LoginPassword.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(456, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 67;
            this.label1.Text = "Password";
            // 
            // footer
            // 
            this.footer.AutoSize = true;
            this.footer.Location = new System.Drawing.Point(1108, 662);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(177, 20);
            this.footer.TabIndex = 66;
            this.footer.Text = "Project By Abhinav Arya";
            // 
            // backToHome
            // 
            this.backToHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToHome.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToHome.ForeColor = System.Drawing.SystemColors.Info;
            this.backToHome.Location = new System.Drawing.Point(43, 485);
            this.backToHome.Name = "backToHome";
            this.backToHome.Size = new System.Drawing.Size(249, 50);
            this.backToHome.TabIndex = 65;
            this.backToHome.Text = "BACK TO HOME";
            this.backToHome.UseMnemonic = false;
            this.backToHome.UseVisualStyleBackColor = false;
            // 
            // LoginAccount
            // 
            this.LoginAccount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginAccount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginAccount.ForeColor = System.Drawing.SystemColors.Info;
            this.LoginAccount.Location = new System.Drawing.Point(641, 336);
            this.LoginAccount.Name = "LoginAccount";
            this.LoginAccount.Size = new System.Drawing.Size(165, 50);
            this.LoginAccount.TabIndex = 64;
            this.LoginAccount.Text = "Login";
            this.LoginAccount.UseMnemonic = false;
            this.LoginAccount.UseVisualStyleBackColor = false;
            this.LoginAccount.Click += new System.EventHandler(this.LoginAccount_Click);
            // 
            // LoginEmail
            // 
            this.LoginEmail.Location = new System.Drawing.Point(583, 174);
            this.LoginEmail.Name = "LoginEmail";
            this.LoginEmail.Size = new System.Drawing.Size(349, 26);
            this.LoginEmail.TabIndex = 59;
            // 
            // empEmail
            // 
            this.empEmail.AutoSize = true;
            this.empEmail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.empEmail.Location = new System.Drawing.Point(456, 176);
            this.empEmail.Name = "empEmail";
            this.empEmail.Size = new System.Drawing.Size(71, 22);
            this.empEmail.TabIndex = 58;
            this.empEmail.Text = "Email ";
            // 
            // mainHeading
            // 
            this.mainHeading.AutoSize = true;
            this.mainHeading.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainHeading.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHeading.Location = new System.Drawing.Point(599, 43);
            this.mainHeading.Name = "mainHeading";
            this.mainHeading.Size = new System.Drawing.Size(207, 36);
            this.mainHeading.TabIndex = 55;
            this.mainHeading.Text = "Login Account";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 724);
            this.Controls.Add(this.LoginPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.backToHome);
            this.Controls.Add(this.LoginAccount);
            this.Controls.Add(this.LoginEmail);
            this.Controls.Add(this.empEmail);
            this.Controls.Add(this.mainHeading);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label footer;
        private System.Windows.Forms.Button backToHome;
        private System.Windows.Forms.Button LoginAccount;
        private System.Windows.Forms.TextBox LoginEmail;
        private System.Windows.Forms.Label empEmail;
        private System.Windows.Forms.Label mainHeading;
    }
}