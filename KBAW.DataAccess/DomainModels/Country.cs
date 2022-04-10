using System.Collections.Generic;

namespace DataAccess.DomainModels
{
    public class Country : Entity
    {
        public virtual string Name { get; set; }
        
        
        public virtual ICollection<Book> Books { get; set; } = new HashSet<Book>();
        
        public virtual ICollection<Patent> Patents { get; set; } = new HashSet<Patent>();
    }
}