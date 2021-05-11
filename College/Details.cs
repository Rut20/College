using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace College
{
     public enum  Gender { man, wife }
    public class Details
    {
        public int id { get; set; }
        public int idNumber { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
        public Gender gender { get; set; }
        public DateTime enrollDate { get; set; }
        public int age { get; set; }
    }

}
