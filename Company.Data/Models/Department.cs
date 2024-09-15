using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Models
{
    public class Department : BaseEnyity
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
