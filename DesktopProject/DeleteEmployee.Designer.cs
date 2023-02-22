
namespace DesktopProject
{
    partial class DeleteEmployee
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
            this.DeleteEmpButton = new System.Windows.Forms.Button();
            this.addEmpIdTxtBox = new System.Windows.Forms.TextBox();
            this.EmpId = new System.Windows.Forms.Label();
            this.mainHeading = new System.Windows.Forms.Label();
            this.backToHome = new System.Windows.Forms.Button();
            this.footer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteEmpButton
            // 
            this.DeleteEmpButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteEmpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteEmpButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEmpButton.ForeColor = System.Drawing.SystemColors.Info;
            this.DeleteEmpButton.Location = new System.Drawing.Point(614, 307);
            this.DeleteEmpButton.Name = "DeleteEmpButton";
            this.DeleteEmpButton.Size = new System.Drawing.Size(165, 50);
            this.DeleteEmpButton.TabIndex = 28;
            this.DeleteEmpButton.Text = "DELETE";
            this.DeleteEmpButton.UseMnemonic = false;
            this.DeleteEmpButton.UseVisualStyleBackColor = false;
            this.DeleteEmpButton.Click += new System.EventHandler(this.DeleteEmpButton_Click);
            // 
            // addEmpIdTxtBox
            // 
            this.addEmpIdTxtBox.Location = new System.Drawing.Point(537, 231);
            this.addEmpIdTxtBox.Name = "addEmpIdTxtBox";
            this.addEmpIdTxtBox.Size = new System.Drawing.Size(349, 26);
            this.addEmpIdTxtBox.TabIndex = 27;
            // 
            // EmpId
            // 
            this.EmpId.AutoSize = true;
            this.EmpId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.EmpId.Location = new System.Drawing.Point(410, 233);
            this.EmpId.Name = "EmpId";
            this.EmpId.Size = new System.Drawing.Size(91, 22);
            this.EmpId.TabIndex = 26;
            this.EmpId.Text = "Emp ID ";
            // 
            // mainHeading
            // 
            this.mainHeading.AutoSize = true;
            this.mainHeading.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainHeading.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHeading.Location = new System.Drawing.Point(492, 78);
            this.mainHeading.Name = "mainHeading";
            this.mainHeading.Size = new System.Drawing.Size(404, 36);
            this.mainHeading.TabIndex = 25;
            this.mainHeading.Text = "Delete Employee In DataBase";
            // 
            // backToHome
            // 
            this.backToHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToHome.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToHome.ForeColor = System.Drawing.SystemColors.Info;
            this.backToHome.Location = new System.Drawing.Point(36, 482);
            this.backToHome.Name = "backToHome";
            this.backToHome.Size = new System.Drawing.Size(249, 50);
            this.backToHome.TabIndex = 29;
            this.backToHome.Text = "BACK TO HOME";
            this.backToHome.UseMnemonic = false;
            this.backToHome.UseVisualStyleBackColor = false;
            this.backToHome.Click += new System.EventHandler(this.backToHome_Click);
            // 
            // footer
            // 
            this.footer.AutoSize = true;
            this.footer.Location = new System.Drawing.Point(1113, 657);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(177, 20);
            this.footer.TabIndex = 30;
            this.footer.Text = "Project By Abhinav Arya";
            // 
            // DeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 716);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.backToHome);
            this.Controls.Add(this.DeleteEmpButton);
            this.Controls.Add(this.addEmpIdTxtBox);
            this.Controls.Add(this.EmpId);
            this.Controls.Add(this.mainHeading);
            this.Name = "DeleteEmployee";
            this.Text = "DeleteEmployee";
            this.Load += new System.EventHandler(this.DeleteEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteEmpButton;
        private System.Windows.Forms.TextBox addEmpIdTxtBox;
        private System.Windows.Forms.Label EmpId;
        private System.Windows.Forms.Label mainHeading;
        private System.Windows.Forms.Button backToHome;
        private System.Windows.Forms.Label footer;
    }
}