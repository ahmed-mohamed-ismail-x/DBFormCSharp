using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_10.Connection;
using Lab_10.Models;
using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Lab_10
{
    public partial class FrmAddEmp : Form
    {
        public FrmAddEmp()
        {
            InitializeComponent();
        }
        Company_SDContext connection2 = new Company_SDContext();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LblSsn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtFname.Text = "";
            TxtLname.Text = "";
            TxtSsn.Text = "";
            TxtSalary.Text = "";
            TxtGender.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Employee e1 = new Employee();
            //e1.Fname = TxtFname.Text;
            //e1.Lname = TxtLname.Text;
            //e1.Ssn = int.Parse(TxtSsn.Text);
            //e1.Salary = int.Parse(TxtSalary.Text);
            //connection2.Employees.Add(e1);
            //connection2.SaveChanges();
            //this.Close();
            
            int salary = int.Parse(TxtSalary.Text);
            int ssn = int.Parse(TxtSsn.Text);
            string fname = TxtFname.Text;
            string lname = TxtLname.Text;
            string gender = TxtGender.Text;
           
            SqlConnection c = new SqlConnection("Data Source=.;Initial Catalog=Company_SD;Integrated Security=True");
            SqlCommand cmd = new SqlCommand($"insert into [Employee] ([SSN], [Fname], [Lname], [Salary], [Sex])values({ssn},'{fname}','{lname}',{salary},'{gender}')", c);
            c.Open();
            cmd.ExecuteNonQuery();
            c.Close();


        }

        private void TxtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSsn_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblSalary_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
