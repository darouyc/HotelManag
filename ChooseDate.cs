using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManag
{
    public partial class ChooseDate : Form
    {
        public DateTimePicker dtPicker;
        public int RoomNum { get; set; } 
        public Boolean isClosed;
        public ChooseDate(int RoomNum)
        {
            this.RoomNum = RoomNum;
            this.Show();
            this.isClosed = false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.Reservation res = new Model.Reservation();
            this.dtPicker = this.dt_Picker;
            res.AddRes(RoomNum, this.dt_Picker.Value);
            MessageBox.Show("saved");
            this.isClosed = true;
            this.Close();
        }

        private void ChooseDate_Load(object sender, EventArgs e)
        {

        }

       
    }
}
