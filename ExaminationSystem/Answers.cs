using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Answer
    {
        // 4.We need to define a class for the answers(AnswerId, AnswerText).
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public Answer(int answerID, string answerText)
        {
            AnswerId = answerID;
            AnswerText = answerText;
        }

        public Answer()
        {

        }
        // Overriding ToString
        public override string ToString()
        {
            return $"{AnswerId} _ {AnswerText}";
        }

    }
}
