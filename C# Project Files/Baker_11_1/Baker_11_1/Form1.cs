using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baker_11_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //TO CLICK & DRAG GUI..
            this.FormBorderStyle = FormBorderStyle.None;

            txtBoxBonus.Hide();
            txtBoxSalary.Hide();
            bunifuLabel5.Hide();
            bunifuLabel6.Hide();
            bunifuLabel4.Hide();
            txtBoxPay.Hide();
        }

        //Christopher Baker
        //Chap 11 Question 1 
        //November-30-2021

        //Create newEmployee Object
        ProductionWorker newEmployee = new ProductionWorker();
        ShiftSupervisor newSupervisor = new ShiftSupervisor();

        //ADD EMPLOYEE BUTTON: INSTANTIATES AND DISPLAYS EMPLOYEE INFO
        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            //Create string variable to hold result from check boxes
            string shift = "";
            double bonusCalc = 0;

            //Try Catch Statement for error checking
            try
            {

                // Get values for class variables
                newEmployee.employeeName = txtBoxName.Text;
                newEmployee.employeeNum = txtBoxNum.Text;
                //get value for pay rate
                newEmployee.employeeHRate = txtBoxPay.Text;

                //if statement for check boxes
                if (chkBoxShift1.Checked)
                {
                    //if box is checked pass value of true
                    newEmployee.employeeShift1 = true;
                    //store value in shift variable to display what shift the employee has
                    shift = "Day Shift";

                    //Display information that has been passed through the classes
                    MessageBox.Show("Employee Name: " + newEmployee.employeeName + "\n" +
                        "Employee Number: " + newEmployee.employeeNum + "\n" +
                        "Employee Shift: " + shift + "\n" +
                        "Employee Pay Rate: $" + newEmployee.employeeHRate + "/hr");
                }
                //else if for checked boxes
                else if (chkBoxShift2.Checked)
                {

                    //if box is checked pass value of true
                    newEmployee.employeeShift2 = true;
                    //store value in shift variable to display what shift the employee has
                    shift = "Night Shift";

                    //Display information that has been passed through the classes
                    MessageBox.Show("Employee Name: " + newEmployee.employeeName + "\n" +
                        "Employee Number: " + newEmployee.employeeNum + "\n" +
                        "Employee Shift: " + shift + "\n" +
                        "Employee Pay Rate: $" + newEmployee.employeeHRate + "/hr");
                }
                else if (chkBoxSup.Checked) 
                {
                    //Get values for Supervisor
                    newSupervisor.superSalary = txtBoxSalary.Text;
                    newSupervisor.superBonus = double.Parse(txtBoxBonus.Text.ToString());
                    newSupervisor.superShift = true;


                    //store value in shift variable to display what shift the employee has
                    shift = "Shift Supervisor";
                    bonusCalc =  newSupervisor.superBonus;

                    if (bonusCalc >= 2000.00)
                    {
                        //Display information that has been passed through the classes
                        MessageBox.Show("Supervisor Name: " + newEmployee.employeeName + "\n" +
                            "Supervisor Number: " + newEmployee.employeeNum + "\n" +
                            "Title: " + shift + "\n" +
                            "Supervisor Salary: $" + newSupervisor.superSalary + "\n" +
                            "Bonus:" + "Great Job! You got the bonus this year!");

                    }
                    else 
                    {
                        //Display information that has been passed through the classes
                        MessageBox.Show("Supervisor Name: " + newEmployee.employeeName + "\n" +
                            "Supervisor Number: " + newEmployee.employeeNum + "\n" +
                            "Title: " + shift + "\n" +
                            "Supervisor Salary: $" + newSupervisor.superSalary + "\n" +
                            "Bonus:" + "Shucks! No bonus this year...");

                    }


                }


            }
            //catch to display errors
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        //method to exit.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //method to Xit.
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //This snippet was taken off of stack flow
        //for design purposes clickable and draggable:CVB 11/30/2021
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void chkBoxSup_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkBoxSup.Checked)
            {
                chkBoxShift1.Checked = false;
                chkBoxShift2.Checked = false;
                
                txtBoxBonus.Show();
                txtBoxSalary.Show();
                bunifuLabel5.Show();
                bunifuLabel6.Show();
            }
            else 
            {
                txtBoxBonus.Hide();
                txtBoxSalary.Hide();
                bunifuLabel5.Hide();
                bunifuLabel6.Hide();
            }
        }

        private void chkBoxShift1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkBoxShift1.Checked)
            {
                chkBoxShift2.Checked = false;
                chkBoxSup.Checked = false;

                txtBoxPay.Show();
                bunifuLabel4.Show();
            }
            else
            {
                bunifuLabel4.Hide();
                txtBoxPay.Hide();
            }

        }

        private void chkBoxShift2_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkBoxShift2.Checked)
            {
                chkBoxShift1.Checked = false;
                chkBoxSup.Checked = false;
                txtBoxPay.Show();
                bunifuLabel4.Show();
            }
            else
            {
                bunifuLabel4.Hide();
                txtBoxPay.Hide();
            }

        }
        //END OF DESIGN SNIPPET- CVB 11/30/2021
    }
}
