using System.ComponentModel.DataAnnotations;

namespace Dislab.Base.Features.Questions.ViewModels
{
    public class UpdateQuestionVM
    {
        [Required]
        public long Id { get; set; }
        //public long QuestionId { get; set; }

        //[Required]
        //[StringLength(150, ErrorMessage = "Question Title can't be more than 150 characters.")]
        public string? QuestionTitle { get; set; }

        //[Required]
        //[StringLength(2000, ErrorMessage = "Question Description can't be more than 2000 characters.")]
        public string? QuestionBody { get; set; }
    }
}
