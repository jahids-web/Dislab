﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dislab.Base.Features.Answer.Entities
{
    public class Answer
    {
        public long QuestionId {  get; set; }
        public string? AnswerBody { get; set; }
    }
}
