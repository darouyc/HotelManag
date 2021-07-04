using MySql.Data.MySqlClient;
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
            listRes = new List<Reservation>();
            getListRes();
        }
        public void getListRes()
        {
            using (MySqlConnection connection = cnxConfig.Connect())
            {

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM reservation", connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Model.Reservation res = new Model.Reservation(dr.GetInt32(0), dr.GetInt32(2), dr.GetDateTime(1));
                    this.listRes.Add(res);
                }

                dr.Close();
            }
        }
    }
}
