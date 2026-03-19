using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMyNumberGUI
{
    /// <summary>
    /// This program is designed to generate a random number between 1 and 100, and allow the user to guess the number,
    /// It will then provide the user with feedback on whether their guess is too high, or too low. 
    /// Whilst keeping track of how many guesses the user has made, and providing the user with the option to reset the game and start again.
    /// Author: Teddy Sun
    /// Last Modified: 19/03/2026
    /// </summary>
    public partial class Form1 : Form
    {
        //Declare Random
        Random Rng = new Random();

        //Declare Constants
        const int MAX = 100, MIN=1;

        //Declare Variables
        int guess, number, count=0;

        public Form1()
        {
            InitializeComponent();
            number = Rng.Next(MIN, MAX);
        }

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //Reset game by generating new random number, clearing list box and text boxes, resetting count and enabling guess button
            number = Rng.Next(MIN, MAX);
            listBox1.Items.Clear();
             textBox1.Clear();
            textBox1.Focus();
            textBoxCount.Clear();
            count = 0;
            buttonGuess.Enabled = true;
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            //Validate input and ensure it is a number between 1 and 100
            if (int.TryParse(textBox1.Text, out int guess) && guess <= MAX && guess >= MIN)
            {
                //Increment count and update text box
                count++;
                textBoxCount.Text=("Number of Guesses: " + count);
                if (guess != number)
                {
                    //Provide feedback to user on whether their guess is too high or too low
                    if (guess < number)
                    {
                        listBox1.Items.Add($"{guess} is too low");
                    }
                    else if (guess > number)
                    {
                        listBox1.Items.Add($"{guess} is too high");
                    }

                }
                else
                {
                    //Provide feedback to user on correct guess and disable guess button
                    listBox1.Items.Add($"{guess} is correct! You guessed in {count} guesses!");
                    buttonGuess.Enabled = false;

                }
                //Clear text box and set focus for next guess
                textBox1.Focus();
                textBox1.Clear();
            }
            else
            {
                //Provide feedback to user on invalid input
                MessageBox.Show("Please enter a number between 1 and 100");
            }

     

            
        }
    }
}
