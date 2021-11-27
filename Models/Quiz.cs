using Quiz_back.Dto;
using Quiz_back.Models;
using System;
using System.Collections.Generic;

namespace Quiz_back.models
{
    public class Quiz: EntityWithId
    {
        public String Name { get; set; }
        public Theme Theme { get; set; }
        public string Description { get; set; }

        // todo: penser aux tags
        public string  ImgPath { get; set; }
        public string QuizPassword { get; set; }

        public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}
