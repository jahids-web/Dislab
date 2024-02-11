using Dislab.Base.Features.Questions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dislab.Base.Features.Questions.DTOs
{
    public class GetAllQuiestionsDTO
    {
        public IEnumerable<Question>? Questions { get; set; }
    }
}
