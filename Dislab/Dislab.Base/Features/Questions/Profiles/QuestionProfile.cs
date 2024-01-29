using AutoMapper;
using Dislab.Base.Features.Questions.DTOs;
using Dislab.Base.Features.Questions.ViewModels;

namespace Dislab.Base.Features.Questions.Profiles
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile()
        {
            CreateMap<InsertQuestionVM, InsertQuestionDTO>();

            //.ForMember(
            //        dest => dest.QuestionTitle,
            //        opt => opt.MapFrom(src => $"{src.QuestionTitle}")
            //    )
            //.ForMember(
            //        dest => dest.QuestionTitle,
            //        opt => opt.MapFrom(src => $"{src.QuestionTitle}")
            //    );
        }
        
    }
}
