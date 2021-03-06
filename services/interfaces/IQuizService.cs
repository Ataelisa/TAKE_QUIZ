using Quiz_back.models;
using System.Collections.Generic;
using System;

namespace Quiz_back.services.interfaces
{
    public interface IQuizService
    {
        public Quiz Create(Quiz q);
        public IEnumerable<Quiz> ReadAll();
        public Quiz Read(Guid Id);
        public Quiz Update(Quiz q);
        public Quiz Delete(Quiz q);
    }
}
