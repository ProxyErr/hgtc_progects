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
using System.Collections;

namespace Baker_exam3
{
    public partial class btnMinamize : Form
    {

        //Christopher Baker
        //Exam 3
        //December-3-2021
        
        public btnMinamize()
        {
            InitializeComponent();


            //hide group boxes with radio info. 
            grpBoxAdv.Hide();
            grpBoxSup.Hide();

            //CVB = Christopher Vere Baker
            this.FormBorderStyle = FormBorderStyle.None;           
        }



        //Create newEmployee Objects/ArrayLists.
        baseEmployee newEmployee = new baseEmployee();
        advancedEmployee newAdvEmployee = new advancedEmployee();
        superEmployee newSupEmployee = new superEmployee();

        //newEmployeeList to send to the file. 
        fileOutput newEmployeeList = new fileOutput();


        


        //Declare Variable
        string permission = "";

        //
        private void btnMinamize_Load(object sender, EventArgs e)
        {

        }


        //MAIN:: Add Button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //first array list to hold inputs as one object.
            var employeeList = new ArrayList();
            

            //Try Catch for errors. 
            try 
            {
                //Get Values for baseEmployee Class. 
                newEmployee.employeeName = txtBoxName.Text;
                newEmployee.employeeEmail = txtBoxEmail.Text;
                newEmployee.employeeAddy = rtxtBoxAddy.Text;

                //baseEmployee Function
                if (radBtnEmp.Checked)
                {


                    //Confirming Adding Employee action. 
                    MessageBox.Show("Employee Has Been Added!");

                    //Display All New Employee Data
                   
                    lstBoxDisplay.Items.Add("Name: " + newEmployee.employeeName);
                    lstBoxDisplay.Items.Add("Email: " + newEmployee.employeeEmail);
                    lstBoxDisplay.Items.Add("Address: " + newEmployee.employeeAddy);
                    lstBoxDisplay.Items.Add("Hourly Rate: " + "");
                    lstBoxDisplay.Items.Add("Hours Worked: " + "");
                    lstBoxDisplay.Items.Add("Permissions: " + "");
                    lstBoxDisplay.Items.Add("Office: " + "");
                    lstBoxDisplay.Items.Add(".....................................");
                    lstBoxDisplay.Items.Add("");
                    //Clear Text Boxes
                    txtBoxName.Clear();
                    txtBoxEmail.Clear();
                    rtxtBoxAddy.Clear();

                }

                //advancedEmployee Function
                else if (radBtnAdvEmp.Checked)
                {

                    //Get Advanced Employee Data
                    newAdvEmployee.employeeRate = double.Parse(txtHRate.Text.ToString());
                    newAdvEmployee.employeeHrs = double.Parse(txtBoxHoursWorked.Text.ToString());

                    //if statment to validate employee rate range. 
                    if (newAdvEmployee.employeeRate >= 10 && newAdvEmployee.employeeRate <= 42.50)
                    {
                        //if statment to validate hours worked range. 
                        if (newAdvEmployee.employeeHrs >= 0 && newAdvEmployee.employeeHrs <= 80)
                        {
                            
                            //Confirming Adding Employee action. 
                            MessageBox.Show("Information Has Been Added!");
                            //Display All New Employee Data
                            
                            lstBoxDisplay.Items.Add("Name: " + newEmployee.employeeName);
                            lstBoxDisplay.Items.Add("Email: " + newEmployee.employeeEmail);
                            lstBoxDisplay.Items.Add("Address: " + newEmployee.employeeAddy);
                            lstBoxDisplay.Items.Add("Hourly Rate: $" + newAdvEmployee.employeeRate);
                            lstBoxDisplay.Items.Add("Hours Worked: " + newAdvEmployee.employeeHrs);
                            lstBoxDisplay.Items.Add("Permissions: " + "");
                            lstBoxDisplay.Items.Add("Office: " + "");
                            lstBoxDisplay.Items.Add(".....................................");
                            lstBoxDisplay.Items.Add("");
                            //Clear Text Boxes
                            txtBoxName.Clear();
                            txtBoxEmail.Clear();
                            rtxtBoxAddy.Clear();
                            txtHRate.Clear();
                            txtBoxHoursWorked.Clear();
                        }
                        else
                        {
                            //if user inputs anything outside the range.
                            MessageBox.Show("Cannot Exceed 80hrs");
                        }
                    }
                    else
                    {
                        //if user inputs anything outside rate range. 
                        MessageBox.Show("Rate Min = $10.00 & Max = $42.50" + "\n" +
                                        "Please add A correct amount!");
                    }


                }

                //superEmployee Function
                else if (radBtnSupEmp.Checked) 
                {

                    //Get Additional Input
                    newSupEmployee.employeeOffice = txtBoxOffice.Text;
                    //Also need inputs from advancedEmployee inputs to make sure it works properly. ! important.
                    newAdvEmployee.employeeRate = double.Parse(txtHRate.Text.ToString());
                    newAdvEmployee.employeeHrs = double.Parse(txtBoxHoursWorked.Text.ToString());

                    //validate if all boxes are full of information. 
                    if (txtBoxName.Text != "" && txtBoxEmail.Text != "" && rtxtBoxAddy.Text != "" && txtHRate.Text != "" && txtBoxHoursWorked.Text != "")
                    {
                        //also validate last imput.. Could've put in code above but 
                        // just incase they dont see the box.  
                        if (txtBoxOffice.Text != "")
                        {
                            //radio buttons for permissions.
                            //Options: high, medium, low 
                            if (radBtnHigh.Checked)
                            {                                
                                newSupEmployee.employeeHigh = true;
                                permission = "High";
                                
                            }
                            if (radBtnMed.Checked)
                            {
                                newSupEmployee.employeeMed = true;
                                permission = "Med";
                               
                            }
                            if (radBtnHigh.Checked)
                            {
                                newSupEmployee.employeeLow = true;
                                permission = "Low";
                                
                            }

                            //Confirming Adding Employee action. 
                            MessageBox.Show("Information Has Been Added!");
                            
                            //Display All New Employee Data
                            lstBoxDisplay.Items.Add("Name: " + newEmployee.employeeName);
                            lstBoxDisplay.Items.Add("Email: " + newEmployee.employeeEmail);
                            lstBoxDisplay.Items.Add("Address: " + newEmployee.employeeAddy);
                            lstBoxDisplay.Items.Add("Hourly Rate: $" + newAdvEmployee.employeeRate);
                            lstBoxDisplay.Items.Add("Hours Worked: " + newAdvEmployee.employeeHrs);
                            lstBoxDisplay.Items.Add("Permissions: " + "Low");
                            lstBoxDisplay.Items.Add("Office: " + newSupEmployee.employeeOffice);
                            lstBoxDisplay.Items.Add(".....................................");
                            lstBoxDisplay.Items.Add("");
                            
                            //Clear Text Boxes
                            txtBoxName.Clear();
                            txtBoxEmail.Clear();
                            rtxtBoxAddy.Clear();
                            txtHRate.Clear();
                            txtBoxHoursWorked.Clear();
                            txtBoxOffice.Clear();
                        }
                        else
                        {
                            //If they dont see the little office box. 
                            MessageBox.Show("Please Add Office Info");
                        }
                    }
                    else 
                    {
                        //All info needs to be submitted. 
                        MessageBox.Show("Plese fill in all information");
                    }

                }

                //put all imputs into one object to be sent to the arraylist.
                employeeList.Add(newEmployee.employeeName + "," + newEmployee.employeeEmail + "," +
                                 newEmployee.employeeAddy + "," + double.Parse(newAdvEmployee.employeeRate.ToString()) + "," +
                                 double.Parse(newAdvEmployee.employeeHrs.ToString()) + "," + permission + "," +
                                 newSupEmployee.employeeOffice);
                
                
                //foreach to grab object in 
                foreach (string i in employeeList)
                {
                    //place info into fileoutput arraylist. 
                    newEmployeeList.employeeList = (i);                    
                }

                
            } 
            catch  
            { 
                MessageBox.Show("Please Add Information");
            }
            //OUTPUT TO FILE! ! ! !
            try
            {
                //using system.IO; : This will append data to the file !important
                //File.AppendText() : this will append data to the file !important
                // ..\\..\\file.txt : is needed syntax for windows file structure !important
                using (StreamWriter OutPutFile = File.AppendText("..\\..\\employeeInformation.txt"))


                    
                    //Write to the file using the data that was passed through the outputfile class. 
                    OutPutFile.Write(newEmployeeList.employeeList + Environment.NewLine);


            }
            //catch statement if file is not found. 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }





