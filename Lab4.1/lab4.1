using System;
using System.Windows.Forms;

namespace ArrayOperations
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Оголошення та ініціалізація двовимірного масиву
            int[,] array = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // а) Виведення на екран усього масиву
            string arrayContent = "Двовимірний масив:\n" + ArrayToString(array);

            // б) Виведення на екран будь-якого елемента другого рядку масиву (наприклад, другого рядка)
            int elementInSecondRow = array[1, 0]; // Ми вибираємо перший елемент другого рядка

            // в) Виведення на екран будь-якого елемента масиву (наприклад, останнього елемента)
            int lastElement = array[array.GetLength(0) - 1, array.GetLength(1) - 1]; // Останній елемент масиву

            string content = $"{arrayContent}\nЕлемент другого рядка масиву: {elementInSecondRow}\nОстанній елемент масиву: {lastElement}";

            Application.Run(new ResultsForm(content));
        }

        private void InitializeComponent()
        {
            this.Load += new EventHandler(MainForm_Load);
            this.Text = "Main Form";
            this.Size = new System.Drawing.Size(400, 300);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Пустой метод, так как логика уже перемещена в конструктор
        }

        private string ArrayToString(int[,] array)
        {
            string result = "";
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result += array[i, j] + "\t";
                }
                result += "\n";
            }

            return result;
        }
    }

    public class ResultsForm : Form
    {
        public ResultsForm(string content)
        {
            Label label = new Label();
            label.Text = content;
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(10, 10);
            label.MaximumSize = new System.Drawing.Size(380, 0);

            Controls.Add(label);

            this.Text = "Results Form";
            this.Size = new System.Drawing.Size(400, 300);
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
