
namespace DesktopProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainHeading = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.Button();
            this.dltBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.CreateAccount = new System.Windows.Forms.Button();
            this.LoginIntoAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainHeading
            // 
            this.mainHeading.AutoSize = true;
            this.mainHeading.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainHeading.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHeading.Location = new System.Drawing.Point(363, 9);
            this.mainHeading.Name = "mainHeading";
            this.mainHeading.Size = new System.Drawing.Size(611, 36);
            this.mainHeading.TabIndex = 0;
            this.mainHeading.Text = "Welcome To Employee Management System\r\n";
            // 
            // footer
            // 
            this.footer.AutoSize = true;
            this.footer.Location = new System.Drawing.Point(1092, 642);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(177, 20);
            this.footer.TabIndex = 1;
            this.footer.Text = "Project By Abhinav Arya";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.addBtn.Location = new System.Drawing.Point(237, 184);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(231, 50);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add Employee";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.searchBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.searchBtn.Location = new System.Drawing.Point(565, 185);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(267, 50);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search Employee";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click_1);
            // 
            // showBtn
            // 
            this.showBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showBtn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.showBtn.Location = new System.Drawing.Point(918, 184);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(257, 50);
            this.showBtn.TabIndex = 4;
            this.showBtn.Text = "Show Employee";
            this.showBtn.UseVisualStyleBackColor = false;
            this.showBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // dltBtn
            // 
            this.dltBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dltBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dltBtn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dltBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.dltBtn.Location = new System.Drawing.Point(568, 326);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(267, 50);
            this.dltBtn.TabIndex = 6;
            this.dltBtn.Text = "Delete Employee";
            this.dltBtn.UseVisualStyleBackColor = false;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.updateBtn.Location = new System.Drawing.Point(918, 325);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(257, 50);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update Employee";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // CreateAccount
            // 
            this.CreateAccount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateAccount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccount.ForeColor = System.Drawing.SystemColors.Info;
            this.CreateAccount.Location = new System.Drawing.Point(237, 326);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(231, 50);
            this.CreateAccount.TabIndex = 8;
            this.CreateAccount.Text = "Create Account";
            this.CreateAccount.UseVisualStyleBackColor = false;
            this.CreateAccount.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // LoginIntoAccount
            // 
            this.LoginIntoAccount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginIntoAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginIntoAccount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginIntoAccount.ForeColor = System.Drawing.SystemColors.Info;
            this.LoginIntoAccount.Location = new System.Drawing.Point(237, 443);
            this.LoginIntoAccount.Name = "LoginIntoAccount";
            this.LoginIntoAccount.Size = new System.Drawing.Size(231, 50);
            this.LoginIntoAccount.TabIndex = 9;
            this.LoginIntoAccount.Text = "Login";
            this.LoginIntoAccount.UseVisualStyleBackColor = false;
            this.LoginIntoAccount.Click += new System.EventHandler(this.LoginIntoAccount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1283, 709);
            this.Controls.Add(this.LoginIntoAccount);
            this.Controls.Add(this.CreateAccount);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.dltBtn);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.mainHeading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainHeading;
        private System.Windows.Forms.Label footer;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Button dltBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button CreateAccount;
        private System.Windows.Forms.Button LoginIntoAccount;
    }
}

