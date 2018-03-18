using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWithDB
{
    public static class DB
    {
        public static string LoadTest1(string inQuery)
        {
            string Query = inQuery;
            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            cn.Open();
            OleDbCommand thisComand = cn.CreateCommand();
            thisComand.CommandText = Query;
            OleDbDataReader thisReader = thisComand.ExecuteReader();
            string FromDb = string.Empty;
            if (thisReader.Read())
            {
                FromDb += thisReader["Questions"];
            }
            cn.Close();
            return FromDb;
        }

        public static void GetAmountOfQuestions() //Get amount of questions from db.
        {
            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            cn.Open();
            OleDbCommand thisComand = cn.CreateCommand();
            //count questions;
            thisComand.CommandText = "SELECT COUNT(Questions) FROM " + User.NameOfTest + ";";
            int AmountOfQuestions = (Int32)thisComand.ExecuteScalar();

            User.AmountOfQuestions = AmountOfQuestions;

            thisComand.CommandText = @"SELECT numQuestion FROM " + User.NameOfTest + ";";
            OleDbDataReader thisReader = thisComand.ExecuteReader();
            string FromDb = string.Empty;
            try
            {
                User.ArrOfQuestions.Clear();
            }
            finally
            {
                User.ArrOfQuestions.Add(0);
                while (thisReader.Read())
                {
                    FromDb = thisReader["numQuestion"].ToString();
                    int numQ = Convert.ToInt32(FromDb);
                    User.ArrOfQuestions.Add(numQ);
                }
            }
            cn.Close(); 
        }

        public static void GetQAnswers(int inNumQuestion) //Get answers for each question from db.
        {
            int NumQuestion = inNumQuestion;
            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            cn.Open();
            OleDbCommand thisComand = cn.CreateCommand();
            thisComand.CommandText = @"SELECT Answers FROM " + User.NameOfTest + " WHERE numQuestion = " + User.ArrOfQuestions[User.NumQuestion];
            OleDbDataReader thisReader = thisComand.ExecuteReader();
            string FromDb = string.Empty;
            if (thisReader.Read())
            {
                FromDb += thisReader["Answers"];
            }
            SeparateQs(FromDb);
            cn.Close();
        }

        private static void SeparateQs(string strinQuestion) //Separate string of questions from db by ';'. 
        {
            string ForSeparate = strinQuestion;
            List<string> answers = new List<string>(ForSeparate.Split(new char[] { ';' }));
            try
            {
                User.AnswerQ1 = answers[0];
                User.AnswerQ2 = answers[1];
                User.AnswerQ3 = answers[2];
                User.AnswerQ4 = answers[3];
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
        }

        public static void GetCorrectAnswer()
            {
            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            cn.Open();
            OleDbCommand thisComand = cn.CreateCommand();
            thisComand.CommandText = @"SELECT CorrectAnswer FROM " + User.NameOfTest + " WHERE numQuestion = " + User.ArrOfQuestions[User.NumQuestion];
            OleDbDataReader thisReader = thisComand.ExecuteReader();
            string FromDb = string.Empty;
            if (thisReader.Read())
            {
                FromDb += thisReader["CorrectAnswer"];
            }
            AddToList.SaveCorrectAnswer(FromDb);
            cn.Close();
        }

        public static void SaveToDb()
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            for (int i = 1; i <= User.AmountOfQuestions; i++)
            {
                cmd.CommandText = @"INSERT into Result (User_Name, Test_Name, Question, Answer, Correct_Answer, DateOfTest) values ('" + User.UserName + "','" + User.NameOfTest + "','" + User.ListOfQuestions.ElementAt(i) + "','" + User.UserAnswer.ElementAt(i) + "','" + User.CorrectAnswer.ElementAt(i) + "', '" + DateTime.Now + "');"; ;
                cmd.Connection = con;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
            con.Close();
        }

        public static void ChangeQuestion(string Question, string answer1, string answer2, string answer3, string answer4, string CorrectAnswer)
        {
            string Q = Question;
            string ans1 = answer1;
            string ans2 = answer2;
            string ans3 = answer3;
            string ans4 = answer4;
            string correct = CorrectAnswer;

            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = @"DELETE FROM " + User.NameOfTest + " WHERE numQuestion = " + User.ArrOfQuestions[User.NumQuestion] + ";";
            cmd.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            cmd.CommandText = @"INSERT INTO " + User.NameOfTest + " (Questions, Answers, CorrectAnswer) VALUES ('" + Q + "', '" + ans1 + ";" + ans2 + ";" + ans3 + ";" + ans4 + ";" + "','" + correct + "');";
            cmd.Connection = con;
            OleDbDataAdapter da2 = new OleDbDataAdapter(cmd);
            DataSet ds2 = new DataSet();
            da.Fill(ds);
            con.Close();
        }

        public static string CheckCorrectQuery(string InQuery)
        {
            
            string Query = InQuery.Replace("'", "''");
            return Query;
        }
        }
    }
