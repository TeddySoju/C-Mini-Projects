using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodsGUI
{
    /// <summary>
    /// This program will check if the integer inputed is even or odd, if even it will become true, if odd it will become false. Afterwards it will take these outputs and then display it to the user.
    /// Author: Teddy Sun
    /// Last Modified: 21/03/2026
    /// Note: This was a simple program for me to practice using methods, Thank you. 
    /// </summary>
    public partial class SimpleMethods : Form
    {
        public SimpleMethods()
        {
            InitializeComponent();
        }
        //This method will check if the number is even or odd, if even it will return true, if odd it will return false.
        private bool IsEven (int number)
        {
            return number%2== 0;       
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            //Converts the textbox input into an integer, and calcultes whether it is an even or odd number. 
            if (int.TryParse(textBox1.Text, out int number))
            {
                //If the number is even, it displays even
                if (IsEven(number))
                {
                    listBox1.Items.Add($"{number} is an even number");
                }
                //or else it displays that it is odd
                else
                {
                    listBox1.Items.Add($"{number} is an odd number");
                }
            }
            else
            {
                //Shows an error message to the user.
                MessageBox.Show("Please enter a valid integer.");
            }
            //Clears the textbox for the user to input a new number.
            textBox1.Clear();
            textBox1.Focus();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clears the listbox and the textbox for the user to input a new number.
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
