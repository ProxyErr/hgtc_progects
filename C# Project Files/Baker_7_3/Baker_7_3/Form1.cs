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

namespace Baker_7_3
{
    //Christopher Baker
    //Chap 7 Question 3 
    //September-7-2021

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Was going to initialize reading the file on opening the form but Can't figure out how to pass info
        //Form1_Load(object sender, EventArgs e) into main/btnGO method. if its even possible or needed? 
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
       //Was going to try and pass a method to a main/btnG0 method but I couldnt figure out the syntax
       //for the button click main and where the method openAccntNumFile() would go. If its even possible or needed?
        private void openAccntNumFile()
        {


        }



        //Go Button method To start the search.
        private void btnGo_Click(object sender, EventArgs e)
        {
            //Declair variables:
            //Create a NEW LIST called accntList when the file is opened we will transfer all data to accntList
            //accountNum variable to zero until user enters txt. 
            List<int> accntList = new List<int>();

            //holds value of entered text.
            int accountNum = 0;
            

            
            //try catch for validation and exception errors. 
            try
            {

                //Declare Object To access File
                StreamReader inputFile;

                //Open the file
                inputFile = File.OpenText("..\\..\\ChargeAccounts.txt");


                //Loop to keep accessing lines in the file and make
                //sure it does not throw an exception reading past the data

                while (!inputFile.EndOfStream)
                {
                    //Read a line from the file and place into accntList List. 
                    accntList.Add(int.Parse(inputFile.ReadLine()));
                                     
                }

                //Close the file
                inputFile.Close();


            }
            //catch statement if file is not found. 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //try catch statment for validation and exceptions. 
            try
            {
                //if statment to validate Users entered text. 
                //makes sure number entered is not 0. 
                if (int.Parse(txtBoxAccntNum.Text) > 0)
                {
                    //if the entered text is greater than 0 accountNum holds value of entered text. 
                    accountNum = int.Parse(txtBoxAccntNum.Text);

                }
                //else statment to show if it is other than a positive number greater than 0. 
                else 
                {
                    MessageBox.Show("Cannot Be a Negative Number");
                }
            }
            //Catch statment if user enters anything other than a number. 
            catch 
            {
                MessageBox.Show("The Account Number Only Contains Numbers");
            }
            // Try Catch for Validation and exceptions. 
            try
            {
                //bool variable set to false as default. 
                bool AccntNumFound = false;
                //foreach statment sets acc variable to int and searches 
                // in accntList
                foreach (int acc in accntList)
                {
                    //if acc equals Users entered number/accountNum then:
                    if (acc == accountNum)
                    {
                        //Change Bool variable to True. 
                        AccntNumFound = true;
                    }
                }
                //validate results. After AccntNumFound is changed to true pass variable to if statment. 
                if (AccntNumFound) 
                {
                    MessageBox.Show("The Account Number Entered is Valid");
                }
                //if acc does not equal accountNum and does not meet the foreach statment then the else will be used. 
                else
                {
                    MessageBox.Show("The Account Number Entered Is Not Found, Please Try Again");
                }
            }
            //Catch to display error message. 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //create Clear button method
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxAccntNum.Text = "";

        }

        //create Exit method
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Code to close the program
            this.Close();
        }

        
    }
}
