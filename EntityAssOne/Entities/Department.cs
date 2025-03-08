using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAssOne.Entities
{


    internal class Department
    {


        public int Id { get; set; }

  
        public String Name { get; set; }

        public int Ins_ID { get; set; }


        public DateTime HireDate { get; set; }
    }
}
