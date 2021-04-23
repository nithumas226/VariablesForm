using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablesForm
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonHockey_Click(object sender, EventArgs e)
        {
            string playerName = "Wayne Gretzky";
            int playerNumber = 99;
            outputLabel1.Text = $"{playerName} is number {playerNumber}.";
        }

        private void buttonArea_Click(object sender, EventArgs e)
        {
            double radius = 15;
            double pi = 3.14;
            double area = radius * radius * pi;

            outputLabel1.Text = $"The area of circle with radius of {radius}cm is {area} cm^2.";
        }

        private void buttonCarpet_Click(object sender, EventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = length * width;
            double totalCost = area * costPerMeter;

            outputLabel1.Text = $"The area of a room with dimensions {length}m x {width}m is {area}m^2.";
            outputLabel1.Text += $"\n\nThe cost to carpet this area at {costPerMeter} per square meter is ${totalCost}."; 

        }

        private void buttonBill_Click(object sender, EventArgs e)
        {
            double shirtCost = 12.49;
            double tenderedCost = 20.00;
            double taxRate = 0.13;
            double taxAmount = shirtCost * taxRate;
            double totalCost = shirtCost + taxAmount;
            double changeCost = tenderedCost - totalCost;

            outputLabel1.Text = $"Bill of Sale";
            outputLabel1.Text += $"\n\nShirt:                 {shirtCost}";
            outputLabel1.Text += $"\n\nTax:                   {taxAmount}";
            outputLabel1.Text += $"\nTotal:                {totalCost}";
            outputLabel1.Text += $"\n\nTendered:       {tenderedCost}";
            outputLabel1.Text += $"\nChange:           {changeCost}";

        }
    }
}
