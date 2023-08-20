using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    abstract class Exam
    {
        //6.Design a Base class Exam describe the common attributes concerning the exam:
        //a.Time of exam
        //b.Number of Questions
        //c.Show Exam Functionality that it’s implementations will be different for each exam based to its type.
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] ListOfQuestions { get; set; }

        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
        }
        public abstract void ShowExam();
        public abstract void CreateListOfQuestions();

    }
}
