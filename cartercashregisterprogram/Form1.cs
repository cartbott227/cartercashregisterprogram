﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Program created by Carter Bott
//on October 11th, 2016
//to complete the chash register summative.

namespace cartercashregisterprogram
{
    public partial class mcdonaldsForm : Form
    {
        const double BURGER = 2.49;
        const double FRIES = 1.89;
        const double SODA = 0.99;
        const double ICECREAM = 1.29;
        const double TAX = 1.13;
        double totalcost;
        int burgercost;
        int friescost;
        int sodacost;
        int icecreamcost;
      

        public mcdonaldsForm()
        {
            InitializeComponent();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            burgercost = Convert.ToInt16(burgertextBox.Text);
            friescost = Convert.ToInt16(friestextBox.Text);
            sodacost = Convert.ToInt16(sodatextBox.Text);
            icecreamcost = Convert.ToInt16(icecreamtextBox.Text);
            totalcost = BURGER * burgercost + FRIES * friescost + SODA * sodacost + icecreamcost * ICECREAM * TAX;

        }
    }
}