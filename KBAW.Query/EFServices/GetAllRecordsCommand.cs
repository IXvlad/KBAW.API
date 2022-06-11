using AutoMapper;
using KBAW.Query.EFServices.Interfaces;
using KBAW.Query.EFServices.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace KBAW.Query.EFServices;

public class GetAllRecordsCommand : IGetAllRecordsCommand
{
    private readonly Lazy<IArticleQueryService> _articleQueryService;
    private readonly Lazy<IBookQueryService> _bookQueryService;
    private readonly Lazy<IPatentQueryService> _patentQueryService;
    private readonly Lazy<IMapper> _mapper;

    public GetAllRecordsCommand(
        Lazy<IArticleQueryService> articleQueryService, 
        Lazy<IBookQueryService> bookQueryService, 
        Lazy<IPatentQueryService> patentQueryService, Lazy<IMapper> mapper)
    {
        _articleQueryService = articleQueryService;
        _bookQueryService = bookQueryService;
        _patentQueryService = patentQueryService;
        _mapper = mapper;
    }

    public IEnumerable<Record> Get()
    {
        var articles = _articleQueryService.Value.GetAll()
            .Include(x => x.AuthorOfArticles)
            .ThenInclude(x => x.Author)
            .Select(article => _mapper.Value.Map<Record>(article));
            
        var books = _bookQueryService.Value.GetAll()
            .Include(x => x.AuthorOfBooks)
            .ThenInclude(x => x.Author)
            .Select(book => _mapper.Value.Map<Record>(book));
            
        var patents = _patentQueryService.Value.GetAll()
            .Include(x => x.AuthorOfPatents)
            .ThenInclude(x => x.Author)
            .Select(patent => _mapper.Value.Map<Record>(patent));

        return Enumerable.Concat(articles, books).Concat(patents).ToList();
    }
}