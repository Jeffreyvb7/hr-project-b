namespace Escape_Room
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.EscapeListButton = new System.Windows.Forms.Button();
            this.FoodDrinkButton = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to 420InchSpacebarz Escape Rooms! Please select an option below in order " +
    "to find out more information or book an adventure!";
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(7, 8);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(75, 23);
            this.LogOutButton.TabIndex = 1;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // EscapeListButton
            // 
            this.EscapeListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.EscapeListButton.Location = new System.Drawing.Point(463, 144);
            this.EscapeListButton.Name = "EscapeListButton";
            this.EscapeListButton.Size = new System.Drawing.Size(221, 77);
            this.EscapeListButton.TabIndex = 2;
            this.EscapeListButton.Text = "Our Escape Rooms";
            this.EscapeListButton.UseVisualStyleBackColor = true;
            this.EscapeListButton.Click += new System.EventHandler(this.EscapeListButton_Click);
            // 
            // FoodDrinkButton
            // 
            this.FoodDrinkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.FoodDrinkButton.Location = new System.Drawing.Point(86, 305);
            this.FoodDrinkButton.Name = "FoodDrinkButton";
            this.FoodDrinkButton.Size = new System.Drawing.Size(221, 77);
            this.FoodDrinkButton.TabIndex = 3;
            this.FoodDrinkButton.Text = "Food and Drink";
            this.FoodDrinkButton.UseVisualStyleBackColor = true;
            this.FoodDrinkButton.Click += new System.EventHandler(this.FoodDrinkButton_Click);
            // 
            // BookButton
            // 
            this.BookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.BookButton.Location = new System.Drawing.Point(86, 144);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(221, 77);
            this.BookButton.TabIndex = 4;
            this.BookButton.Text = "Book Now!";
            this.BookButton.UseVisualStyleBackColor = true;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1.Location = new System.Drawing.Point(463, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 77);
            this.button1.TabIndex = 5;
            this.button1.Text = "About Us";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.FoodDrinkButton);
            this.Controls.Add(this.EscapeListButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "HomeScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button EscapeListButton;
        private System.Windows.Forms.Button FoodDrinkButton;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.Button button1;
    }
}