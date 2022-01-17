using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baker_8_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            //Christopher Baker
            //Chap 8 Question 9
            //September-28-2021

            //Declare Variables
            string enteredString, changeString;

            //Get the input from the textbox
            enteredString = txtbUserEntry.Text;

            //Call method and get numbers to change for letters 
            changeString = chngtoNum(enteredString);

            //Output to list box. 
            lstbResults.Items.Add(changeString.ToString());

        }

        //Method to change letters to numbers 
        private string chngtoNum(string str) 
        {
            //Declare variables
            string newString = "";

            //For loop to iterate through entered text string
            for (int i = 0; i < str.Length; i++) 
            {
                // if statement say if any of the letters are there change to newString value. 
                if (str[i] == 'A' || str[i] == 'B' || str[i] == 'C')
                {
                    newString += 2;
                }
                else if (str[i] == 'D' || str[i] == 'E' || str[i] == 'F')
                {
                    newString += 3;
                }
                else if (str[i] == 'G' || str[i] == 'H' || str[i] == 'I')
                {
                    newString += 4;
                }
                else if (str[i] == 'J' || str[i] == 'K' || str[i] == 'L')
                {
                    newString += 5;
                }
                else if (str[i] == 'M' || str[i] == 'N' || str[i] == 'O')
                {
                    newString += 6;
                }
                else if (str[i] == 'P' || str[i] == 'Q' || str[i] == 'R' || str[i] == 'S')
                {
                    newString += 7;
                }
                else if (str[i] == 'T' || str[i] == 'U' || str[i] == 'V')
                {
                    newString += 8;
                }
                else if (str[i] == 'W' || str[i] == 'X' || str[i] == 'Y' || str[i] == 'Z')
                {
                    newString += 9;
                }
                //else statment for anything other than these letters use the same value of the string input. 
                else 
                {
                    newString += str[i];
                }
            }
            //return the value to the function chngtoNum()
            return newString;
        }

        //method to clear all text related boxes. 
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear text areas
            txtbUserEntry.Clear();
            lstbResults.Items.Clear();
        }
        //This method to close on exit button click.
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes program.
            this.Close();
        }
    }
}
