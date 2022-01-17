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

namespace Baker_9_2
{
    //Declare Structure
    struct DrinkData
    {
        public string drinkName;
        public float drinkCost;
        public int drinkCount;
    }

    public partial class Form1 : Form
    {
        //Christopher Baker
        //Chap 9 Question 2 
        //October-18-2021

        //CVB = Christopher Vere Baker


        //Declare variable
        DrinkData allData = new DrinkData();

        //List to hold all Data
        List<DrinkData> allDataList = new List<DrinkData>();

        string[,] drinkInfo = new string[,]
        {
                {"Cola", "1.00", "20"},
                {"Cream Soda", "1.00", "20"},
                {"Lemon Lime", "1.00", "20"},
                {"Grape Soda", "1.50", "20"},
                {"Root Beer", "1.50", "20"},

        };//2D array to hold all values for Items.


       //Declare Desending Global Variables.
        int colaCount = 20;
        int csCount = 20;
        int llCount = 20;
        int gsCount = 20;
        int rbCount = 20;

        //Declair Total Gobal Variables.
        float colaTotal = 0;
        float csTotal = 0;
        float llTotal = 0;
        float gsTotal = 0;
        float rbTotal = 0;
        float vendingTotal = 0;

        //Ascending Global Variables. 
        int colanumItems = 1;
        int csnumItems = 1;
        int llnumItems = 1;
        int gsnumItems = 1;
        int rbnumItems = 1;
        



        public Form1()
        {
            InitializeComponent();


            //CVB = Christopher Vere Baker

            
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstBoxDisplay.Items.Add("...".ToString());
            lstBoxDisplay.Items.Add("...".ToString());
            lstBoxDisplay.Items.Add("Welcome!".ToString());
            lstBoxDisplay.Items.Add("Choose a Drink".ToString());
            lstBoxDisplay.Items.Add(".....................".ToString());
        }//Prompt 

        private void btnCola_Click(object sender, EventArgs e)
        {

            //Declare variable for the loop
            int indexCounter = 0;


            if (colaCount != 0)
            {
                
                //Loop to run through the array and pupulate the structure 
                //and then the list
                for (int i = 0; i < drinkInfo.GetLength(0); i++)
                {
                    //Populate the DrinkData array with info from the array
                    allData.drinkName = drinkInfo[i, 0];
                    allData.drinkCost = float.Parse(drinkInfo[i, 1]);
                    allData.drinkCount = colaCount;

                    //Add the allData from the iteration of the loop into the list
                    allDataList.Add(allData);
                }

                
                colaCount--;
                lstBoxDisplay.Items.Add("(" + colanumItems.ToString() + ")" + allDataList[indexCounter].drinkName + "........" + allDataList[indexCounter].drinkCost.ToString("c"));              
                lblColaCount.Text = colaCount.ToString();


                lstBoxTotal.Items.Clear();
                vendingTotal += allDataList[indexCounter].drinkCost;
            }
            else
            {
                lstBoxTotal.Items.Clear();
                vendingTotal = vendingTotal;
                colaCount = 0;
                MessageBox.Show("Cola is Sold Out");

            }

            lstBoxTotal.Items.Add(vendingTotal.ToString("c"));


        }//Cola: [Cola]
        private void btnCS_Click(object sender, EventArgs e)
        {
            //Declare variable for the loop        
            int indexCounter = 1;

            if (csCount != 0)
            {
                
                //Loop to run through the array and pupulate the structure 
                //and then the list
                for (int i = 0; i < drinkInfo.GetLength(0); i++)
                {
                    //Populate the DrinkData array with info from the array
                    allData.drinkName = drinkInfo[i, 0];
                    allData.drinkCost = float.Parse(drinkInfo[i, 1]);
                    allData.drinkCount = csCount;

                    //Add the allData from the iteration of the loop into the list
                    allDataList.Add(allData);
                }

                
                csCount--;
                lstBoxDisplay.Items.Add("(" + csnumItems.ToString() + ")" + allDataList[indexCounter].drinkName + ".." + allDataList[indexCounter].drinkCost.ToString("c"));
                lblCSCount.Text = csCount.ToString();

                lstBoxTotal.Items.Clear();
                vendingTotal += allDataList[indexCounter].drinkCost;
            }
            else
            {
                lstBoxTotal.Items.Clear();
                vendingTotal = vendingTotal;               
                csCount = 0;
                MessageBox.Show("Creme Soda is Sold Out");

            }

            lstBoxTotal.Items.Add(vendingTotal.ToString("c"));
        }//Creme Soda: [CS, cs]

