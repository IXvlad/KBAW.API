using System.Linq;
using AutoMapper;
using KBAW.API.ViewModels;
using KBAW.DataAccess.DomainModels;

namespace KBAW.API.Infrastructure
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            ArticleConfiguration();
            BookConfiguration();
            PatentConfiguration();
        }

        private void ArticleConfiguration()
        {
            CreateMap<Article, Record>()
                .ForMember(dest => dest.Authors, src =>
                    src.MapFrom(article => article.AuthorOfArticles.Select(author => $"{author.Author.Name} {author.Author.Surname} {author.Author.Lastname}")))
                .ForMember(dest => dest.Ydk, src =>
                    src.MapFrom(article => article.Ydk.Name))
                .ForMember(dest => dest.Country, src => src.Ignore())
                .ForMember(dest => dest.СertificateAuthorship, src => src.Ignore())
                .ForMember(dest => dest.Classification, src => src.Ignore())
                .ForMember(dest => dest.Number, src => src.Ignore());
        }

        private void BookConfiguration()
        {
            CreateMap<Book, Record>()
                .ForMember(dest => dest.Authors, src =>
                    src.MapFrom(book => book.AuthorOfBooks.Select(author => $"{author.Author.Name} {author.Author.Surname} {author.Author.Lastname}")))
                .ForMember(dest => dest.Country, src =>
                    src.MapFrom(book => book.Country.Name))
                .ForMember(dest => dest.Ydk, src =>
                    src.MapFrom(book => book.Ydk.Name))
                .ForMember(dest => dest.СertificateAuthorship, src => src.Ignore())
                .ForMember(dest => dest.Classification, src => src.Ignore())
                .ForMember(dest => dest.Number, src => src.Ignore())
                .ForMember(dest => dest.PlacePublication, src => src.Ignore());
        }

        private void PatentConfiguration()
        {
            CreateMap<Patent, Record>()
                .ForMember(dest => dest.Authors, src =>
                    src.MapFrom(patent => patent.AuthorOfPatents.Select(author => $"{author.Author.Name} {author.Author.Surname} {author.Author.Lastname}")))
                .ForMember(dest => dest.Country, src =>
                    src.MapFrom(patent => patent.Country.Name))
                .ForMember(dest => dest.Ydk, src =>
                    src.MapFrom(patent => patent.Ydk.Name))
                .ForMember(dest => dest.PlacePublication, src => src.Ignore());
        }
    }
}