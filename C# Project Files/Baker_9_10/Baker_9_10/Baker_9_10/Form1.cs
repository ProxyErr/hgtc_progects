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

namespace Baker_9_10
{
    

    public partial class Form1 : Form
    {
        //Christopher Baker
        //Chap 9 Question 10
        //October-26-2021


        //Declare Dictionary:
        private Dictionary<string, string> namesEmailsDY = new Dictionary<string, string>();


        // Declare Count Variable
        int userNameCount = 0;
        

        public Form1()
        {

            InitializeComponent();

            //CVB = Christopher Vere Baker
            this.FormBorderStyle = FormBorderStyle.None;
        }
        //
        //
        //READ FILE AND PUT ITEMS INTO THE DICTIONARY
        //INITIALIZE LISTBOX AND SHOW USERNAMES
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Declare Object To access File
                StreamReader inputFile;

                //Open the file
                inputFile = File.OpenText("..\\..\\names_emails.txt");

                //Loop through File accessing lines in the file and make
                while (!inputFile.EndOfStream)
                {
                    //READ FILE INTO STRING.
                    string namesEmails = inputFile.ReadLine();

                    //SPLIT DATA AT THE COMMA AND PUT INTO ARRAY.
                    string[] stringSplit = namesEmails.Split(new char[] { ',' });

                    if (stringSplit.Length < 2) // IF THERE IS LESS THAN 2 RESULTS DISCARD THEM.
                    {
                        continue;
                    }
                    else if (stringSplit.Length == 2) //  IF THERE ARE 2 RESULTS ADD THEM TO THE DICTIONARY.
                    {
                        namesEmailsDY.Add(stringSplit[0].Trim(), stringSplit[1].Trim());//ADD TO DICTIONARY.
                    }
                }

                //Close the file
                inputFile.Close();


            }
            //catch statement if file is not found. 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            //RESTOR LIST BOX. 
            lstBoxDisplay.Items.Clear();
            lstBoxDisplay.Items.Add("Select User:");
            lstBoxDisplay.Items.Add("........................................");
            lstBoxDisplay.Items.Add("");

