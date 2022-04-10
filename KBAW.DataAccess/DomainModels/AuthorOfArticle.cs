namespace DataAccess.DomainModels
{
    public class AuthorOfArticle : Entity
    {
        public virtual int ArticleId { get; set; }
        
        public virtual int AuthorId { get; set; }

        
        public virtual Article Article { get; set; }
        
        public virtual Author Author { get; set; }
    }
}