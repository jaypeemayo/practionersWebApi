﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePlusWebApi.BLL.Services
{
    public interface IPractitionerService
    {
        List<Practitioner> GetPractitioners(string searchText, DateTime? start = null, DateTime? end = null, string searchType = null);
    }
}
