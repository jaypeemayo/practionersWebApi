using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorePlusWebApi.BLL;
using CorePlusWebApi.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace CorePlusWebApi.Controllers
{
    [Route("api/[controller]")]
    public class PractitionersController : Controller
    {
        private readonly IPractitionerService practitionerService;
 
        public PractitionersController(IPractitionerService practitionerService)
        {
            this.practitionerService = practitionerService;
        }

        [HttpGet("{searchText?}/{start?}/{end?}/{searchTextType?}")]
        public Practitioner[] Get(string searchText = null, DateTime? start = null, DateTime? end = null, string searchTextType = null)
        {
            return this.practitionerService.GetPractitioners(searchText, start, end, searchTextType).ToArray();
        }

        
    }
}
