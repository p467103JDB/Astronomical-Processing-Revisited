namespace Astronomical_Processing
{
    public partial class frmMain : Form
    {
        private int[] data = new int[24];

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

        private void btnSort_Click(object sender, EventArgs e)
        {
            BubbleSort(data);
            UpdateListBox();
        }

        private void BubbleSort(int[] array)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        // Swap array[i-1] and array[i]
                        int temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
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