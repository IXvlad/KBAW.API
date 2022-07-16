using System.Collections.Generic;

namespace KBAW.DataAccess.DomainModels;

public class Country : Entity
{
    public virtual string Name { get; set; }


    public virtual HashSet<Book> Books { get; set; } = new();

    public virtual HashSet<Patent> Patents { get; set; } = new();
}