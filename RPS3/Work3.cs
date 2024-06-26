﻿using System;
using System.Windows.Forms;
using System.IO;

namespace RPS3
{
    public partial class Work3 : Form
    {
        public Work3()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;

            // Запретить открытие на полный экран
            MaximizeBox = false;
            if (CheckTheLoad())
            {
                MessageBox.Show(GetHello(), "Приветствие",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                checkerHello.Checked = true;
            }
            else checkerHello.Checked = false;

            a_in.KeyPress += a_in_KeyPress;
            b_in.KeyPress += b_in_KeyPress;
            c_in.KeyPress += c_in_KeyPress;
            d_in.KeyPress += d_in_KeyPress;
            left_border_in.KeyPress += left_border_in_KeyPress;
            right_border_in.KeyPress += right_border_in_KeyPress;
            step_in.KeyPress += step_in_KeyPress;

            a_in.Text = "0";
            b_in.Text = "1";
            c_in.Text = "5";
            d_in.Text = "0";
            left_border_in.Text = "1";
            right_border_in.Text = "5";
            step_in.Text = "1";

            double a = 0, b = 1, c = 5, d = 0, left_border = 1, right_border = 5, step = 1;
            Algorithm.StartAlgorithm(a, b, c, d, left_border, right_border, step, result_panel, chart, false);
        }

        public static bool CheckTheLoad()
        {
            return Convert.ToBoolean(File.ReadAllText(Path.Combine(Application.StartupPath, "check_hello.txt")));
        }
        public static void ChangeCheckBoxValue(Work3 mw)
        {
            if (mw.checkerHello.Checked == true)
            {
                File.WriteAllText(Path.Combine(Application.StartupPath, "check_hello.txt"), true.ToString());
            }
            if (mw.checkerHello.Checked == false)
            {
                File.WriteAllText(Path.Combine(Application.StartupPath, "check_hello.txt"), false.ToString());
            }
        }

        public static string GetHello()
        {
            string hello = "Семенков Даниил гр.425" + Environment.NewLine +
            "Контрольная работа № 3" + Environment.NewLine +
            "Вариант 19" + Environment.NewLine +
            "Построение графика синусоиды y = a + b * sin(c * x + d).";
            return hello;
        }


        private void Btn_GetResult_Click(object sender, EventArgs e)
        {
            Btn_GetResult.Enabled = false;

            bool check = Algorithm.GetCheck(a_in, b_in, c_in, d_in, left_border_in, right_border_in, step_in);

            if (check)
            {
                double a = double.Parse(a_in.Text);
                double b = double.Parse(b_in.Text);
                double c = double.Parse(c_in.Text);
                double d = double.Parse(d_in.Text);
                double left_border = double.Parse(left_border_in.Text);
                double right_border = double.Parse(right_border_in.Text);
                double step = double.Parse(step_in.Text);

                Algorithm.StartAlgorithm(a, b, c, d, left_border, right_border, step, result_panel, chart, false);
            }

            Btn_GetResult.Enabled = true;
        }


