using System.Collections.Generic;

namespace KBAW.DataAccess.DomainModels
{
    public class Author : Entity
    {
        public virtual string Surname { get; set; }
        
        public virtual string Name { get; set; }
        
        public virtual string Lastname { get; set; }


        public virtual HashSet<AuthorOfArticle> AuthorOfArticles { get; set; } = new();

        public virtual HashSet<AuthorOfBook> AuthorOfBooks { get; set; } = new();
        
        public virtual HashSet<AuthorOfPatent> AuthorOfPatents { get; set; } = new();
    }
}