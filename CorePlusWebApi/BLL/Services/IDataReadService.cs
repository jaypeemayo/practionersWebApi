using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePlusWebApi.BLL.Services
{
    public interface IDataReadService<T>
    {
        T Read(string resourceName);
    }
}
