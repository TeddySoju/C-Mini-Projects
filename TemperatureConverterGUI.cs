using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverterGUI
{
    /// <summary>
    /// This program is used to test my knowledge on how methods work, and is used to calculate the users inputed measurement into either a Fahrenheit or a Celsius. It then outputs it back to them via a listbox with the new conversion and the previous converstion.
    /// Author: Teddy Sun
    /// Last modified: 21/3/2026
    /// </summary>
    public partial class Form1 : Form
    {
        //Declare Constants
        const int ROUNDING_PLACES = 2;  
        public Form1()
        {
            InitializeComponent();
        }
        //Declare Methods
       
        /// <summary>
        /// Converts a temperature from degrees Celsius to degrees Fahrenheit.
        /// </summary>
        /// <param name="celsius">The temperature value in degrees Celsius to convert.</param>
        /// <returns>The equivalent temperature in degrees Fahrenheit.</returns>
        private double CelsiusToFahrenheit(double celsius)
        {
            //Celsius to Fahrenheit formula: (C * 9 / 5) + 32
            return (celsius * 9 / 5) + 32;
        }
        /// <summary>
        /// Converts a temperature from degrees Fahrenheit to degrees Celsius.
        /// </summary>
        /// <param name="fahrenheit">The temperature value in degrees Fahrenheit to convert.</param>
        /// <returns>The equivalent temperature in degrees Celsius.</returns>
        private double FahrenheitToCelsius(double fahrenheit)
        {
            //Fahrenheit to Celsius formula: (F - 32) * 5 / 9
            return (fahrenheit - 32) * 5 / 9;
        }
        private void buttonFahrenheit_Click(object sender, EventArgs e)
        {
            //Declare Variables
            double originalTemp;
            //Try to parse the text in the textbox as a double to calculate into Fahrenheit, and parses the original input temperature as a double to display
            if (double.TryParse(textBox1.Text, out double fah))
            {
                //Saves the original temperature input into fah to display to the user later
                originalTemp = fah;
                //Call the method to convert Celsius to Fahrenheit and store the result in the fah variable
                fah = CelsiusToFahrenheit(fah);

                //Add the original temperature and the converted temperature to the listbox, rounding the converted temperature to 2 decimal places
                listBox1.Items.Add($"{originalTemp}°C converted to Fahrenheit is {Math.Round(fah, ROUNDING_PLACES)}°F");
            }
            else
            {
                //Shows an error message
                MessageBox.Show("Please enter a valid number for Celsius, E.g. 12.3");
            }
            //Clears the textbox and sets the focus back to the textbox
            textBox1.Clear();
            textBox1.Focus();
        }
        private void buttonCelsius_Click(object sender, EventArgs e)
        {
            //Declare Variables
            double originalTemp;
            //Try to parse the text in the textbox as a double to calculate into Celsius, and parses the original input temperature as a double to display
            if (double.TryParse(textBox1.Text, out double cel))
            {
                //Saves the original temperature input into cel to display to the user later
                originalTemp = cel;
                //Call the method to convert Fahrenheit to Celsius and store the result in the cel variable
                cel = FahrenheitToCelsius(cel);

                //Add the original temperature and the converted temperature to the listbox, rounding the converted temperature to 2 decimal places
                listBox1.Items.Add($"{originalTemp}°F converted to Celsius is {Math.Round(cel, ROUNDING_PLACES)}°C");
            }
            else
            {
                //Shows an error message
                MessageBox.Show("Please enter a valid number for Fahrenheit, E.g. 12.3");
            }
            //Clears the textbox and sets the focus back to the textbox
            textBox1.Clear();
            textBox1.Focus();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clears the listbox and textbox, then sets the focus back to the textbox
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
