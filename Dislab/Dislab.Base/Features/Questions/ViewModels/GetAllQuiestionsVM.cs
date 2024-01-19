using Dislab.Base.Features.Questions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dislab.Base.Features.Questions.ViewModels
{
    public class GetAllQuiestionsVM
    {
        public IEnumerable<AskQuestion>? Questions { get; set; }
    }
}
