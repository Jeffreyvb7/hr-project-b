namespace Escape_Room
{
    partial class Register
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
            this.BackButton = new System.Windows.Forms.Button();
            this.PassWordBox2 = new System.Windows.Forms.TextBox();
            this.PassWordBox = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(0, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PassWordBox2
            // 
            this.PassWordBox2.Location = new System.Drawing.Point(294, 174);
            this.PassWordBox2.Name = "PassWordBox2";
            this.PassWordBox2.PasswordChar = '*';
            this.PassWordBox2.Size = new System.Drawing.Size(211, 20);
            this.PassWordBox2.TabIndex = 5;
            // 
            // PassWordBox
            // 
            this.PassWordBox.Location = new System.Drawing.Point(294, 125);
            this.PassWordBox.Name = "PassWordBox";
            this.PassWordBox.PasswordChar = '*';
            this.PassWordBox.Size = new System.Drawing.Size(211, 20);
            this.PassWordBox.TabIndex = 4;
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(294, 74);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(211, 20);
            this.UserNameBox.TabIndex = 6;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(362, 224);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 7;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.PassWordBox2);
            this.Controls.Add(this.PassWordBox);
            this.Controls.Add(this.BackButton);
            this.Name = "Register";
            this.Text = "RegisterScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox PassWordBox2;
        private System.Windows.Forms.TextBox PassWordBox;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Button RegisterButton;
    }
}