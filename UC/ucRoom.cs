using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManag.UC
{
    public partial class ucRoom : UserControl
    {
        public int Num { get; set; }


        public void ShowStat(DateTime ResDate)
        {
            foreach (Model.Reservation res in ucHotel.DB.listRes)
            {
                if (res.RoomNum == Num && res.DateResr.Date == ResDate.Date)
                {
                    this.BackColor = Color.Cyan;
                    return;
                }
            }
            this.BackColor = Color.White;
        }
        public ucRoom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void ucRoom_Load(object sender, EventArgs e)
        {
            lbl_numRoom.Text = Num.ToString();
        }

        private void bookedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Model.Reservation res = new Model.Reservation();
            //var form = new Form(); // or control how you like
            
           // Button close_btn = new Button();
            ChooseDate form = new ChooseDate(Num);
            
            
        }

        private void freeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
