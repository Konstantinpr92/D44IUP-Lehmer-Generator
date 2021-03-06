using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D44IUP_Lehmer_Generator
{
    public partial class PiCalc : Form
    {
        LehmerGenerator gen;
        public PiCalc(LehmerGenerator g)
        {
            InitializeComponent();
            gen = g;
        }



        private void btnStart_Click(object sender, EventArgs e)
        {
   
            int NumPoints; //переменная для хранения количества генерируемых точек

            if (Int32.TryParse(textBoxNumPoints.Text, out NumPoints) && NumPoints > 0)
            {
                txtBoxPiCalc.Text = "Идут вычисления...";
                txtBoxPiCalc.Invalidate();
                txtBoxPiCalc.Update();

                int InCircle = 0; //переменная-счетчик для учета количества очек, попавших в сектор единичного круга
                
                for (int i = 0; i < NumPoints; i++)
                {
                    progressBar1.Value = Convert.ToInt32((Convert.ToDouble(i) / NumPoints) * 100.0);
                    progressBar1.Invalidate();
                    progressBar1.Update();
                    //генерируем случайное значения координат Х, Y для точки
                    Decimal x = gen.Lemer();
                    Decimal y = gen.Lemer();
                    //проверяем, попадает точка с сгенерироваными координатами в круг.
                    if (PointInCircle(x, y))
                    {
                        InCircle++;
                    }
                    progressBar1.Invalidate();
                    progressBar1.Update();
                }
                //MessageBox.Show("Вычисление завершено");
                progressBar1.Invalidate();
                progressBar1.Update();
                Thread.Sleep(100);
                //считаем чилсо Пи по формуле, и выводим его.
                decimal Pi = ((InCircle / 1.0M / NumPoints) * 4M);
                txtBoxPiCalc.Text = Convert.ToString(Pi);
            }
            else { MessageBox.Show("Неверный ввод..."); }

        }
        //метод для проверки вхождения точки с координатами X, Y  в единичный круг, используя теорему Пифагора.
        public bool PointInCircle(decimal x, decimal y)
        {
            return Math.Sqrt((double)(x * x + y * y)) <= 1.0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
