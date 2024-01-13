using Dislab.Base.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dislab.Base.Data
{
    public interface IUnitOfWork
    {
        public IAskQuestionRepository AskQuestionRepository { get; }
    }
}
