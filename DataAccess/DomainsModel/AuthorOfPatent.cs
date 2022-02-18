namespace DomainModels.DomainsModel
{
    public class AuthorOfPatent : Entity
    {
        public virtual int PatentId { get; set; }
        
        public virtual int AuthorId { get; set; }
        
        
        public virtual Patent Patent { get; set; }
        
        public virtual Author Author { get; set; }
    }
}