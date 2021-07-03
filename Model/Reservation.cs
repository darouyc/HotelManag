using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManag.Model
{
    public class Reservation
    {
        public int res_id { get; set; }
        public int RoomNum { get; set; }
        public DateTime DateResr { get; set; }

        public Reservation()
        {
            
        }

        public Reservation(int Num, DateTime dtRes)
        {
            this.RoomNum = Num;
            this.DateResr = dtRes;
        }
    }
}
