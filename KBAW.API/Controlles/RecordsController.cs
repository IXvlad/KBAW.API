using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using KBAW.API.ViewModels;
using KBAW.Query.EFServices.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public IEnumerable<Record> GetAllRecords()
        {
            IQueryable<Record> articles = _articleQueryService.Value.GetAll()
                .Include(x => x.AuthorOfArticles)
                .ThenInclude(x => x.Author)
                .Select(article => _mapper.Value.Map<Record>(article));
            
            IQueryable<Record> books = _bookQueryService.Value.GetAll()
                .Include(x => x.AuthorOfBooks)
                .ThenInclude(x => x.Author)
                .Select(book => _mapper.Value.Map<Record>(book));
            
            IQueryable<Record> patents = _patentQueryService.Value.GetAll()
                .Include(x => x.AuthorOfPatents)
                .ThenInclude(x => x.Author)
                .Select(patent => _mapper.Value.Map<Record>(patent));

            return Enumerable.Concat(articles, books).Concat(patents);
        }
    }
}