using Dislab.Base.Features.Answer.ViewModel;

namespace Dislab.Base.Features.Answer.DTOs
{
    public class GetAllAnswerDTO
    {
        public IEnumerable<GetAllAnswerVM>? GetAllAnswerVMs { get; set; }
    }
}
