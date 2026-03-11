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
    /// This program is designed to calculate the net profit or loss or an item
    /// </summary>
    public partial class Form1 : Form
    {
        //Declare Constants
        const int MIN = 0;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //Declare Variables
           double netIncome;

            if (int.TryParse(textBoxAmount.Text, out int amount) && (double.TryParse(textBoxSalePrice.Text, out double pricePerUnit) && (double.TryParse(textBoxExpense.Text, out double expense))))
            {
                if (amount >= MIN)
                {
                    netIncome = pricePerUnit * amount - expense;
                    if (netIncome > 0)
                    {
                        listBox1.Items.Add("Net Profit: " + netIncome.ToString("C"));
                    }
                    else if (netIncome < 0)
                    {
                        listBox1.Items.Add("Net Loss: " + netIncome.ToString("C"));
                    }
                    else if (netIncome == 0)
                    {
                        listBox1.Items.Add("Break Even: " + netIncome.ToString("C"));
                    }
                    textBoxAmount.Clear();
                    textBoxSalePrice.Clear();
                    textBoxExpense.Clear();
                    textBoxAmount.Focus();
                }
                else
                {
                    MessageBox.Show("Please verify that the amount sold is greater than or equal to 0.");
                }
            }
            else
            {
                MessageBox.Show("Please verify wheter you have inputed the correct information.");
            }
         
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBoxAmount.Clear();
            textBoxSalePrice.Clear();
            textBoxExpense.Clear();
            textBoxAmount.Focus();
        }
    }
}
