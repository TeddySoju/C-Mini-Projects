using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BogoGUI
{
    /// <summary>
    /// This program allows the user to calculate their BOGO, Buy One Get One ___, through taking the user's two prices, and determining which one is lower. After, it calculates the percentage discount provided by the user, then it outputs both prices and the total combined
    /// Author: Teddy Sun
    /// Last Modified:20/03/26
    /// </summary>
    public partial class Form1 : Form
    {
        //Declare Constants
        const int MAX_DISCOUNT = 100;
        const int MIN_DISCOUNT = 1;
        const int MIN_COST = 0;
        //Used to convert a percentage (e.g. 50) into a decimal (e.g. 0.5) by dividing
        const int PERCENTAGE = 100;
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            //Declare variables
            decimal cost1, cost2, finalPrice, totalCost;
            double discount, discountTotal;

            //Turns inputs from text boxes into variables, whilst ensuring that the inputs are reasonable. For instance, cost's cannot be below 0, and how  discount has to be between 1% or  100%
            if (decimal.TryParse(textBox1.Text, out cost1) && decimal.TryParse(textBox2.Text, out cost2) && double.TryParse(textBoxDiscount.Text, out discount) && cost1>MIN_COST &&cost2>MIN_COST&&discount>=MIN_DISCOUNT&&discount<=MAX_DISCOUNT)
            {
                //converts discount to decimals
                discountTotal = discount / PERCENTAGE;

                //If item one's cost is lower or equal to item two's cost
                if (cost1 <= cost2)
                {
                    //Calculates discounted price by multiplying initial cost with discount, then finding the difference between initial price.
                    finalPrice = cost1 - (cost1 * (decimal)discountTotal);
                    //Outputs the calculation of discounted item
                    listBox1.Items.Add($"Discounted Item: {finalPrice.ToString("C")}");
                    //Outputs the calculation of non-discounted item
                    listBox1.Items.Add($"Full Price Item: {cost2.ToString("C")}");

                    //calculates final cost of both items, then outputs it
                    totalCost = finalPrice + cost2;
                    listBox1.Items.Add($"Total Cost: {totalCost.ToString("C")}");
                }
                //if item two's cost is lower than item one's cost
                else 
                {
                    //Calculates discounted price by multiplying initial cost with discount, then finding the difference between initial price.
                    finalPrice = cost2 - (cost2 * (decimal)discountTotal);
                    //Outputs the calculation of discounted item
                    listBox1.Items.Add($"Discounted Item: {finalPrice.ToString("C")}");
                    //Outputs the calculation of non-discounted item
                    listBox1.Items.Add($"Full Price Item: {cost1.ToString("C")}");

                    //calculates final cost of both items, then outputs it
                    totalCost = finalPrice + cost1;
                    listBox1.Items.Add($"Total Cost: {totalCost.ToString("C")}");
                }
                //Clears the input boxes, allowing the user to input more items
                textBox1.Clear();
                textBox2.Clear();
                textBoxDiscount.Clear();
                textBox1.Focus();
            }
            else
            {
                //Shows error message
                MessageBox.Show($"Please ensure that costs are not below {MIN_COST}, and that discounts are between {MIN_DISCOUNT}% to {MAX_DISCOUNT}%.");
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clears both input and output boxes, fully clearing everything for the user
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBoxDiscount.Clear();
            textBox1.Focus();
        }
    }
}
