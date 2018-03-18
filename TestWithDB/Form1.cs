using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWithDB
{
    public partial class Form1 : Form
    {
        public int NumberOfAnswer;
        public Form1()
        {
            InitializeComponent();
            pLeft.Hide();
            pCenter.Hide();
            Select_Test.GetListOfTests();
        }

        public void bSaveName_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text == "") { MessageBox.Show("Enter name"); return; }
            pTestsMain.Show();
            User.UserName = tbUserName.Text;
            pLogin.Hide();
            pLeft.Show();

            OleDbConnection dbCon2 = new OleDbConnection();
            dbCon2.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            dbCon2.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter dbAdapter2 = new OleDbDataAdapter(@"SELECT NameOfTest FROM ListOfTests;", dbCon2);
            dbAdapter2.Fill(ds);
            cbListTests.DataSource = ds.Tables[0];
            cbListTests.ValueMember = "NameOfTest";
            cbListTests.DisplayMember = "Название";
            dbCon2.Close();

            lUserName.Text = User.UserName;
        }

 

        private void bTest1_Click(object sender, EventArgs e)
        {
            bFinish.Show();
            User.NameOfTest = cbListTests.SelectedValue.ToString();
            pTestsMain.Hide();
            lNameTest.Text = "Test: " + User.NameOfTest;
                lScore.Text = ""; 
                DB.GetAmountOfQuestions();
                AddToList.SetDefaultAnswers();
                pCenter.Show();
                pTriggers.Show();
                User.NumQuestion = 1;
                User.TotalScore = 0;
                TestFinished = false;
                bBack.Hide();
                bNext.Show();
                ShowQuestions();
                pLeft.Hide();
                tbQ1.BackColor = Color.FromName("White");
                tbQ2.BackColor = Color.FromName("White");
                tbQ3.BackColor = Color.FromName("White");
                tbQ4.BackColor = Color.FromName("White");
            TestFinished = false;
        }

        void ShowQuestions()
        {
            
           
            rA.Checked = false;
            rB.Checked = false;
            rC.Checked = false;
            rD.Checked = false;
            User.Question = (DB.LoadTest1(@"SELECT Questions FROM " + User.NameOfTest + " WHERE numQuestion = " + User.ArrOfQuestions[User.NumQuestion]));

            rtbQuestionField.Text = User.Question;
            User.AnswerQ1 = "";
            User.AnswerQ2 = "";
            User.AnswerQ3 = "";
            User.AnswerQ4 = "";
            DB.GetQAnswers(User.ArrOfQuestions[User.NumQuestion]);
            if (User.AnswerQ1 == "") { tbQ1.Hide(); rA.Hide(); } else { tbQ1.Show(); rA.Show(); }
            if (User.AnswerQ2 == "") { tbQ2.Hide(); rB.Hide(); } else { tbQ2.Show(); rB.Show(); }
            if (User.AnswerQ3 == "") { tbQ3.Hide(); rC.Hide(); } else { tbQ3.Show(); rC.Show(); }
            if (User.AnswerQ4 == "") { tbQ4.Hide(); rD.Hide(); } else { tbQ4.Show(); rD.Show(); }
            DB.GetCorrectAnswer();
            tbQ1.Text = User.AnswerQ1;
            tbQ2.Text = User.AnswerQ2;
            tbQ3.Text = User.AnswerQ3;
            tbQ4.Text = User.AnswerQ4;
            lQuestion.Text = "Questions: " + User.NumQuestion + "/" + User.AmountOfQuestions;
            CheckUserAnswer();
            AddToList.MakeListOfQuestion();
            if (User.NumQuestion == User.AmountOfQuestions)
            {
                bNext.Hide();
            }
            else bNext.Show();

            if (User.NumQuestion == 1)
            {
                bBack.Hide();
            }
            else bBack.Show();
        }

        private void bNext_Click(object sender, EventArgs e)
        {

            CheckUserAnswer();
            User.NumQuestion++;
                if (User.NumQuestion > 1)
            {
                bBack.Show();
            }
            ShowQuestions();
            if (TestFinished == false) { SelectedByUser(); }
            else if (TestFinished == true) { ShowColors(); }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            if (User.NumQuestion < 1)
            {
                User.NumQuestion = 1;
            }

            if (User.NumQuestion < User.AmountOfQuestions)
            {

                bNext.Show();
            }

            if (User.NumQuestion == 1)
            {
                bBack.Hide();
            }

            CheckUserAnswer();
            User.NumQuestion--;
            ShowQuestions();
            if (TestFinished == false) { SelectedByUser(); }
            else if (TestFinished == true) { ShowColors(); }
        }

        public void CheckUserAnswer()
        {
            if (rA.Checked) 
                {
                User.UserAnswer.RemoveAt(User.NumQuestion);
                User.UserAnswer.Insert(User.NumQuestion, tbQ1.Text); 
                }
            if (rB.Checked)
            {
                User.UserAnswer.RemoveAt(User.NumQuestion);
                User.UserAnswer.Insert(User.NumQuestion, tbQ2.Text);
            }
            if (rC.Checked)
            {
                User.UserAnswer.RemoveAt(User.NumQuestion);
                User.UserAnswer.Insert(User.NumQuestion, tbQ3.Text);
            }
            if (rD.Checked)
            {
                User.UserAnswer.RemoveAt(User.NumQuestion);
                User.UserAnswer.Insert(User.NumQuestion, tbQ4.Text);
            }
            ShowColors();
            
        }
        public bool TestFinished = false;
        private void bFinish_Click(object sender, EventArgs e)
        {
            bFinish.Hide();
            pTestsMain.Show();
            CheckUserAnswer();
            for (int i = 1; i <= User.AmountOfQuestions; i++)
            {

                if (User.UserAnswer.ElementAt(i).ToString() == "noAnswer")
                {
                    MessageBox.Show(@"Question number: " + i + " is not answered!");
                    bFinish.Show();
                    return;
                }

            }
            
            User.NumQuestion++;
            pTriggers.Hide();
            TestFinished = true;
            if (TestFinished == true) { bFinish.Hide(); }
            
            for (int i = 1; i<=User.AmountOfQuestions; i ++)
            {
                if (User.UserAnswer.ElementAt(i) == User.CorrectAnswer.ElementAt(i))
                {
                    User.TotalScore++;
                }
            }
            
            User.NumQuestion--;
            ShowQuestions();
            ShowColors();
            lScore.Text = "Score: " + (((User.TotalScore) * 100) / (User.AmountOfQuestions)) + "%." + " Correct answer(s) " + User.TotalScore + "/" + User.AmountOfQuestions;
            CheckUserAnswer();
            DB.SaveToDb();
            pLeft.Show();

            ScoreTable scoreTable = new ScoreTable();
            scoreTable.Show();
            
          
        }

        private void ShowColors()
        {
            if ((User.CorrectAnswer.ElementAt(User.NumQuestion) ==
               (User.UserAnswer.ElementAt(User.NumQuestion))) &&
               ((User.UserAnswer.ElementAt(User.NumQuestion) == tbQ1.Text)))
            { tbQ1.BackColor = Color.FromName("MediumAquamarine"); }
            else tbQ1.BackColor = Color.FromName("White");

            if ((User.CorrectAnswer.ElementAt(User.NumQuestion) ==
               (User.UserAnswer.ElementAt(User.NumQuestion ))) &&
               ((User.UserAnswer.ElementAt(User.NumQuestion ) == tbQ2.Text)))
            { tbQ2.BackColor = Color.FromName("MediumAquamarine"); }
            else tbQ2.BackColor = Color.FromName("White");

            if ((User.CorrectAnswer.ElementAt(User.NumQuestion ) ==
               (User.UserAnswer.ElementAt(User.NumQuestion ))) &&
               ((User.UserAnswer.ElementAt(User.NumQuestion ) == tbQ3.Text)))
            { tbQ3.BackColor = Color.FromName("MediumAquamarine"); }
            else tbQ3.BackColor = Color.FromName("White");

            if ((User.CorrectAnswer.ElementAt(User.NumQuestion ) ==
               (User.UserAnswer.ElementAt(User.NumQuestion ))) &&
               ((User.UserAnswer.ElementAt(User.NumQuestion ) == tbQ4.Text)))
            { tbQ4.BackColor = Color.FromName("MediumAquamarine"); }
            else tbQ4.BackColor = Color.FromName("White");

            if ((User.CorrectAnswer.ElementAt(User.NumQuestion) !=
                (User.UserAnswer.ElementAt(User.NumQuestion))) &&
                (User.UserAnswer.ElementAt(User.NumQuestion) == tbQ1.Text))
            {
                tbQ1.BackColor = Color.FromName("LightCoral");
            }

            if ((User.CorrectAnswer.ElementAt(User.NumQuestion) !=
                (User.UserAnswer.ElementAt(User.NumQuestion))) &&
                (User.UserAnswer.ElementAt(User.NumQuestion) == tbQ2.Text))
            {
                tbQ2.BackColor = Color.FromName("LightCoral");
            }

            if ((User.CorrectAnswer.ElementAt(User.NumQuestion) !=
                (User.UserAnswer.ElementAt(User.NumQuestion))) &&
                (User.UserAnswer.ElementAt(User.NumQuestion) == tbQ3.Text))
            {
                tbQ3.BackColor = Color.FromName("LightCoral");
            }

            if ((User.CorrectAnswer.ElementAt(User.NumQuestion) !=
                (User.UserAnswer.ElementAt(User.NumQuestion))) &&
                (User.UserAnswer.ElementAt(User.NumQuestion) == tbQ4.Text))
            {
                tbQ4.BackColor = Color.FromName("LightCoral");
            }
        }

        private void SelectedByUser()
        {
            if ((User.UserAnswer.ElementAt(User.NumQuestion) != "noAnswer") &&
                (User.UserAnswer.ElementAt(User.NumQuestion) == tbQ1.Text))
            { tbQ1.BackColor = Color.FromName("PowderBlue"); }

            if ((User.UserAnswer.ElementAt(User.NumQuestion) != "noAnswer") &&
                (User.UserAnswer.ElementAt(User.NumQuestion) == tbQ2.Text))
            { tbQ2.BackColor = Color.FromName("PowderBlue"); }

            if ((User.UserAnswer.ElementAt(User.NumQuestion) != "noAnswer") &&
                (User.UserAnswer.ElementAt(User.NumQuestion) == tbQ3.Text))
            { tbQ3.BackColor = Color.FromName("PowderBlue"); }

            if ((User.UserAnswer.ElementAt(User.NumQuestion) != "noAnswer") &&
                (User.UserAnswer.ElementAt(User.NumQuestion) == tbQ4.Text))
            { tbQ4.BackColor = Color.FromName("PowderBlue"); }
        }

        private void bEditName_Click(object sender, EventArgs e)
        {
            pCenter.Hide();
            pLogin.Show();
            pLeft.Hide();
            pTestsMain.Hide();
        }

        private void bSelectTest_Click(object sender, EventArgs e)
        {
            Select_Test Select_Test = new Select_Test();
            Select_Test.Show();
            bReloadList.Show();
            bEditName.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bReloadList_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            //reload combobox;
            OleDbDataAdapter dbAdapter2 = new OleDbDataAdapter(@"SELECT NameOfTest FROM ListOfTests;", con);
            DataSet ds = new DataSet();
            dbAdapter2.Fill(ds);
            cbListTests.DataSource = ds.Tables[0];
            cbListTests.ValueMember = "NameOfTest";
            cbListTests.DisplayMember = "Название";
            con.Close();
            bReloadList.Hide();
            bEditTest.Show();
            bEditName.Show();
        }



        private void tbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bSaveName_Click(this, new EventArgs());
            }
        }

        private void bAdmin_Click(object sender, EventArgs e)
        {
            pAdmin.Show();
            tbAdmin.Show();
            bCheckAdmin.Show();
            tbAdmin.Clear();
        }

        private void bCheckAdmin_Click(object sender, EventArgs e)
        {
            if (tbAdmin.Text == "admin")
            {
                bAdmin.Hide();
                bEditTest.Show();
                tbAdmin.Hide();
                bCheckAdmin.Hide();
                bAdminOff.Show();
                bScoreTable.Show();
            }
            else { MessageBox.Show("Incorrect password");
                tbAdmin.Clear();
            }
        }

        private void bAdminOff_Click(object sender, EventArgs e)
        {
            tbAdmin.Hide();
            pAdmin.Hide();
            bAdmin.Show();
            bScoreTable.Hide();
            bEditTest.Hide();
            bAdminOff.Hide();
            bEditName.Show();
        }

        private void bScoreTable_Click(object sender, EventArgs e)
        {
            AdminTable adminTable = new AdminTable();
            adminTable.Show();
        }
    }
}
