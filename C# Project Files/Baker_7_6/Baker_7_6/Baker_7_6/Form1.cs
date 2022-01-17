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
using System.Runtime.InteropServices;

namespace Baker_7_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //CVB = Christopher Vere Baker

            //This is a snippet taken off of stack flow
            //for design purposes to make clickable and draggable:CVB 9/14/2021
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //This snippet was taken off of stack flow
        //for design purposes clickable and draggable:CVB 9/14/2021
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        /// <summary>
        /// 
        /// Was wanting to make it a little more... custom. 
        /// CANNOT FIGURE OUT WHY UPPER BAR IS NOT CLICKABLE???
        /// 
        /// </summary>

        //END OF DESIGN SNIPPET- CVB 9/14/2021


        //Christopher Baker
        //Chap 7 Question 6 
        //September-19-2021

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {

            //Declair variables:
            //Create a NEW LIST when the file is opened  will transfer all data to variable names
            //to zero until user enters txt. 
            List<string> boysFirstNameList = new List<string>();
            List<string> boyslastNameList = new List<string>();

            List<string> girlsFirstNameList = new List<string>();
            List<string> girlslastNameList = new List<string>();

            //holds value of entered text.
            string boysfirstName = "";
            string boyslastName = "";

            string girlsfirstName = "";
            string girlslastName = "";


            //try catch for validation and exception errors BOYS FIRST. 
            try
            {

                //Declare Object To access File
                StreamReader inputFile;

                //Open the file
                inputFile = File.OpenText("..\\..\\BoyNames.txt");
                


                //Loop to keep accessing lines in the file and make
                //sure it does not throw an exception reading past the data

                while (!inputFile.EndOfStream)
                {
                    //Read a line from the file and place into boysFirstNameList List. 
                    boysFirstNameList.Add(inputFile.ReadLine());
                    

                }

                //Close the file
                inputFile.Close();


            }
            //catch statement if file is not found. 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //try catch for validation and exception errors BOYS LAST. 
            try
            {

                //Declare Object To access File
                StreamReader inputFile;

                //Open the file
                inputFile = File.OpenText("..\\..\\BoyNames.txt");



                //Loop to keep accessing lines in the file and make
                //sure it does not throw an exception reading past the data

                while (!inputFile.EndOfStream)
                {
                    //Read a line from the file and place into boyslastNameList List. 
                    boyslastNameList.Add(inputFile.ReadLine());


                }

                //Close the file
                inputFile.Close();


            }
            //catch statement if file is not found. 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //try catch for validation and exception errors GIRLS FIRST. 
            try
            {

                //Declare Object To access File
                StreamReader inputFile;

                //Open the file
                inputFile = File.OpenText("..\\..\\GirlNames.txt");



                //Loop to keep accessing lines in the file and make
                //sure it does not throw an exception reading past the data

                while (!inputFile.EndOfStream)
                {
                    //Read a line from the file and place into girlsFirstNameList List. 
                    girlsFirstNameList.Add(inputFile.ReadLine());


                }

                //Close the file
                inputFile.Close();


            }
            //catch statement if file is not found. 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //try catch for validation and exception errors GIRLS LAST. 
            try
            {

                //Declare Object To access File
                StreamReader inputFile;

                //Open the file
                inputFile = File.OpenText("..\\..\\GirlNames.txt");



                //Loop to keep accessing lines in the file and make
                //sure it does not throw an exception reading past the data

                while (!inputFile.EndOfStream)
                {
                    //Read a line from the file and place into girlsLastNameList. 
                    girlslastNameList.Add(inputFile.ReadLine());


                }

                //Close the file
                inputFile.Close();


            }
            //catch statement if file is not found. 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //try catch statment for validation and exceptions BOYS. 
            try
            {
                //if statment to validate Users entered text. 
                //makes sure number entered is not empty. 
                if (txtbxFirstName.Text != "")
                {
                    //if the entered text is a value firstName holds the value of entered text. 
                    boysfirstName = txtbxFirstName.Text;

                    try
                    {
                        //bool variable set to false as default. 
                        bool firstNameFound = false;
                        //foreach statment sets name variable to int and searches 
                        // in accntList
                        foreach (string name in boysFirstNameList)
                        {
                            //if name equals Users entered boysfirstName then:
                            if (name == boysfirstName)
                            {
                                //Change Bool variable to True. 
                                firstNameFound = true;
                            }
                        }
                        //validate results. After AccntNumFound is changed to true pass variable to if statment. 
                        if (firstNameFound)
                        {
                            MessageBox.Show("The First Name Entered is a Popular Boys Name!");
                        }
                        //if acc does not equal accountNum and does not meet the foreach statment then the else will be used. 
                        else
                        {
                            MessageBox.Show("The First Name Entered is a RARE Boys Name!");
                        }
                    }
                    //Catch to display error message. 
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                //else statment to bypass 
                else
                {
                    
                }
                //if statment to validate Users entered text. 
                //makes sure number entered is not Empty. 
                if (txtbxLastName.Text != "")
                {
                    //if the entered text is greater a value lastName holds value of entered text. 
                    boyslastName = txtbxLastName.Text;

                    try
                    {
                        //bool variable set to false as default. 
                        bool lastNameFound = false;
                        //foreach statment sets name variable to int and searches 
                        // in accntList
                        foreach (string name in boyslastNameList)
                        {
                            //if name equals Users entered boyslastName then:
                            if (name == boyslastName)
                            {
                                //Change Bool variable to True. 
                                lastNameFound = true;
                            }
                        }
                        //validate results. After AccntNumFound is changed to true pass variable to if statment. 
                        if (lastNameFound)
                        {
                            MessageBox.Show("The Last Name Entered is a Popular Boys Name!");
                        }
                        //if acc does not equal accountNum and does not meet the foreach statment then the else will be used. 
                        else
                        {
                            MessageBox.Show("The Last Name Entered is a RARE Boys Name!");
                        }
                    }
                    //Catch to display error message. 
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }



                }
                //else statment to bypass. 
                else
                {
                    
                }

            }
            //Catch statment if user enters anything other. 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //try catch statment for validation and exceptions GIRLS. 
            try
            {
                //if statment to validate Users entered text. 
                //makes sure number entered is not empty. 
                if (txtbxGirlsFirstNames.Text != "")
                {
                    //if the entered text is a value firstName holds the value of entered text. 
                    girlsfirstName = txtbxGirlsFirstNames.Text;

                    // Try Catch for Validation and exceptions GIRLS FIRST. 
                    try
                    {
                        //bool variable set to false as default. 
                        bool girlsfirstNameFound = false;
                        //foreach statment sets name variable to int and searches 
                        // in accntList
                        foreach (string name in girlsFirstNameList)
                        {
                            //if name equals Users entered girlsfirstName then:
                            if (name == girlsfirstName)
                            {
                                //Change Bool variable to True. 
                                girlsfirstNameFound = true;
                            }
                        }
                        //validate results. After AccntNumFound is changed to true pass variable to if statment. 
                        if (girlsfirstNameFound)
                        {
                            MessageBox.Show("The First Name Entered is a Popular Girls Name!");
                        }
                        //if acc does not equal accountNum and does not meet the foreach statment then the else will be used. 
                        else
                        {
                            MessageBox.Show("The First Name Entered is a RARE Girls Name!");
                        }
                    }
                    //Catch to display error message. 
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                //else statment to bypass. 
                else
                {
                    
                }
                //if statment to validate Users entered text. 
                //makes sure number entered is not Empty. 
                if (txtbxGirlsLastNames.Text != "")
                {
                    //if the entered text is greater a value lastName holds value of entered text. 
                    girlslastName = txtbxGirlsLastNames.Text;

                    // Try Catch for Validation and exceptions GIRLS LAST. 
                    try
                    {
                        //bool variable set to false as default. 
                        bool girlslastNameFound = false;
                        //foreach statment sets name variable to int and searches 
                        // in accntList
                        foreach (string name in girlslastNameList)
                        {
                            //if name equals Users entered girlslastName then:
                            if (name == girlslastName)
                            {
                                //Change Bool variable to True. 
                                girlslastNameFound = true;
                            }
                        }
                        //validate results. After AccntNumFound is changed to true pass variable to if statment. 
                        if (girlslastNameFound)
                        {
                            MessageBox.Show("The Last Name Entered is a Popular Girls Name!");
                        }
                        //if acc does not equal accountNum and does not meet the foreach statment then the else will be used. 
                        else
                        {
                            MessageBox.Show("The Last Name Entered is a RARE Girls Name!");
                        }
                    }
                    //Catch to display error message. 
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                //else statment to bypass. 
                else
                {
                    
                }

            }
            //Catch statment if user enters anything other. 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //create Exit method
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Code to close the program
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //method to clear text boxes.
        private void btnClear_Click(object sender, EventArgs e)
        {
            //code to clear textboxes. 
            txtbxFirstName.Clear();
            txtbxLastName.Clear();
            txtbxGirlsFirstNames.Clear();
            txtbxGirlsLastNames.Clear();
        }
    }
}
