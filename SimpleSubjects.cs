using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSubjectRotatorGUI
{
    /// <summary>
    /// This program will display a simple GUI that allows the user to add subjects to a list and display them.
    /// Author: Teddy Sun
    /// Last Modified:14/03/26
    /// </summary>
    public partial class Form1 : Form
    {
        //Declare Arrays
        string[] days = {"Monday:", "Tuesday:", "Wednesday:", "Thursday:", "Friday:" };

        //Declare Lists
        List<string> subjects = new List<string>();

        //Declare Constants
        const int MAX_SUBJECTS = 5;

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This button will add the users subjects into the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Checks if the user has reached the maximum number of subjects before adding the subject to the list.
            if (subjects.Count < MAX_SUBJECTS && textBox1.Text != "")
            {
                //Adds the subject to the list and clears the textbox for the next subject.
                subjects.Add(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
            }
            else if (subjects.Count == MAX_SUBJECTS)
            {
                //Showcases an error message if the user has reached the maximum number of subjects.
                MessageBox.Show($"You have reached the maximum number of subjects of {MAX_SUBJECTS}.");
            }
            else 
            {
                //Showcases an error message if the user has not entered anything in the textbox.
                MessageBox.Show("Please ensure that the input box is not empty.");
            }
          


        }
        /// <summary>
        /// This button will generate the days with the subjects from first to last and display them in the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            //Checks if the user has reached the maximum number of subjects before generating the schedule.
            if (subjects.Count == MAX_SUBJECTS)
            {
                //For every subject in the list, it will add the day and subject.
                for (int i = 0; i < subjects.Count; i++)
                {
                    //The PadRight method is used to align the subjects in the listbox. 
                    listBox1.Items.Add(days[i].PadRight(15) + subjects[i]);
                }
            }
            else
            {
                //Showcases an error message if the user has not reached the maximum number of subjects.
                MessageBox.Show($"Please add {MAX_SUBJECTS - subjects.Count} more subjects before generating the schedule.");
            }
        }
        /// This button will clear the listbox and the list of subjects.
        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            subjects.Clear();
            textBox1.Focus();
            textBox1.Clear();
        }
    }
}
