using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeesSystem.Model;

namespace EmployeesSystem
{
    public partial class Form1 : Form
    {

        DataTable empTable = new DataTable();
        List<Employee> employeeList = new List<Employee>();
        Employee employee;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            empTable.Columns.Add("EmpID", typeof(int));
            empTable.Columns.Add("First Name", typeof(string));
            empTable.Columns.Add("Last Name", typeof(string));
            empTable.Columns.Add("Address", typeof(string));
            empTable.Columns.Add("BirthDate", typeof(string));
            empTable.Columns.Add("Department", typeof(string));
        }

        private void clearFields()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
                else if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Text = "";

                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            employeeList.Add(new Employee(txtId.Text, txtFirst.Text, txtLast.Text,
                                           txtAddress.Text, txtBirth.Text, department.Text));
            Employee lastEmp = employeeList.Last<Employee>();
            empTable.Rows.Add(lastEmp.empId, lastEmp.firstName, lastEmp.lastName,
                               lastEmp.address, lastEmp.birthDate, lastEmp.department);

            clearFields();
            dataGridView1.DataSource = empTable;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text != "")
            {
                string id = txtSearch.Text;
                string searchExpression = "EmpID = "+id;
                DataRow[] foundRows = empTable.Select(searchExpression);
            if(foundRows.Length > 0)
            {
                    txtId.Text = foundRows[0]["EmpID"].ToString();
                    txtFirst.Text = foundRows[0]["First Name"].ToString();
                    txtLast.Text = foundRows[0]["Last Name"].ToString();
                    txtAddress.Text = foundRows[0]["Address"].ToString();
                    txtBirth.Text = foundRows[0]["BirthDate"].ToString();
                    department.Text = foundRows[0]["Department"].ToString();
                }
            }
        }
        private EmployeesSystem.Model.Employee SelectEmployee(string id)
        {
            foreach (Employee std in employeeList)
            {
                if (std.empId == id)
                {
                    employee = std;
                }
            }
            return employee;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Employee currentEmp = SelectEmployee(id);
            txtId.Text = currentEmp.empId;
            txtFirst.Text = currentEmp.firstName;
            txtLast.Text = currentEmp.lastName;
            txtAddress.Text = currentEmp.address;
            txtBirth.Text = currentEmp.birthDate;
            department.Text = currentEmp.department;
        }

    }
}
