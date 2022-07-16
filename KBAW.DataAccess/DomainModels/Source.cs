using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KBAW.DataAccess.DomainModels;

public class Source : Entity
{
    [Required]
    public virtual string Name { get; set; }

    [Required]
    public virtual byte[] Image { get; set; }

    public virtual string Url { get; set; }


    public virtual HashSet<Article> Articles { get; set; } = new();

    public virtual HashSet<Book> Books { get; set; } = new();

    public virtual HashSet<Patent> Patents { get; set; } = new();
}