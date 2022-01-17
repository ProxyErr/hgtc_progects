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

namespace Baker_8_2

            //Christopher Baker
            //Chap 8 Question 2
            //September-21-2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //CVB = Christopher Vere Baker

            //This is a snippet taken off of stack flow
            //for design purposes to make clickable and draggable:CVB 9/21/2021
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //This snippet was taken off of stack flow
        //for design purposes clickable and draggable:CVB 9/21/2021
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;



        //END OF DESIGN SNIPPET- CVB 9/21/2021

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            //Declare Variables
            string enteredString;
            int totalWords;
            double averageWords;
            double totalAverage;


            //Clear List box Info after every Iteration.
            listBox1.Items.Clear();

            //Get Text out of TextBox and place into string. 
            enteredString = richTextBox1.Text;

            //Call the countwords method and place returned value into totalWords
            totalWords = countWords(enteredString);



            averageWords = getAverage(enteredString);


            totalAverage = averageWords / totalWords; 

            //Output
            listBox1.Items.Add("The Word Count is: " + totalWords.ToString());
            listBox1.Items.Add("The Average letter per Words are: " + totalAverage.ToString());
        }

        private int countWords(string str)
        {
            //Declare variables in method
            int numWords = 0;
            Boolean wordBegin = false;


            //Loop to run through string
            for (int i = 0; i < str.Length; i++)
            {
                //If statment to see if it is the first character of the string and not a space. 
                if (i == 0 && !char.IsWhiteSpace(str[i]))
                {
                    wordBegin = true;
                }
                else if (i > 0 && char.IsWhiteSpace(str[i - 1]))
                {
                    wordBegin = true;
                }
                else
                {
                    wordBegin = false;
                }

                //if statement to see if wordbegin is true
                if (wordBegin == true && (char.IsLetterOrDigit(str[i]) || char.IsPunctuation(str[i])))
                {
                    //increment the count
                    numWords++;
                }


            }
            //Return value back to main
            return numWords;
        }

        private int getAverage(string str) 
        {
            //Declare variables in method
            int numLetters = 0;
            Boolean letterCount = false;


            //Loop to run through string
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0 && char.IsWhiteSpace(str[i]))
                {
                    letterCount = false;
                }
                else
                {
                    letterCount = true;
                }
               

                //if statement to see if wordbegin is true
                if (letterCount == true && (char.IsLetterOrDigit(str[i])))
                {
                    //increment the count
                    numLetters++;                
                }                       

            }
            //Return value back to main
            return numLetters;

        }






        //Method to clear text boxes. 
        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            listBox1.Items.Clear();



        }
        //Exit button 
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Close Button Top Corner
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
