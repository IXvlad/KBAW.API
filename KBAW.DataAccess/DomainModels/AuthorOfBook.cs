namespace DataAccess.DomainModels
{
    public class AuthorOfBook : Entity
    {
        public virtual int BookId { get; set; }
        
        public virtual int AuthorId { get; set; }
        
        
        public virtual Book Book { get; set; }
        
        public virtual Author Author { get; set; }
    }
}