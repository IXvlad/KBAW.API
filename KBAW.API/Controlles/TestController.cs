using System;
using System.Linq;
using KBAW.Command.XmlServices;
using KBAW.DataAccess.DomainModels;
using KBAW.Query.EFServices.Interfaces;
using KBAW.Query.XmlServices.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
        
        #endregion

        #region XmlCommandAndQuery
        
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

        private readonly ILogger<TestController> _log;

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
            ILogger<TestController> log)
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
            _log = log;
        }

        [HttpGet("GetYdkXml")]
        public IQueryable<Ydk> GetYdkXml()
        { 
            return _ydkXmlQueryService.Value.GetAll();
        }

        [HttpGet("CreateArticleXml")]
        public Article CreateArticleXml()
        {
            var article = new Article
            {
                Id = 1
            };

            _articleXmlCommandService.Value.Create(article);

            return article;
        }
        
        [HttpGet("CreateAuthorOfArticleXml")]
        public AuthorOfArticle CreateAuthorOfArticleXml()
        {
            var authorOfArticle = new AuthorOfArticle
            {
                Id = 1,
            };
            
            _authorOfArticleXmlCommandService.Value.Create(authorOfArticle);

            return authorOfArticle;
        }
        
        [HttpGet("CreateAuthorOfBookXml")]
        public AuthorOfBook CreateAuthorOfBookXml()
        {
            var authorOfBook = new AuthorOfBook
            {
                Id = 1,
            };
            
            _authorOfBookXmlCommandService.Value.Create(authorOfBook);

            return authorOfBook;
        }
        
        [HttpGet("CreateAuthorOfPatentXml")]
        public AuthorOfPatent CreateAuthorOfPatentXml()
        {
            var authorOfPatent = new AuthorOfPatent
            {
                Id = 1,
            };
            
            _authorOfPatentXmlCommandService.Value.Create(authorOfPatent);

            return authorOfPatent;
        }
        
        [HttpGet("CreateAuthorXml")]
        public Author CreateAuthorXml()
        {
            var author = new Author
            {
                Id = 1,
            };
            
            _authorXmlCommandService.Value.Create(author);

            return author;
        }
        
        [HttpGet("CreateBookXml")]
        public Book CreateBookXml()
        {
            var book = new Book
            {
                Id = 1,
            };
            
            _bookXmlCommandService.Value.Create(book);

            return book;
        }
        
        [HttpGet("CreatePatentXml")]
        public Patent CreatePatentXml()
        {
            var patent = new Patent
            {
                Id = 1,
            };
            
            _patentXmlCommandService.Value.Create(patent);

            return patent;
        }
        
        [HttpGet("CreateRecommendedBookXml")]
        public RecommendedBook CreateRecommendedBookXml()
        {
            var recommendedBook = new RecommendedBook
            {
                Id = 1,
            };
            
            _recommendedBookXmlCommandService.Value.Create(recommendedBook);

            return recommendedBook;
        }
        
        [HttpGet("CreateSourceXml")]
        public Source CreateSourceXml()
        {
            var source = new Source
            {
                Id = 1,
            };
            
            _sourceXmlCommandService.Value.Create(source);

            return source;
        }
        
        [HttpGet("CreateYdkXml")]
        public Ydk CreateYdkXml()
        {
            var ydk = new Ydk
            {
                Id = 1,
            };
            
            _ydkXmlCommandService.Value.Create(ydk);

            return ydk;
        }
        
        
        
        
        
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
    }
}