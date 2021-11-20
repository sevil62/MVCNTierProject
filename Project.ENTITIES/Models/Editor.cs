﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
   public class Editor:BaseEntity
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        //Relation Property
        public virtual List<Article>Articles { get; set; }


    }
}
