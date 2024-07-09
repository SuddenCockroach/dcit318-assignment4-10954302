using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            textBox1.Clear();
            textBox2.Clear();
        }

        private bool isValid()
        {
            if (textBox1.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("enter valid UserName", "error");
                return false;
            }else if (textBox2.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("enter valid Password", "error");
                return false;
            }
            return true;
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
              using(SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\caleb\Desktop\Caleb\Login\Login\Database1.mdf;Integrated Security=True"))
                {
                    string query = "SELECT * FROM LOGIN WHERE UserName = '" + textBox1.Text.Trim() + "'AND Password = '" + textBox2.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dta = new DataTable();
                    sda.Fill(dta);
                    if (dta.Rows.Count == 1)
                    { 
                        Dashboard dashboard = new Dashboard();
                        this.Hide();
                        dashboard.Show();
                    }
                }
            }
        }
    }
}
