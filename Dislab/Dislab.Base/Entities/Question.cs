using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dislab.Base.Entities
{
    public class Question
    {
        [Key] 
        public Guid Id { get; set; }
        public string? QuestionTitle { get; set; }
        public string? QuestionBody { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }

    }
}
