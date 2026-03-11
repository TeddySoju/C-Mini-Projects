using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinearAlgebraGUI
{
    /// <summary>
    /// This program is designed to calculate the net profit or loss or an item.
    /// Author: Teddy Sun
    /// Last Edited: 11/03/2026
    /// </summary>
    public partial class LinearAlgebraGUI : Form
    {
        //Declare Constants
        const int MIN = 0;
       
        public LinearAlgebraGUI()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //Declare Variables
           double netIncome;

            //Input Validation
            if (int.TryParse(textBoxAmount.Text, out int amount) && (double.TryParse(textBoxSalePrice.Text, out double pricePerUnit) && (double.TryParse(textBoxExpense.Text, out double expense))))
            {
                //continues after confirming that amount can not be below 0 
                if (amount >= MIN)
                {
                    // calculates net income
                    netIncome = pricePerUnit * amount - expense;
                    //displays net profit
                    if (netIncome > 0)
                    {
                        listBox1.Items.Add("Net Profit: " + netIncome.ToString("C"));
                    }
                    //displays net loss
                    else if (netIncome < 0)
                    {
                        listBox1.Items.Add("Net Loss: " + netIncome.ToString("C"));
                    }
                    //displays break even
                    else if (netIncome == 0)
                    {
                        listBox1.Items.Add("Break Even: " + netIncome.ToString("C"));
                    }
                    //clears textboxes and focuses on amount textbox for next calculation
                    textBoxAmount.Clear();
                    textBoxSalePrice.Clear();
                    textBoxExpense.Clear();
                    textBoxAmount.Focus();
                }
                else
                {   //error message if amount is below 0
                    MessageBox.Show("Please verify that the amount sold is greater than or equal to 0.");
                }
            }
            else
            {   //error message if input is not a number
                MessageBox.Show("Please verify wheter you have inputed the correct information.");
            }
         
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //clears listbox and textboxes and focuses on amount textbox for next calculation
            listBox1.Items.Clear();
            textBoxAmount.Clear();
            textBoxSalePrice.Clear();
            textBoxExpense.Clear();
            textBoxAmount.Focus();
        }
    }
}
