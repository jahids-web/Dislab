using Dislab.Base.Features.Answer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dislab.Base.Features.Answer.ViewModel
{
    public class GetAnswerByIdVM
    {
        public long Id { get; set; }
        public long QuestionId { get; set; }

        public long AnswerId { get; set; }
        public string? AnswerBody { get; set; }

   

   
    }
  
}
