using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dislab.Base.Features.Answer.ViewModel
{
    public class AdminAnswerVM
    {
        public long Id { get; set; }

        //[Required]
        //[StringLength(3000, ErrorMessage = "Answer Body can't be more than 3000 characters.")]
        public string? AnswerBody { get; set; }
    }
}
