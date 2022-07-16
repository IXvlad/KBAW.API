using System;
using System.Collections.Generic;

namespace KBAW.DataAccess.DomainModels;

public class Article : Entity
{
    public virtual string K1 { get; set; }

    public virtual string K2 { get; set; }

    public virtual string K3 { get; set; }

    public virtual string Title { get; set; }

    public virtual string Description { get; set; }

    /// TODO:
    /// Set DateOnly
    public virtual DateTime Date { get; set; }

    public virtual long YdkId { get; set; }

    public virtual long RecommendedBookId { get; set; }

    public virtual string PlacePublication { get; set; }

    public virtual long SourceId { get; set; }


    public virtual Ydk Ydk { get; set; }

    public virtual Source Source { get; set; }

    public virtual RecommendedBook RecommendedBook { get; set; }

    public virtual HashSet<AuthorOfArticle> AuthorOfArticles { get; set; } = new();
}