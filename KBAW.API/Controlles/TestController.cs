using System.Linq;
using KBAW.DataAccess.DomainModels;
using KBAW.Query;
using KBAW.Query.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KBAW.API.Controlles
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IArticleQueryService _articleQueryService;
        private readonly IAuthorOfArticleQueryService _authorOfArticleQueryService;
        private readonly IAuthorOfBookQueryService _authorOfBookQueryService;
        private readonly IAuthorOfPatentQueryService _authorOfPatentQueryService;
        private readonly IAuthorsQueryService _authorsQueryService;
        private readonly IBookQueryService _bookQueryService;
        private readonly IPatentQueryService _patentQueryService;
        private readonly IRecommendedBookQueryService _recommendedBookQueryService;
        private readonly ISourceQueryService _sourceQueryService;

        public TestController(IArticleQueryService articleQueryService,
            IAuthorOfArticleQueryService authorOfArticleQueryService, IPatentQueryService patentQueryService,
            IAuthorOfBookQueryService authorOfBookQueryService, IAuthorOfPatentQueryService authorOfPatentQueryService,
            IAuthorsQueryService authorsQueryService, IBookQueryService bookQueryService,
            IRecommendedBookQueryService recommendedBookQueryService, ISourceQueryService sourceQueryService)
        {
            _articleQueryService = articleQueryService;
            _authorOfArticleQueryService = authorOfArticleQueryService;
            _patentQueryService = patentQueryService;
            _authorOfBookQueryService = authorOfBookQueryService;
            _authorOfPatentQueryService = authorOfPatentQueryService;
            _authorsQueryService = authorsQueryService;
            _bookQueryService = bookQueryService;
            _recommendedBookQueryService = recommendedBookQueryService;
            _sourceQueryService = sourceQueryService;
        }
        
        [HttpGet("Articles")]
        public IQueryable<Article> GetArticle()
        {
            return _articleQueryService.GetAll();
        }

        [HttpGet("AuthorOfArticles")]
        public IQueryable<AuthorOfArticle> GetAuthorOfArticle()
        {
            return _authorOfArticleQueryService.GetAll();
        }

        [HttpGet("AuthorOfBooks")]
        public IQueryable<AuthorOfBook> GetAuthorOfBook()
        {
            return _authorOfBookQueryService.GetAll();
        }

        [HttpGet("AuthorOfPatents")]
        public IQueryable<AuthorOfPatent> GetAuthorOfPatent()
        {
            return _authorOfPatentQueryService.GetAll();
        }

        [HttpGet("Authors")]
        public IQueryable<Author> GetAuthors()
        {
            return _authorsQueryService.GetAll();
        }

        [HttpGet("Books")]
        public IQueryable<Book> GetBook()
        {
            return _bookQueryService.GetAll();
        }

        [HttpGet("Patents")]
        public IQueryable<Patent> GetPatent()
        {
            return _patentQueryService.GetAll();
        }

        [HttpGet("RecommendedBooks")]
        public IQueryable<RecommendedBook> GetRecommendedBook()
        {
            return _recommendedBookQueryService.GetAll();
        }

        [HttpGet("Sources")]
        public IQueryable<Source> GetSource()
        {
            return _sourceQueryService.GetAll();
        }
    }
}