using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method_of_calculation_1
{
    public partial class LR1 : Form
    {
        public LR1()
        {
            InitializeComponent();
        }

        //Данные, необходимые для решения программы
        const double epsilon = 10E-4;
        const double a = 20, b = 0.5, c = 3.81, d = 0.30;

        //Функция, которую нужно минимизировать
        double f(double x, double y)
        {
            return a * x + b * y + Math.Exp(c * x * x + d * y * y);
        }

        //Производная по x
        double dfdx(double x, double y)
        {
            return a + 2 * c * x * Math.Exp(c * x * x + d * y * y);
        }

        //Производная по y
        double dfdy(double x, double y)
        {
            return b + 2 * d * y * Math.Exp(c * x * x + d * y * y);
        }

        //Основа программы
        private void start_btn_Click(object sender, EventArgs e)
        {
            //Изначально координаты равны (0,0) и альфа равен 1
            double x = 0, y = 0;
            double alpha = 1;
            dtGV.Rows.Add(x, y, f(x, y), dfdx(x, y), dfdy(x, y));
            //пока одновременно выполняются два неравенства
            while (Math.Abs(dfdx(x, y)) > epsilon / 2 || Math.Abs(dfdy(x, y)) > epsilon / 2)
            {
                //находим новые координаты
                double next_x = x - alpha * dfdx(x, y);
                double next_y = y - alpha * dfdy(x, y);
                //делаем проверку
                if (f(next_x, next_y) > f(x, y))
                {
                    alpha /= 2;
                    continue;
                }
                x = next_x;
                y = next_y;
                dtGV.Rows.Add(x, y, f(x, y), dfdx(x, y), dfdy(x, y), alpha);
            }
        }

        //нумерация первого столбца
        private void dtGV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dtGV.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }

        //открытие формы с информацией
        Info_form info_Form;
        private void Info_btn_Click(object sender, EventArgs e)
        {
            if (info_Form == null || info_Form.IsDisposed)
            {
                info_Form = new Info_form();
                info_Form.Show();
            }
        }
    }
}
