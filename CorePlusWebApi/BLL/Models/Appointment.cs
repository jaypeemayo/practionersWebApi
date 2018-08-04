using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePlusWebApi.BLL
{
    public class Appointment
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }
    }
}
