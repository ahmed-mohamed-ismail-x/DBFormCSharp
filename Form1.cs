using Lab_10.Connection;
using Lab_10.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System.Data;

namespace Lab_10
{

   
    public partial class FrmCompany : Form
    {
        public FrmCompany()
        {
            InitializeComponent();
        }

        
        Company_SDContext connect = new Company_SDContext();


        private void FrmCompany_Load(object sender, EventArgs e)
        {
           
            SqlConnection c = new SqlConnection("Data Source=.;Initial Catalog=Company_SD;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select SSN, Concat(fname,' ', Lname) Full_Name,Salary,sex Gender    \r\nfrom dbo.Employee", c);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);

          
            //List<Employee> Employees = connect.Employees.ToList();
            DGV.DataSource = dt;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddEmp_Click(object sender, EventArgs e)
        {
            FrmAddEmp frmAddEmp1 = new FrmAddEmp();
            if (frmAddEmp1.ShowDialog() == DialogResult.OK)
            {
                
                //List<Employee> Employees = connect.Employees.ToList();
                //DGV.DataSource = Employees;
               
                
                SqlConnection c = new SqlConnection("Data Source=.;Initial Catalog=Company_SD;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select SSN, Concat(fname,' ', Lname) Full_Name,Salary,sex Gender    \r\nfrom dbo.Employee", c);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                DGV.DataSource=dt;
                DGV.Refresh();
            }
        }

        private void LblHead_Click(object sender, EventArgs e)
        {

        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}