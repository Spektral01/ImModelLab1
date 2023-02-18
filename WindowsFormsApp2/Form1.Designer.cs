
namespace WindowsFormsApp2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnStart = new System.Windows.Forms.Button();
            this.CheckPoverh = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NumSize = new System.Windows.Forms.NumericUpDown();
            this.NumWeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TrackStep = new System.Windows.Forms.TrackBar();
            this.NumSpeed = new System.Windows.Forms.NumericUpDown();
            this.NumAngle = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LabelResX = new System.Windows.Forms.Label();
            this.LabelResY = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LabelResStep = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LabelSpeed = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelSpeed);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.LabelResStep);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.LabelResY);
            this.panel1.Controls.Add(this.LabelResX);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.BtnStart);
            this.panel1.Controls.Add(this.CheckPoverh);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.NumSize);
            this.panel1.Controls.Add(this.NumWeight);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TrackStep);
            this.panel1.Controls.Add(this.NumSpeed);
            this.panel1.Controls.Add(this.NumAngle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NumHeight);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 735);
            this.panel1.TabIndex = 0;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(37, 391);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(289, 68);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Старт";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // CheckPoverh
            // 
            this.CheckPoverh.AutoSize = true;
            this.CheckPoverh.Location = new System.Drawing.Point(37, 325);
            this.CheckPoverh.Name = "CheckPoverh";
            this.CheckPoverh.Size = new System.Drawing.Size(154, 21);
            this.CheckPoverh.TabIndex = 1;
            this.CheckPoverh.Text = "Наложение поверх";
            this.CheckPoverh.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Шаг";
            // 
            // NumSize
            // 
            this.NumSize.Location = new System.Drawing.Point(101, 220);
            this.NumSize.Name = "NumSize";
            this.NumSize.Size = new System.Drawing.Size(120, 22);
            this.NumSize.TabIndex = 4;
            this.NumSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumWeight
            // 
            this.NumWeight.Location = new System.Drawing.Point(101, 174);
            this.NumWeight.Name = "NumWeight";
            this.NumWeight.Size = new System.Drawing.Size(120, 22);
            this.NumWeight.TabIndex = 6;
            this.NumWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Масса";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Площадь";
            // 
            // TrackStep
            // 
            this.TrackStep.LargeChange = 1;
            this.TrackStep.Location = new System.Drawing.Point(102, 263);
            this.TrackStep.Minimum = 1;
            this.TrackStep.Name = "TrackStep";
            this.TrackStep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TrackStep.Size = new System.Drawing.Size(224, 56);
            this.TrackStep.SmallChange = 10;
            this.TrackStep.TabIndex = 1;
            this.TrackStep.Value = 1;
            // 
            // NumSpeed
            // 
            this.NumSpeed.Location = new System.Drawing.Point(101, 121);
            this.NumSpeed.Name = "NumSpeed";
            this.NumSpeed.Size = new System.Drawing.Size(120, 22);
            this.NumSpeed.TabIndex = 2;
            this.NumSpeed.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // NumAngle
            // 
            this.NumAngle.Location = new System.Drawing.Point(101, 75);
            this.NumAngle.Name = "NumAngle";
            this.NumAngle.Size = new System.Drawing.Size(120, 22);
            this.NumAngle.TabIndex = 3;
            this.NumAngle.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Угол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Скорость";
            // 
            // NumHeight
            // 
            this.NumHeight.Location = new System.Drawing.Point(101, 30);
            this.NumHeight.Name = "NumHeight";
            this.NumHeight.Size = new System.Drawing.Size(120, 22);
            this.NumHeight.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Высота";
            // 
            // chart1
            // 
            chartArea1.AxisX.Maximum = 25D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 10D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(471, 30);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Series";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series4";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series6";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(827, 641);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "X:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 579);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Максимум по Y:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Результат";
            // 
            // LabelResX
            // 
            this.LabelResX.AutoSize = true;
            this.LabelResX.Location = new System.Drawing.Point(293, 534);
            this.LabelResX.Name = "LabelResX";
            this.LabelResX.Size = new System.Drawing.Size(0, 17);
            this.LabelResX.TabIndex = 12;
            // 
            // LabelResY
            // 
            this.LabelResY.AutoSize = true;
            this.LabelResY.Location = new System.Drawing.Point(293, 579);
            this.LabelResY.Name = "LabelResY";
            this.LabelResY.Size = new System.Drawing.Size(0, 17);
            this.LabelResY.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Максимум 5 линий";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 627);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Шаг:";
            // 
            // LabelResStep
            // 
            this.LabelResStep.AutoSize = true;
            this.LabelResStep.Location = new System.Drawing.Point(293, 627);
            this.LabelResStep.Name = "LabelResStep";
            this.LabelResStep.Size = new System.Drawing.Size(0, 17);
            this.LabelResStep.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 667);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Скорость в конечной точке:";
            // 
            // LabelSpeed
            // 
            this.LabelSpeed.AutoSize = true;
            this.LabelSpeed.Location = new System.Drawing.Point(293, 667);
            this.LabelSpeed.Name = "LabelSpeed";
            this.LabelSpeed.Size = new System.Drawing.Size(0, 17);
            this.LabelSpeed.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 735);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar TrackStep;
        private System.Windows.Forms.NumericUpDown NumSpeed;
        private System.Windows.Forms.NumericUpDown NumAngle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumSize;
        private System.Windows.Forms.NumericUpDown NumWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.CheckBox CheckPoverh;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label LabelResY;
        private System.Windows.Forms.Label LabelResX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LabelResStep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LabelSpeed;
    }
}

