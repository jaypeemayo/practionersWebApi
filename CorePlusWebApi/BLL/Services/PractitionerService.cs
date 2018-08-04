using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CorePlusWebApi.BLL.Services
{
    internal class PractitionerService : IPractitionerService
    {
        private readonly IDataReadService<List<Practitioner>> dataReadService;

        public PractitionerService(IDataReadService<List<Practitioner>> dataReadService)
        {
            this.dataReadService = dataReadService;
        }
        public List<Practitioner> GetPractitioners(string searchText, DateTime? start, DateTime? end, string searchType)
        {
            var practitioners = dataReadService.Read("CorePlusWebApi.BLL.Data.db.json");

            var filteredPractitioners = practitioners.Where(o => string.IsNullOrEmpty(searchText) || o.Name.ToLower().Contains(searchText.ToLower())).ToList();
            var newPractitioners = filteredPractitioners.Aggregate(new List<Practitioner>(), (practitionerAccumulator, practitioner) =>
            {
                var newAppointments = practitioner.Appointments
                                         .Where(appointment => !start.HasValue || start <= appointment.Date)
                                         .Where(appointment => !end.HasValue || end >= appointment.Date)
                                         .Where(appointment => string.IsNullOrEmpty(searchType) || appointment.Type.ToLower().Contains(searchType.ToLower()));

                if(newAppointments.Count() > 0)
                {
                    practitioner.Appointments = newAppointments.ToList();
                    practitionerAccumulator.Add(practitioner);
                }
                
                return practitionerAccumulator;
            });
            return newPractitioners;
        }
    }
}
