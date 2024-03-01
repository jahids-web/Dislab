using System.ComponentModel.DataAnnotations;

namespace Dislab.Base.Features.Questions.ViewModels
{
    public class InsertQuestionVM
    {
        //[Required]
        //[StringLength(150, ErrorMessage = "Question Title can't be more than 150 characters.")]
        public string? QuestionTitle { get; set; }

        //[Required]
        //[StringLength(2000, ErrorMessage = "Question Description can't be more than 2000 characters.")]
        public string? QuestionBody { get; set; }

    }
 

}
