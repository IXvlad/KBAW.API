using System;
using System.Linq;
using KBAW.Command.XmlServices;
using KBAW.DataAccess.DomainModels;
using KBAW.Query.EFServices.Interfaces;
using KBAW.Query.XmlServices.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KBAW.API.Controlles
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        #region EFCommandAndQuery

        private readonly Lazy<IArticleQueryService> _articleQueryService;
        private readonly Lazy<IAuthorOfArticleQueryService> _authorOfArticleQueryService;
        private readonly Lazy<IAuthorOfBookQueryService> _authorOfBookQueryService;
        private readonly Lazy<IAuthorOfPatentQueryService> _authorOfPatentQueryService;
        private readonly Lazy<IAuthorQueryService> _authorQueryService;
        private readonly Lazy<IBookQueryService> _bookQueryService;
        private readonly Lazy<IPatentQueryService> _patentQueryService;
        private readonly Lazy<IRecommendedBookQueryService> _recommendedBookQueryService;
        private readonly Lazy<ISourceQueryService> _sourceQueryService;
        private readonly Lazy<IYdkQueryService> _ydkQueryService;

        #endregion

        #region XmlCommandAndQuery

        private readonly Lazy<IArticleXmlQueryService> _articleXmlQueryService;
        private readonly Lazy<IAuthorOfArticleXmlQueryService> _authorOfArticleXmlQueryService;
        private readonly Lazy<IAuthorOfBookXmlQueryService> _authorOfBookXmlQueryService;
        private readonly Lazy<IAuthorOfPatentXmlQueryService> _authorOfPatentXmlQueryService;
        private readonly Lazy<IAuthorXmlQueryService> _authorXmlQueryService;
        private readonly Lazy<IBookXmlQueryService> _bookXmlQueryService;
        private readonly Lazy<IPatentXmlQueryService> _patentXmlQueryService;
        private readonly Lazy<IRecommendedBookXmlQueryService> _recommendedBookXmlQueryService;
        private readonly Lazy<ISourceXmlQueryService> _sourceXmlQueryService;
        private readonly Lazy<IYdkXmlQueryService> _ydkXmlQueryService;

        private readonly Lazy<IArticleXmlCommandService> _articleXmlCommandService;
        private readonly Lazy<IAuthorOfArticleXmlCommandService> _authorOfArticleXmlCommandService;
        private readonly Lazy<IAuthorOfBookXmlCommandService> _authorOfBookXmlCommandService;
        private readonly Lazy<IAuthorOfPatentXmlCommandService> _authorOfPatentXmlCommandService;
        private readonly Lazy<IAuthorXmlCommandService> _authorXmlCommandService;
        private readonly Lazy<IBookXmlCommandService> _bookXmlCommandService;
        private readonly Lazy<IPatentXmlCommandService> _patentXmlCommandService;
        private readonly Lazy<IRecommendedBookXmlCommandService> _recommendedBookXmlCommandService;
        private readonly Lazy<ISourceXmlCommandService> _sourceXmlCommandService;
        private readonly Lazy<IYdkXmlCommandService> _ydkXmlCommandService;

        #endregion

        public TestController(
            Lazy<IArticleQueryService> articleQueryService,
            Lazy<IAuthorOfArticleQueryService> authorOfArticleQueryService,
            Lazy<IPatentQueryService> patentQueryService,
            Lazy<IAuthorOfBookQueryService> authorOfBookQueryService,
            Lazy<IAuthorOfPatentQueryService> authorOfPatentQueryService,
            Lazy<IAuthorQueryService> authorQueryService,
            Lazy<IBookQueryService> bookQueryService,
            Lazy<IRecommendedBookQueryService> recommendedBookQueryService,
            Lazy<ISourceQueryService> sourceQueryService,
            Lazy<IYdkXmlQueryService> ydkXmlQueryService,
            Lazy<IYdkXmlCommandService> ydkXmlCommandService,
            Lazy<IArticleXmlCommandService> articleXmlCommandService,
            Lazy<IAuthorOfBookXmlCommandService> authorOfBookXmlCommandService,
            Lazy<IAuthorOfArticleXmlCommandService> authorOfArticleXmlCommandService,
            Lazy<IAuthorOfPatentXmlCommandService> authorOfPatentXmlCommandService,
            Lazy<IAuthorXmlCommandService> authorXmlCommandService,
            Lazy<IBookXmlCommandService> bookXmlCommandService,
            Lazy<IPatentXmlCommandService> patentXmlCommandService,
            Lazy<IRecommendedBookXmlCommandService> recommendedBookXmlCommandService,
            Lazy<ISourceXmlCommandService> sourceXmlCommandService,
            Lazy<IArticleXmlQueryService> articleXmlQueryService,
            Lazy<IAuthorOfArticleXmlQueryService> authorOfArticleXmlQueryService,
            Lazy<IAuthorOfBookXmlQueryService> authorOfBookXmlQueryService,
            Lazy<IAuthorOfPatentXmlQueryService> authorOfPatentXmlQueryService,
            Lazy<IAuthorXmlQueryService> authorXmlQueryService,
            Lazy<IBookXmlQueryService> bookXmlQueryService,
            Lazy<IPatentXmlQueryService> patentXmlQueryService,
            Lazy<IRecommendedBookXmlQueryService> recommendedBookXmlQueryService,
            Lazy<ISourceXmlQueryService> sourceXmlQueryService, 
            Lazy<IYdkQueryService> ydkQueryService)
        {
            _articleQueryService = articleQueryService;
            _authorOfArticleQueryService = authorOfArticleQueryService;
            _patentQueryService = patentQueryService;
            _authorOfBookQueryService = authorOfBookQueryService;
            _authorOfPatentQueryService = authorOfPatentQueryService;
            _authorQueryService = authorQueryService;
            _bookQueryService = bookQueryService;
            _recommendedBookQueryService = recommendedBookQueryService;
            _sourceQueryService = sourceQueryService;
            _ydkXmlQueryService = ydkXmlQueryService;
            _ydkXmlCommandService = ydkXmlCommandService;
            _articleXmlCommandService = articleXmlCommandService;
            _authorOfBookXmlCommandService = authorOfBookXmlCommandService;
            _authorOfArticleXmlCommandService = authorOfArticleXmlCommandService;
            _authorOfPatentXmlCommandService = authorOfPatentXmlCommandService;
            _authorXmlCommandService = authorXmlCommandService;
            _bookXmlCommandService = bookXmlCommandService;
            _patentXmlCommandService = patentXmlCommandService;
            _recommendedBookXmlCommandService = recommendedBookXmlCommandService;
            _sourceXmlCommandService = sourceXmlCommandService;

            _articleXmlQueryService = articleXmlQueryService;
            _authorOfArticleXmlQueryService = authorOfArticleXmlQueryService;
            _authorOfBookXmlQueryService = authorOfBookXmlQueryService;
            _authorOfPatentXmlQueryService = authorOfPatentXmlQueryService;
            _authorXmlQueryService = authorXmlQueryService;
            _bookXmlQueryService = bookXmlQueryService;
            _patentXmlQueryService = patentXmlQueryService;
            _recommendedBookXmlQueryService = recommendedBookXmlQueryService;
            _sourceXmlQueryService = sourceXmlQueryService;
            _ydkQueryService = ydkQueryService;
        }

        #region GetFromXml

        [HttpGet("GetArticleXml")]
        public IQueryable<Article> GetArticleXml()
        {
            return _articleXmlQueryService.Value.GetAll();
        }

        [HttpGet("GetAuthorOfArticleXml")]
        public IQueryable<AuthorOfArticle> GetAuthorOfArticleXml()
        {
            return _authorOfArticleXmlQueryService.Value.GetAll();
        }

        [HttpGet("GetAuthorOfBookXml")]
        public IQueryable<AuthorOfBook> GetAuthorOfBookXml()
        {
            return _authorOfBookXmlQueryService.Value.GetAll();
        }

        [HttpGet("GetAuthorOfPatentXml")]
        public IQueryable<AuthorOfPatent> GetAuthorOfPatentXml()
        {
            return _authorOfPatentXmlQueryService.Value.GetAll();
        }

        [HttpGet("GetAuthorXml")]
        public IQueryable<Author> GetAuthorXml()
        {
            return _authorXmlQueryService.Value.GetAll();
        }

        [HttpGet("GetBookXml")]
        public IQueryable<Book> GetBookXml()
        {
            return _bookXmlQueryService.Value.GetAll();
        }

        [HttpGet("GetPatentXml")]
        public IQueryable<Patent> GetPatentXml()
        {
            return _patentXmlQueryService.Value.GetAll();
        }

        [HttpGet("GetRecommendedBookXml")]
        public IQueryable<RecommendedBook> GetRecommendedBookXml()
        {
            return _recommendedBookXmlQueryService.Value.GetAll();
        }

        [HttpGet("GetSourceBookXml")]
        public IQueryable<Source> GetSourceBookXml()
        {
            return _sourceXmlQueryService.Value.GetAll();
        }

        [HttpGet("GetYdkXml")]
        public IQueryable<Ydk> GetYdkXml()
        {
            return _ydkXmlQueryService.Value.GetAll();
        }

        #endregion

        #region CreateXml

        [HttpGet("CreateArticleXml")]
        public Article CreateArticleXml()
        {
            var articles = _articleQueryService.Value.GetAll()
                .ToList();

            foreach (var article in articles)
            {
                _articleXmlCommandService.Value.Create(article);
            }

            return articles.FirstOrDefault();
        }

        [HttpGet("CreateAuthorOfArticleXml")]
        public AuthorOfArticle CreateAuthorOfArticleXml()
        {
            var authorOfArticles = _authorOfArticleQueryService.Value.GetAll()
                .ToList();

            foreach (var authorOfArticle in authorOfArticles)
            {
                _authorOfArticleXmlCommandService.Value.Create(authorOfArticle);
            }

            return authorOfArticles.FirstOrDefault();
        }

        [HttpGet("CreateAuthorOfBookXml")]
        public AuthorOfBook CreateAuthorOfBookXml()
        {
            var authorOfBooks = _authorOfBookQueryService.Value.GetAll()
                .ToList();

            foreach (var authorOfBook in authorOfBooks)
            {
                _authorOfBookXmlCommandService.Value.Create(authorOfBook);
            }

            return authorOfBooks.FirstOrDefault();
        }

        [HttpGet("CreateAuthorOfPatentXml")]
        public AuthorOfPatent CreateAuthorOfPatentXml()
        {
            var authorOfPatents = _authorOfPatentQueryService.Value.GetAll()
                .ToList();

            foreach (var authorOfPatent in authorOfPatents)
            {
                _authorOfPatentXmlCommandService.Value.Create(authorOfPatent);
            }

            return authorOfPatents.FirstOrDefault();
        }

        [HttpGet("CreateAuthorXml")]
        public Author CreateAuthorXml()
        {
            var authors = _authorQueryService.Value.GetAll()
                .ToList();

            foreach (var author in authors)
            {
                _authorXmlCommandService.Value.Create(author);
            }

            return authors.FirstOrDefault();
        }

        [HttpGet("CreateBookXml")]
        public Book CreateBookXml()
        {
            var books = _bookQueryService.Value.GetAll()
                .ToList();

            foreach (var book in books)
            {
                _bookXmlCommandService.Value.Create(book);
            }

            return books.FirstOrDefault();
        }

        [HttpGet("CreatePatentXml")]
        public Patent CreatePatentXml()
        {
            var patents = _patentQueryService.Value.GetAll()
                .ToList();

            foreach (var patent in patents)
            {
                _patentXmlCommandService.Value.Create(patent);
            }

            return patents.FirstOrDefault();
        }

        [HttpGet("CreateRecommendedBookXml")]
        public RecommendedBook CreateRecommendedBookXml()
        {
            var recommendedBooks = _recommendedBookQueryService.Value.GetAll()
                .ToList();

            foreach (var recommendedBook in recommendedBooks)
            {
                _recommendedBookXmlCommandService.Value.Create(recommendedBook);
            }

            return recommendedBooks.FirstOrDefault();
        }

        [HttpGet("CreateSourceXml")]
        public Source CreateSourceXml()
        {
            var sources = _sourceQueryService.Value.GetAll()
                .ToList();

            foreach (var source in sources)
            {
                _sourceXmlCommandService.Value.Create(source);
            }

            return sources.FirstOrDefault();
        }

        [HttpGet("CreateYdkXml")]
        public Ydk CreateYdkXml()
        {
            var ydks = _ydkQueryService.Value.GetAll()
                .ToList();

            foreach (var ydk in ydks)
            {
                _ydkXmlCommandService.Value.Create(ydk);
            }

            return ydks.FirstOrDefault();
        }

        #endregion

        #region GetFromEF

        [HttpGet("Articles")]
        public IQueryable<Article> GetArticle()
        {
            return _articleQueryService.Value.GetAll();
        }

        [HttpGet("AuthorOfArticles")]
        public IQueryable<AuthorOfArticle> GetAuthorOfArticle()
        {
            return _authorOfArticleQueryService.Value.GetAll();
        }

        [HttpGet("AuthorOfBooks")]
        public IQueryable<AuthorOfBook> GetAuthorOfBook()
        {
            return _authorOfBookQueryService.Value.GetAll();
        }

        [HttpGet("AuthorOfPatents")]
        public IQueryable<AuthorOfPatent> GetAuthorOfPatent()
        {
            return _authorOfPatentQueryService.Value.GetAll();
        }

        [HttpGet("Authors")]
        public IQueryable<Author> GetAuthors()
        {
            return _authorQueryService.Value.GetAll();
        }

        [HttpGet("Books")]
        public IQueryable<Book> GetBook()
        {
            return _bookQueryService.Value.GetAll();
        }

        [HttpGet("Patents")]
        public IQueryable<Patent> GetPatent()
        {
            return _patentQueryService.Value.GetAll();
        }

        [HttpGet("RecommendedBooks")]
        public IQueryable<RecommendedBook> GetRecommendedBook()
        {
            return _recommendedBookQueryService.Value.GetAll();
        }

        [HttpGet("Sources")]
        public IQueryable<Source> GetSource()
        {
            return _sourceQueryService.Value.GetAll();
        }

        #endregion
    }
}