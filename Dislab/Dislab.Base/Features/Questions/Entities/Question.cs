using System.ComponentModel.DataAnnotations;

namespace Dislab.Base.Features.Questions.Entities
{
    public class Question
    {
      
        public long Id { get; set; }
        public string? QuestionTitle { get; set; }
        public string? QuestionBody { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }

    }
}
