namespace RPS3
{
    partial class Work3
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.a_in = new System.Windows.Forms.TextBox();
            this.b_in = new System.Windows.Forms.TextBox();
            this.c_in = new System.Windows.Forms.TextBox();
            this.d_in = new System.Windows.Forms.TextBox();
            this.right_border_in = new System.Windows.Forms.TextBox();
            this.left_border_in = new System.Windows.Forms.TextBox();
            this.step_in = new System.Windows.Forms.TextBox();
            this.Btn_GetResult = new System.Windows.Forms.Button();
            this.Btn_LoadData = new System.Windows.Forms.Button();
            this.Btn_SaveOriginal = new System.Windows.Forms.Button();
            this.Btn_SaveResult = new System.Windows.Forms.Button();
            this.result_panel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(383, 20);
            this.chart.Name = "chart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Sin";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(721, 498);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1124, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "y = a + b * sin(c * x + d)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1124, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "График";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1124, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Коэффициенты:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1124, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "a =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1124, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "b =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1296, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "d =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1296, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "c =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1124, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "Правая граница:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1124, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "Шаг расчёта:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(1124, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 29);
            this.label10.TabIndex = 10;
            this.label10.Text = "Левая граница:";
            // 
            // a_in
            // 
            this.a_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a_in.Location = new System.Drawing.Point(1176, 143);
            this.a_in.Name = "a_in";
            this.a_in.Size = new System.Drawing.Size(102, 34);
            this.a_in.TabIndex = 11;
            // 
            // b_in
            // 
            this.b_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_in.Location = new System.Drawing.Point(1176, 183);
            this.b_in.Name = "b_in";
            this.b_in.Size = new System.Drawing.Size(102, 34);
            this.b_in.TabIndex = 12;
            // 
            // c_in
            // 
            this.c_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c_in.Location = new System.Drawing.Point(1347, 140);
            this.c_in.Name = "c_in";
            this.c_in.Size = new System.Drawing.Size(102, 34);
            this.c_in.TabIndex = 13;
            // 
            // d_in
            // 
            this.d_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d_in.Location = new System.Drawing.Point(1347, 182);
            this.d_in.Name = "d_in";
            this.d_in.Size = new System.Drawing.Size(102, 34);
            this.d_in.TabIndex = 14;
            // 
            // right_border_in
            // 
            this.right_border_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.right_border_in.Location = new System.Drawing.Point(1347, 278);
            this.right_border_in.Name = "right_border_in";
            this.right_border_in.Size = new System.Drawing.Size(102, 34);
            this.right_border_in.TabIndex = 16;
            // 
            // left_border_in
            // 
            this.left_border_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.left_border_in.Location = new System.Drawing.Point(1347, 238);
            this.left_border_in.Name = "left_border_in";
            this.left_border_in.Size = new System.Drawing.Size(102, 34);
            this.left_border_in.TabIndex = 15;
            // 
            // step_in
            // 
            this.step_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step_in.Location = new System.Drawing.Point(1347, 317);
            this.step_in.Name = "step_in";
            this.step_in.Size = new System.Drawing.Size(102, 34);
            this.step_in.TabIndex = 17;
            // 
            // Btn_GetResult
            // 
            this.Btn_GetResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_GetResult.Location = new System.Drawing.Point(1129, 364);
            this.Btn_GetResult.Name = "Btn_GetResult";
            this.Btn_GetResult.Size = new System.Drawing.Size(376, 37);
            this.Btn_GetResult.TabIndex = 18;
            this.Btn_GetResult.Text = "Построить график";
            this.Btn_GetResult.UseVisualStyleBackColor = true;
            this.Btn_GetResult.Click += new System.EventHandler(this.Btn_GetResult_Click);
            // 
            // Btn_LoadData
            // 
            this.Btn_LoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_LoadData.Location = new System.Drawing.Point(1129, 404);
            this.Btn_LoadData.Name = "Btn_LoadData";
            this.Btn_LoadData.Size = new System.Drawing.Size(376, 37);
            this.Btn_LoadData.TabIndex = 19;
            this.Btn_LoadData.Text = "Загрузить данные из файла";
            this.Btn_LoadData.UseVisualStyleBackColor = true;
            this.Btn_LoadData.Click += new System.EventHandler(this.Btn_LoadData_Click);
            // 
            // Btn_SaveOriginal
            // 
            this.Btn_SaveOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_SaveOriginal.Location = new System.Drawing.Point(1129, 444);
            this.Btn_SaveOriginal.Name = "Btn_SaveOriginal";
            this.Btn_SaveOriginal.Size = new System.Drawing.Size(376, 37);
            this.Btn_SaveOriginal.TabIndex = 20;
            this.Btn_SaveOriginal.Text = "Сохранить исходные данные";
            this.Btn_SaveOriginal.UseVisualStyleBackColor = true;
            this.Btn_SaveOriginal.Click += new System.EventHandler(this.Btn_SaveOriginal_Click);
            // 
            // Btn_SaveResult
            // 
            this.Btn_SaveResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_SaveResult.Location = new System.Drawing.Point(1129, 484);
            this.Btn_SaveResult.Name = "Btn_SaveResult";
            this.Btn_SaveResult.Size = new System.Drawing.Size(376, 37);
            this.Btn_SaveResult.TabIndex = 21;
            this.Btn_SaveResult.Text = "Сохранить результат";
            this.Btn_SaveResult.UseVisualStyleBackColor = true;
            this.Btn_SaveResult.Click += new System.EventHandler(this.Btn_SaveResult_Click);
            // 
            // result_panel
            // 
            this.result_panel.AutoScroll = true;
            this.result_panel.Location = new System.Drawing.Point(12, 59);
            this.result_panel.Name = "result_panel";
            this.result_panel.Size = new System.Drawing.Size(352, 459);
            this.result_panel.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 29);
            this.label11.TabIndex = 23;
            this.label11.Text = "№";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(54, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 29);
            this.label12.TabIndex = 24;
            this.label12.Text = "Значение X";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(217, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 29);
            this.label13.TabIndex = 25;
            this.label13.Text = "Значение Y";
            // 
            // Work3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 548);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.result_panel);
            this.Controls.Add(this.Btn_SaveResult);
            this.Controls.Add(this.Btn_SaveOriginal);
            this.Controls.Add(this.Btn_LoadData);
            this.Controls.Add(this.Btn_GetResult);
            this.Controls.Add(this.step_in);
            this.Controls.Add(this.left_border_in);
            this.Controls.Add(this.right_border_in);
            this.Controls.Add(this.d_in);
            this.Controls.Add(this.c_in);
            this.Controls.Add(this.b_in);
            this.Controls.Add(this.a_in);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart);
            this.Name = "Work3";
            this.Text = "График синусоиды";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox a_in;
        private System.Windows.Forms.TextBox b_in;
        private System.Windows.Forms.TextBox c_in;
        private System.Windows.Forms.TextBox d_in;
        private System.Windows.Forms.TextBox right_border_in;
        private System.Windows.Forms.TextBox left_border_in;
        private System.Windows.Forms.TextBox step_in;
        private System.Windows.Forms.Button Btn_GetResult;
        private System.Windows.Forms.Button Btn_LoadData;
        private System.Windows.Forms.Button Btn_SaveOriginal;
        private System.Windows.Forms.Button Btn_SaveResult;
        private System.Windows.Forms.Panel result_panel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

