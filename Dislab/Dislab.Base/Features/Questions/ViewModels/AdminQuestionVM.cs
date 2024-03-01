using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dislab.Base.Features.Questions.ViewModels
{
    public class AdminQuestionVM
    {
        public long Id { get; set; }

        //[Required]
        //[StringLength(150, ErrorMessage = "Question Title can't be more than 150 characters.")]
        public string? QuestionTitle { get; set; }

        //[Required]
        //[StringLength(2000, ErrorMessage = "Question Description can't be more than 2000 characters.")]
        public string? QuestionBody { get; set; }
    }
}
