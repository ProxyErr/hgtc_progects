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

namespace Baker_exam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //CHRISTOPHER V BAKER
            //EXAM 2
            //NOVEMBER-15-2021

            InitializeComponent();

            //ENABLE BUTTONS. 
            btnProd1.Enabled = true;
            btnProd2.Enabled = true;
            btnProd3.Enabled = true;
            btnProd4.Enabled = true;
            btnProd5.Enabled = true;
            btnCalc.Enabled = true;

            //TO CLICK & DRAG GUI..
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //DECLARE TOTAL VARIABLE.
        double cartTotal = 0;
        double taxTotal = 0;

        //QTY COUNT VARIABLES. 
        int prod1Qty = 10;
        int prod2Qty = 10;
        int prod3Qty = 10;
        int prod4Qty = 10;
        int prod5Qty = 10;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //PRODUCT ONE BUTTON: INSTANTIATES AND STORES TOTAL. 
        private void btnProd1_Click(object sender, EventArgs e)
        {
            //Decrease Qty count.
            prod1Qty--;

            //Instantiate an object of the type theProduct
            theProducts prod1 = new theProducts();

            //Information for product.
            prod1.Name = "Titleist Pro V1";
            prod1.Descr = "The Best";
            prod1.Price = 100;
            prod1.Qty = prod1Qty;

            //If statment to make sure count is not 0. 
            if (prod1Qty != 0)
            {

                //Display information of product.
                lstBoxDisplay.Items.Add("Name: " + prod1.Name);
                lstBoxDisplay.Items.Add("Description: " + prod1.Descr);
                lstBoxDisplay.Items.Add("Price: $" + prod1.Price);
                lstBoxDisplay.Items.Add("....................");

                //Display Qty count.
                lblQtyProd1.Text =  prod1.Qty.ToString();

                //Add total amount to cartTotal. 
                cartTotal += prod1.Price;
                            
            }
            //else count is below 0 and disable button.
            else 
            {
                btnProd1.Enabled = false;
                lblQtyProd1.Text = 0.ToString();

            }
        }
        //PRODUCT TWO BUTTON: INSTANTIATES AND STORES TOTAL. 
        private void btnProd2_Click(object sender, EventArgs e)
        {
            //Decrease Qty count.
            prod2Qty--;

            //Instantiate an object of the type theProduct
            theProducts prod2 = new theProducts();

            //Information for product.
            prod2.Name = "Mizuno RB 566V";
            prod2.Descr = "2nd Best";
            prod2.Price = 85;
            prod2.Qty = prod2Qty;

            //If statment to make sure count is not 0.
            if (prod2Qty != 0)
            {
                //Display information of product.
                lstBoxDisplay.Items.Add("Name: " + prod2.Name);
                lstBoxDisplay.Items.Add("Description: " + prod2.Descr);
                lstBoxDisplay.Items.Add("Price: $" + prod2.Price);
                lstBoxDisplay.Items.Add("....................");


                //Display Qty count.
                lblQtyProd2.Text = prod2.Qty.ToString();

                //Display Qty count.
                cartTotal += prod2.Price;

            }
            //else count is below 0 and disable button.
            else
            {
                btnProd2.Enabled = false;
                lblQtyProd2.Text = 0.ToString();

            }
        }
        //PRODUCT THREE BUTTON: INSTANTIATES AND STORES TOTAL. 
        private void btnProd3_Click(object sender, EventArgs e)
        {
            //Decrease Qty count.
            prod3Qty--;
            //Instantiate an object of the type theProduct
            theProducts prod3 = new theProducts();

            //Information for product.
            prod3.Name = "Callaway Chrome Soft X";
            prod3.Descr = "3rd Best";
            prod3.Price = 65;
            prod3.Qty = prod3Qty;

            //If statment to make sure count is not 0.
            if (prod3Qty != 0)
            {
                //Display information of product.
                lstBoxDisplay.Items.Add("Name: " + prod3.Name);
                lstBoxDisplay.Items.Add("Description: " + prod3.Descr);
                lstBoxDisplay.Items.Add("Price: $" + prod3.Price);
                lstBoxDisplay.Items.Add("....................");


                //Display Qty count.
                lblQtyProd3.Text = prod3.Qty.ToString();

                //Display Qty count.
                cartTotal += prod3.Price;

            }
            //else count is below 0 and disable button.
            else
            {
                btnProd3.Enabled = false;
                lblQtyProd3.Text = 0.ToString();

            }
}
        //PRODUCT FOUR BUTTON: INSTANTIATES AND STORES TOTAL. 
        private void btnProd4_Click(object sender, EventArgs e)
        {
            //Decrease Qty count.
            prod4Qty--;
            //Instantiate an object of the type theProduct
            theProducts prod4 = new theProducts();

            //Information for product.
            prod4.Name = "Vice Pro Soft";
            prod4.Descr = "4th Best";
            prod4.Price = 45;
            prod4.Qty = prod4Qty;

            //If statment to make sure count is not 0.
            if (prod4Qty != 0)
            {
                //Display information of product.
                lstBoxDisplay.Items.Add("Name: " + prod4.Name);
                lstBoxDisplay.Items.Add("Description: " + prod4.Descr);
                lstBoxDisplay.Items.Add("Price: $" + prod4.Price);
                lstBoxDisplay.Items.Add("....................");


                //Display Qty count.
                lblQtyProd4.Text = prod4.Qty.ToString();

                //Display Qty count.
                cartTotal += prod4.Price;

            }
            //else count is below 0 and disable button.
            else
            {
                btnProd4.Enabled = false;
                lblQtyProd4.Text = 0.ToString();

            }
        }
        //PRODUCT FIVE BUTTON: INSTANTIATES AND STORES TOTAL. 
        private void btnProd5_Click(object sender, EventArgs e)
        {
            //Decrease Qty count.
            prod5Qty--;
            //Instantiate an object of the type theProduct
            theProducts prod5 = new theProducts();

            //Information for product.
            prod5.Name = "TaylorMade TP5X";
            prod5.Descr = "5th Best";
            prod5.Price = 25;
            prod5.Qty = prod5Qty;

            //If statment to make sure count is not 0.
            if (prod5Qty != 0)
            {


                lstBoxDisplay.Items.Add("Name: " + prod5.Name);
                lstBoxDisplay.Items.Add("Description: " + prod5.Descr);
                lstBoxDisplay.Items.Add("Price: $" + prod5.Price);
                lstBoxDisplay.Items.Add("....................");

                //Display Qty count.
                lblQtyProd5.Text = prod5.Qty.ToString();

                //Display Qty count.
                cartTotal += prod5.Price;

            }
            //else count is below 0 and disable button.
            else
            {
                btnProd5.Enabled = false;
                lblQtyProd5.Text = 0.ToString();

            }
}
        //CALCULATION BUTTON: CALCULATES TOTAL WITH 11% TAX. 
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Disabling all buttons. 
            btnProd1.Enabled = false;
            btnProd2.Enabled = false;
            btnProd3.Enabled = false;
            btnProd4.Enabled = false;
            btnProd5.Enabled = false;
            btnCalc.Enabled = false;


            //Display Subtotal...
            lstBoxTotal.Items.Add("Subtotal...." + cartTotal.ToString("c"));


            //Calculating tax amount. 
            taxTotal = cartTotal * .11;
            lstBoxTotal.Items.Add("Tax(11%).........." + taxTotal.ToString("c"));



            //Calculating total amount including taxes.
            cartTotal *= 1.11;
            lstBoxTotal.Items.Add("Total: $" + cartTotal);

            lstBoxTotal.Items.Add("Try Not To Lose Anymore! (つ◉益◉)つ");
        }
        //XIT BUTTON.
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //close program.
            this.Close();

        }

        //This snippet was taken off of stack flow
        //for design purposes clickable and draggable:CVB 11/15/2021
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        //END OF DESIGN SNIPPET- CVB 11/15/2021

    }
}
