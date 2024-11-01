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

        private void buttonEditObject_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли объект в ListBox
            if (listBox.SelectedItem != null)
            {
                // Получаем выбранную строку из ListBox
                string selectedLine = listBox.SelectedItem.ToString();

                // Разделяем строку для получения параметров
                string[] parameters = selectedLine.Split(',');

                // Создаем и отображаем форму для редактирования с текущими значениями
                using (NewObjectForm createNewForm = new NewObjectForm(parameters))
                {
                    createNewForm.ShowDialog();
                }

                // Обновляем ListBox после закрытия формы, чтобы отобразить изменения
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите объект для редактирования.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли объект в ListBox
            if (listBox.SelectedItem != null)
            {
                // Получаем выбранную строку из ListBox
                string selectedLine = listBox.SelectedItem.ToString();

                // Извлекаем название из выбранной строки (предполагая, что оно первое)
                string nameToDelete = selectedLine.Split(',')[0];

                // Подтверждаем удаление у пользователя
                var result = MessageBox.Show($"Вы уверены, что хотите удалить '{nameToDelete}'?", "Подтверждение удаления", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Путь к файлу
                    string filePath = @"C:\Users\Msi\source\repos\BallisticalCalculator\BallisticalCalculator\bullets.csv";

                    // Удаляем запись из CSV
                    DeleteFromCsvFile(filePath, nameToDelete);

                    // Обновляем ListBox после удаления
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
            // Читаем все строки из файла
            var lines = File.ReadAllLines(filePath, Encoding.UTF8).ToList();

            // Удаляем строки, соответствующие имени
            for (int i = lines.Count - 1; i >= 0; i--) // проходим с конца, чтобы не сбивать индексы
            {
                if (lines[i].StartsWith(nameToDelete + ",")) // ищем по имени
                {
                    lines.RemoveAt(i); // удаляем строку
                }
            }

            // Записываем все строки обратно в файл
            File.WriteAllLines(filePath, lines, Encoding.UTF8);
        }

    }
}
