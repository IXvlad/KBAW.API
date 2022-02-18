using System.Collections.Generic;

namespace DomainModels.DomainsModel
{
    public class RecommendedBook : Entity
    {
        public virtual string Title { get; set; }
        
        public virtual byte[] Book { get; set; }
        
        public virtual string Url { get; set; }


        public virtual ICollection<Article> Articles { get; set; } = new HashSet<Article>();
        
        public virtual ICollection<Book> Books { get; set; } = new HashSet<Book>();
        
        public virtual ICollection<Patent> Patents { get; set; } = new HashSet<Patent>();
    }
}