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



        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //Bubble sort

            for (int i = 0; i < GlobalLength; i++) 
            {
                bool isSwapped = false;

                
                for (int j = 0; j < GlobalLength; j++) 
                { 
                
                    if (GlobalArray[j] > GlobalArray[j + 1])
                    {
                        // Might try whacky tuple deconstructor way of doing this. - No temp int for this one, shit's pretty wild.
                        (GlobalArray[j + 1], GlobalArray[j]) = (GlobalArray[j], GlobalArray[j + 1]);
                        isSwapped = true;
                    }
                }

                if(!isSwapped)
                {
                    break;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void FillArray()
        {
            for(int i = 0; i < GlobalLength; i++)
            {
                Random r = new Random(); // initialise rand
                int rInt = r.Next(10, 99); // lower, higher
                GlobalArray[i] = rInt;    // set vals to index in array
            }

        }
    }
}