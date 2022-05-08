namespace KBAW.DataAccess.DomainModels
{
    public class AuthorOfArticle : Entity
    {
        public virtual long ArticleId { get; set; }
        
        public virtual long AuthorId { get; set; }

        
        public virtual Article Article { get; set; }
        
        public virtual Author Author { get; set; }
    }
}