using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using SabsGetsAbs.Models;
using MySql.Data.MySqlClient;
using SabsGetsAbs.Utilities;

namespace SabsGetsAbs.ViewModels
{
    public class MainPageVM
    {
        public MainPageVM()
        {
        }

        public String GetGuestByBarcode(string Barcode)
        {
            MySqlConnection sqlconn;
            string connsqlstring = DatabaseInfo.ConnectionString;
            sqlconn = new MySqlConnection();
            sqlconn.ConnectionString = connsqlstring;
            sqlconn.Open();

            Guest TestGuest = new Guest();
            string Query = DatabaseInfo.QueryGuestByBarcode + "'123456'"; 

            using (MySqlCommand command = new MySqlCommand(Query, sqlconn))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TestGuest.Barcode = reader.GetString(0);
                        TestGuest.Name = reader.GetString(1);
                        TestGuest.NumberOfGuests = reader.GetString(2);
                        TestGuest.InvitedTo = reader.GetString(3);
                        TestGuest.Groomsman = reader.GetString(4);
                        TestGuest.Bridesmaid = reader.GetString(5);
                        TestGuest.RSVP = reader.GetString(6);
                    }
                    reader.Close();
                }
            }
            sqlconn.Close();


            return TestGuest.Name;
        }


    }
}
