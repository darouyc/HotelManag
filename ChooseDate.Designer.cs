namespace HotelManag
{
    partial class ChooseDate
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
            this.OK = new System.Windows.Forms.Button();
            this.dt_Picker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(102, 87);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(120, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // dt_Picker
            // 
            this.dt_Picker.Location = new System.Drawing.Point(22, 28);
            this.dt_Picker.Name = "dt_Picker";
            this.dt_Picker.Size = new System.Drawing.Size(200, 20);
            this.dt_Picker.TabIndex = 1;
            // 
            // ChooseDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 122);
            this.Controls.Add(this.dt_Picker);
            this.Controls.Add(this.OK);
            this.Name = "ChooseDate";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ChooseDate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.DateTimePicker dt_Picker;
    }
}