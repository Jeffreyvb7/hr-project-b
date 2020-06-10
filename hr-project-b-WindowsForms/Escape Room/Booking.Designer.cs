namespace Escape_Room
{
    partial class Booking
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
            this.HomeButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.reserveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(4, 5);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(75, 23);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // bookButton
            // 
            this.bookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.bookButton.Location = new System.Drawing.Point(160, 174);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(185, 89);
            this.bookButton.TabIndex = 2;
            this.bookButton.Text = "Book a Room";
            this.bookButton.UseVisualStyleBackColor = true;
            // 
            // reserveButton
            // 
            this.reserveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.reserveButton.Location = new System.Drawing.Point(428, 174);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(185, 89);
            this.reserveButton.TabIndex = 3;
            this.reserveButton.Text = "View Reservations";
            this.reserveButton.UseVisualStyleBackColor = true;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reserveButton);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.HomeButton);
            this.Name = "Booking";
            this.Text = "Booking";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Button reserveButton;
    }
}