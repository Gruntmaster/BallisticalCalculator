using System.Text;

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

            MessageBox.Show("Properties of bullet were saved in bullets.csv");
        }
    }
}
