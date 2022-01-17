using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Baker_10_4
{
    public partial class Form1 : Form
    {
        //List to hold Employee data: 
        List<Employee> employeeList = new List<Employee>();        

        public Form1()
        {
            InitializeComponent();
        }

        private void GetEmployeeData(Employee employee) 
        {
            //Declare variable for idNumber
            int idNum;

            //Get the Employee name:
            employee.Name = txtBoxEmpName.Text;
            //Get the Employee idNumber:
            try
            {
                if (int.TryParse(txtBoxEmpId.Text, out idNum))
                {
                    employee.id = idNum;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //Get the Employee department:
            employee.department = txtBoxEmpDep.Text;
            //Get the Employee position:
            employee.position = txtBoxEmpPos.Text;
        }


        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Create Employee object:

            Employee newEmployee = new Employee();



            //Get the employee data:
            GetEmployeeData(newEmployee);

            // Add Employee object to the list
            employeeList.Add(newEmployee);


            //Display employees to list box. 
            lstBoxDisp.Items.Add(newEmployee.Name + "" + newEmployee.id + "" + newEmployee.department + "" + newEmployee.position);

            Employee secondConstruct = new Employee("");

            Employee thirdConstruct = new Employee(0);

            //Get the employee data:
            GetEmployeeData(thirdConstruct);

            // Add Employee object to the list
            employeeList.Add(thirdConstruct);

            //Display employees to list box. 
            lstBoxDisp.Items.Add(thirdConstruct.nameToString + "" + thirdConstruct.idToZero + "" + thirdConstruct.depToString + "" + thirdConstruct.posToString);

            
            ////I have no Idea what im doing..... 



            



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Code to exit the program.
            this.Close();
        }
    }
}
