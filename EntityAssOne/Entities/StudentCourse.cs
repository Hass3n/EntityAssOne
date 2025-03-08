using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAssOne.Entities
{
    

    internal class StudentCourse
    {

 
        public int Id { get; set; }
        public int StusentId { get; set; }

        public int CourseId { get; set; }

   
        public float Grade { get; set; }



    }
}
