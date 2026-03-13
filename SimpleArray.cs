using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraryLoopGUI
{
    /// <summary>
    /// This program will display 5 different fruits from a predefined array of fruits.
    /// Author: Teddy Sun
    /// Last Editied: 14/3/26
    /// </summary>
    public partial class Form1 : Form
    {
        //Declare Arrarys
        string[] fruits = { "Apple", "Banana", "Orange", "Grape", "Mango" };
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Generates the arrays of fruits and displays them in the list box when the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            //Loops through the array until number of fruits is reached.
            for (int i = 0; i < fruits.Length; i++) 
            {
                //adds the current fruit to the list box.
                listBox1.Items.Add(fruits[i]);
            }
        }
        /// <summary>
        /// Clears the listbox, so that it can be generated again without the previous fruits in the list box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clears the list box.
            listBox1.Items.Clear();
        }
    }
}
