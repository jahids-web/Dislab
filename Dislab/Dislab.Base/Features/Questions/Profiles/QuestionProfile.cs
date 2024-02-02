using AutoMapper;
using Dislab.Base.Features.Questions.DTOs;
using Dislab.Base.Features.Questions.ViewModels;

namespace Dislab.Base.Features.Questions.Profiles
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile()
        {

            CreateMap<InsertQuestionDTO, InsertQuestionVM>().ReverseMap();
            //CreateMap<UpdateQuestionVM, UpdateQuestionDTO>().ReverseMap();

            //.ForMember(
            //        dest => dest.QuestionTitle,
            //        opt => opt.MapFrom(src => $"{src.QuestionTitle}")
            //    )
            //.ForMember(
            //        dest => dest.QuestionBody,
            //        opt => opt.MapFrom(src => $"{src.QuestionBody}")
            //    );

            //ConfigureMappings();


        }

        //private void ConfigureMappings()
        //{
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<InsertQuestionVM, InsertQuestionDTO>().ReverseMap();
        //    });

        //    IMapper mapper = config.CreateMapper();

        //    mapper.Map<InsertQuestionDTO, InsertQuestionVM>(new InsertQuestionDTO());
        //}

    }
}
