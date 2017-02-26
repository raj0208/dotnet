using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspnetmvc.Models
{
    public class Employee
    {
        public int EmpCode { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
    }
}