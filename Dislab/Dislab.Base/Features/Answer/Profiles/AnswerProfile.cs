using AutoMapper;
using Dislab.Base.Features.Answer.DTOs;
using Dislab.Base.Features.Answer.DTOS;
using Dislab.Base.Features.Answer.ViewModel;

namespace Dislab.Base.Features.Answer.Profiles
{
    public class AnswerProfile : Profile
    {
        public AnswerProfile()
        {
            CreateMap<InsertAnswerVM, InsertAnswerDTO>().ReverseMap()
              .ForMember(dest => dest.QuestionId, opt => opt.MapFrom(src => src.QuestionId))
              .ForMember(dest => dest.AnswerBody, opt => opt.MapFrom(src => src.AnswerBody));

            CreateMap<GetAnswerByIdVM, GetAnswerByIdDTO>().ReverseMap()
             .ForMember(dest => dest.QuestionId, opt => opt.MapFrom(src => src.QuestionId))
             .ForMember(dest => dest.AnswerBody, opt => opt.MapFrom(src => src.AnswerBody));

            CreateMap<GetAllAnswerVM, GetAllAnswerDTO>().ReverseMap();
             
        }
     

    }
}
