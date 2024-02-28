namespace Dislab.Base.Features.Answer.ViewModel
{
    public class GetAllAnswerVM
    {
        public long Id { get; set; }
        public long QuestionId { get; set; }
        public string QuestionTitle { get; set; }
        public string? AnswerBody { get; set; }
    }
}
