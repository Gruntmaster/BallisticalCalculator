using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallisticalCalculator
{
    public partial class NewObjectForm : Form
    {
        public NewObjectForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Путь к файлу
            string filePath = @"C:\Users\Msi\source\repos\BallisticalCalculator\BallisticalCalculator\bullets.csv";

            // Получение значений с формы
            string name = textBoxNewObjectWindow.Text;
            int muzzleVelocity = (int)numericUpDown3.Value;
            double ballisticCoefficient = (double)numericUpDown2.Value;
            int distanceToTarget = (int)numericUpDown3.Value;

            string newBulletLineInCSV = $"{name},{muzzleVelocity},{ballisticCoefficient},{distanceToTarget}";

            bool fileExists = File.Exists(filePath);
          
            using (StreamWriter writer = new StreamWriter(filePath, true, Encoding.UTF8))
            {
                if (!fileExists)
                {
                    writer.WriteLine("Name,Muzzle Velocity,Ballistic Coefficient,Distance to Target");
                }
                writer.WriteLine(newBulletLineInCSV);
            }

            MessageBox.Show("Properties of bullet were saved in bullets.csv");
            this.Close();
        }
    }
}
