using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Angular7DemoServices
{
    public class Employee
    {
        [Key]
        
        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
    }
}
