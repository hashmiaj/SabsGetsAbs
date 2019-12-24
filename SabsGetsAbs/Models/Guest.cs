
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
namespace SabsGetsAbs.Models
{
    public class Guest
    {
        public string Barcode { get; set; }

        public string Name { get; set; }

        public string NumberOfGuests { get; set; }

        public string InvitedTo { get; set; }

        public string Groomsman { get; set; }

        public string Bridesmaid { get; set; }

        public string RSVP { get; set; }
    }
}
