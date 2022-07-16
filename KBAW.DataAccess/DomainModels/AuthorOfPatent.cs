namespace KBAW.DataAccess.DomainModels;

public class AuthorOfPatent : Entity
{
    public virtual long PatentId { get; set; }

    public virtual long AuthorId { get; set; }


    public virtual Patent Patent { get; set; }

    public virtual Author Author { get; set; }
}