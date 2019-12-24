using System;
namespace SabsGetsAbs.Utilities
{
    public class DatabaseInfo
    {
        public static string ConnectionString = "Server=sabsgetsabs.cyxqyhgcvzjg.us-east-1.rds.amazonaws.com;Port=3306;database=weddingdb;User Id=sabsgetsabs;Password=sabsgetsabs;charset=utf8";

        public static string QueryGuestByBarcode = "Select * From weddingdb.GuestsTable Where Barcode = ";

        public static string QueryRSVPResponse = "";
    }
}
