using AutoMapper;
using Dislab.Base.Features.Answer.DTOS;
using Dislab.Base.Features.Answer.ViewModel;
using Dislab.Base.Features.Questions.DTOs;
using Dislab.Base.Features.Questions.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dislab.Base.Features.Answer.Profiles
{
    public class AnswerProfile : Profile
    {
        public AnswerProfile()
        {
            CreateMap<InsertAnswerVM, InsertAnswerDTO>()
              .ForMember(dest => dest.AnswerBody, opt => opt.MapFrom(src => src.AnswerBody));

            CreateMap<UpdateAnswerVM, UpdateAnswerDTO>()
              .ForMember(dest => dest.AnswerBody, opt => opt.MapFrom(src => src.AnswerBody));
        }
     

    }
}
