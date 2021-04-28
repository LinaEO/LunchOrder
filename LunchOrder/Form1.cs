using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    /* 
     * Lunch Order App
     * Author: Lina Orozco
     * When: April 2021
     */

    public partial class Form1 : Form
    {
        //Constants
        const decimal BURGER = 6.95m;
        const decimal PIZZA = 5.95m;
        const decimal SALAD = 4.95m;
        const decimal BURGERITEM = 0.75m;
        const decimal PIZZAITEM = 0.50m;
        const decimal SALADITEM = 0.25m;
        const decimal TAX = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }
        //Exit Terminates the application 
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Reset all controls to starting state
        private void btnReset_Click(object sender, EventArgs e)
        {
            lblSubtotal.Text = ""; 
            lblTax.Text = "";
            lblTotal.Text = "";
            radHamburger.Checked = true;
            radPizza.Checked = false;
            radSalad.Checked = false;
            chkItem1.Checked = false;
            chkItem2.Checked = false;
            chkItem3.Checked = false;
            
        }
        //Customer select Hamburger change Add-on Items and Picture
        private void radHamburger_CheckedChanged(object sender, EventArgs e)
        {
            gbAddOn.Text = "Add-on items ($.75/each)";
            chkItem1.Text = "Lettuce, Tomato, and Onions";
            chkItem2.Text = "Ketchup, Mustard, and Mayo";
            chkItem3.Text = "French Fries";
            picLunch.Image = Image.FromFile(@"..\..\Images\burger.jpg");
        }
        //Customer select Pizza change Add-on Items and Picture
        private void radPizza_CheckedChanged(object sender, EventArgs e)
        {
            gbAddOn.Text = "Add-on items ($.50/each)";
            chkItem1.Text = "Pepperoni";
            chkItem2.Text = "Sausage";
            chkItem3.Text = "Olives";
            picLunch.Image = Image.FromFile(@"..\..\Images\pizza.jpg");
        }
        //Customer select Salad change Add-on Items and Picture
        private void radSalad_CheckedChanged(object sender, EventArgs e)
        {
            gbAddOn.Text = "Add-on items ($.25/each)";
            chkItem1.Text = "Croutons";
            chkItem2.Text = "Bacon bits";
            chkItem3.Text = "Bread sticks";
            picLunch.Image = Image.FromFile(@"..\..\Images\salad.jpg");
        }
        //Place order and calculate amount to pay
        private void btnOrder_Click(object sender, EventArgs e)
        {
            //variables
            decimal subtotal; //purchase
            decimal tax; //tax 5%
            decimal total; //total amount to pay

            //Evaluate lunch choosen by customer and calculate subtotal
            if (radHamburger.Checked) //Burger is selected
            {
                subtotal = CalculateSubtotal(BURGER, BURGERITEM);
            }
            else if (radPizza.Checked)//Pizza is selected
            {
                subtotal = CalculateSubtotal(PIZZA, PIZZAITEM);
            }
            else //Salad and add-on items selected
            {
                subtotal = CalculateSubtotal(SALAD, SALADITEM);
            }

            //Calculate tax and Total
            CalculateTaxAndTotal(subtotal, out tax, out total);

            //Display totals
            lblSubtotal.Text = subtotal.ToString("c");
            lblTax.Text = tax.ToString("c");
            lblTotal.Text = total.ToString("c");


        }
        //method to calculate tax and total
        public static void CalculateTaxAndTotal(decimal subtotal, out decimal tax, out decimal total)
        {
            tax = subtotal * TAX;
            total = subtotal + tax;
        }
        //method to calculate subtotal
        public decimal CalculateSubtotal(decimal lunch,decimal item)
        {
            decimal subtotal = lunch;
            if (chkItem1.Checked)
                subtotal += item;
            if (chkItem2.Checked)
                subtotal += item;
            if (chkItem3.Checked)
                subtotal += item;
            return subtotal;
        }
    }
}
