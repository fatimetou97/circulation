using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection(@"Data Source = \DESKTOP-QTLF4OF;Initial Catalog = demo;Integrated Security= True");
        DataSet ds = new DataSet();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from books", cnx);
            adapter.Fill(ds, "books");
            dataGridView1.DataSource = ds.Tables["books"];
            cnx.Close();
        }
    }
}
