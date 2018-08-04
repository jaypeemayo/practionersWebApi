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
            return dataReadService.Read("CorePlusWebApi.BLL.Data.db.json");
        }  
    }
}
