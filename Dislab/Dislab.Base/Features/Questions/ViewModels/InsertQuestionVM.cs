using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dislab.Base.Features.Questions.ViewModels
{
    public class InsertQuestionVM
    {
        public Guid Id { get; set; }
        public string? QuestionTitle { get; set; }
        public string? QuestionBody { get; set; }
    }
}
