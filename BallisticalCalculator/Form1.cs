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
            if (!File.Exists(filePath))
            {
                MessageBox.Show("CSV file not found");
                return;

            }

            // Read lines and add them to ListBox
            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

            // Skip the first line with the header and add only names to the ListBox
            foreach (string line in lines.Skip(1)) // Start from the second line to skip the header
            {
                // Split the line by commas to get fields
                var fields = line.Split(',');

                if (fields.Length > 0)
                {
                    // Add only the name (first element) to the ListBox
                    listBox.Items.Add(fields[0]);
                }
            }
        }

        private void buttonEditObject_Click(object sender, EventArgs e)
        {
            // Check if an object is selected in the ListBox
            if (listBox.SelectedItem != null)
            {
                // Get the selected name from the ListBox
                string selectedName = listBox.SelectedItem.ToString();

                // File path
                string filePath = @"C:\Users\Msi\source\repos\BallisticalCalculator\BallisticalCalculator\bullets.csv";

                // Check if the file exists
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("CSV файл не найден. Нечего редактировать.");
                    return;
                }

                // Read all lines and find the entry with the desired name
                string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);
                string[] parameters = null;

                foreach (string line in lines.Skip(1)) // Skip the header
                {
                    var fields = line.Split(',');
                    if (fields.Length > 0 && fields[0] == selectedName) // Compare the name
                    {
                        parameters = fields; // Save parameters if found
                        break;
                    }
                }

                if (parameters != null)
                {
                    // Create the CreateNewForm with current parameters for editing
                    using (NewObjectForm createNewForm = new NewObjectForm(parameters))
                    {
                        createNewForm.ShowDialog();
                    }

                    // Update ListBox after closing the form to reflect changes
                    UpdateListBox();
                }
                else
                {
                    MessageBox.Show("Не удалось найти выбранный объект в CSV файле.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите объект для редактирования.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Check if an object is selected in the ListBox
            if (listBox.SelectedItem != null)
            {
                // Get the selected line from the ListBox
                string selectedLine = listBox.SelectedItem.ToString();

                // Extract the name from the selected line (assuming it is the first)
                string nameToDelete = selectedLine.Split(',')[0];

                // Confirm deletion with the user
                var result = MessageBox.Show($"Вы уверены, что хотите удалить '{nameToDelete}'?", "Подтверждение удаления", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // File path
                    string filePath = @"C:\Users\Msi\source\repos\BallisticalCalculator\BallisticalCalculator\bullets.csv";

                    // Delete the entry from the CSV
                    DeleteFromCsvFile(filePath, nameToDelete);

                    // Update ListBox after deletion
                    UpdateListBox();

                    MessageBox.Show("Объект успешно удален из CSV файла.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите объект для удаления.");
            }
        }

        private void DeleteFromCsvFile(string filePath, string nameToDelete)
        {
            // Read all lines from the file
            var lines = File.ReadAllLines(filePath, Encoding.UTF8).ToList();

            // Remove lines that match the name
            for (int i = lines.Count - 1; i >= 0; i--) // Looping from the end to avoid index issues
            {
                if (lines[i].StartsWith(nameToDelete + ",")) // Search by name
                {
                    lines.RemoveAt(i); // Remove the line
                }
            }

            // Write all lines back to the file
            File.WriteAllLines(filePath, lines, Encoding.UTF8);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (listBox.SelectedItem == null)
            {
                ClearParameterFields();
                return;
            }

            // Get the selected name
            string selectedName = listBox.SelectedItem.ToString();

            // File path
            string filePath = @"C:\Users\Msi\source\repos\BallisticalCalculator\BallisticalCalculator\bullets.csv";

            // Check if the file exists
            if (!File.Exists(filePath))
            {
                MessageBox.Show("CSV файл не найден. Невозможно отобразить параметры.");
                return;
            }

            // Read the file and search for the entry with the selected name
            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);
            string[] parameters = null;

            foreach (string line in lines.Skip(1)) // Skip the header
            {
                var fields = line.Split(',');
                if (fields.Length >= 4 && fields[0] == selectedName) // Check the name
                {
                    parameters = fields;
                    break;
                }
            }

            if (parameters != null)
            {
                // Update the parameter fields on the form
                numericMuzzleVelocity.Text = parameters[1]; // Muzzle Velocity
                numericBallisticCoefficient.Text = parameters[2]; // Ballistic Coefficient
                numericDistanceToTarget.Text = parameters[3]; // Distance to Target
            }
            else
            {
                ClearParameterFields();
                MessageBox.Show("Не удалось найти выбранный объект в CSV файле.");
            }
        }

        // Method to clear parameter fields
        private void ClearParameterFields()
        {
            numericMuzzleVelocity.Text = "";
            numericBallisticCoefficient.Text = "";
            numericDistanceToTarget.Text = "";
        }

        private void buttonCalculateResult_Click(object sender, EventArgs e)
        {
            // Check if an object is selected in the ListBox
            if (listBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an object from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected object name
            string selectedName = listBox.SelectedItem.ToString();

            try
            {
                // Extract values from text fields and convert them to numbers
                double muzzleVelocity = double.Parse(numericMuzzleVelocity.Text);
                double ballisticCoefficient = double.Parse(numericBallisticCoefficient.Text);
                double distanceToTarget = double.Parse(numericDistanceToTarget.Text);

                // Perform the calculation using the formula
                double result = muzzleVelocity * ballisticCoefficient * (distanceToTarget / 1000);

                // Format the result string as "<Object Name>: <Result>"
                string resultText = $"{selectedName}: {result:F2}";

                // Append the result to the outputTextBox on a new line
                outputTextBox.AppendText(resultText + Environment.NewLine);
            }
            catch (FormatException)
            {
                MessageBox.Show("Input error: please make sure all parameters are numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
