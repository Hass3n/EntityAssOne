﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAssOne.Entities
{
   

    internal class Topic
    {
    
        public int Id { get; set; }

        public int Name { get; set; }
    }
}
