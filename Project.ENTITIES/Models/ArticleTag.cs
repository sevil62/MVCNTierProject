using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
   public class ArticleTag:BaseEntity
    {
        public int TagID { get; set; }
        public int ArticleID { get; set; }

        //Relation Property
        public virtual Tag Tag { get; set; }
        public virtual Article Article { get; set; }

    }
}
