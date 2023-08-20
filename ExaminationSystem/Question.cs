using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public abstract class Question
    {
        //1.Design a Class to represent the Question Object, Question is consisting of:
        //a.Header of the question
        //b.Body of the question
        //c.Mark 
        // Class Members
        public abstract string Header { get; }
        public string Body { get; set; }
        public int Marks { get; set; }

        // 5.Question is associated with an Array of answers and its right answer(Answers[] AnswerList).
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }
        public Answer UserAnswer { get; set; }
        

        // Constructor
        public Question()
        {
            RightAnswer = new Answer();
            UserAnswer = new Answer();
        }
        
        // Methods
        public abstract void AddQuestion();
        public override string ToString()
        {
            return $"{Header} \t Mark({Marks})\n" +
                "-------------------------------------" +
                $" \n{Body}\n";
        }
    }
}
