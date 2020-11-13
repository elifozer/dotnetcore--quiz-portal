﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizPortal.Models
{
    [Table("Questions")]
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Quiz")]
        public int QuizId { get; set; }

        [Required]
        public string QuestionText { get; set; }

        [Required]
        public string AnswerA { get; set; }

        [Required]
        public string AnswerB { get; set; }

        [Required]
        public string AnswerC { get; set; }

        [Required]
        public string AnswerD { get; set; }

        [Required]
        public int CorrectAnswer { get; set; }
    }
}
