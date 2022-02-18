using System.Collections.Generic;

namespace DomainModels.DomainsModel
{
    public class Country : Entity
    {
        public virtual string Name { get; set; }
        
        
        public virtual ICollection<Book> Books { get; set; } = new HashSet<Book>();
        
        public virtual ICollection<Patent> Patents { get; set; } = new HashSet<Patent>();
    }
}