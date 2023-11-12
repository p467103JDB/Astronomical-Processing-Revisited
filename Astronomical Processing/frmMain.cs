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
            FillArray();
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
            int row = listBox.SelectedIndex;
            if (row != -1) // Check if an item is selected
            {
                // The program liked string with string? for some reason, something to do with the conversion type

                string? s = listBox.Items[row].ToString();
                if (s != null) 
                {
                    // set textbox text 
                    textBox.Text = s;

                    // Get focus on the text box and move the cursor to the end
                    textBox.Focus();
                    textBox.SelectionStart = s.Length;
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //Bubble sort
            for (int i = 0; i < GlobalLength; i++)
            {
                bool isSwapped = false;

                for (int j = 0; j < GlobalLength - 1; j++)
                {
                    if (GlobalArray[j] > GlobalArray[j + 1])
                    {
                        // Might try the whacky tuple deconstructor way of doing this. - No temp int for this one, shit's pretty wild.
                        (GlobalArray[j + 1], GlobalArray[j]) = (GlobalArray[j], GlobalArray[j + 1]);
                        isSwapped = true;
                    }
                }

                if (!isSwapped)
                {
                    break;
                }
            }
            UpdateListBox();
        }

        private void FillArray()
        {
            for (int i = 0; i < GlobalLength; i++)
            {
                Random r = new Random();    // initialise rand
                int rInt = r.Next(10, 99);  // lower, higher
                GlobalArray[i] = rInt;      // set vals to index in array
            }
            UpdateListBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}