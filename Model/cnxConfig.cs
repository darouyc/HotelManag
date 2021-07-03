using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HotelManag.Model
{
  
    public static class cnxConfig
    {  
        static string mycon = "server =localhost; Uid=root; password = ; persistsecurityinfo = True; database =hotelman; SslMode = none";
        static MySqlConnection con = new MySqlConnection(mycon);
        static DataTable dt = new DataTable();
        static MySqlCommand cmd = null;

     
        public ListReservation GetReservations()
        {
            try
            {
                cmd = new MySqlCommand("Select * from reservation", con);
                con.Open();
                dt.Load(cmd.ExecuteReader());
                con.Close();

            }
            catch (Exception ex)
            {
                //Response.Write("<script>alert('" + ex.Message + "')</script>");
                con.Close();
            }
            ListReservation List = new ListReservation();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Reservation res = new Reservation();
                res.res_id = Convert.ToInt32(dt.Rows[i]["res_id"]);
                res.RoomNum = Convert.ToInt32(dt.Rows[i]["room_num"]);
                res.DateResr = Convert.ToDateTime(dt.Rows[i]["res_date"]);
                List.listRes.Add(res);
            }
            return List;
        }
    }
}
