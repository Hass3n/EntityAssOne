using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAssOne.Entities
{
    internal class Instructor
    {

        public int Id { get; set; }

        public String Name { get; set; }

        public int Bonus { get; set; }

        public double Salary { get; set; }

        public String Address { get; set; }

        public int HourRate { get; set; }


        public int Dept_Id { get; set; }

    }
}
