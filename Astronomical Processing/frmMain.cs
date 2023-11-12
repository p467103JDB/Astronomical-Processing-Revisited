namespace Astronomical_Processing
{
    public partial class frmMain : Form
    {
        int[] data = new int[24];

        public frmMain()
        {
            InitializeComponent();
            InitializeDataArray();
        }

        private void InitializeDataArray()
        {
            Random random = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(10, 100);
            }
            UpdateListBox();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            InitializeDataArray();
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(Array.ConvertAll(data, x => x.ToString()));
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                textBox.Text = listBox.SelectedItem.ToString();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int searchValue;
            if (int.TryParse(textBox.Text, out searchValue))
            {
                int index = BinarySearch(data, searchValue);
                if (index != -1)
                {
                    MessageBox.Show($"Search successful. Value found at index {index}.");
                }
                else
                {
                    MessageBox.Show("Search unsuccessful. Value not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid search value.");
            }
        }

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

       private void btnSort_Click(object sender, EventArgs e)
        {
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
                data[listBox.SelectedIndex] = newValue;
                UpdateListBox();
                textBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer to edit the value and select an item in the list.");
            }
        }

        private int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                {
                    return mid;
                }

                if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1; // Return -1 if not found
        }
    }
}
