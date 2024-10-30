using System.Text;
using System.Windows.Forms;

namespace BallisticalCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateNew_Click(object sender, EventArgs e)
        {
            using (NewObjectForm createNewObjectForm = new NewObjectForm())
            {
                //Open
                createNewObjectForm.ShowDialog();
            }

            //Close and Save
            UpdateListBox();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            // Update ListBox
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            // Clear ListBox
            listBox.Items.Clear();

            string filePath = @"C:\Users\Msi\source\repos\BallisticalCalculator\BallisticalCalculator\bullets.csv";

            // Does File Exist
            if (File.Exists(filePath))
            {
                // Read lines and add them to ListBox
                string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

                foreach (string line in lines)
                {
                    listBox.Items.Add(line);  // Adding each line to ListBox
                }
            }
            else
            {
                MessageBox.Show("CSV file not found");
            }
        }
    }
}
