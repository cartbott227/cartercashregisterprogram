using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

//Program created by Carter Bott
//on October 11th, 2016
//to complete the chash register summative.

namespace cartercashregisterprogram
{
    public partial class mcdonaldsForm : Form
    {
        const double BURGER = 2.49; //Declares the cost of all the menu items and the tax percentage 
        const double FRIES = 1.89;
        const double SODA = 0.99;
        const double ICECREAM = 1.29;
        const double TAX = 1.13;

        double totalcost;           //Creates variables to hold the amount of items bought and makes the
        int burgercost;             //total cost a double
        int friescost;
        int sodacost;
        int icecreamcost;

        double tender;             //Declares tender, change, tax amount and sub total as doubles
        double change;
        double taxAmount;
        double subtotal;
         
        public mcdonaldsForm()
        {
            InitializeComponent();

            subtotalCalc.Visible = false;   //Makes all calculations invisible
            taxCalc.Visible = false;
            totalCalc.Visible = false;
            changeCalc.Visible = false;
        }

        private void totalButton_Click(object sender, EventArgs e)
        { 
            burgercost = Convert.ToInt16(burgertextBox.Text);   //Declares the varibles for holding the amount of
            friescost = Convert.ToInt16(friestextBox.Text);     //food items selected
            sodacost = Convert.ToInt16(sodatextBox.Text);
            icecreamcost = Convert.ToInt16(icecreamtextBox.Text);

            subtotal = BURGER * burgercost + FRIES * friescost + SODA * //Variable to calculate the sub total of the order
            sodacost + icecreamcost * ICECREAM;                         

            taxAmount = subtotal * TAX - subtotal;  //Variable to calculate tax
                                                    
            totalcost = subtotal + taxAmount;   //Variable to calculate the total cost

            subtotalCalc.Text = subtotal.ToString("C"); //Converts the calculation to a string (int to string)
            subtotalCalc.Visible = true;                //and makes the label visible

            taxCalc.Text = taxAmount.ToString("C"); //Converts the calculation to a string (int to string)
            taxCalc.Visible = true;                 //and makes the label visible     

            totalCalc.Text = totalcost.ToString("C");   //Converts the calculation to a string (int to string)
            totalCalc.Visible = true;                   //and makes the label visible

        }

        private void payButton_Click(object sender, EventArgs e)
        {      
            tender = Convert.ToDouble(payBox.Text); //Creates a variabe to hold the amount of tender and converts it to a number
            change = tender - totalcost;            //Calculates change

            if (tender < totalcost) //Displays error message in tender is insufficient
            {
                changeCalc.Text = ("Insufficient tender.");
                changeCalc.Visible = true;
            }
            else
            {
                changeCalc.Text = change.ToString("C");
                changeCalc.Visible = true;

                SoundPlayer cashPlayer = new SoundPlayer(Properties.Resources.chaching); //Creates a player to store the sound and
                cashPlayer.Play();                                                       //and plays the sound
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            //prints receipt
        }

        private void neworderButton_Click(object sender, EventArgs e)
        {
            subtotalCalc.Visible = false;
            taxCalc.Visible = false;
            totalCalc.Visible = false;
            changeCalc.Visible = false;

            subtotalCalc.Text = "";
            taxCalc.Text = "";
            totalCalc.Text = "";
            changeCalc.Text = "";

            burgertextBox.Text = "";
            friestextBox.Text = "";
            sodatextBox.Text = "";
            icecreamtextBox.Text = "";
            payBox.Text = "";
        }
    }
}
