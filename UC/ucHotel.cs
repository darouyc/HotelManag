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
    public partial class ucHotel : UserControl
    {
        public static Model.ListReservation DB { get; set; }
        public ucHotel()
        {
            DB = new Model.ListReservation();
            InitializeComponent();
            Refresh(DateTime.Now);
        }


        private void dT_Picker_ValueChanged(object sender, EventArgs e)
        {

            Refresh(dT_Picker.Value);
        }

        private void Refresh(DateTime date)
        {
            foreach (Control item in this.Controls)
            {
                //verify type of item
                if (item is ucRoom)
                {
                    //cast item to get only ucRooms type
                    ucRoom room = (ucRoom)item;
                    room.ShowStat(date);
                }
            }
        }
        
    }
}
