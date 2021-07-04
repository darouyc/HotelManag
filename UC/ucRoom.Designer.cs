namespace HotelManag.UC
{
    partial class ucRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_numRoom = new System.Windows.Forms.Label();
            this.StatMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bookedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_numRoom
            // 
            this.lbl_numRoom.AutoSize = true;
            this.lbl_numRoom.BackColor = System.Drawing.Color.Gold;
            this.lbl_numRoom.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_numRoom.Location = new System.Drawing.Point(3, 0);
            this.lbl_numRoom.Name = "lbl_numRoom";
            this.lbl_numRoom.Size = new System.Drawing.Size(20, 22);
            this.lbl_numRoom.TabIndex = 0;
            this.lbl_numRoom.Text = "0";
            this.lbl_numRoom.Click += new System.EventHandler(this.label1_Click);
            // 
            // StatMenu
            // 
            this.StatMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookedToolStripMenuItem,
            this.freeToolStripMenuItem});
            this.StatMenu.Name = "StatMenu";
            this.StatMenu.Size = new System.Drawing.Size(102, 48);
            // 
            // bookedToolStripMenuItem
            // 
            this.bookedToolStripMenuItem.Name = "bookedToolStripMenuItem";
            this.bookedToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.bookedToolStripMenuItem.Text = "Book";
            this.bookedToolStripMenuItem.Click += new System.EventHandler(this.bookedToolStripMenuItem_Click);
            // 
            // freeToolStripMenuItem
            // 
            this.freeToolStripMenuItem.Name = "freeToolStripMenuItem";
            this.freeToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.freeToolStripMenuItem.Text = "Free";
            this.freeToolStripMenuItem.Click += new System.EventHandler(this.freeToolStripMenuItem_Click);
            // 
            // ucRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.StatMenu;
            this.Controls.Add(this.lbl_numRoom);
            this.Name = "ucRoom";
            this.Size = new System.Drawing.Size(169, 58);
            this.Load += new System.EventHandler(this.ucRoom_Load);
            this.StatMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_numRoom;
        private System.Windows.Forms.ContextMenuStrip StatMenu;
        private System.Windows.Forms.ToolStripMenuItem bookedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeToolStripMenuItem;
    }
}
