using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RPS3
{
    public class Algorithm
    {
        public static List<double> list_x, list_y;
        public static int elem_counter;

        public static bool GetCheck(TextBox a_in, TextBox b_in, TextBox c_in, TextBox d_in,
                                    TextBox left_border_in, TextBox right_border_in,
                                    TextBox step_in)
        {
            bool all_good = true;


            if (string.IsNullOrEmpty(a_in.Text) ||
                string.IsNullOrEmpty(b_in.Text) ||
                string.IsNullOrEmpty(c_in.Text) ||
                string.IsNullOrEmpty(d_in.Text) ||
                string.IsNullOrEmpty(left_border_in.Text) ||
                string.IsNullOrEmpty(right_border_in.Text) ||
                string.IsNullOrEmpty(step_in.Text))
            {
                MessageBox.Show("Не все значения были введены.", "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (!double.TryParse(a_in.Text, out double a))
            {
                MessageBox.Show("Введен некорректный коэффициент (а).", "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                all_good = false;
            }

            if (!double.TryParse(b_in.Text, out double b))
            {
                MessageBox.Show("Введен некорректный коэффициент (b).", "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                all_good = false;
            }

            if (!double.TryParse(c_in.Text, out double c))
            {
                MessageBox.Show("Введен некорректный коэффициент (c).", "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                all_good = false;
            }

            if (!double.TryParse(d_in.Text, out double d))
            {
                MessageBox.Show("Введен некорректный коэффициент (d).", "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                all_good = false;
            }

            if (!double.TryParse(left_border_in.Text, out double left_border))
            {
                MessageBox.Show("Введена некорректная левая граница.", "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                all_good = false;
            }
            if (!double.TryParse(right_border_in.Text, out double right_border))
            {
                MessageBox.Show("Введена некорректная правая граница.", "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                all_good = false;
            }
            else if (left_border >= right_border)
            {
                MessageBox.Show("Введены некорректные границы. Значение левой границы не должно превосходить или быть равной" +
                    " значению правой.", "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                all_good = false;
            }

            if (!double.TryParse(step_in.Text, out double step))
            {
                MessageBox.Show("Введен некорректный шаг.", "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                all_good = false;
            }
            else if (step <= 0)
            {
                MessageBox.Show("Значение шага должно быть положительным числом.", "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                all_good = false;
            }
            if (step > (right_border - left_border))
            {
                MessageBox.Show("Шаг больше заданного диапазона, введите другое значение.", "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                all_good = false;
            }
            if ((right_border - left_border) / step >= 100)
            {
                MessageBox.Show("При данном диапазоне и шаге, число полученных значений превышает 100" +
                    ", введите другой диапазон или увеличьте шаг.", "Предупреждение",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                all_good = false;
            }


            if (all_good)
            {
                if (a_in.Text != a.ToString())
                {
                    a_in.Text = a.ToString();
                    MessageBox.Show("Некорректный ввод коэффициента (а) был исправлен.", "Информация",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                if (b_in.Text != b.ToString())
                {
                    b_in.Text = b.ToString();
                    MessageBox.Show("Некорректный ввод коэффициента (b) был исправлен.", "Информация",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                if (c_in.Text != c.ToString())
                {
                    c_in.Text = c.ToString();
                    MessageBox.Show("Некорректный ввод коэффициента (c) был исправлен.", "Информация",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                if (d_in.Text != d.ToString())
                {
                    d_in.Text = d.ToString();
                    MessageBox.Show("Некорректный ввод коэффициента (d) был исправлен.", "Информация",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                if (left_border_in.Text != left_border.ToString())
                {
                    left_border_in.Text = left_border.ToString();
                    MessageBox.Show("Некорректный ввод левой границы был исправлен.", "Информация",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                if (right_border_in.Text != right_border.ToString())
                {
                    right_border_in.Text = right_border.ToString();
                    MessageBox.Show("Некорректный ввод правой границы был исправлен.", "Информация",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                if (step_in.Text != step.ToString())
                {
                    step_in.Text = step.ToString();
                    MessageBox.Show("Некорректный ввод шага был исправлен.", "Информация",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            return all_good;
        }


        public static void StartAlgorithm(double a, double b, double c, double d,
                                          double left_border, double right_border, double step,
                                          Panel result_panel, Chart chart, bool is_test)
        {
            elem_counter = 0;
            double x = left_border;
            double y;
            list_x = new List<double>();
            list_y = new List<double>();

            if (!is_test)
            {
                foreach (Control control in result_panel.Controls)
                {
                    if (control is Label label)
                    {
                        label.Hide();
                    }
                }


                chart.Series[0].Points.Clear();
            }

            for (double i = left_border; i <= right_border; i += step, x += step)
            {
                x = Math.Round(x, 5);
                y = a + b * Math.Sin(c * x + d);
                y = Math.Round(y, 5);
                if (!is_test)
                {
                    if (!double.IsNaN(y))
                    {
                        Label labelCount = new Label()
                        {
                            Height = 30,
                            Width = 50,
                            Text = $"{elem_counter + 1}",
                            Location = new Point(5, 30 * elem_counter + 5),
                            Font = new Font("Microsoft Sans Serif", 13.8f)
                        };

                        Label labelY = new Label()
                        {
                            Height = 30,
                            Width = 100,
                            Text = y.ToString(),
                            Location = new Point(145, 30 * elem_counter + 5),
                            Font = new Font("Microsoft Sans Serif", 13.8f)
                        };

                        Label labelX = new Label()
                        {
                            Height = 30,
                            Width = 80,
                            Text = x.ToString(),
                            Location = new Point(60, 30 * elem_counter + 5),
                            Font = new Font("Microsoft Sans Serif", 13.8f)
                        };
                        result_panel.Controls.Add(labelX);
                        result_panel.Controls.Add(labelY);
                        result_panel.Controls.Add(labelCount);
                        labelX.BringToFront();
                        labelY.BringToFront();
                        labelCount.BringToFront();
                        labelX.Show();
                        labelY.Show();
                        labelCount.Show();
                        list_x.Add(x);
                        list_y.Add(y);
                        chart.Series[0].Points.AddXY(x, y);
                        elem_counter++;
                    }

                    if (elem_counter == 0)
                    {
                        MessageBox.Show("Необходимо изменить диапазон, чтобы рассчитать значение функции.", "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    list_x.Add(x);
                    list_y.Add(y);
                    elem_counter++;
                }
            }
        }
    }
}
