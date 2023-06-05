using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace Employee_details
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(cs);
            con.Open();

            string query = "insert into employee values(@ID, @ename, @age, @designation, @salery)";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", txtid.Text); 
            cmd.Parameters.AddWithValue("@ename", txtname.Text);
            cmd.Parameters.AddWithValue("@age", agefield.Value);
            cmd.Parameters.AddWithValue("@designation", combodesig.Text);
            cmd.Parameters.AddWithValue("@salery", txtsalery.Text);

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Record Saved successfully","SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
