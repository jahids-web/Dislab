using AutoMapper;
using Dislab.Base.Features.Questions.DTOs;
using Dislab.Base.Features.Questions.ViewModels;

namespace Dislab.Base.Features.Questions.Profiles
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile()
        {
            //<TSource, TDestination>
            CreateMap<InsertQuestionVM, InsertQuestionDTO>()
                 .ForMember(dest => dest.QuestionTitle, opt => opt.MapFrom(src => src.QuestionTitle))
                 .ForMember(dest => dest.QuestionBody, opt => opt.MapFrom(src => src.QuestionBody));

            CreateMap<UpdateQuestionVM, UpdateQuestionDTO>()
               .ForMember(dest => dest.QuestionTitle, opt => opt.MapFrom(src => src.QuestionTitle))
               .ForMember(dest => dest.QuestionBody, opt => opt.MapFrom(src => src.QuestionBody));

            CreateMap<QuestionDetailsVM, QuestionDetailsDTO>().ReverseMap();

            CreateMap<GetAllQuiestionsVM, GetAllQuiestionsDTO>().ReverseMap();
          
        }
    }
}
