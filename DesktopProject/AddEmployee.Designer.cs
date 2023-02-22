
namespace DesktopProject
{
    partial class AddEmployee
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
            this.mainHeading = new System.Windows.Forms.Label();
            this.EmpId = new System.Windows.Forms.Label();
            this.addEmpIdTxtBox = new System.Windows.Forms.TextBox();
            this.addEmpNameTxtBox = new System.Windows.Forms.TextBox();
            this.empName = new System.Windows.Forms.Label();
            this.addEmpEmailTxtBox = new System.Windows.Forms.TextBox();
            this.empEmail = new System.Windows.Forms.Label();
            this.addEmpPhoneTxtBox = new System.Windows.Forms.TextBox();
            this.empPhone = new System.Windows.Forms.Label();
            this.addEmpCityTxtBox = new System.Windows.Forms.TextBox();
            this.empCity = new System.Windows.Forms.Label();
            this.addEmpBtn = new System.Windows.Forms.Button();
            this.backToHome = new System.Windows.Forms.Button();
            this.footer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainHeading
            // 
            this.mainHeading.AutoSize = true;
            this.mainHeading.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainHeading.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHeading.Location = new System.Drawing.Point(431, 35);
            this.mainHeading.Name = "mainHeading";
            this.mainHeading.Size = new System.Drawing.Size(374, 36);
            this.mainHeading.TabIndex = 1;
            this.mainHeading.Text = "Add Employee In DataBase";
            this.mainHeading.Click += new System.EventHandler(this.mainHeading_Click);
            // 
            // EmpId
            // 
            this.EmpId.AutoSize = true;
            this.EmpId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.EmpId.Location = new System.Drawing.Point(395, 159);
            this.EmpId.Name = "EmpId";
            this.EmpId.Size = new System.Drawing.Size(91, 22);
            this.EmpId.TabIndex = 2;
            this.EmpId.Text = "Emp ID ";
            this.EmpId.Click += new System.EventHandler(this.label1_Click);
            // 
            // addEmpIdTxtBox
            // 
            this.addEmpIdTxtBox.Location = new System.Drawing.Point(522, 157);
            this.addEmpIdTxtBox.Name = "addEmpIdTxtBox";
            this.addEmpIdTxtBox.Size = new System.Drawing.Size(349, 26);
            this.addEmpIdTxtBox.TabIndex = 3;
            // 
            // addEmpNameTxtBox
            // 
            this.addEmpNameTxtBox.Location = new System.Drawing.Point(522, 207);
            this.addEmpNameTxtBox.Name = "addEmpNameTxtBox";
            this.addEmpNameTxtBox.Size = new System.Drawing.Size(349, 26);
            this.addEmpNameTxtBox.TabIndex = 5;
            // 
            // empName
            // 
            this.empName.AutoSize = true;
            this.empName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.empName.Location = new System.Drawing.Point(395, 209);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(118, 22);
            this.empName.TabIndex = 4;
            this.empName.Text = "Emp Name";
            // 
            // addEmpEmailTxtBox
            // 
            this.addEmpEmailTxtBox.Location = new System.Drawing.Point(522, 263);
            this.addEmpEmailTxtBox.Name = "addEmpEmailTxtBox";
            this.addEmpEmailTxtBox.Size = new System.Drawing.Size(349, 26);
            this.addEmpEmailTxtBox.TabIndex = 7;
            // 
            // empEmail
            // 
            this.empEmail.AutoSize = true;
            this.empEmail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.empEmail.Location = new System.Drawing.Point(395, 265);
            this.empEmail.Name = "empEmail";
            this.empEmail.Size = new System.Drawing.Size(121, 22);
            this.empEmail.TabIndex = 6;
            this.empEmail.Text = "Emp Email ";
            // 
            // addEmpPhoneTxtBox
            // 
            this.addEmpPhoneTxtBox.Location = new System.Drawing.Point(522, 316);
            this.addEmpPhoneTxtBox.Name = "addEmpPhoneTxtBox";
            this.addEmpPhoneTxtBox.Size = new System.Drawing.Size(349, 26);
            this.addEmpPhoneTxtBox.TabIndex = 9;
            // 
            // empPhone
            // 
            this.empPhone.AutoSize = true;
            this.empPhone.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.empPhone.Location = new System.Drawing.Point(395, 318);
            this.empPhone.Name = "empPhone";
            this.empPhone.Size = new System.Drawing.Size(123, 22);
            this.empPhone.TabIndex = 8;
            this.empPhone.Text = "Emp Phone";
            // 
            // addEmpCityTxtBox
            // 
            this.addEmpCityTxtBox.Location = new System.Drawing.Point(522, 368);
            this.addEmpCityTxtBox.Name = "addEmpCityTxtBox";
            this.addEmpCityTxtBox.Size = new System.Drawing.Size(349, 26);
            this.addEmpCityTxtBox.TabIndex = 11;
            // 
            // empCity
            // 
            this.empCity.AutoSize = true;
            this.empCity.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.empCity.Location = new System.Drawing.Point(395, 370);
            this.empCity.Name = "empCity";
            this.empCity.Size = new System.Drawing.Size(105, 22);
            this.empCity.TabIndex = 10;
            this.empCity.Text = "Emp City ";
            // 
            // addEmpBtn
            // 
            this.addEmpBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addEmpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmpBtn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.addEmpBtn.Location = new System.Drawing.Point(979, 237);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Size = new System.Drawing.Size(184, 50);
            this.addEmpBtn.TabIndex = 12;
            this.addEmpBtn.Text = "ADD";
            this.addEmpBtn.UseVisualStyleBackColor = false;
            this.addEmpBtn.Click += new System.EventHandler(this.addEmpBtn_Click);
            // 
            // backToHome
            // 
            this.backToHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToHome.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToHome.ForeColor = System.Drawing.SystemColors.Info;
            this.backToHome.Location = new System.Drawing.Point(35, 485);
            this.backToHome.Name = "backToHome";
            this.backToHome.Size = new System.Drawing.Size(249, 50);
            this.backToHome.TabIndex = 26;
            this.backToHome.Text = "BACK TO HOME";
            this.backToHome.UseMnemonic = false;
            this.backToHome.UseVisualStyleBackColor = false;
            this.backToHome.Click += new System.EventHandler(this.backToHome_Click);
            // 
            // footer
            // 
            this.footer.AutoSize = true;
            this.footer.Location = new System.Drawing.Point(1104, 670);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(177, 20);
            this.footer.TabIndex = 27;
            this.footer.Text = "Project By Abhinav Arya";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 715);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.backToHome);
            this.Controls.Add(this.addEmpBtn);
            this.Controls.Add(this.addEmpCityTxtBox);
            this.Controls.Add(this.empCity);
            this.Controls.Add(this.addEmpPhoneTxtBox);
            this.Controls.Add(this.empPhone);
            this.Controls.Add(this.addEmpEmailTxtBox);
            this.Controls.Add(this.empEmail);
            this.Controls.Add(this.addEmpNameTxtBox);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.addEmpIdTxtBox);
            this.Controls.Add(this.EmpId);
            this.Controls.Add(this.mainHeading);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainHeading;
        private System.Windows.Forms.Label EmpId;
        private System.Windows.Forms.TextBox addEmpIdTxtBox;
        private System.Windows.Forms.TextBox addEmpNameTxtBox;
        private System.Windows.Forms.Label empName;
        private System.Windows.Forms.TextBox addEmpEmailTxtBox;
        private System.Windows.Forms.Label empEmail;
        private System.Windows.Forms.TextBox addEmpPhoneTxtBox;
        private System.Windows.Forms.Label empPhone;
        private System.Windows.Forms.TextBox addEmpCityTxtBox;
        private System.Windows.Forms.Label empCity;
        private System.Windows.Forms.Button addEmpBtn;
        private System.Windows.Forms.Button backToHome;
        private System.Windows.Forms.Label footer;
    }
}