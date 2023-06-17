using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquationSolver
{
    public partial class FormThomas : Form
    {
        private OpenFileDialog openFile;
        private Func<double[,], double[], double[]> solvingMethod;
        public FormThomas()
        {
            InitializeComponent();
        }

        private void thomas_Click(object sender, EventArgs e)
        {
            // Считывание значений из текстовых полей
            double[] a = ParseArray(aTextBox.Text);
            double[] b = ParseArray(bTextBox.Text);
            double[] c = ParseArray(cTextBox.Text);
            double[] d = ParseArray(dTextBox.Text);

            // Проверка корректности размерностей массивов
            if (a.Length != b.Length || b.Length != c.Length || c.Length != d.Length)
            {
                MessageBox.Show("Некорректные размерности массивов.", "Ошибка");
                return;
            }

            try
            {
                // Решение системы с помощью метода прогонки
                double[] solution = EquationSolver.ThomasAlgorithm(a, b, c, d);

                // Вывод решения в текстовое поле
                resultTextBox.Text = string.Join(", ", solution);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
        private double[] ParseArray(string input)
        {
            // Разделение входной строки на отдельные элементы
            string[] values = input.Split(',');

            // Преобразование элементов в числа и сохранение в массив
            double[] array = new double[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                if (!double.TryParse(values[i], out array[i]))
                {
                    throw new Exception("Ошибка при разборе входных данных.");
                }
            }

            return array;
        }
        private void SolveEquationsFromFile(string filePath)
        {
            try
            {
                // Чтение данных из текстового файла
                string[] lines = File.ReadAllLines(filePath);

                // Проверка наличия достаточного количества строк для чтения
                if (lines.Length < 4)
                {
                    MessageBox.Show("Invalid file format. Not enough lines.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Извлечение данных из строк и преобразование их в массивы и матрицы
                double[] a = ParseArray(lines[0]);
                double[] b = ParseArray(lines[1]);
                double[] c = ParseArray(lines[2]);
                double[] d = ParseArray(lines[3]);

                double[,] coefficients = new double[b.Length, b.Length];
                double[] constants = new double[d.Length];

                for (int i = 0; i < b.Length; i++)
                {
                    coefficients[i, i] = b[i];

                    if (i > 0)
                        coefficients[i, i - 1] = a[i];

                    if (i < b.Length - 1)
                        coefficients[i, i + 1] = c[i];

                    constants[i] = d[i];
                }

                // Решение системы уравнений с использованием выбранного метода
                double[] solution = solvingMethod(coefficients, constants);

                // Вывод результата
                resultTextBox.Text = string.Join(", ", solution);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void text_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                SolveEquationsFromFile(filePath);
            }
            openFile.ShowDialog();
        }
        private void FormGauss_Load(object sender, EventArgs e)
        {
            // Оформление формы
            this.BackColor = Color.LightGray;



            // Оформление кнопки thomas
            thomas.BackColor = Color.DarkCyan;
            thomas.ForeColor = Color.Blue;
            thomas.Font = new Font("Arial", 12, FontStyle.Bold);
            thomas.Text = "Solve Equations";
            thomas.FlatStyle = FlatStyle.Flat;
            thomas.FlatAppearance.BorderSize = 0;

            // Оформление кнопки cancel
            cancel.BackColor = Color.DarkRed;
            cancel.ForeColor = Color.Blue;
            cancel.Font = new Font("Arial", 12, FontStyle.Bold);
            cancel.Text = "Cancel";
            cancel.FlatStyle = FlatStyle.Flat;
            cancel.FlatAppearance.BorderSize = 0;

            // Оформление текстовых полей
            aTextBox.Font = new Font("Arial", 12);
            bTextBox.Font = new Font("Arial", 12);
            cTextBox.Font = new Font("Arial", 12);
            dTextBox.Font = new Font("Arial", 12);
            resultTextBox.Font = new Font("Arial", 12);

            // Оформление кнопки text
            text.BackColor = Color.DarkRed;
            text.ForeColor = Color.Blue;
            text.Font = new Font("Arial", 12, FontStyle.Bold);
            text.Text = "text";
            text.FlatStyle = FlatStyle.Flat;
            text.FlatAppearance.BorderSize = 0;

            // Установка цвета фона для текстовых полей и меток
            aTextBox.BackColor = Color.WhiteSmoke;
            bTextBox.BackColor = Color.WhiteSmoke;
            cTextBox.BackColor = Color.WhiteSmoke;
            dTextBox.BackColor = Color.WhiteSmoke;
            resultTextBox.BackColor = Color.WhiteSmoke;
            openFile = new OpenFileDialog();

        }
    }
}
