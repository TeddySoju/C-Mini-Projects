using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestedLoop
{
    /// <summary>
    /// This progam will display a simple 3x3 table/grid of numbers. 
    /// Author: Teddy Sun
    /// Last Modified: 14/03/26
    /// </summary>
    public partial class SimpleGrid : Form
    {
        //Declare Array
        int[] num = { 1,2,3,4,5,6,7,8,9};
        public SimpleGrid()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Generates the table/grid of numbers using a nested loop.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGenerate_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < 3; i++)        // each row
            {
                string rowText = "";
                for (int j = 0; j < 3; j++)    // each column
                {
                    rowText += num[i * 3 + j]; // add the number to rowText
                }
                // add rowText to listbox
                listBoxTable.Items.Add(rowText);
            }
        }
    }
}