            //LOOP THROUGH EACH VALUE TO DISPLAY ON LISTBOX.
            foreach (KeyValuePair<string, string> name in namesEmailsDY)
            {
                lstBoxDisplay.Items.Add(name.Key);//DISPLAY ONLY KEY VALUE ON SCREEN.
            }
        }
        //
        //
        // BUTTON SEARCH METHOD.
        private void btnSearch_Click(object sender, EventArgs e)
        {

            //if statment to validate Users entered text. 
            //makes sure number entered is not empty. 
            if (txtBoxSearch.Text != "")
            {
                //if the entered text is a value firstName holds the value of entered text. 
                string UserName = txtBoxSearch.Text;

                try
                {
                    //Declare variable for the loop
                    int indexCounter = 0;
                    //bool variable set to false as default. 
                    bool userNameFound = false;
                    //foreach statment sets name variable to int and searches 
                    // in namesEmailsDY
                    foreach (var name in namesEmailsDY)
                    {
                        //if name equals UsersName then:
                        if (!namesEmailsDY.ContainsKey(UserName))
                        {
                            //Change Bool variable to True. 
                            userNameFound = true;
                        }
                    }
                    //validate results and display User name and Email. 
                    if (!userNameFound)
                    {
                        lstBoxDisplay.Items.Clear();
                        lstBoxDisplay.Items.Add("UserName:" + "       " + "Email:");
                        lstBoxDisplay.Items.Add("........................................");
                        lstBoxDisplay.Items.Add("");
                        lstBoxDisplay.Items.Add(  UserName.ToString() + "              " + namesEmailsDY[UserName]);
                        txtBoxChngDltFirstName.Text = UserName;
                        txtBoxChngDltEmail.Text = namesEmailsDY[UserName];                       
                    }
                    //if UserName does not equal namesEmailsDY and does not meet the foreach statment then the else will be used. 
                    else
                    {
                        MessageBox.Show("That User Does Not Exist! \n" + "Please Check Spelling and Caps");
                        txtBoxSearch.Clear();
                    }
                }
                //Catch to display error message. 
                catch (Exception ex)
                {
                    MessageBox.Show("That User Does Not Exist! \n" + "Please Check Spelling and Caps");
                    txtBoxSearch.Clear();
                }

            }
        }
        //
        //
        // ITEM SELECT FROM LIST BOx METHOD.
        private void lstBoxDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Make sure listbox is not empty.
            if (lstBoxDisplay.Text != "")
            {
                // Get the selected name.
                string UserName = lstBoxDisplay.SelectedItem.ToString();

                // Get the selected Users email.
                string email = namesEmailsDY[UserName];

                // Display the selected Users Name.
                txtBoxChngDltFirstName.Text = UserName;

                // Display the selected Users email.
                txtBoxChngDltEmail.Text = email;
            }
            else 
            {
                MessageBox.Show("Cannot Apply. Please Choose Option");
            }

        }
        //
        //
        // BUTTON CHANGE EMAIL METHOD
        private void btnChange_Click(object sender, EventArgs e)
        {
            
            //Get txtBox input and set to variable.
            string UserName = txtBoxChngDltFirstName.Text;

            //Declare variable for the loop
            int indexCounter = 0;
            //bool variable set to false as default. 
            bool userNameFound = false;

            //foreach to iterate through dictionary.
            foreach (var name in namesEmailsDY)
            {
                
                //validate if UserName equals name.
                if (!namesEmailsDY.ContainsKey(UserName))
                {
                    //Change Bool variable to True. 
                    userNameFound = true;
                    
                }
            }
            //If userNameFound is true.
            if (!userNameFound)
            {
                //Display info of username that was clicked.  
                namesEmailsDY[UserName] = txtBoxChngDltEmail.Text;

                lstBoxDisplay.Items.Clear();
                lstBoxDisplay.Items.Add("UserName:" + "       " + "Email:");
                lstBoxDisplay.Items.Add("........................................");
                lstBoxDisplay.Items.Add("");
                lstBoxDisplay.Items.Add(UserName.ToString() + "              " + namesEmailsDY[UserName]);
                txtBoxChngDltFirstName.Text = UserName;
                txtBoxChngDltEmail.Text = namesEmailsDY[UserName];

            }
            else 
            {
                MessageBox.Show("That User Does Not Exist! \n" + "Please Check Spelling and Caps");
            }



        }
        //
        //
        // BUTTON TO DELETE USER.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //text box input set to variable.
            string UserName = txtBoxChngDltFirstName.Text;

            //Declare variable for the loop
            int indexCounter = 0;
            //bool variable set to false as default. 
            bool userNameFound = false;

            //Iterate through Dictionary.
            foreach (var name in namesEmailsDY)
            {

                //If username equals a name in the Dictionary.
                if (!namesEmailsDY.ContainsKey(UserName))
                {
                    //Change Bool variable to True. 
                    userNameFound = true;

                }
            }
            //If userNameFound is False
            if (!userNameFound)
            {
                //Display output to list of all data.
                namesEmailsDY.Remove(UserName);

                txtBoxChngDltFirstName.Clear();
                txtBoxAddUserName.Clear();
                txtBoxAddUserEmail.Clear();
                txtBoxChngDltFirstName.Clear();
                txtBoxChngDltEmail.Clear();
                lstBoxDisplay.Items.Clear();
                lstBoxDisplay.Items.Add("Users:");
                lstBoxDisplay.Items.Add("........................................");
                lstBoxDisplay.Items.Add("");

                //Iterate through dictionary and display each item key.
                foreach (KeyValuePair<string, string> name in namesEmailsDY)
                {
                    lstBoxDisplay.Items.Add(name.Key);
                }


            }
            else
            {
                MessageBox.Show("That User Does Not Exist! \n" + "Please Check Spelling and Caps");
            }

        }
        //
        //
        // BUTTON TO ADD USER.
        private void btnAdd_Click(object sender, EventArgs e)
        {


            if (lstBoxDisplay.Text != "")
            {
                //text box input is set to variable.
                string UserName = txtBoxChngDltFirstName.Text;

                //Declare variable for the loop
                int indexCounter = 0;
                //bool variable set to false as default. 
                bool userNameFound = false;

                //Iterate through Dictionary. 
                foreach (var name in namesEmailsDY)
                {

                    //If the UserName equals the name in the Dictionary.
                    if (!namesEmailsDY.ContainsKey(UserName))
                    {
                        //Change Bool variable to True. 
                        userNameFound = true;

                    }
                }
                //If the userNameFound is False.
                if (!userNameFound)
                {

                    MessageBox.Show("That User Already Exist! \n" + "Please Try Another Name");

                }
                //If true..
                else
                {
                    //Display and add content to dictionary.
                    namesEmailsDY.Add(txtBoxAddUserName.Text, txtBoxAddUserEmail.Text);

                    txtBoxChngDltFirstName.Clear();
                    txtBoxAddUserName.Clear();
                    txtBoxAddUserEmail.Clear();
                    txtBoxChngDltFirstName.Clear();
                    txtBoxChngDltEmail.Clear();
                    lstBoxDisplay.Items.Clear();
                    lstBoxDisplay.Items.Add("Users:");
                    lstBoxDisplay.Items.Add("........................................");
                    lstBoxDisplay.Items.Add("");

                    //Iterate and re list the new content.
                    foreach (KeyValuePair<string, string> name in namesEmailsDY)
                    {
                        lstBoxDisplay.Items.Add(name.Key);
                    }
                }
            }
            //IF LIST BOX IS EMPTY THEN JUST ADD ENTRY TO DICTIONARY.
            else 
            {
                namesEmailsDY.Add(txtBoxAddUserName.Text, txtBoxAddUserEmail.Text);

                txtBoxChngDltFirstName.Clear();
                txtBoxAddUserName.Clear();
                txtBoxAddUserEmail.Clear();
                txtBoxChngDltFirstName.Clear();
                txtBoxChngDltEmail.Clear();
                lstBoxDisplay.Items.Clear();
                lstBoxDisplay.Items.Add("Users:");
                lstBoxDisplay.Items.Add("........................................");
                lstBoxDisplay.Items.Add("");

                //Iterate through Dictionary and display list with new content.
                foreach (KeyValuePair<string, string> name in namesEmailsDY)
                {
                    lstBoxDisplay.Items.Add(name.Key);
                }

            }

        }
        //
        //
        // XIT BUTTON.
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            try
            {

                using (StreamWriter OutPutFile = new StreamWriter("..\\..\\names_emails.txt"))



                    //Loop to keep accessing lines in the file and make
                    //sure it does not throw an exception reading past the data

                    foreach (KeyValuePair<string, string> name in namesEmailsDY)
                    {
                        //Read a line from the file and place into boysFirstNameList List. 
                        OutPutFile.WriteLine(name.Key + "," + name.Value);


                    }


            }
            //catch statement if file is not found. 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //Code to Close.
            this.Close();
        }
        //
        //
        // EXIT BUTTON.
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {

                using (StreamWriter OutPutFile = new StreamWriter("..\\..\\names_emails.txt"))



                    //Loop to keep accessing lines in the file and make
                    //sure it does not throw an exception reading past the data

                foreach (KeyValuePair<string, string> name in namesEmailsDY)
                {
                    //Read a line from the file and place into List. 
                    OutPutFile.WriteLine(name.Key + "," + name.Value);


                }


            }
            //catch statement if file is not found. 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
        //
        //
        // CLEAR BUTTON.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxSearch.Clear();
            txtBoxChngDltFirstName.Clear();
            txtBoxChngDltEmail.Clear();
            lstBoxDisplay.Items.Clear();
            lstBoxDisplay.Items.Add("Users:");
            lstBoxDisplay.Items.Add("........................................");
            lstBoxDisplay.Items.Add("");
            foreach (KeyValuePair<string, string> name in namesEmailsDY)
            {
                lstBoxDisplay.Items.Add(name.Key);
            }
        }

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
