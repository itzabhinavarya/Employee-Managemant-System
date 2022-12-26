
namespace newForm
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
            this.UpdatetxtUserCity = new System.Windows.Forms.TextBox();
            this.UpdatetxtUserEmail = new System.Windows.Forms.TextBox();
            this.UpdatetxtUserName = new System.Windows.Forms.TextBox();
            this.UpdatetxtUserID = new System.Windows.Forms.TextBox();
            this.userCity = new System.Windows.Forms.Label();
            this.userEmail = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.empID = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdatetxtUserCity
            // 
            this.UpdatetxtUserCity.Location = new System.Drawing.Point(192, 184);
            this.UpdatetxtUserCity.Name = "UpdatetxtUserCity";
            this.UpdatetxtUserCity.Size = new System.Drawing.Size(310, 26);
            this.UpdatetxtUserCity.TabIndex = 16;
            // 
            // UpdatetxtUserEmail
            // 
            this.UpdatetxtUserEmail.Location = new System.Drawing.Point(192, 138);
            this.UpdatetxtUserEmail.Name = "UpdatetxtUserEmail";
            this.UpdatetxtUserEmail.Size = new System.Drawing.Size(310, 26);
            this.UpdatetxtUserEmail.TabIndex = 15;
            // 
            // UpdatetxtUserName
            // 
            this.UpdatetxtUserName.Location = new System.Drawing.Point(192, 89);
            this.UpdatetxtUserName.Name = "UpdatetxtUserName";
            this.UpdatetxtUserName.Size = new System.Drawing.Size(310, 26);
            this.UpdatetxtUserName.TabIndex = 14;
            // 
            // UpdatetxtUserID
            // 
            this.UpdatetxtUserID.Location = new System.Drawing.Point(192, 39);
            this.UpdatetxtUserID.Name = "UpdatetxtUserID";
            this.UpdatetxtUserID.Size = new System.Drawing.Size(310, 26);
            this.UpdatetxtUserID.TabIndex = 13;
            // 
            // userCity
            // 
            this.userCity.AutoSize = true;
            this.userCity.Location = new System.Drawing.Point(111, 187);
            this.userCity.Name = "userCity";
            this.userCity.Size = new System.Drawing.Size(35, 20);
            this.userCity.TabIndex = 12;
            this.userCity.Text = "City";
            // 
            // userEmail
            // 
            this.userEmail.AutoSize = true;
            this.userEmail.Location = new System.Drawing.Point(111, 140);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(48, 20);
            this.userEmail.TabIndex = 11;
            this.userEmail.Text = "Email";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(111, 92);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(51, 20);
            this.userName.TabIndex = 10;
            this.userName.Text = "Name";
            // 
            // empID
            // 
            this.empID.AutoSize = true;
            this.empID.Location = new System.Drawing.Point(111, 42);
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(64, 20);
            this.empID.TabIndex = 9;
            this.empID.Text = "User ID";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(541, 37);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(132, 30);
            this.searchBtn.TabIndex = 17;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(263, 262);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(132, 30);
            this.updateBtn.TabIndex = 18;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.UpdatetxtUserCity);
            this.Controls.Add(this.UpdatetxtUserEmail);
            this.Controls.Add(this.UpdatetxtUserName);
            this.Controls.Add(this.UpdatetxtUserID);
            this.Controls.Add(this.userCity);
            this.Controls.Add(this.userEmail);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.empID);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UpdatetxtUserCity;
        private System.Windows.Forms.TextBox UpdatetxtUserEmail;
        private System.Windows.Forms.TextBox UpdatetxtUserName;
        private System.Windows.Forms.TextBox UpdatetxtUserID;
        private System.Windows.Forms.Label userCity;
        private System.Windows.Forms.Label userEmail;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label empID;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button updateBtn;
    }
}