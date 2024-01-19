using System.ComponentModel.DataAnnotations;

namespace Dislab.Base.Features.Questions.ViewModels
{
    public class InsertQuestionVM
    {
        public long Id { get; set; }

        [Required]
        public string? QuestionTitle { get; set; }

        [Required]
        public string? QuestionBody { get; set; }
    }
}