        private void Btn_LoadData_Click(object sender, EventArgs e)
        {
            Btn_LoadData.Enabled = false;
            // Диалог выбора файла
            OpenFileDialog file_open_dialog = new OpenFileDialog();
            file_open_dialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            file_open_dialog.FilterIndex = 1;
            file_open_dialog.RestoreDirectory = true;

            if (file_open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Чтение данных из файла
                    string file_path = file_open_dialog.FileName;
                    string initial_data = File.ReadAllText(file_path);

                    if (string.IsNullOrEmpty(initial_data))
                    {
                        MessageBox.Show("Открытый файл пуст.", "Внимание!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        Btn_LoadData.Enabled = true;
                        return;
                    }
                    else
                    {
                        // Разделение строк
                        string[] lines = initial_data.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                        if (lines.Length == 7)
                        {
                            if (!double.TryParse(lines[0], out double a))
                            {
                                MessageBox.Show("Файл содержит некорректное значение коэффициента a, исправьте данные.", "Внимание!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                Btn_LoadData.Enabled = true;
                                return;
                            }
                            if (!double.TryParse(lines[1], out double b))
                            {
                                MessageBox.Show("Файл содержит некорректное значение коэффициента b, исправьте данные.", "Внимание!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                Btn_LoadData.Enabled = true;
                                return;
                            }
                            if (!double.TryParse(lines[2], out double c))
                            {
                                MessageBox.Show("Файл содержит некорректное значение коэффициента c, исправьте данные.", "Внимание!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                Btn_LoadData.Enabled = true;
                                return;
                            }
                            if (!double.TryParse(lines[3], out double d))
                            {
                                MessageBox.Show("Файл содержит некорректное значение коэффициента d, исправьте данные.", "Внимание!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                Btn_LoadData.Enabled = true;
                                return;
                            }
                            if (!double.TryParse(lines[4], out double left_border))
                            {
                                MessageBox.Show("Файл содержит некорректное значение левой границы, исправьте данные.", "Внимание!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                Btn_LoadData.Enabled = true;
                                return;
                            }
                            if (!double.TryParse(lines[5], out double right_border))
                            {
                                MessageBox.Show("Файл содержит некорректное значение правой границы, исправьте данные.", "Внимание!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                Btn_LoadData.Enabled = true;
                                return;
                            }    
                            if (!double.TryParse(lines[6], out double step))
                            {
                                MessageBox.Show("Файл содержит некорректное значение шага, исправьте данные.", "Внимание!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                Btn_LoadData.Enabled = true;
                                return;
                            }

                            a_in.Text = a.ToString();
                            b_in.Text = b.ToString();
                            c_in.Text = c.ToString();
                            d_in.Text = d.ToString();
                            left_border_in.Text = left_border.ToString();
                            right_border_in.Text = right_border.ToString();
                            step_in.Text = step.ToString();

                            bool check = Algorithm.GetCheck(a_in, b_in, c_in, d_in, left_border_in, right_border_in, step_in);
                           
                            if (check)
                            {
                                MessageBox.Show($"Данные успешно загружены из файла {file_path}.", "Загрузка",
                                                                MessageBoxButtons.OK,
                                                                MessageBoxIcon.Information);
                            }
                            else
                            {
                                a_in.Text = "";
                                b_in.Text = "";
                                c_in.Text = "";
                                d_in.Text = "";
                                left_border_in.Text = "";
                                right_border_in.Text = "";
                                step_in.Text = "";
                                MessageBox.Show($"Не удалось загрузить данные из файла {file_path}.", "Ошибка",
                                                                MessageBoxButtons.OK,
                                                                MessageBoxIcon.Error);
                            }
                        }
                        else if (lines.Length < 7)
                        {
                            MessageBox.Show("Данных не хватает, должно быть 7 строк в файле.", "Внимание!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            Btn_LoadData.Enabled = true;
                            return;
                        }
                        else if (lines.Length > 7)
                        {
                            MessageBox.Show("Данных слишком много, должно быть 7 строк в файле.", "Внимание!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            Btn_LoadData.Enabled = true;
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при загрузке данных: {ex.Message}", "Ошибка", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }

            Btn_LoadData.Enabled = true;
        }


        private void Btn_SaveOriginal_Click(object sender, EventArgs e)
        {
            Btn_SaveOriginal.Enabled = false;

            try
            {
                bool check = Algorithm.GetCheck(a_in, b_in, c_in, d_in, left_border_in, right_border_in, step_in);

                if (check)
                {
                    double a = double.Parse(a_in.Text);
                    double b = double.Parse(b_in.Text);
                    double c = double.Parse(c_in.Text);
                    double d = double.Parse(d_in.Text);
                    double left_border = double.Parse(left_border_in.Text);
                    double right_border = double.Parse(right_border_in.Text);
                    double step = double.Parse(step_in.Text);

                    string original_data = a + Environment.NewLine
                                             + b + Environment.NewLine
                                             + c + Environment.NewLine
                                             + d + Environment.NewLine
                                             + left_border + Environment.NewLine
                                             + right_border + Environment.NewLine
                                             + step;


                    // Диалог выбора места сохранения файла
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Получение пути к выбранному файлу
                        string file_path = saveFileDialog.FileName;

                        // Запись данных в файл
                        File.WriteAllText(file_path, original_data);
                        MessageBox.Show($"Данные успешно сохранены в файл {file_path}.", "Сохранение", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                    }          
                }
                else
                {
                    MessageBox.Show("Сохранить данные не удалось.", "Ошибка", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при сохранении данных: {ex.Message}.", "Ошибка", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }

            Btn_SaveOriginal.Enabled = true;
        }


        private void Btn_SaveResult_Click(object sender, EventArgs e)
        {
            Btn_SaveResult.Enabled = false;

            try
            {
                bool check = Algorithm.GetCheck(a_in, b_in, c_in, d_in, left_border_in, right_border_in, step_in);

                if (check)
                {
                    double a = double.Parse(a_in.Text);
                    double b = double.Parse(b_in.Text);
                    double c = double.Parse(c_in.Text);
                    double d = double.Parse(d_in.Text);
                    double left_border = double.Parse(left_border_in.Text);
                    double right_border = double.Parse(right_border_in.Text);
                    double step = double.Parse(step_in.Text);

                    Algorithm.StartAlgorithm(a, b, c, d, left_border, right_border, step, result_panel, chart, false);

                    string result = "№\tЗначение X\tЗначение Y" + Environment.NewLine;
                    for (int i = 0; i < Algorithm.elem_counter; i++)
                    {
                        result += $"{i+1}\t{Algorithm.list_x[i]}\t{Algorithm.list_y[i]}" + Environment.NewLine;
                    }

                    string save_data = "Исходные значения:" + Environment.NewLine
                                             + "График:" + Environment.NewLine
                                             + $"y = {a} + {b} * sin({c} * x + {d})" + Environment.NewLine
                                             + "Левая граница: " + left_border + Environment.NewLine
                                             + "Правая граница: " + right_border + Environment.NewLine
                                             + "Шаг расчёта: " + step + Environment.NewLine
                                             + "Результат: " + Environment.NewLine + result;

                    // Диалог выбора места сохранения файла
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Получение пути к выбранному файлу
                        string file_path = saveFileDialog.FileName;
                        // Запись данных в файл
                        File.WriteAllText(file_path, save_data);
                        MessageBox.Show($"Данные успешно сохранены в файл {file_path}.", "Сохранение", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                    }
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Текстовые файлы (*.png)|*.png|Все файлы (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Получение пути к выбранному файлу
                        string file_path = saveFileDialog.FileName;
                        // Запись данных в файл

                        this.chart.SaveImage(file_path, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show($"Данные успешно сохранены в файл {file_path}.", "Сохранение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Сохранить данные не удалось.", "Ошибка", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при сохранении данных: {ex.Message}.", "Ошибка", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }

            Btn_SaveResult.Enabled = true;
        }


        private void a_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем вводить только цифры и запятые
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }
        }


        private void b_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем вводить только цифры и запятые
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }
        }


        private void c_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем вводить только цифры и запятые
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }
        }


        private void d_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем вводить только цифры и запятые
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }
        }


        private void left_border_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем вводить только цифры и запятые
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }
        }


        private void right_border_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем вводить только цифры и запятые
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }
        }


        private void step_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем вводить только цифры и запятые
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }
        }

        private void checkerHello_Click(object sender, EventArgs e)
        {
            ChangeCheckBoxValue(this);
        }
    }
}
