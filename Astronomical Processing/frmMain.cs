using System;
using System.Collections;
using System.Windows.Forms;

#region Info
//  Alice & Jack, The Team, Sprint 2
//  Git Branch: main
//  Date: 11/11/2023
//  Version: v2.0
//  Astronomical Processing
//  Simple data search and sort program
// 
//  Inputs:
//  - Textbox requires user string input
//  - Textbox displaying 
//  - Edit button
//  - Binary Search Button
//  - Linear Search Button
//  - Bubble Sort Button
//  - Listbox row selection
//
//  - A button to calculate the mid-extreme (mean)
//  - A button to calculate the mode 
//  - A button to calculate the average (median)
//  - A button to calculate the range 
//  - ToolTips
//
//  Processes:
//  - InitializeDataArray: Fills the global array between 10 and 99 (Also updates the listbox)
//  - btnBinarySearch_Click: Searches for the entered text in the TextBox within the GlobalArray
//  - btnLinearSearch_Click: Perfoms a sequential search
//  - btnMean_Click: Calculates the mid-extreme
//  - btnMode_Click: Calculates the mode
//  - btnMedian_Click: Calculates the average
//  - btnRange_Click: Calculates the range
//  - btnSort_Click: Performs a bubble sort on the GlobalArray (Also updates the listbox)
//  - btnEdit_Click: Allows the user to edit the selected index (Also updates the listbox)
//  
//  Outputs:
//  - Sort button bubble sorts data in list and updates list.
//  - Error messagebox if textbox == null.
//  - Error messagebox if textbox string was not found.
//  - Success messagebox if textbox string was found.
//  - Allows user to edit selected index
//  - Displays results in textBox
//  - Displays toolTips
#endregion

namespace Astronomical_Processing
{
    public partial class frmMain : Form
    {
        // Globals
        const int GlobalLength = 24; // Global constant - Seeing as that is all we are going to use for now, there is no point in calling array.length
        int[] GlobalArray = new int[GlobalLength];

        public frmMain()
        {
            InitializeComponent();
            InitializeDataArray();
        }

        #region Initialization
        private void InitializeDataArray()
        {
            Random r = new Random();    // initialise random
            for (int i = 0; i < GlobalLength; i++)
            {
                int rInt = r.Next(10, 99);  // lower, higher
                GlobalArray[i] = rInt;      // set values to index in array
            }
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            // Converts all the ints in the GlobalArray to a string data type purely for the list box 
            string[] stringArray = Array.ConvertAll(GlobalArray, x => x.ToString());

            listBox.Items.Clear();
            listBox.Items.AddRange(stringArray);
        }
        #endregion

