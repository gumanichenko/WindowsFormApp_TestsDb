using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWithDB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public static class User
    {
        public static string UserName;
        public static int NumQuestion = 1;
        public static string Question;
        public static string AnswerQ1;
        public static string AnswerQ2;
        public static string AnswerQ3;
        public static string AnswerQ4;
        public static int AmountOfQuestions;
        public static List<string> UserAnswer = new List<string>();
        public static List<string> CorrectAnswer = new List<string>();
        public static int TotalScore = 0;
        public static string NameOfTest;
        public static int AmountOfTests;
        public static List<string> ListOfTests = new List<string>();
        public static List<int> ArrOfQuestions = new List<int>();
        public static bool AdminCheck = false;
        public static List<string> ListOfQuestions = new List<string>();
    }

    public static class AddToList
    {
        public static void SetDefaultAnswers()
        {
            try
            {
                User.UserAnswer.Clear();
                User.CorrectAnswer.Clear();
                User.ListOfQuestions.Clear();
            }
            finally
            {
                for (int i = 0; i <= User.AmountOfQuestions; i++)
                {
                    User.UserAnswer.Add("noAnswer");
                    User.CorrectAnswer.Add("correct");
                    User.ListOfQuestions.Add("question");
                }
            }
        }

        public static void SaveCorrectAnswer(string inAnswer)
        {
            string Answer = inAnswer;
                User.CorrectAnswer.RemoveAt(User.NumQuestion);
                User.CorrectAnswer.Insert(User.NumQuestion, Answer);
        }

        public static void MakeListOfQuestion()
        {
            User.ListOfQuestions.RemoveAt(User.NumQuestion);
            string CheckForDb = User.Question;
            User.Question = CheckForDb.Replace("'", "''");
            User.ListOfQuestions.Insert(User.NumQuestion, User.Question);
        }
    }
}