        //Employee Select Radio Buttons.........................................................................................
        private void radBtnEmp_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
                //Didn't need This as the radio button is defaulted checked when program loads. 

        }

        //Show Advanced Group Box
        private void radBtnAdvEmp_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            //if statement to show the advanced employees group box. 
            if (radBtnAdvEmp.Checked)
            {
                grpBoxAdv.Show();
            }
            else if (!radBtnAdvEmp.Checked && radBtnSupEmp.Checked)
            {
                grpBoxAdv.Show();

            }
            else 
            {
                grpBoxAdv.Hide();
            }

        }
        //Show Super Group Box
        private void radBtnSupEmp_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            //if statement to show the superEmployee group box.
            if (radBtnSupEmp.Checked)
            {
                grpBoxAdv.Show();
                grpBoxSup.Show();

            }
            else
            {
                grpBoxAdv.Hide();
                grpBoxSup.Hide();
            }


        }


        //...................................................................
        //Xit 
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {          
            this.Close();
        }
        
        //Minimize:
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Accidentally Clicked the DB Logo...
        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }
        //Clear
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            txtBoxName.Clear();
            txtBoxEmail.Clear();
            rtxtBoxAddy.Clear();
            txtHRate.Clear();
            txtBoxHoursWorked.Clear();
            txtBoxOffice.Clear();
        }


        //CVB = Christopher Vere Baker
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;


        //END OF DESIGN SNIPPET- CVB 10/26/2021


    }
}