        private void btnLL_Click(object sender, EventArgs e)
        {
            //Declare variable for the loop
            int indexCounter = 2;

            if (llCount != 0)
            {
                
                //Loop to run through the array and pupulate the structure 
                //and then the list
                for (int i = 0; i < drinkInfo.GetLength(0); i++)
                {
                    //Populate the DrinkData array with info from the array
                    allData.drinkName = drinkInfo[i, 0];
                    allData.drinkCost = float.Parse(drinkInfo[i, 1]);
                    allData.drinkCount = llCount;

                    //Add the allData from the iteration of the loop into the list
                    allDataList.Add(allData);

                }

                
                llCount--;
                lstBoxDisplay.Items.Add("(" + llnumItems.ToString() + ")" + allDataList[indexCounter].drinkName + ".." + allDataList[indexCounter].drinkCost.ToString("c"));
                lblLLCount.Text = llCount.ToString();


                lstBoxTotal.Items.Clear();
                vendingTotal += allDataList[indexCounter].drinkCost;
            }
            else
            {
                lstBoxTotal.Items.Clear();
                vendingTotal = vendingTotal;
                llCount = 0;
                MessageBox.Show("Lemon Lime is Sold Out");

            }

            lstBoxTotal.Items.Add(vendingTotal.ToString("c"));
        }//Lemon Lime: [LL, ll]

        private void btnGS_Click(object sender, EventArgs e)
        {
            //Declare variable for the loop
            int indexCounter = 3;

            if (gsCount != 0)
            {

                

                for (int i = 0; i < drinkInfo.GetLength(0); i++)
                {
                    //Populate the DrinkData array with info from the array
                    allData.drinkName = drinkInfo[i, 0];
                    allData.drinkCost = float.Parse(drinkInfo[i, 1]);
                    allData.drinkCount = csCount;

                    //Add the allData from the iteration of the loop into the list
                    allDataList.Add(allData);
                }

                
                gsCount--;

                lstBoxDisplay.Items.Add("(" + gsnumItems.ToString() + ")" + allDataList[indexCounter].drinkName + ".." + allDataList[indexCounter].drinkCost.ToString("c"));
                lblGSCount.Text = gsCount.ToString();

                lstBoxTotal.Items.Clear();
                vendingTotal += allDataList[indexCounter].drinkCost;
            }
            else
            {
                lstBoxTotal.Items.Clear();
                vendingTotal = vendingTotal;
                gsCount = 0;
                MessageBox.Show("Grape Soda is Sold Out");

            }

            lstBoxTotal.Items.Add(vendingTotal.ToString("c"));
        }//Grape Soda: [GS, gs]

        private void btnRB_Click(object sender, EventArgs e)
        {
            //Declare variable for the loop
            int indexCounter = 4;

            if (rbCount != 0)
            {

                //Loop to run through the array and pupulate the structure 
                //and then the list
                for (int i = 0; i < drinkInfo.GetLength(0); i++)
                {
                    //Populate the DrinkData array with info from the array
                    allData.drinkName = drinkInfo[i, 0];
                    allData.drinkCost = float.Parse(drinkInfo[i, 1]);
                    allData.drinkCount = rbCount;

                    //Add the allData from the iteration of the loop into the list
                    allDataList.Add(allData);

                }
                rbCount--;
                lstBoxDisplay.Items.Add("(" + rbnumItems.ToString() + ")" + allDataList[indexCounter].drinkName + ".." + allDataList[indexCounter].drinkCost.ToString("c"));
                lblRBCount.Text = rbCount.ToString();

                lstBoxTotal.Items.Clear();
                vendingTotal += allDataList[indexCounter].drinkCost;
            }
            else
            {
                lstBoxTotal.Items.Clear();
                vendingTotal = vendingTotal;
                rbCount = 0;
                MessageBox.Show("Root Beer is Sold Out");

            }

            lstBoxTotal.Items.Add(vendingTotal.ToString("c"));
        }//Root Beer: [RB, rb]



        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //This snippet was taken off of stack flow
        //for design purposes clickable and draggable:CVB 10/18/2021
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        //END OF DESIGN SNIPPET- CVB 10/18/2021
    }
}
