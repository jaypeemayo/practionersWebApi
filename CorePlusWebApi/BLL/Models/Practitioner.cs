using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePlusWebApi.BLL
{
    public class Practitioner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Appointment[] Appointments { get; set; }
    }
}
