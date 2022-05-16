using System.Collections.Generic;

namespace KBAW.DataAccess.DomainModels
{
    public class Source: Entity
    {
        public virtual string Name { get; set; }
        
        public virtual byte[] Image { get; set; }
        
        public virtual string Url { get; set; }


        public virtual HashSet<Article> Articles { get; set; } = new();
        
        public virtual HashSet<Book> Books { get; set; } = new();
        
        public virtual HashSet<Patent> Patents { get; set; } = new();
    }
}