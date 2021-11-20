using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
   public class Article:BaseEntity
    {
        public string UserName { get; set; }
        public string Content { get; set; }
        public int? AppUserID { get; set; }
        public int? CategoryID { get; set; }
        public int? EditorID { get; set; }

        //Relation Property
        public virtual AppUser AppUser { get; set; }
        public virtual Category Category { get; set; }
        public virtual Editor Editor { get; set; }
        public virtual List<Tag>Tags { get; set; }


    }
}
