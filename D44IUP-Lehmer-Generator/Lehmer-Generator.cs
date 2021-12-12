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

namespace D44IUP_Lehmer_Generator
{
    public partial class Form1 : Form
    {
        //переменные, исвользуемые в формуле.
        uint A;
        uint B;
        uint C;
        decimal X;

        //список массивов для хранения результатов генерации, практически не используется, но добавляет возможность будущих доработок     
        List<int[]> generations = new List<int[]>();
        // переменная для хранени ячисла N для текущей генерации.
        int currentN = 0;
        int countSeries = 0;

        //создаем объект-генератор
        LehmerGenerator g = new LehmerGenerator();

        public Form1()
        {
            InitializeComponent();
        }

        private void вычислениеЧислаPiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PiCalc formPiCal = new PiCalc(g);
            DialogResult r = formPiCal.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {   
            if (Int32.TryParse(txtBoxforN.Text, out currentN) && (currentN>=100 && currentN <= 10000))
            {

                if (rbL.Checked) { CalcForLemer(currentN); }
                else { calcForRandomCs(currentN); }
            }
            else {
                MessageBox.Show("Неверный ввод. Введите n = целое число от 100 до 10000");
            }
        }
        //метод для рассчетов, используя метод Лемера
        public void CalcForLemer(int currentN)
        {
            //массив для хранения результатов генерации.
            int[] currentGeneration = new int[100];
            //генерируем числа и записываем результат в массив
            for (int i = 0; i < currentN; i++)
            {
                int currentRandomNumber = g.LemerN();
                currentGeneration[currentRandomNumber]++;
            }

            generations.Add(currentGeneration);

            decimal M = 0;

            //считаем математическое ожидание по формуле
            for (int x = 0; x < 100; x++)
            {
                M += x / 1.0M * (currentGeneration[x] / 1.0M / currentN);
            }

            decimal D = 0;
            //считаем дисперсию чисел по формуле
            for (int x = 0; x < 100; x++)
            {
                D += (x / 1.0M - M) * (x / 1.0M - M) * (currentGeneration[x] / 1.0M / currentN);
            }
            //вывод результатов 
            txtResult.Text = $"Результаты генерации {countSeries+1}: математическое ожидание M[X] = {M}, дисперсия D[X] =  {D} . ";

            //вызов метода для рисования  графиков
            paintCharts1(currentGeneration);
            paintCharts2(currentGeneration);
            countSeries++;

    
            
        }
        //метод для рассчетов, используя встроенный класс Random
        public void calcForRandomCs(int currentN) 
        {

                var rnd = new Random();
                int[] currentGeneration = new int[100];
                for (int i = 0; i < currentN; i++)
                {
                    int currentRandomNumber = rnd.Next(0, 100); ;
                    currentGeneration[currentRandomNumber]++;
                }

                generations.Add(currentGeneration);

                decimal M = 0;
            //считаем математическое ожидание по формуле
            for (int x = 0; x < 100; x++)
                {
                    M += x / 1.0M * (currentGeneration[x] / 1.0M / currentN);
                }

                decimal D = 0;
            //считаем дисперсию чисел по формуле
            for (int x = 0; x < 100; x++)
                {
                    D += (x / 1.0M - M) * (x / 1.0M - M) * (currentGeneration[x] / 1.0M / currentN);
                }

                txtResult.Text = $"Результаты генерации {countSeries+1}: математическое ожидание M[X] = {M}, дисперсия D[X] =  {D} . ";

            paintCharts1(currentGeneration);
            paintCharts2(currentGeneration);
            countSeries++;
        }

        //метод для рисования графика-гистограммы функции f(X), для результата генерации.
        public void paintCharts1(int[] arr)
        {
            chart1fX.Series.Add(countSeries.ToString());
            //настройка осей.
            Axis ax = new Axis();
            ax.Title = "Значение случайной величины";
            ax.Maximum = 100;
            ax.Minimum = -1;
            ax.Interval = 1;
            Axis ay = new Axis();
            ay.Title = "Вероятность P";
            
            ay.Interval = 0.01;

           chart1fX.ChartAreas[0].AxisX = ax;
           chart1fX.ChartAreas[0].AxisY = ay;
            //отображение столбца.
            for (int i = 0; i < 100; i++)
            {
                chart1fX.Series[countSeries.ToString()].Points.AddXY(i,arr[i]/1.0/currentN);
            }
        }

        //метод для рисования графика для интегральной функции распределения F(X), , для результата генерации.
        public void paintCharts2(int[] arr)
        {
            //настройка оосей, маркеров-точек.
            chart2.Series.Add(countSeries.ToString());
            chart2.Series[countSeries.ToString()].ChartType = SeriesChartType.Point;
            chart2.Series[countSeries.ToString()].MarkerSize = 2;
            Axis ax = new Axis();
            ax.Title = "X";
            ax.Maximum = 100;
            ax.Minimum = -5;
            ax.Interval = 1;
            Axis ay = new Axis();
            ay.Title = "F( X )";
            ay.Maximum = 1.1;


            chart2.ChartAreas[0].AxisX = ax;
            chart2.ChartAreas[0].AxisY = ay;
            
            
            decimal P = 0;
            decimal q = -10M;
            int a = 0;
            //рисуем точки с координатами (q,P), постепенно увеличивая q,
            //для получения линии для нужной вероятности P,
            //так как график должен выглядеть как ступенчатая ломанная линия
            while (q < a)
            {
                    if (arr[a] == 0)
                {
                    a++;

                }
                chart2.Series[countSeries.ToString()].Points.AddXY(q, P);
                q += 0.001M;
            }

            for (int i = 0; i < 100; i++)
                
            {if (arr[i] == 0) continue;
                P += arr[i] / 1.0M / currentN;
                decimal k = i;
                int nextStep = i + 1;
                while (k <= nextStep)
                {
                    
                    if ( nextStep<100 && arr[nextStep] == 0)
                    {
                        nextStep++;
                    }
                    chart2.Series[countSeries.ToString()].Points.AddXY(k, P);
                    k += 0.001M;
                    
                }

            }
        }

        //очистка полей графика по нажанию кнопки
        private void btnClear_Click(object sender, EventArgs e)
        {
                chart1fX.Series.Clear();
                chart2.Series.Clear();
                countSeries = 0;    
        }

        private void настройкаГенератораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options OptForm = new Options();
            DialogResult r = OptForm.ShowDialog();
            uint resultA, resultB, resultC, resultX;
            if (r == DialogResult.OK)
            {
                if (UInt32.TryParse(OptForm.returnA, out resultA) && UInt32.TryParse(OptForm.returnB, out resultB) && UInt32.TryParse(OptForm.returnC, out resultC) && UInt32.TryParse(OptForm.returnX, out resultX)) 
                {
                    if (resultC >= 2 && resultA >= 0 && resultA < resultC && resultB >= 0 && resultB < resultC && resultX >= 0 && resultX < resultC)
                    {
                        A = resultA;
                        B = resultB;
                        C = resultC;
                        X = resultX / 1.0M;
                        g = new LehmerGenerator(A, B, C, X);
                    }
                    else { MessageBox.Show("Неверный ввод"); }
                }
                else { MessageBox.Show("Неверный ввод"); }



            }
            else
            {
                MessageBox.Show("Отмена операции");
            }


        }
    }




}
    

