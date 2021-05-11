using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace College.BL
{
    public class Bissnes
    {
        public static List<Details> list1;
        public static IEnumerable<Details> GetList()
        {
            list1 = JsonConvert.DeserializeObject<List<Details>>(File.ReadAllText(".//data.json"));
            return list1;
        }

        public static IEnumerable<Details> GetSearchList(string param)
        {
            return list1.Where(x => x.firstName.IndexOf(param) >= 0 ||
            x.lastName.IndexOf(param) >= 0 || x.idNumber.ToString().IndexOf(param) >= 0).ToList();
        }
    }
}
