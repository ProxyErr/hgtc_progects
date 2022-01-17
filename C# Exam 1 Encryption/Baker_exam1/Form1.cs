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

namespace Baker_exam1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        //Christopher Baker
        //Exam 1 
        //October-4-2021

       
        //search through the letters of the file. 
        private void btnCalcLetters_Click(object sender, EventArgs e)
        {
           
            //list of hhlyrics file. This is not reading the file correctly 
            List<string> hhLyricsList = new List<string>();


            //Declare Variables. 
            int totalLetters;
            int letterCount = 0;
            string userLetters;

            //try catch for validation and exception errors countLetters(). 
            try
            {
                //Declare Object To access File
                StreamReader inputFile;
               
                //Open the file
                inputFile = File.OpenText("..\\..\\hhlyrics.txt");
                
                
                //Loop to keep accessing lines in the file and make
                //sure it does not throw an exception reading past the data
                while (!inputFile.EndOfStream)
                {
                    //Read a line from the file and place into boysFirstNameList List. 
                    hhLyricsList.Add(inputFile.ReadLine());

                }

                //Close the file
                inputFile.Close();
            }
            //catch statement if file is not found. 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (string txt in hhLyricsList)
            {
                userLetters = txtBoxUserLetter.Text;
                //create array of user letters so it can compare values in the for loop. 
                char[] userCharacters = userLetters.ToCharArray();

                //for loop to iterate throught the str1 string. 
                for (int i = 0; i < txt.Length; i++)
                {
                    //if statment to compare all items in the str1 array to the 
                    //users input. 
                    if (txt[i] == userCharacters[0])
                    {
                        //Counts the amount of times it recognizes the letter.
                        letterCount++;
                    }

                }
            }     
        
            //Call the countLetters method and place returned value into totalLetters
            totalLetters = letterCount;

            //Display results of the totalLetters to listbox. Cannot understand why
            //this is displaying the error message and not the contents of the file.
            lstBoxResults.Items.Add("There are " + totalLetters.ToString() + " of those letters total in the file.");


        }

       


        //encrypt method. 
        private void btnCalcEnc_Click(object sender, EventArgs e)
        {
            //list of hhlyrics file. This is not reading the file correctly 
            List<string> hhLyricsList = new List<string>();


            string newLetter = "";

            //try catch for validation and exception errors countLetters(). 
            try
            {
                //Declare Object To access File
                StreamReader inputFile;

                //Open the file
                inputFile = File.OpenText("..\\..\\hhlyrics.txt");


                //Loop to keep accessing lines in the file and make
                //sure it does not throw an exception reading past the data
                while (!inputFile.EndOfStream)
                {
                    //Read a line from the file and place into boysFirstNameList List. 
                    hhLyricsList.Add(inputFile.ReadLine());

                }

                //Close the file
                inputFile.Close();
            }
            //catch statement if file is not found. 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //foreach statment sets name variable to string and searches 
            // in hhLyricsList
            foreach (string txt in hhLyricsList)
            {
                char[] CharactersCapitols = { 'A', 'D', 'H', 'K', 'M', 'O', 'S', 'X', '\n'};

                char[] CharactersLowerCase = { 'a', 'd', 'h', 'k', 'm', 'o', 's', 'x'};

                //for loop to iterate throught the txt string. 
                for (int i = 0; i < txt.Length; i++)
                {
                    // if statement say if any of the letters are there change to newLetter value.
                    if (txt[i] == CharactersCapitols[0])
                    {
                        newLetter += 'Z';

                    }
                    else if (txt[i] == CharactersLowerCase[0])
                    {
                        newLetter += 'z';
                    }
                    else if (txt[i] == CharactersCapitols[1])
                    {
                        newLetter += 'W';
                    }
                    else if (txt[i] == CharactersLowerCase[1])
                    {
                        newLetter += 'w';
                    }
                    else if (txt[i] == CharactersCapitols[2])
                    {
                        newLetter += 'T';
                    }
                    else if (txt[i] == CharactersLowerCase[2])
                    {
                        newLetter += 't';
                    }
                    else if (txt[i] == CharactersCapitols[3])
                    {
                        newLetter += 'R';
                    }
                    else if (txt[i] == CharactersLowerCase[3])
                    {
                        newLetter += 'r';
                    }
                    else if (txt[i] == CharactersCapitols[4])
                    {
                        newLetter += 'P';
                    }
                    else if (txt[i] == CharactersLowerCase[4])
                    {
                        newLetter += 'p';
                    }
                    else if (txt[i] == CharactersCapitols[5])
                    {
                        newLetter += 'N';
                    }
                    else if (txt[i] == CharactersLowerCase[5])
                    {
                        newLetter += 'n';
                    }
                    else if (txt[i] == CharactersCapitols[6])
                    {
                        newLetter += 'J';
                    }
                    else if (txt[i] == CharactersLowerCase[6])
                    {
                        newLetter += 'j';
                    }
                    else if (txt[i] == CharactersCapitols[7])
                    {
                        newLetter += 'E';
                    }
                    else if (txt[i] == CharactersLowerCase[7])
                    {
                        newLetter += 'e';
                    }
                    else if (txt[i] == CharactersCapitols[8])
                    {
                        newLetter += '\n';
                    }
                    //else statement to put back anything that isn't in the lower or capitols arrays. 
                    else
                    {
                        newLetter += txt[i];
                    }

                }
            }

            //Tried to display to the list box but cannot figure out
            //how to format the string to fit inside the list box. 
            //The format did not stay the same when I output the file. 
            lstBoxResults.Items.Add(newLetter.ToString());

            //I just used a message box instead to display the encrypted file contents. 
            MessageBox.Show(newLetter.ToString());

        }
        //method to clear text boxes.
        private void btnClear_Click(object sender, EventArgs e)
        {
            //code to clear textboxes.
            txtBoxUserLetter.Clear();
            lstBoxResults.Items.Clear();
        }
        //method to close the program.
        private void btnExit_Click(object sender, EventArgs e)
        {
            //code to close. 
            this.Close();
        }
    }
}
