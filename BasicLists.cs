using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicListGUI
{
    /// <summary>
    /// This program will take the users input of names, max of 5 and display it back to them in the listbox.
    /// Author: Teddy Sun
    /// Last edited: 
    /// </summary>
    public partial class BasicLists : Form
    {
        //Declare Lists
        List<string> names = new List<string>();

        //Declare Constants
        const int MAX_NAMES = 5;
        public BasicLists()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This generates the list of names into the listbox if the user has reached the max number of names.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (names.Count == MAX_NAMES)
            {
                for (int i = 0; i < MAX_NAMES; i++)
                {
                    listBox1.Items.Add(names[i]);
                }
                textBoxGenerate.Clear();
                textBoxGenerate.Focus();
            }
            else
            {
                //Shows an error message, indicating to the user that they have not reached the max number of names.
                MessageBox.Show($"Please input {MAX_NAMES - names.Count} more names.");
            }

        }
        /// <summary>
        /// This adds names to the list until the user has reached the max number of names.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (names.Count < MAX_NAMES)
            {
                names.Add(textBoxGenerate.Text);
                textBoxGenerate.Clear(); 
                textBoxGenerate.Focus();
            }
            else
            {
                //Shows an error message, indicating to the user that they have reached the max number of names.
                MessageBox.Show($"You have reached the maximum number of names which is {MAX_NAMES}.");
            }
        }
        /// <summary>
        /// Clears all the names in the list and the listbox, allowing the user to start over with a new set of names.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            names.Clear();
            listBox1.Items.Clear();
            textBoxGenerate.Clear();
            textBoxGenerate.Focus();
        }
    }
}
