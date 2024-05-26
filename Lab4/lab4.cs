using System;
using System.Windows.Forms;

namespace ArrayOperations
{
    public partial class ResultsForm : Form
    {
        public ResultsForm(double negativeProduct, double sumBeforeMax, double[] reversedArray)
        {
            InitializeComponent();

            NegativeProductLabel.Text = $"Добуток від'ємних елементів масиву: {negativeProduct}";
            SumBeforeMaxLabel.Text = $"Сума додатних елементів масиву, розташованих до максимального елементу: {sumBeforeMax}";
            ReversedArrayLabel.Text = "Змінений масив: " + string.Join(", ", reversedArray);
        }

        private void InitializeComponent()
        {
            NegativeProductLabel = new Label();
            NegativeProductLabel.Location = new System.Drawing.Point(10, 10);
            NegativeProductLabel.AutoSize = true;
            Controls.Add(NegativeProductLabel);

            SumBeforeMaxLabel = new Label();
            SumBeforeMaxLabel.Location = new System.Drawing.Point(10, 30);
            SumBeforeMaxLabel.AutoSize = true;
            Controls.Add(SumBeforeMaxLabel);

            ReversedArrayLabel = new Label();
            ReversedArrayLabel.Location = new System.Drawing.Point(10, 50);
            ReversedArrayLabel.AutoSize = true;
            Controls.Add(ReversedArrayLabel);

            Text = "Результати операцій з масивом";
            Size = new System.Drawing.Size(300, 150);
        }

        private Label NegativeProductLabel;
        private Label SumBeforeMaxLabel;
        private Label ReversedArrayLabel;
    }

    class Program
    {
        static void Main()
        {
            double[] array = { 3.6, -1.5, 7.7, -5.8, 1.2, -2.1, 9.9 };

            double negativeProduct = 1;
            foreach (double num in array)
            {
                if (num < 0)
                {
                    negativeProduct *= num;
                }
            }

            double maxElement = array[0];
            foreach (double num in array)
            {
                if (num > maxElement)
                {
                    maxElement = num;
                }
            }

            double sumBeforeMax = 0;
            foreach (double num in array)
            {
                if (num == maxElement)
                {
                    break;
                }
                if (num > 0)
                {
                    sumBeforeMax += num;
                }
            }

            double[] reversedArray = new double[array.Length];
            array.CopyTo(reversedArray, 0);
            Array.Reverse(reversedArray);

            Application.Run(new ResultsForm(negativeProduct, sumBeforeMax, reversedArray));
        }
    }
}
