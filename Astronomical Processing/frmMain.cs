namespace Astronomical_Processing
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
            InitializeDataArray();
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
    }
}