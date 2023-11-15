using System.Collections;
using System.Windows.Forms;

//  Alice & Jack, The Team, Sprint 1
//  Git Branch: JD - AP
//  Date: 11/11/2023
//  Version: v0.2 (commmit 2) 
//  Astronomical Processing
//  Simple data search and sort program
// 
//  Inputs:
//  - Textbox requires user string input
//  - Edit button
//  - Search Button
//  - Sort Button
//  - Listbox row selection
//
//  Processes:
//  - FillArray: Fills the global array between 10 and 99 (Also updates the listbox)
//  - btnSearch_Click: Searches for the entered text in the TextBox within the GlobalArray
//  - btnSort_Click: Performs a bubble sort on the GlobalArray (Also updates the listbox)
//  - btnEdit_Click: Allows the user to edit the selected index (Also updates the listbox)
//  
//  Outputs:
//  - Sort button bubble sorts data in list and updates list.
//  - Error messagebox if textbox == null.
//  - Error messagebox if textbox string was not found.
//  - Success messagebox if textbox string was found.
//  - Allows user to edit selected index


namespace Astronomical_Processing
{
    public partial class frmMain : Form
    {
        // Globals
        const int GlobalLength = 24; // Global constant
        int[] GlobalArray = new int[GlobalLength];

        public frmMain()
        {
            InitializeComponent();
            InitializeDataArray();
        }
        private void InitializeDataArray()
        {
            for (int i = 0; i < GlobalLength; i++)
            {
                Random r = new Random();    // initialise rand
                int rInt = r.Next(10, 99);  // lower, higher
                GlobalArray[i] = rInt;      // set vals to index in array
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

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                textBox.Text = listBox.SelectedItem.ToString();
            }
        }

        //Alice integrated BSearch algorithm to Search Button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int searchValue;
            if (int.TryParse(textBox.Text, out searchValue))
            {
                int left = 0;
                int right = GlobalArray.Length - 1;
                
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
                isSwapped=false;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int newValue;
            if (int.TryParse(textBox.Text, out newValue) && listBox.SelectedIndex != -1)
            {
                GlobalArray[listBox.SelectedIndex] = newValue;
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
    }
}
