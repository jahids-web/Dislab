namespace Dislab.Base.Features.Answer.DTOS
{
    public class InsertAnswerDTO
    {
        public long Id { get; set; }
        public long QuestionId { get; set; }
        public string? AnswerBody { get; set; }
    }
}
