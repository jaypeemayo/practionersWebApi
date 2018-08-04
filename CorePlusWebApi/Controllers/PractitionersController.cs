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
            return this.practitionerService.GetPractitioners(searchText == "undefined" ? "" : searchText, start, end, searchTextType == "undefined" ? "" : searchTextType).ToArray();
        }

        //// GET api/practitioners/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //

        // POST api/practitioners
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/practitioners/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/practitioners/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
