using Dislab.Base.Features.Answer.ViewModel;

namespace Dislab.Base.Features.Answer.DTOs
{
    public class GetAllAnswerDTO
    {
        public long Id { get; set; }
        public long QuestionId { get; set; }
        public string QuestionTitle { get; set; }
        public string? AnswerBody { get; set; }
    }
}
