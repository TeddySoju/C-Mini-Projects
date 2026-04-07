using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeTracker
{
    /// <summary>
    /// This program will take the students name and grade then add it to a list. Afterwards it will display the students name seperately with their initial 
    /// grade/ if they passed or failed, sorted from highest grade to lowest grade. It will also display the average grade, highest grade, and lowest grade 
    /// of the students in the list. 
    /// Author: Teddy Sun
    /// Last Modified: 7/04/2026
    /// </summary>
    public partial class StudentGradeTracker : Form
    {
        //Declare Collections
        new List<string> studentNames = new List<string>();
        new List<double> studentGrades = new List<double>();
        //Declare constants
        const int MAX_GRADE = 100;
        const int MIN_GRADE = 0;
        const int PASSING_GRADE = 50;
        public StudentGradeTracker()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Simple method to display the items into the listbox easier and cleaner
        /// </summary>
        /// <param name="display"></param>
        private void display(string display)
        {
            listBoxOutput.Items.Add(display);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Checks if the user input is valid, including if the grade is a number between MIN and MAX and if the student name is not empty
            if (double.TryParse(textBoxGrade.Text, out double grade) && grade >= MIN_GRADE && grade <= MAX_GRADE && textBoxStudent.Text != "")
            {
                //adds the students grade and names to their lists
                studentGrades.Add(grade);
                studentNames.Add(textBoxStudent.Text);
                //Clears the textboxes and focuses the cursor on the student name textbox
                textBoxGrade.Clear();
                textBoxStudent.Clear();
                textBoxStudent.Focus();
            }
            else
            {
                //Display relevant error message if the user input is invalid
                MessageBox.Show($"Please enter a valid student name and grade ({MIN_GRADE}-{MAX_GRADE}).");
            } 
        }
        /// <summary>
        /// Displays the acutal results into a listbox, including the students name,
        /// grade, average grade, highest grade, and lowest grade. It also shows the 
        /// relevant error message if there are no students in the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            //checks if there is atleast one item within the list
            if (studentGrades.Count != 0)
            {
                //displays the studen with their grade
                display("--------STUDENT RESULTS--------");
                for (int i = 0; i < studentGrades.Count; i++)
                {
                    //checks if the students grade is above or equal to the passing grade
                    if (studentGrades[i] >= PASSING_GRADE)
                    {
                        //displays the students name, grade, and passed status
                        display($"{studentNames[i]}: {studentGrades[i]} PASSED");
                    }
                    else
                    {
                        //displays the students name, grade, and failed status
                        display($"{studentNames[i]}: {studentGrades[i]} FAILED");
                    }
                }
                //displays the average grade, highest grade, and lowest grade of the students in the list
                display("-------------------------------");
                display($"AVERAGE: {Math.Round(studentGrades.Average(), 2)}");
                display($"HIGHEST: {studentGrades.Max()}");
                display($"LOWEST: {studentGrades.Min()}");
            }
            else
            {
                //Shows the relevant error message if there are no students in the list
                MessageBox.Show("No students in the list. Please add students before displaying."); 
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clears the collections, listbox, textboxes, and focuses the cursor on the student name textbox
            listBoxOutput.Items.Clear();
            textBoxGrade.Clear();
            textBoxStudent.Clear();
            textBoxStudent.Focus();
            studentGrades.Clear();
            studentNames.Clear();
        }
    }
}
