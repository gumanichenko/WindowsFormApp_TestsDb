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
    public partial class AdminTable : Form
    {
        public AdminTable()
        {
            InitializeComponent();
            LoadGrid();
        
        }

        private void AdminTable_Load(object sender, EventArgs e)
        {

        }

        public void LoadGrid()
        {
            OleDbConnection dbCon2 = new OleDbConnection();
            dbCon2.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            dbCon2.Open();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            OleDbDataAdapter da = new OleDbDataAdapter();
            da = new OleDbDataAdapter(@"SELECT * FROM Result;", dbCon2);
            da.Fill(dt);
            dgvAdminGrid.DataSource = dt.DefaultView;
            dbCon2.Close();
        }
    }
}
