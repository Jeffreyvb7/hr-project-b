namespace Escape_Room
{
    partial class AdminMenu
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
            this.Home = new System.Windows.Forms.Button();
            this.adminMenuAddEscapeRoom = new System.Windows.Forms.Button();
            this.adminMenuEditEscapeRoom = new System.Windows.Forms.Button();
            this.adminMenuRemoveEscapeRoom = new System.Windows.Forms.Button();
            this.adminMenuEditCompanyInfo = new System.Windows.Forms.Button();
            this.AdminMenuManageFood = new System.Windows.Forms.Button();
            this.adminMenuLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(12, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 23);
            this.Home.TabIndex = 1;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // adminMenuAddEscapeRoom
            // 
            this.adminMenuAddEscapeRoom.Location = new System.Drawing.Point(115, 128);
            this.adminMenuAddEscapeRoom.Name = "adminMenuAddEscapeRoom";
            this.adminMenuAddEscapeRoom.Size = new System.Drawing.Size(142, 62);
            this.adminMenuAddEscapeRoom.TabIndex = 2;
            this.adminMenuAddEscapeRoom.Text = "ADD escape room";
            this.adminMenuAddEscapeRoom.UseVisualStyleBackColor = true;
            // 
            // adminMenuEditEscapeRoom
            // 
            this.adminMenuEditEscapeRoom.Location = new System.Drawing.Point(327, 128);
            this.adminMenuEditEscapeRoom.Name = "adminMenuEditEscapeRoom";
            this.adminMenuEditEscapeRoom.Size = new System.Drawing.Size(142, 62);
            this.adminMenuEditEscapeRoom.TabIndex = 3;
            this.adminMenuEditEscapeRoom.Text = "EDIT escape room";
            this.adminMenuEditEscapeRoom.UseVisualStyleBackColor = true;
            // 
            // adminMenuRemoveEscapeRoom
            // 
            this.adminMenuRemoveEscapeRoom.Location = new System.Drawing.Point(535, 128);
            this.adminMenuRemoveEscapeRoom.Name = "adminMenuRemoveEscapeRoom";
            this.adminMenuRemoveEscapeRoom.Size = new System.Drawing.Size(142, 62);
            this.adminMenuRemoveEscapeRoom.TabIndex = 4;
            this.adminMenuRemoveEscapeRoom.Text = "REMOVE escape room";
            this.adminMenuRemoveEscapeRoom.UseVisualStyleBackColor = true;
            // 
            // adminMenuEditCompanyInfo
            // 
            this.adminMenuEditCompanyInfo.Location = new System.Drawing.Point(184, 311);
            this.adminMenuEditCompanyInfo.Name = "adminMenuEditCompanyInfo";
            this.adminMenuEditCompanyInfo.Size = new System.Drawing.Size(142, 62);
            this.adminMenuEditCompanyInfo.TabIndex = 5;
            this.adminMenuEditCompanyInfo.Text = "Edit Company Info";
            this.adminMenuEditCompanyInfo.UseVisualStyleBackColor = true;
            // 
            // AdminMenuManageFood
            // 
            this.AdminMenuManageFood.Location = new System.Drawing.Point(465, 311);
            this.AdminMenuManageFood.Name = "AdminMenuManageFood";
            this.AdminMenuManageFood.Size = new System.Drawing.Size(142, 62);
            this.AdminMenuManageFood.TabIndex = 6;
            this.AdminMenuManageFood.Text = "Manage Food Menu";
            this.AdminMenuManageFood.UseVisualStyleBackColor = true;
            // 
            // adminMenuLine
            // 
            this.adminMenuLine.AutoSize = true;
            this.adminMenuLine.Location = new System.Drawing.Point(-6, 225);
            this.adminMenuLine.Name = "adminMenuLine";
            this.adminMenuLine.Size = new System.Drawing.Size(991, 13);
            this.adminMenuLine.TabIndex = 7;
            this.adminMenuLine.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "___";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminMenuLine);
            this.Controls.Add(this.AdminMenuManageFood);
            this.Controls.Add(this.adminMenuEditCompanyInfo);
            this.Controls.Add(this.adminMenuRemoveEscapeRoom);
            this.Controls.Add(this.adminMenuEditEscapeRoom);
            this.Controls.Add(this.adminMenuAddEscapeRoom);
            this.Controls.Add(this.Home);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button adminMenuAddEscapeRoom;
        private System.Windows.Forms.Button adminMenuEditEscapeRoom;
        private System.Windows.Forms.Button adminMenuRemoveEscapeRoom;
        private System.Windows.Forms.Button adminMenuEditCompanyInfo;
        private System.Windows.Forms.Button AdminMenuManageFood;
        private System.Windows.Forms.Label adminMenuLine;
    }
}