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
    public partial class Select_Test : Form
    {
        public Select_Test()
        {
            InitializeComponent();
            LoadList();
            pAddQuestion.Hide();
        }

        public void LoadList()
        {
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
        }

        private void bGo_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Please, click Reload List");
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            pEdit.Show();
            tbNameOfTest.Clear();
            try
            {
                tbNameOfTest.Text = cbListTests.SelectedValue.ToString();
                bRename.Show();
                bSaveNewName.Hide();
            }
            catch { return; }
            GetListOfTests();
        }

        private void bRename_Click(object sender, EventArgs e)
        {
            tbNameOfTest.Enabled = true;
            bSaveNewName.Show();
            bRename.Hide();
        }

        private void bSaveNewName_Click(object sender, EventArgs e)
        {
            GetListOfTests();
            int index = tbNameOfTest.Text.IndexOf(' ');
            if (index != -1) { tbNameOfTest.Text = tbNameOfTest.Text.Remove(index, 1).Insert(index, "_"); }
            tbNameOfTest.Enabled = false;

            for (int i = 0; i < User.AmountOfTests; i++)
            {
                if (tbNameOfTest.Text == User.ListOfTests.ElementAt(i))
                {
                    MessageBox.Show("This name exists. Try to enter another name for test;");
                    bRename.Show();
                    bSaveNewName.Hide();
                    return;
                }
            }

            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            //Create same table;
            cmd.CommandText = @"CREATE TABLE " + DB.CheckCorrectQuery(tbNameOfTest.Text.ToString()) + "(numQuestion INTEGER IDENTITY, Questions VARCHAR(255), Answers VARCHAR(255), CorrectAnswer VARCHAR(255));";
            cmd.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            //Cope old table with questions to new one;
            cmd.CommandText = @"INSERT INTO " + DB.CheckCorrectQuery(tbNameOfTest.Text.ToString()) + "(Questions, Answers, CorrectAnswer) SELECT Questions, Answers, CorrectAnswer FROM " + cbListTests.SelectedValue.ToString() + ";";
            cmd.Connection = con;
            OleDbDataAdapter da2 = new OleDbDataAdapter(cmd);
            DataSet ds2 = new DataSet();
            da.Fill(ds);
            //Delete old name from list of tests;
            cmd.CommandText = @"DELETE FROM ListOfTests WHERE NameOfTest = '" + cbListTests.SelectedValue.ToString() + "';";
            cmd.Connection = con;
            OleDbDataAdapter da5 = new OleDbDataAdapter(cmd);
            DataSet ds5 = new DataSet();
            da.Fill(ds);
            //Add name of table to list of questions;
            cmd.CommandText = @"INSERT INTO ListOfTests (NameOfTest) VALUES ('" + DB.CheckCorrectQuery(tbNameOfTest.Text.ToString()) + "');";
            cmd.Connection = con;
            OleDbDataAdapter da3 = new OleDbDataAdapter(cmd);
            DataSet ds3 = new DataSet();
            da.Fill(ds);
            //Drop old table;
            cmd.CommandText = @"DROP TABLE " + DB.CheckCorrectQuery(cbListTests.SelectedValue.ToString()) + ";";
            cmd.Connection = con;
            OleDbDataAdapter da4 = new OleDbDataAdapter(cmd);
            DataSet ds4 = new DataSet();
            da.Fill(ds);
            LoadList();
            cbListTests.SelectedItem = tbNameOfTest.Text;
            User.NameOfTest = tbNameOfTest.Text;
            con.Close();
            pEdit.Hide();

            cbListTests.SelectedValue = tbNewNameTest.Text;
            MessageBox.Show("Name of test was changed");
            User.NameOfTest = tbNameOfTest.Text;
            tbNameOfTest.Clear();
            
            lInfo.Text = "Test: " + User.NameOfTest;
            lQuestion.Text = "Question " + User.NumQuestion + "/" + User.AmountOfQuestions;
        }

        public static void GetListOfTests()
        {
            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            cn.Open();
            //count tests;
            OleDbCommand thisComand = cn.CreateCommand();
            thisComand.CommandText = "SELECT COUNT(NameOfTest) FROM ListOfTests;";
            int AmountOfTests = (Int32)thisComand.ExecuteScalar();
            User.AmountOfTests = AmountOfTests;

            //get list of tests;
            thisComand.CommandText = "SELECT NameOfTest FROM ListOfTests;";
            User.ListOfTests.Clear();
            using (var reader = thisComand.ExecuteReader())
            {
                while (reader.Read())
                {
                    User.ListOfTests.Add(reader.GetString(0));
                }
            }

            cn.Close();
        }

        private void Select_Test_Load(object sender, EventArgs e)
        {

        }

        private void bCreateNewTest_Click(object sender, EventArgs e)
        {
            pNewTest.Show();
        }

        private void bSaveTestName_Click(object sender, EventArgs e)
        {
            if (tbNewNameTest.Text.Contains(' ')) { MessageBox.Show("Test can't contain char ' '"); return; }
            tbNameOfTest.Enabled = false;

            for (int i = 0; i < User.AmountOfTests; i++)
            {
                if (tbNewNameTest.Text == User.ListOfTests.ElementAt(i))
                {
                    MessageBox.Show("This name exist. Try to enter another name for test;");
                    return;
                }
            }

            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = @"CREATE TABLE " + tbNewNameTest.Text + "(numQuestion INTEGER IDENTITY, Questions VARCHAR(255), Answers VARCHAR(255), CorrectAnswer VARCHAR(255));";
            cmd.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            //add new test to list of tests;
            cmd.CommandText = @"INSERT INTO ListOfTests (NameOfTest) VALUES ('" + DB.CheckCorrectQuery(tbNewNameTest.Text) + "');";
            cmd.Connection = con;
            OleDbDataAdapter da3 = new OleDbDataAdapter(cmd);
            DataSet ds3 = new DataSet();
            da.Fill(ds);

            //reload combobox;
            OleDbDataAdapter dbAdapter2 = new OleDbDataAdapter(@"SELECT NameOfTest FROM ListOfTests;", con);
            dbAdapter2.Fill(ds);
            cbListTests.DataSource = ds.Tables[0];
            cbListTests.ValueMember = "NameOfTest";
            cbListTests.DisplayMember = "Название";
            con.Close();

            pNewTest.Hide();
            cbListTests.SelectedValue = tbNewNameTest.Text;
            User.ListOfTests.Add(tbNameOfTest.Text);

            GetListOfTests();
            bDeleteQuestion.Hide();
            bAddQuestion.Hide();
            bEditQuestion.Hide();
            bAddQue.Show();
            bEditThisQuestion.Hide();
            bSaveEdit.Hide();
            User.NameOfTest = tbNewNameTest.Text;
            tbNewNameTest.Clear();
            User.NumQuestion = 0;
            User.AmountOfQuestions = 0;
            rtbAddQuestion.Clear();
            tbAnsw1.Clear();
            tbAnsw2.Clear();
            tbAnsw3.Clear();
            tbAnsw4.Clear();
            
            lInfo.Text = "Test: " + User.NameOfTest;
            lQuestion.Text = "Question " + User.NumQuestion + "/" + User.AmountOfQuestions;
        }

        private void bDeleteTest_Click(object sender, EventArgs e)
        {
            rtbAddQuestion.Clear();
            tbAnsw1.Clear();
            tbAnsw2.Clear();
            tbAnsw3.Clear();
            tbAnsw4.Clear();
            //drop test from db;
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = @"DROP TABLE " + cbListTests.SelectedValue + ";";
            cmd.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            //remove name of test from list in db;
            cmd.CommandText = @" DELETE FROM ListOfTests WHERE NameOfTest = '" + DB.CheckCorrectQuery(cbListTests.SelectedValue.ToString()) + "';";
            cmd.Connection = con;
            OleDbDataAdapter da5 = new OleDbDataAdapter(cmd);
            DataSet ds5 = new DataSet();
            da.Fill(ds);

            User.ListOfTests.Remove(cbListTests.SelectedValue.ToString());

            //reload combobox;
            OleDbDataAdapter dbAdapter2 = new OleDbDataAdapter(@"SELECT NameOfTest FROM ListOfTests;", con);
            dbAdapter2.Fill(ds);
            cbListTests.DataSource = ds.Tables[0];
            cbListTests.ValueMember = "NameOfTest";
            cbListTests.DisplayMember = "Название";
            con.Close();
            MessageBox.Show("Test was deleted");
            GetListOfTests();
        }

        public void bEditQuestion_Click(object sender, EventArgs e)
        {
            pAddQuestion.Show();
            User.NameOfTest = cbListTests.SelectedValue.ToString();
            lInfo.Text = "Test: " + User.NameOfTest;
            lQuestion.Text = "Question " + User.NumQuestion + "/" + User.AmountOfQuestions;
            if (lQuestion.Text == "Question: 0/0") { bEditThisQuestion.Hide(); }
            User.NumQuestion = 1;
            pAddQuestion.Show();
            bEditThisQuestion.Show();
            bDeleteQuestion.Show();
            bSaveEdit.Hide();
            bAddQue.Show();
            bAddQuestion.Hide();
            rtbAddQuestion.Enabled = false;
            tbAnsw1.Enabled = false;
            tbAnsw2.Enabled = false;
            tbAnsw3.Enabled = false;
            tbAnsw4.Enabled = false;
         
            rbAA.Enabled = false;
            rbBB.Enabled = false;
            rbCC.Enabled = false;
            rbDD.Enabled = false;
            rbAA.Show();
            rbBB.Show();
            rbCC.Show();
            rbDD.Show();
            try
            {
                ShowQuestions();
            }
            catch (Exception) { bEditQuestion.Hide(); bAddQuestion.Hide(); bAddQuestion.Show(); }
        }

        public void ShowQuestions()
        {
            User.NameOfTest = cbListTests.SelectedValue.ToString();
            if (User.NumQuestion < User.AmountOfQuestions) { bBack.Show(); bNext.Show(); }
            if (User.NumQuestion > 1 )      { bBack.Show(); bNext.Show();  }
            if (User.NumQuestion == 1) { bBack.Hide(); bNext.Show(); }
            if (User.NumQuestion == 0)      { User.NumQuestion = 1; bBack.Hide(); bNext.Hide(); return; }
            User.AmountOfQuestions = 0;
            DB.GetAmountOfQuestions();
            if (User.AmountOfQuestions == 1) { bDeleteQuestion.Hide(); } else bDeleteQuestion.Show();
            if (User.NumQuestion == User.AmountOfQuestions) { bNext.Hide(); bBack.Show(); }
            DB.GetQAnswers(User.NumQuestion);
            tbAnsw1.Text = User.AnswerQ1;
            tbAnsw2.Text = User.AnswerQ2;
            tbAnsw3.Text = User.AnswerQ3;
            tbAnsw4.Text = User.AnswerQ4;
            User.Question = (DB.LoadTest1(@"SELECT Questions FROM " + User.NameOfTest + " WHERE numQuestion = " + User.ArrOfQuestions[User.NumQuestion]));
            rtbAddQuestion.Text = User.Question;
            AddToList.SetDefaultAnswers();
            DB.GetCorrectAnswer();
            if ((User.CorrectAnswer.ElementAt(User.NumQuestion)) == tbAnsw1.Text) { rbAA.Checked = true; };
            if ((User.CorrectAnswer.ElementAt(User.NumQuestion)) == tbAnsw2.Text) { rbBB.Checked = true; };
            if ((User.CorrectAnswer.ElementAt(User.NumQuestion)) == tbAnsw3.Text) { rbCC.Checked = true; };
            if ((User.CorrectAnswer.ElementAt(User.NumQuestion)) == tbAnsw4.Text) { rbDD.Checked = true; };
            lInfo.Text = "Test: " + User.NameOfTest;     
            lQuestion.Text = "Question " + User.NumQuestion + "/" + User.AmountOfQuestions;
            if (lQuestion.Text == "Question 1/1") { bBack.Hide(); bNext.Hide(); }
            if (lQuestion.Text == "Question 0/0") { MessageBox.Show("Test without questions"); }
        }

        private void bEditThisQuestion_Click(object sender, EventArgs e)
        {
            bDeleteQuestion.Hide();
            bAddQue.Hide();
            bSaveEdit.Show();
            rtbAddQuestion.Enabled = true;
            tbAnsw1.Enabled = true;
            tbAnsw2.Enabled = true;
            tbAnsw3.Enabled = true;
            tbAnsw4.Enabled = true;
            rbAA.Enabled = true;
            rbBB.Enabled = true;
            rbCC.Enabled = true;
            rbDD.Enabled = true;
            bEditThisQuestion.Hide();
        }

        private void bSaveEdit_Click(object sender, EventArgs e)
        {
            string Question = rtbAddQuestion.Text;
            string Answer1 = tbAnsw1.Text;
            string Answer2 = tbAnsw2.Text;
            string Answer3 = tbAnsw3.Text;
            string Answer4 = tbAnsw4.Text;
            string CorrctAns = "";
            if (rbAA.Checked == true) { CorrctAns = tbAnsw1.Text; }
            if (rbBB.Checked == true) { CorrctAns = tbAnsw2.Text; }
            if (rbCC.Checked == true) { CorrctAns = tbAnsw3.Text; }
            if (rbDD.Checked == true) { CorrctAns = tbAnsw4.Text; }
            DB.ChangeQuestion(Question, Answer1, Answer2, Answer3, Answer4, CorrctAns);
            bSaveEdit.Hide();
            bEditThisQuestion.Show();
            rtbAddQuestion.Enabled = false;
            tbAnsw1.Enabled = false;
            tbAnsw2.Enabled = false;
            tbAnsw3.Enabled = false;
            tbAnsw4.Enabled = false;
            rbAA.Enabled = false;
            rbBB.Enabled = false;
            rbCC.Enabled = false;
            rbDD.Enabled = false;
            bAddQue.Show();
            bDeleteQuestion.Show();
        }

        private void bAddQuestion_Click(object sender, EventArgs e)
        {
            bBack.Hide();
            bNext.Hide();
            bEditQuestion.Show();
            

            lInfo.Text = "Test: " + User.NameOfTest;
            lQuestion.Text = "Question " + User.NumQuestion + "/" + User.AmountOfQuestions;

            if ((rbAA.Checked == false) && (rbBB.Checked == false) && (rbCC.Checked == false) && (rbDD.Checked == false))
            { MessageBox.Show("Select correct question"); return; }

            if ((rtbAddQuestion.Text == ("")) && (tbAnsw1.Text == ("")))
            { MessageBox.Show("Fill question and at least one answer"); return; }

            string answ = "";
            if (rbAA.Checked && tbAnsw1.Text == "") { MessageBox.Show("Answer can't be empty"); return; }
            if (rbBB.Checked && tbAnsw2.Text == "") { MessageBox.Show("Answer can't be empty"); return; }
            if (rbCC.Checked && tbAnsw3.Text == "") { MessageBox.Show("Answer can't be empty"); return; }
            if (rbDD.Checked && tbAnsw4.Text == "") { MessageBox.Show("Answer can't be empty"); return; }

            if (rbAA.Checked) { answ = tbAnsw1.Text; }
            if (rbBB.Checked) { answ = tbAnsw2.Text; }
            if (rbCC.Checked) { answ = tbAnsw3.Text; }
            if (rbDD.Checked) { answ = tbAnsw4.Text; }



            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = @"INSERT INTO " + DB.CheckCorrectQuery(cbListTests.SelectedValue.ToString()) + " (Questions, Answers, CorrectAnswer) " +
            "VALUES ('" + DB.CheckCorrectQuery(rtbAddQuestion.Text.ToString()) + "'," +
                "'" + DB.CheckCorrectQuery(tbAnsw1.Text) + ";"
                + DB.CheckCorrectQuery(tbAnsw2.Text) + ";"
                + DB.CheckCorrectQuery(tbAnsw3.Text) + ";"
                + DB.CheckCorrectQuery(tbAnsw4.Text) + ";', "
                + "'" + DB.CheckCorrectQuery(answ) + "');";


            cmd.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Question was added to test " + cbListTests.SelectedValue);

            rbAA.Checked = false;
            rbBB.Checked = false;
            rbCC.Checked = false;
            rbDD.Checked = false;
            tbAnsw1.Clear();
            tbAnsw2.Clear();
            tbAnsw3.Clear();
            tbAnsw4.Clear();
            rtbAddQuestion.Clear();
            lInfo.Text = "Test: " + User.NameOfTest;
            lQuestion.Text = "Question " + User.NumQuestion + "/" + User.AmountOfQuestions;
        }

        private void bDeleteQuestion_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = @"DELETE FROM " + User.NameOfTest + " WHERE numQuestion = " + User.ArrOfQuestions[User.NumQuestion] + ";";
            cmd.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Question was deleted from " + cbListTests.SelectedValue);
            User.NumQuestion = 1;
            rtbAddQuestion.Clear();
            tbAnsw1.Clear();
            tbAnsw2.Clear();
            tbAnsw3.Clear();
            tbAnsw4.Clear();
            ShowQuestions();
            lInfo.Text = "Test: " + User.NameOfTest;
            lQuestion.Text = "Question " + User.NumQuestion + "/" + User.AmountOfQuestions;
        }

        private void bDelTest_Click(object sender, EventArgs e)
        {

        }

        private void bNext_Click(object sender, EventArgs e)
        {
            User.NumQuestion++;
            ShowQuestions();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            User.NumQuestion--;
            ShowQuestions();
        }

        private void bAddQue_Click(object sender, EventArgs e)
        {
            
            pAddQuestion.Show();
            bBack.Hide();
            bNext.Hide();
            bEditThisQuestion.Hide();
            rtbAddQuestion.Clear();
            tbAnsw1.Clear();
            tbAnsw2.Clear();
            tbAnsw3.Clear();
            tbAnsw4.Clear();
            rbAA.Checked = false;
            rbBB.Checked = false;
            rbCC.Checked = false;
            rbDD.Checked = false;
            bDeleteQuestion.Hide();
            bAddQue.Hide();
            bAddQuestion.Show();
            rtbAddQuestion.Enabled = true;
            tbAnsw1.Enabled = true;
            tbAnsw2.Enabled = true;
            tbAnsw3.Enabled = true;
            tbAnsw4.Enabled = true;
            rbAA.Enabled = true;
            rbBB.Enabled = true;
            rbCC.Enabled = true;
            rbDD.Enabled = true;
            lInfo.Text = "Test: " + User.NameOfTest;
            lQuestion.Text = "Question " + User.NumQuestion + "/" + User.AmountOfQuestions;
        }


    }
}