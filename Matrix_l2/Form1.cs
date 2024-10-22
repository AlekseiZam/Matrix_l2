using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Matrix_l2
{
    public partial class Form1 : Form
    {
        int rowA;
        int colA;
        int rowB;
        int colB;
        int rowC;
        int colC;

        int[,] matrixA;
        int[,] matrixB;

        public Form1()
        {
            InitializeComponent();
            MARowTextBox.Text = "5";
            MAColTextBox.Text = "5";
            MBRowTextBox.Text = "5";
            MBColTextBox.Text = "5";

            rowA = Convert.ToInt32(MARowTextBox.Text);
            colA = Convert.ToInt32(MAColTextBox.Text);
            rowB = Convert.ToInt32(MBRowTextBox.Text);
            colB = Convert.ToInt32(MBColTextBox.Text);
            rowC = rowA;
            colC = colB;

            MCRowTextBox.Text = rowC.ToString();
            MCColTextBox.Text = colC.ToString();
            oneCalcButton.Enabled = false;
            multiCalcButton.Enabled = false;
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            oneCalcButton.Enabled = true;
            multiCalcButton.Enabled = true;

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView4.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            dataGridView3.Columns.Clear();
            dataGridView4.Columns.Clear();

            rowA = Convert.ToInt32(MARowTextBox.Text);
            colA = Convert.ToInt32(MAColTextBox.Text);
            rowB = Convert.ToInt32(MBRowTextBox.Text);
            colB = Convert.ToInt32(MBColTextBox.Text);
            rowC = rowA;
            colC = colB;
            MCRowTextBox.Text = rowC.ToString();
            MCColTextBox.Text = colC.ToString();

            multiCalcButton.Text = "Умножить матрицы \n Кол-во задач = " + rowC;

            matrixA = new int[rowA, colA];
            matrixB = new int[rowB, colB];

            var rnd = new Random();

            for(int i = 0; i < colA; i++)
            {
                dataGridView1.Columns.Add("", "");
                dataGridView1.Columns[i].Width = 20;
            }

            for (int i = 0; i < rowA; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Height = 16;
                for(int j = 0; j < colA; j++)
                {
                    matrixA[i, j] = rnd.Next(0,10);
                    dataGridView1.Rows[i].Cells[j].Value = matrixA[i, j].ToString();
                }
            }

            for (int i = 0; i < colB; i++)
            {
                dataGridView2.Columns.Add("", "");
                dataGridView2.Columns[i].Width = 20;
            }

            for (int i = 0; i < rowB; i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].Height = 16;
                for (int j = 0; j < colB; j++)
                {
                    matrixB[i, j] = rnd.Next(0, 10);
                    dataGridView2.Rows[i].Cells[j].Value = matrixB[i, j].ToString();
                }
            }

            for (int i = 0; i < colC; i++)
            {
                dataGridView3.Columns.Add("", "");
                dataGridView3.Columns[i].Width = 20;
            }

            for (int i = 0; i < rowC; i++)
            {
                dataGridView3.Rows.Add();
                dataGridView3.Rows[i].Height = 16;
            }
        }

        private void oneCalcButton_Click(object sender, EventArgs e)
        {
            if(colA != rowB)
            {
                MessageBox.Show("Неверный формат матриц");
                return;
            }
            DateTime D1, D2;
            D1 = DateTime.Now;
            for(int i = 0; i < rowC; i++)
            {
                for(int j = 0; j < colC; j++)
                {
                    int sum = 0;
                    for(int n = 0; n < colA; n++)
                    {
                        sum += matrixA[i, n] * matrixB[n, j];
                        dataGridView3.Rows[i].Cells[j].Value = sum.ToString();
                    }
                }
            }
            D2 = DateTime.Now;
            oneTimeLabel.Text = "Время выполнения (тики): " + (D2 - D1).Ticks.ToString();
        }

        private async void multiCalcButton_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();
            dataGridView4.Columns.Clear();

            if (colA != rowB)
            {
                MessageBox.Show("Неверный формат матриц");
                return;
            }

            dataGridView4.Columns.Add("", "");
            for (int i = 0; i < rowC; i++)
            {
                dataGridView4.Rows.Add();
                dataGridView4.Rows[i].HeaderCell.Value = ""+(i+1);
                dataGridView4.Rows[i].Height = 16;
            }

            DateTime D1, D2;
            D1 = DateTime.Now;

            Task[] tasks = new Task[rowC];
            for (int i = 0; i < rowC; i++)
            {
                int row = i;
                tasks[i] = Task.Run(() => TaskCalc(row));
            }

            await Task.WhenAll(tasks);

            D2 = DateTime.Now;
            multiTimeLabel.Text = "Время выполнения (тики): " + (D2 - D1).Ticks.ToString();
        }

        private void TaskCalc(int row)
        {
            DateTime D1, D2;
            D1 = DateTime.Now;

            int[] resultRow = new int[colC];
            for (int j = 0; j < colC; j++)
            {
                int sum = 0;
                for (int n = 0; n < colA; n++) 
                {
                    sum += matrixA[row, n] * matrixB[n, j];
                }
                resultRow[j] = sum;
            }
            D2 = DateTime.Now;

            
            this.Invoke((Action)(() =>
            {
                for (int j = 0; j < colC; j++)
                {
                    dataGridView3.Rows[row].Cells[j].Value = resultRow[j].ToString();
                }
                dataGridView4.Rows[row].Cells[0].Value = (D2 - D1).Ticks.ToString();
            }));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Pmax = Convert.ToDouble(txtEnd.Text); // Максимальное значение производительности процессора
            int maxProcessors = Convert.ToInt32(txtSteps.Text); // Количество процессоров
            double S = Convert.ToDouble(textS.Text); // Доля последовательной части программы

            // Очистка предыдущих данных на графике
            chartResults.Series.Clear();
            chartResults.Titles.Clear();

            var series = new Series
            {
                Name = "Закон Адамала",
                Color = System.Drawing.Color.Blue,
                ChartType = SeriesChartType.Line
            };

            // Вычисление производительности для каждого количества процессоров
            for (int n = 1; n <= maxProcessors; n++)
            {
                double performance = Pmax / (S + (1 - S) / n);
                series.Points.AddXY(n, performance); // Добавление точки на график
            }

            // Добавление серии на график
            chartResults.Series.Add(series);
            chartResults.Titles.Add("Закон Адамала: Ограничение роста производительности");
            chartResults.ChartAreas[0].AxisX.Title = "Количество процессоров";
            chartResults.ChartAreas[0].AxisY.Title = "Производительность";

        }
    }

}
