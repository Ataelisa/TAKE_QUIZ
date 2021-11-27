using Quiz_back.models;
using Quiz_back.repositories.interfaces;
using Quiz_back.services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz_back.services
{
    public class QuizService : IQuizService
    {
        private readonly IQuizRepository _quizRepository;

        public QuizService(IQuizRepository quizRepository)
        {
            this._quizRepository = quizRepository;
        }
        public Quiz Create(Quiz q) => _quizRepository.Create(q);
        public IEnumerable<Quiz> ReadAll() => _quizRepository.ReadAll();
        public Quiz Read(Guid Id) => _quizRepository.Read(Id);
        public Quiz Delete(Quiz q) => _quizRepository.Delete(q);
        public Quiz Update(Quiz q) => _quizRepository.Update(q);
    }
}
