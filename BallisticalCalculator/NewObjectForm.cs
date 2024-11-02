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
        public NewObjectForm(string[] parameters = null)
        {
            InitializeComponent();

            // If parameters are not null, populate fields with values
            if (parameters != null && parameters.Length == 4) // 4 = Name + 3 parameters
            {
                textBoxNewObjectWindow.Text = parameters[0];  // Name
                numericUpDown3.Value = int.Parse(parameters[1]); // Muzzle Velocity
                numericUpDown2.Value = decimal.Parse(parameters[2]); // Ballistic Coefficient
                numericUpDown1.Value = int.Parse(parameters[3]); // Distance to Target
            }
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Path to the file
            string filePath = @"C:\Users\Msi\source\repos\BallisticalCalculator\BallisticalCalculator\bullets.csv";

            // Retrieve values from the form
            string name = textBoxNewObjectWindow.Text;
            int muzzleVelocity = (int)numericUpDown3.Value;
            double ballisticCoefficient = (double)numericUpDown2.Value;
            int distanceToTarget = (int)numericUpDown1.Value;

            // Create a string to write to the CSV file
            string newBullet = $"{name},{muzzleVelocity},{ballisticCoefficient},{distanceToTarget}";

            // Update the existing object in the CSV file
            UpdateCsvFile(filePath, newBullet, name);

            MessageBox.Show("Объект успешно сохранен в CSV файл!");
            this.Close(); // Close the form after saving
        }


        // Method to update a record in the CSV file
        private void UpdateCsvFile(string filePath, string newBullet, string oldName)
        {
            // Read all lines from the file
            var lines = File.ReadAllLines(filePath, Encoding.UTF8).ToList();

            // Find the index of the line to update
            for (int i = 1; i < lines.Count; i++) // Start at 1 to skip the header
            {
                if (lines[i].StartsWith(oldName + ",")) // Look for the line by old name
                {
                    lines[i] = newBullet; // Replace with the new line
                    break;
                }
            }
            // Write all lines back to the file
            File.WriteAllLines(filePath, lines, Encoding.UTF8);
        }


    }
}
