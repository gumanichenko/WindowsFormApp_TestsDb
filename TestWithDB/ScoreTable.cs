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
    public partial class ScoreTable : Form
    {
        public ScoreTable()
        {
            InitializeComponent();

        }

        private void ScoreTable_Load(object sender, EventArgs e)
        {
            dgvScoreTable.Rows.Clear();
            lInfo.Text = "Name: " + User.UserName + " Total: " + User.AmountOfQuestions + " Correct: " + User.TotalScore + " Uncorrect: " + (User.AmountOfQuestions - User.TotalScore);
            ShowAll();
        }

        private void bShowCorrect_Click(object sender, EventArgs e)
        { 
            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            cn.Open();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            OleDbDataAdapter da = new OleDbDataAdapter();
            da = new OleDbDataAdapter("SELECT Question, Answer, Correct_Answer, DateOfTest FROM Result WHERE Correct_Answer LIKE Answer AND User_Name = '" + User.UserName + "' AND Test_Name = '" + User.NameOfTest + "';", cn);
            da.Fill(dt);
            dgvScoreTable.DataSource = dt.DefaultView;
            cn.Close();
        }

        private void bAll_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void ShowAll()
        {
            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            cn.Open();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            OleDbDataAdapter da = new OleDbDataAdapter();
            da = new OleDbDataAdapter("SELECT Question, Answer, Correct_Answer, DateOfTest FROM Result WHERE User_Name = '" + User.UserName + "' AND Test_Name = '" + User.NameOfTest + "';", cn);
            da.Fill(dt);
            dgvScoreTable.DataSource = dt.DefaultView;
            cn.Close();
        }

        private void bUncorrect_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            cn.Open();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            OleDbDataAdapter da = new OleDbDataAdapter();
            da = new OleDbDataAdapter("SELECT Question, Answer, Correct_Answer, DateOfTest FROM Result WHERE Correct_Answer NOT LIKE Answer AND User_Name = '" + User.UserName + "' AND Test_Name = '" + User.NameOfTest + "';", cn);
            da.Fill(dt);
            dgvScoreTable.DataSource = dt.DefaultView;
            cn.Close();
        }
    }
}
    
