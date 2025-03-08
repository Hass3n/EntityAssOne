using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EntityAssOne.Entities
{
 
    internal class Instructor
    {

     
        public int Id { get; set; }

        [MaxLength(20)]

        public String Name { get; set; }



        public int Bonus { get; set; }

        public double Salary { get; set; }

        public String Address { get; set; }

      
        public int HourRate { get; set; }


        public int Dept_Id { get; set; }

    }
}
