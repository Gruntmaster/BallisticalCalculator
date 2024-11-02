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

            // Пропускаем первую строку с заголовком и добавляем только название в ListBox
            foreach (string line in lines.Skip(1)) // Начинаем со второй строки, чтобы пропустить заголовок
            {
                // Разделяем строку по запятым, чтобы получить поля
                var fields = line.Split(',');

                if (fields.Length > 0)
                {
                    // Добавляем только название (первый элемент) в ListBox
                    listBox.Items.Add(fields[0]);
                }
            }
        }

        private void buttonEditObject_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли объект в ListBox
            if (listBox.SelectedItem != null)
            {
                // Получаем выбранное название из ListBox
                string selectedName = listBox.SelectedItem.ToString();

                // Путь к файлу
                string filePath = @"C:\Users\Msi\source\repos\BallisticalCalculator\BallisticalCalculator\bullets.csv";

                // Проверяем, существует ли файл
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("CSV файл не найден. Нечего редактировать.");
                    return;
                }

                // Читаем все строки и находим запись с нужным названием
                string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);
                string[] parameters = null;

                foreach (string line in lines.Skip(1)) // Пропускаем заголовок
                {
                    var fields = line.Split(',');
                    if (fields.Length > 0 && fields[0] == selectedName) // Сравниваем название
                    {
                        parameters = fields; // Сохраняем параметры, если нашли
                        break;
                    }
                }

                if (parameters != null)
                {
                    // Создаем форму CreateNewForm с текущими параметрами для редактирования
                    using (NewObjectForm createNewForm = new NewObjectForm(parameters))
                    {
                        createNewForm.ShowDialog();
                    }

                    // Обновляем ListBox после закрытия формы, чтобы отобразить изменения
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

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверяем, выбран ли элемент
            if (listBox.SelectedItem == null)
            {
                ClearParameterFields();
                return;
            }

            // Получаем выбранное название
            string selectedName = listBox.SelectedItem.ToString();

            // Путь к файлу
            string filePath = @"C:\Users\Msi\source\repos\BallisticalCalculator\BallisticalCalculator\bullets.csv";

            // Проверяем, существует ли файл
            if (!File.Exists(filePath))
            {
                MessageBox.Show("CSV файл не найден. Невозможно отобразить параметры.");
                return;
            }

            // Читаем файл и ищем запись с выбранным названием
            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);
            string[] parameters = null;

            foreach (string line in lines.Skip(1)) // Пропускаем заголовок
            {
                var fields = line.Split(',');
                if (fields.Length >= 4 && fields[0] == selectedName) // Проверяем название
                {
                    parameters = fields;
                    break;
                }
            }

            if (parameters != null)
            {
                // Обновляем поля параметров на форме
                numericUpDown3.Text = parameters[1]; // Muzzle Velocity
                numericUpDown2.Text = parameters[2]; // Ballistic Coefficient
                numericUpDown1.Text = parameters[3]; // Distance to Target
            }
            else
            {
                ClearParameterFields();
                MessageBox.Show("Не удалось найти выбранный объект в CSV файле.");
            }
        }

        // Метод для очистки полей параметров
        private void ClearParameterFields()
        {
            numericUpDown3.Text = "";
            numericUpDown2.Text = "";
            numericUpDown1.Text = "";
        }


    }
}
