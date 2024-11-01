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

            // Если параметры не равны null, заполняем поля значениями
            if (parameters != null && parameters.Length == 4) // 4 - это Name + 3 параметра
            {
                textBoxNewObjectWindow.Text = parameters[0];  // Name
                numericUpDown3.Value = int.Parse(parameters[1]); // Muzzle Velocity
                numericUpDown2.Value = decimal.Parse(parameters[2]); // Ballistic Coefficient
                numericUpDown1.Value = int.Parse(parameters[3]); // Distance to Target
            }
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Путь к файлу
            string filePath = @"C:\Users\Msi\source\repos\BallisticalCalculator\BallisticalCalculator\bullets.csv";

            // Получение значений с формы
            string name = textBoxNewObjectWindow.Text;
            int muzzleVelocity = (int)numericUpDown3.Value;
            double ballisticCoefficient = (double)numericUpDown2.Value;
            int distanceToTarget = (int)numericUpDown1.Value;

            // Создаем строку для записи в CSV
            string newBullet = $"{name},{muzzleVelocity},{ballisticCoefficient},{distanceToTarget}";

            // Обновляем существующий объект в CSV файле
            UpdateCsvFile(filePath, newBullet, name);

            MessageBox.Show("Объект успешно сохранен в CSV файл!");
            this.Close(); // Закрываем форму после сохранения
        }


        // Метод для обновления записи в CSV
        private void UpdateCsvFile(string filePath, string newBullet, string oldName)
        {
            // Читаем все строки из файла
            var lines = File.ReadAllLines(filePath, Encoding.UTF8).ToList();

            // Находим индекс строки, которую нужно обновить
            for (int i = 1; i < lines.Count; i++) // начинаем с 1, чтобы пропустить заголовок
            {
                if (lines[i].StartsWith(oldName + ",")) // ищем по старому имени
                {
                    lines[i] = newBullet; // заменяем на новую строку
                    break;
                }
            }
            // Записываем все строки обратно в файл
            File.WriteAllLines(filePath, lines, Encoding.UTF8);
        }


    }
}
