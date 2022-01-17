using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baker_10_6
{
    public partial class MainForm : Form
    {

       //Christopher V Baker
       //Chapter 10 problem 6
       // November-9-2021



        public MainForm()
        {
            InitializeComponent();
        }

        // main form on load. 
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        // method for calculate button.
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //

            //Create an Instance of the TotalChargesForm
            TotalChargesForm totalForm = new  TotalChargesForm();


            //if, else if === statements to check which radio is checked.
            if (rbtnAllenHall.Checked && rbtn7meals.Checked)
            {
                totalForm.lblTotal.Text = "$" + (1500 + 600);
            }
            else if (rbtnAllenHall.Checked && rbtn14meals.Checked)
            {
                totalForm.lblTotal.Text = "$" + (1500 + 1200);
            }
            else if (rbtnAllenHall.Checked && rbtnUnlimited.Checked)
            {
                totalForm.lblTotal.Text = "$" + (1500 + 1700);
            }
            else if (rbtnPikeHall.Checked && rbtn7meals.Checked)
            {
                totalForm.lblTotal.Text = "$" + (1600 + 600);
            }
            else if (rbtnPikeHall.Checked && rbtn14meals.Checked)
            {
                totalForm.lblTotal.Text = "$" + (1600 + 1200);
            }
            else if (rbtnPikeHall.Checked && rbtnUnlimited.Checked)
            {
                totalForm.lblTotal.Text = "$" + (1600 + 1700);
            }
            else if (rbtnFarthingHall.Checked && rbtn7meals.Checked) 
            {
                totalForm.lblTotal.Text = "$" + (1800 + 600);
            }
            else if (rbtnFarthingHall.Checked && rbtn14meals.Checked)
            {
                totalForm.lblTotal.Text = "$" + (1800 + 1200);
            }
            else if (rbtnFarthingHall.Checked && rbtnUnlimited.Checked)
            {
                totalForm.lblTotal.Text = "$" + (1800 + 1700);
            }
            else if (rbtnUnivSuites.Checked && rbtn7meals.Checked)
            {
                totalForm.lblTotal.Text = "$" + (2500 + 600);
            }
            else if (rbtnUnivSuites.Checked && rbtn14meals.Checked)
            {
                totalForm.lblTotal.Text = "$" + (2500 + 1200);
            }
            else if (rbtnUnivSuites.Checked && rbtnUnlimited.Checked)
            {
                 totalForm.lblTotal.Text = "$" + (2500 + 1700);
            }



            //Display the TotalChargesForm.
            totalForm.ShowDialog();
                
        }

        // method for exit button click. 
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }
    }
}
