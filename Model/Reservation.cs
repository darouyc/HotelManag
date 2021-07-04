using MySql.Data.MySqlClient;
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
        public Reservation(int res_id, int Num, DateTime dtRes)
        {
            this.res_id = res_id;
            this.RoomNum = Num;
            this.DateResr = dtRes;
        }
        public Reservation(int Num, DateTime dtRes)
        {
            this.RoomNum = Num;
            this.DateResr = dtRes;
        }

        public void AddRes(int Num, DateTime dtRes)
        {
            MySqlCommand cmd;
            using (MySqlConnection connection = cnxConfig.Connect())
            {

                cmd = new MySqlCommand("INSERT INTO reservation (res_date, room_num) VALUES (@res_date, @room_num)", connection);
                cmd.Parameters.AddWithValue("@res_date", dtRes);
                cmd.Parameters.AddWithValue("@room_num", Num);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
