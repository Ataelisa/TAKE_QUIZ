using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Quiz_back.Dto;
using Quiz_back.models;
using Quiz_back.Models;
using Quiz_back.services;
using Quiz_back.services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuizController
    {
        private readonly IQuizService _quizService;

        public QuizController( IQuizService quizService)
        {
            this._quizService = quizService;
        }

        [HttpPost]
        public Quiz Create(CreateQuizDto quizDto)
        {
            var quiz = new Quiz
            {
                Name = quizDto.Name,
                Theme = (Theme)quizDto.Theme,
                Description = quizDto.Description,
                ImgPath = quizDto.ImagePath,
                QuizPassword = quizDto.QuizPassword

            };

            return _quizService.Create(quiz);
           
        }
    }
}

