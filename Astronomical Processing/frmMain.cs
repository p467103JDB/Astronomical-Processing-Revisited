namespace Astronomical_Processing
{
    public partial class frmMain : Form
    {
        private int[] data = new int[24];
        private object listBoxData;

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
                data[i] = random.Next(10, 100); // Generate random numbers between 10 and 99
            }
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBoxData.Items.Clear();
            listBoxData.Items.AddRange(data);
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
            BubbleSort(data);
            UpdateListBox();
        }

        private void BubbleSort(int[] data)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int newValue;
            if (int.TryParse(textBoxSearch.Text, out newValue))
            {
                data[listBoxData.SelectedIndex] = newValue;
                UpdateListBox();
                textBoxSearch.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer to edit the value.");
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