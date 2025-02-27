using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAssOne.Entities
{
    internal class Student
    {

        public int Id { get; set; }

        public String FName { get; set; }

        public String LName { get; set; }

        public String Address { get; set; }

        public int? Age { get; set; }

        public int DeptId { get; set; }
    }
}
