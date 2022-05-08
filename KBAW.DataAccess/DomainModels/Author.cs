using System.Collections.Generic;

namespace KBAW.DataAccess.DomainModels
{
    public class Author : Entity
    {
        public virtual string Surname { get; set; }
        
        public virtual string Name { get; set; }
        
        public virtual string Lastname { get; set; }


        public virtual ICollection<AuthorOfArticle> AuthorOfArticles { get; set; } = new HashSet<AuthorOfArticle>();

        public virtual ICollection<AuthorOfBook> AuthorOfBooks { get; set; } = new HashSet<AuthorOfBook>();
        
        public virtual ICollection<AuthorOfPatent> AuthorOfPatents { get; set; } = new HashSet<AuthorOfPatent>();
    }
}