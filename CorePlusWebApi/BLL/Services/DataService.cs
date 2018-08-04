using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CorePlusWebApi.BLL.Services
{
    internal class DataService<T> : IDataReadService<T>
    {
        public T Read(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))           
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(result);
            }
        }
    }
}
