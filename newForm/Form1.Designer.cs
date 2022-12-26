
namespace newForm
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
            this.clickBtn = new System.Windows.Forms.Button();
            this.empID = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.userEmail = new System.Windows.Forms.Label();
            this.userCity = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.txtUserCity = new System.Windows.Forms.TextBox();
            this.deleteDataBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clickBtn
            // 
            this.clickBtn.BackColor = System.Drawing.SystemColors.Control;
            this.clickBtn.Location = new System.Drawing.Point(369, 344);
            this.clickBtn.Name = "clickBtn";
            this.clickBtn.Size = new System.Drawing.Size(100, 30);
            this.clickBtn.TabIndex = 0;
            this.clickBtn.Text = "Add Data";
            this.clickBtn.UseVisualStyleBackColor = false;
            this.clickBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // empID
            // 
            this.empID.AutoSize = true;
            this.empID.Location = new System.Drawing.Point(201, 137);
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(64, 20);
            this.empID.TabIndex = 1;
            this.empID.Text = "User ID";
            this.empID.Click += new System.EventHandler(this.empID_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(201, 187);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(51, 20);
            this.userName.TabIndex = 2;
            this.userName.Text = "Name";
            // 
            // userEmail
            // 
            this.userEmail.AutoSize = true;
            this.userEmail.Location = new System.Drawing.Point(201, 235);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(48, 20);
            this.userEmail.TabIndex = 3;
            this.userEmail.Text = "Email";
            this.userEmail.Click += new System.EventHandler(this.label2_Click);
            // 
            // userCity
            // 
            this.userCity.AutoSize = true;
            this.userCity.Location = new System.Drawing.Point(201, 282);
            this.userCity.Name = "userCity";
            this.userCity.Size = new System.Drawing.Size(35, 20);
            this.userCity.TabIndex = 4;
            this.userCity.Text = "City";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(282, 134);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(310, 26);
            this.txtUserID.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(282, 184);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(310, 26);
            this.txtUserName.TabIndex = 6;
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(282, 233);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(310, 26);
            this.txtUserEmail.TabIndex = 7;
            // 
            // txtUserCity
            // 
            this.txtUserCity.Location = new System.Drawing.Point(282, 279);
            this.txtUserCity.Name = "txtUserCity";
            this.txtUserCity.Size = new System.Drawing.Size(310, 26);
            this.txtUserCity.TabIndex = 8;
            // 
            // deleteDataBtn
            // 
            this.deleteDataBtn.Location = new System.Drawing.Point(55, 39);
            this.deleteDataBtn.Name = "deleteDataBtn";
            this.deleteDataBtn.Size = new System.Drawing.Size(115, 30);
            this.deleteDataBtn.TabIndex = 9;
            this.deleteDataBtn.Text = "Detete Data";
            this.deleteDataBtn.UseVisualStyleBackColor = true;
            this.deleteDataBtn.Click += new System.EventHandler(this.deleteDataBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(223, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Update Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteDataBtn);
            this.Controls.Add(this.txtUserCity);
            this.Controls.Add(this.txtUserEmail);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.userCity);
            this.Controls.Add(this.userEmail);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.empID);
            this.Controls.Add(this.clickBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickBtn;
        private System.Windows.Forms.Label empID;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label userEmail;
        private System.Windows.Forms.Label userCity;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.TextBox txtUserCity;
        private System.Windows.Forms.Button deleteDataBtn;
        private System.Windows.Forms.Button button1;
    }
}

