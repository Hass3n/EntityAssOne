using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAssOne.Entities
{
    internal class Course
    {

        public int Id { get; set; }

        public int Duration { get; set; }

        public String Name { get; set; }

        public String Description { get; set; }

        public int TopId { get; set; }
    }
}
