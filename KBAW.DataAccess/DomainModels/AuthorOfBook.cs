namespace KBAW.DataAccess.DomainModels;

public class AuthorOfBook : Entity
{
    public virtual long BookId { get; set; }

    public virtual long AuthorId { get; set; }


    public virtual Book Book { get; set; }

    public virtual Author Author { get; set; }
}