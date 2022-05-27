using System;
using System.Linq;
using AutoMapper;
using KBAW.API.ViewModels;
using KBAW.Query.EFServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KBAW.API.Controlles
{
    [ApiController]
    [Route("[controller]")]
    public class RecordsController : ControllerBase
    {
        private readonly Lazy<IArticleQueryService> _articleQueryService;
        private readonly Lazy<IBookQueryService> _bookQueryService;
        private readonly Lazy<IPatentQueryService> _patentQueryService;
        private readonly Lazy<IMapper> _mapper;

        public RecordsController(
            Lazy<IArticleQueryService> articleQueryService, 
            Lazy<IBookQueryService> bookQueryService, 
            Lazy<IPatentQueryService> patentQueryService, 
            Lazy<IMapper> mapper)
        {
            _articleQueryService = articleQueryService;
            _bookQueryService = bookQueryService;
            _patentQueryService = patentQueryService;
            _mapper = mapper;
        }

        [HttpGet("GetAllRecords")]
        public IQueryable<Record> GetAllRecords()
        {
            IQueryable<Record> articles = _articleQueryService.Value.GetAll()
                .Select(article => _mapper.Value.Map<Record>(article));
            
            IQueryable<Record> books = _bookQueryService.Value.GetAll()
                .Select(book => _mapper.Value.Map<Record>(book));
            
            IQueryable<Record> patents = _patentQueryService.Value.GetAll()
                .Select(patent => _mapper.Value.Map<Record>(patent));

            return articles.Union(books).Union(patents);
        }
    }
}