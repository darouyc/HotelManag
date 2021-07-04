namespace HotelManag
{
    partial class Hotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hotel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucHotel1 = new HotelManag.UC.ucHotel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(337, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 85);
            this.panel1.TabIndex = 1;
            // 
            // ucHotel1
            // 
            this.ucHotel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ucHotel1.Location = new System.Drawing.Point(53, 103);
            this.ucHotel1.Name = "ucHotel";
            this.ucHotel1.Size = new System.Drawing.Size(638, 370);
            this.ucHotel1.TabIndex = 0;
            // 
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 529);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucHotel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hotel";
            this.Text = "Reservation";
            this.ResumeLayout(false);

        }

        #endregion

        private UC.ucHotel ucHotel1;
        private System.Windows.Forms.Panel panel1;
    }
}

