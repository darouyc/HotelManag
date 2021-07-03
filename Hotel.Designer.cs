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
            this.ucHotel1 = new HotelManag.UC.ucHotel();
            this.SuspendLayout();
            // 
            // ucHotel1
            // 
            this.ucHotel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ucHotel1.Location = new System.Drawing.Point(37, 40);
            this.ucHotel1.Name = "ucHotel1";
            this.ucHotel1.Size = new System.Drawing.Size(638, 370);
            this.ucHotel1.TabIndex = 0;
            // 
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.ucHotel1);
            this.Name = "Hotel";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UC.ucHotel ucHotel1;
    }
}

