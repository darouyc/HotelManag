using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManag.Model
{
    public class ListReservation
    {
        public List<Reservation> listRes { get; set; }
        public cnxConfig cnx;
        public ListReservation()
        {
           cnx = new cnxConfig();
           listRes = cnx.GetReservations();
            /*
            Reservation res1 = new Reservation(1, new DateTime(2021, 8, 8));
            Reservation res2 = new Reservation(6, new DateTime(2021, 8, 8));
            Reservation res3 = new Reservation(8, new DateTime(2021, 9, 16));
            Reservation res4 = new Reservation(6, new DateTime(2021, 9, 16));
            Reservation res5 = new Reservation(8, new DateTime(2021, 8, 23));
            listRes = new List<Reservation> 
            { 
                res1,
                res2,
                res3,
                res4,
                res5
            }; */
        }
    }
}