        #region Event Handlers

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                textBox.Text = listBox.SelectedItem.ToString();
            }
        }

        // Alice integrated BSearch algorithm to Search Button
        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            int searchValue;
            if (int.TryParse(textBox.Text, out searchValue))
            {
                int left = 0;
                int right = GlobalLength - 1;

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;

                    if (GlobalArray[mid] == searchValue)
                    {
                        MessageBox.Show($"Value found at index {mid}.");
                        return; // Exit the method if the value is found
                    }

                    if (GlobalArray[mid] < searchValue)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }

                MessageBox.Show("Value not found.");
            }

            else
            {
                MessageBox.Show("Please enter a valid search value.");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // Alices do while bubble sort with a tuple deconstructor
            bool isSwapped;
            do
            {
                isSwapped = false;
                for (int i = 0; i < GlobalLength - 1; i++)
                {
                    if (GlobalArray[i] > GlobalArray[i + 1])
                    {
                        // Might try the whacky tuple deconstructor way of doing this. - No temp int for this one, shit's pretty wild.
                        (GlobalArray[i], GlobalArray[i + 1]) = (GlobalArray[i + 1], GlobalArray[i]);
                        isSwapped = true;
                    }
                }
            }
            while (isSwapped);
            UpdateListBox();
        }

        // Edit selected item from the listbox
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int newValue;
            if (int.TryParse(textBox.Text, out newValue) && listBox.SelectedIndex != -1)
            {
                GlobalArray[listBox.SelectedIndex] = newValue;
                btnSort_Click(sender, e);
                UpdateListBox();
                textBox.Clear();
            }
            else
            {
                MessageBox.Show("Please select an item from the list and then enter a valid integer to edit the value.");
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        // Perform Linear Search and display appropriate messages
        private void BtnLinearSearch_Click(object sender, EventArgs e)
        {
            int searchValue;
            if (int.TryParse(textBox.Text, out searchValue))
            {
                for (int i = 0; i < GlobalLength; i++)
                {
                    if (GlobalArray[i] == searchValue)
                    {
                        MessageBox.Show($"Value found at index {i}.");
                        return;
                    }
                }
                MessageBox.Show("Value not found.");
            }

            else
            {
                MessageBox.Show("Please enter a valid search value.");
            }
        }
        #endregion

        #region Calculation Methods

        // Find mean of data set
        private void btnMean_Click(object sender, EventArgs e)
        {
            btnSort_Click(sender, e); // force sort before calc
            double total = 0;
            for (int i = 0; i < GlobalLength; i++)
            {
                total += GlobalArray[i];
            }

            double mean = total / GlobalLength;
            textBoxCalc.Text = $"Mean : {mean:F2}"; // Formats to 2 decimal places
        }

        // Find median of data set
        private void btnMedian_Click(object sender, EventArgs e)
        {
            btnSort_Click(sender, e); // force sort before calc
            int midpoint1 = (GlobalLength / 2) - 1; // get lowest end of middle so 23 / 2 = 11.5. This means that we should be using 11 and 12 in the array
            double median;

            if (GlobalLength % 2 == 0)
            {
                // Get low end of middle then get high end of middle and divide by 2 - pretty simple
                median = (GlobalArray[midpoint1] + GlobalArray[midpoint1 + 1]) / 2;
            }
            textBoxCalc.Text = $"Median : {median:F2}"; // Formats to 2 decimal places
        }

        // Find mode of data set
        private void btnMode_Click(object sender, EventArgs e)
        {
            // I'm sure theres an easier method, but this is what i could come up with.
            btnSort_Click(sender, e); // force sort before calc
            List<int> list = new List<int>(); // Create a list in case there are multiple numbers with the same number of duplicates
            int counter = 0;

            for (int i = 0; i < GlobalLength; i++)
            {
                int curCounter = 0;
                for (int j = 0; j < GlobalLength; j++)
                {
                    if (GlobalArray[i] == GlobalArray[j])
                    {
                        curCounter++;
                    }
                }

                // If this happened we need to create a new list to get rid of the old one
                if (curCounter > counter)
                {
                    list = new List<int> { GlobalArray[i] }; // This way seems to be liked more by vs2022 - Just add the value at index i immediately.
                    counter = curCounter;
                }

                // if the counters are the same then we need to add them.
                else if (curCounter == counter)
                {
                    // if list does not contain this index then add
                    if (!list.Contains(GlobalArray[i]))
                    {
                        list.Add(GlobalArray[i]);
                    }
                }
            }

            // if there is mulitple numbers with the same amount of duplicates
            if (list.Count > 1)
            {
                // Build the string and deliver to text box - Just found out that i should have used stringbuilder. It doesnt matter so much i guess.
                string build = "Multimodal: ";
                int previousNum = 0;

                for (int j = 0; j < GlobalLength; j++)
                {
                    int temp = GlobalArray[j];
                    if (list.Contains(temp) &&  temp != previousNum) // make sure im not printing out the same number more than once
                    {
                        build += $"{GlobalArray[j]:F2}, ";
                        previousNum = temp;
                    }
                }
                textBoxCalc.Text = build + " | Occurences: " + counter;
            }

            // if there is only 1 number with the highest duplicates then do this
            else
            {
                textBoxCalc.Text = $"Mode : {list[0]:F2}" + " | Occurences: " + counter;
            }
        }

        // Find range of data set
        private void btnRange_Click(object sender, EventArgs e)
        {
            btnSort_Click(sender, e); // force sort before calc
            // Knowing Milan, he probably wants proof of using double
            // Get highest and lowest then find difference
            double range = GlobalArray[GlobalLength - 1] - GlobalArray[0]; 
            textBoxCalc.Text = $"Range: {range:F2}";
        }
    }
}
#endregion