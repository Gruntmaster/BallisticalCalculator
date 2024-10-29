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
            string filePath = @"C:\Users\Msi\source\repos\BallisticalCalculator\BallisticalCalculator\bullets.csv";

            int muzzleVelocity = (int)numericUpDown3.Value;
            double ballisticCoefficient = (double)numericUpDown2.Value;
            int distanceToTarget = (int)numericUpDown1.Value;

            string newBullet = $"{muzzleVelocity},{ballisticCoefficient},{distanceToTarget}";

            bool fileExists = File.Exists(filePath);

            using (StreamWriter writer = new StreamWriter(filePath, true, Encoding.UTF8))
            {
                if (!fileExists)
                {
                    writer.WriteLine("Muzzle Velocity,Ballistic Coefficient,Distance to Target");
                }
                writer.WriteLine(newBullet);
            }

            UpdateListBox();

            MessageBox.Show("Properties of bullet were saved in bullets.csv");
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
