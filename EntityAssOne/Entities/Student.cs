using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAssOne.Entities
{
    

    internal class Student
    {

  
        public int Id { get; set; }

        [MaxLength(20)]
        public String FName { get; set; }

        [MaxLength(20)]
        public String LName { get; set; }


        public String Address { get; set; }

        [Range(15,60)]
        public int? Age { get; set; }

        
        public int DeptId { get; set; }
    }
}
