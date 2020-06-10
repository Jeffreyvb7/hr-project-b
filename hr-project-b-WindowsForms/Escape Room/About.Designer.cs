namespace Escape_Room
{
    partial class About
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
            this.aboutTags = new System.Windows.Forms.Label();
            this.aboutCompanyName = new System.Windows.Forms.Label();
            this.aboutCompanyInfo = new System.Windows.Forms.Label();
            this.aboutTwitterInfo = new System.Windows.Forms.Label();
            this.aboutFacebookInfo = new System.Windows.Forms.Label();
            this.aboutEmailInfo = new System.Windows.Forms.Label();
            this.aboutPhoneNumber = new System.Windows.Forms.Label();
            this.aboutLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(12, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 23);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // aboutTags
            // 
            this.aboutTags.AutoSize = true;
            this.aboutTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.aboutTags.Location = new System.Drawing.Point(12, 51);
            this.aboutTags.Name = "aboutTags";
            this.aboutTags.Size = new System.Drawing.Size(145, 220);
            this.aboutTags.TabIndex = 2;
            this.aboutTags.Text = "Company name: \r\nCompany info:\r\n\r\nTwitter info:\r\nFacebook:\r\n\r\nEmail info:\r\nPhone n" +
    "umber:\r\n\r\nLocation: ";
            // 
            // aboutCompanyName
            // 
            this.aboutCompanyName.AutoSize = true;
            this.aboutCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.aboutCompanyName.Location = new System.Drawing.Point(163, 51);
            this.aboutCompanyName.Name = "aboutCompanyName";
            this.aboutCompanyName.Size = new System.Drawing.Size(168, 22);
            this.aboutCompanyName.TabIndex = 3;
            this.aboutCompanyName.Text = "420 Inch Spacebarz";
            // 
            // aboutCompanyInfo
            // 
            this.aboutCompanyInfo.AutoSize = true;
            this.aboutCompanyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.aboutCompanyInfo.Location = new System.Drawing.Point(163, 73);
            this.aboutCompanyInfo.Name = "aboutCompanyInfo";
            this.aboutCompanyInfo.Size = new System.Drawing.Size(636, 22);
            this.aboutCompanyInfo.TabIndex = 4;
            this.aboutCompanyInfo.Text = "We make escape rooms for everyone who enjoys puzzling and problem solving";
            // 
            // aboutTwitterInfo
            // 
            this.aboutTwitterInfo.AutoSize = true;
            this.aboutTwitterInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.aboutTwitterInfo.Location = new System.Drawing.Point(163, 117);
            this.aboutTwitterInfo.Name = "aboutTwitterInfo";
            this.aboutTwitterInfo.Size = new System.Drawing.Size(173, 22);
            this.aboutTwitterInfo.TabIndex = 5;
            this.aboutTwitterInfo.Text = "@420inchspacebarz";
            // 
            // aboutFacebookInfo
            // 
            this.aboutFacebookInfo.AutoSize = true;
            this.aboutFacebookInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.aboutFacebookInfo.Location = new System.Drawing.Point(163, 139);
            this.aboutFacebookInfo.Name = "aboutFacebookInfo";
            this.aboutFacebookInfo.Size = new System.Drawing.Size(168, 22);
            this.aboutFacebookInfo.TabIndex = 6;
            this.aboutFacebookInfo.Text = "420 Inch Spacebarz";
            // 
            // aboutEmailInfo
            // 
            this.aboutEmailInfo.AutoSize = true;
            this.aboutEmailInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.aboutEmailInfo.Location = new System.Drawing.Point(163, 183);
            this.aboutEmailInfo.Name = "aboutEmailInfo";
            this.aboutEmailInfo.Size = new System.Drawing.Size(268, 22);
            this.aboutEmailInfo.TabIndex = 7;
            this.aboutEmailInfo.Text = "420inchspacebarz@hotmail.com";
            // 
            // aboutPhoneNumber
            // 
            this.aboutPhoneNumber.AutoSize = true;
            this.aboutPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.aboutPhoneNumber.Location = new System.Drawing.Point(163, 205);
            this.aboutPhoneNumber.Name = "aboutPhoneNumber";
            this.aboutPhoneNumber.Size = new System.Drawing.Size(110, 22);
            this.aboutPhoneNumber.TabIndex = 8;
            this.aboutPhoneNumber.Text = "0612345678";
            // 
            // aboutLocation
            // 
            this.aboutLocation.AutoSize = true;
            this.aboutLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.aboutLocation.Location = new System.Drawing.Point(163, 249);
            this.aboutLocation.Name = "aboutLocation";
            this.aboutLocation.Size = new System.Drawing.Size(214, 22);
            this.aboutLocation.TabIndex = 9;
            this.aboutLocation.Text = "Wijnhaven 107  3011 WN";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aboutLocation);
            this.Controls.Add(this.aboutPhoneNumber);
            this.Controls.Add(this.aboutEmailInfo);
            this.Controls.Add(this.aboutFacebookInfo);
            this.Controls.Add(this.aboutTwitterInfo);
            this.Controls.Add(this.aboutCompanyInfo);
            this.Controls.Add(this.aboutCompanyName);
            this.Controls.Add(this.aboutTags);
            this.Controls.Add(this.Home);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label aboutTags;
        private System.Windows.Forms.Label aboutCompanyName;
        private System.Windows.Forms.Label aboutCompanyInfo;
        private System.Windows.Forms.Label aboutTwitterInfo;
        private System.Windows.Forms.Label aboutFacebookInfo;
        private System.Windows.Forms.Label aboutEmailInfo;
        private System.Windows.Forms.Label aboutPhoneNumber;
        private System.Windows.Forms.Label aboutLocation;
    }
}