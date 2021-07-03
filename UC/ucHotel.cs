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
            InitializeComponent();
            DB = new Model.ListReservation();
        }

        private void dT_Picker_ValueChanged(object sender, EventArgs e)
        {
            // get rooms stat
            foreach (Control item in this.Controls)
            {
                //verify type of item
                if (item is ucRoom)
                {
                     //cast item to get only ucRooms type
                      ucRoom room = (ucRoom)item;
                    room.ShowStat(dT_Picker.Value);
                }
               

            }
        }
    }
}
