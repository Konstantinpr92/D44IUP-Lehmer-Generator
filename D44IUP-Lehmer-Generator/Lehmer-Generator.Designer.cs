
namespace D44IUP_Lehmer_Generator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаГенератораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычислениеЧислаPiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1fX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtBoxforN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbCs = new System.Windows.Forms.RadioButton();
            this.rbL = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1fX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1380, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкаГенератораToolStripMenuItem,
            this.вычислениеЧислаPiToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // настройкаГенератораToolStripMenuItem
            // 
            this.настройкаГенератораToolStripMenuItem.Name = "настройкаГенератораToolStripMenuItem";
            this.настройкаГенератораToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.настройкаГенератораToolStripMenuItem.Text = "Настройка генератора";
            this.настройкаГенератораToolStripMenuItem.Click += new System.EventHandler(this.настройкаГенератораToolStripMenuItem_Click);
            // 
            // вычислениеЧислаPiToolStripMenuItem
            // 
            this.вычислениеЧислаPiToolStripMenuItem.Name = "вычислениеЧислаPiToolStripMenuItem";
            this.вычислениеЧислаPiToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.вычислениеЧислаPiToolStripMenuItem.Text = "Вычисление числа Пи";
            this.вычислениеЧислаPiToolStripMenuItem.Click += new System.EventHandler(this.вычислениеЧислаPiToolStripMenuItem_Click);
            // 
            // chart1fX
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1fX.ChartAreas.Add(chartArea7);
            this.chart1fX.Location = new System.Drawing.Point(208, 0);
            this.chart1fX.Name = "chart1fX";
            this.chart1fX.Size = new System.Drawing.Size(1172, 330);
            this.chart1fX.TabIndex = 1;
            this.chart1fX.Text = "chart1fX";
            // 
            // chart2
            // 
            chartArea8.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea8);
            this.chart2.Location = new System.Drawing.Point(208, 327);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(1172, 330);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2FX";
            // 
            // txtBoxforN
            // 
            this.txtBoxforN.Location = new System.Drawing.Point(30, 132);
            this.txtBoxforN.Name = "txtBoxforN";
            this.txtBoxforN.Size = new System.Drawing.Size(153, 20);
            this.txtBoxforN.TabIndex = 3;
            this.txtBoxforN.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "100 <= n <= 10000";
            // 
            // rbCs
            // 
            this.rbCs.AutoSize = true;
            this.rbCs.Location = new System.Drawing.Point(30, 245);
            this.rbCs.Name = "rbCs";
            this.rbCs.Size = new System.Drawing.Size(116, 17);
            this.rbCs.TabIndex = 6;
            this.rbCs.Text = "Класс Random C#";
            this.rbCs.UseVisualStyleBackColor = true;
            // 
            // rbL
            // 
            this.rbL.AutoSize = true;
            this.rbL.Checked = true;
            this.rbL.Location = new System.Drawing.Point(30, 209);
            this.rbL.Name = "rbL";
            this.rbL.Size = new System.Drawing.Size(172, 30);
            this.rbL.TabIndex = 7;
            this.rbL.TabStop = true;
            this.rbL.Text = "Собственный генератор,\r\nреализующий метод Лемера";
            this.rbL.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "Будет сгенерировано n\r\nпсевдослучайных целых\r\nчисел диапазона [0; 99].";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Использовать:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(30, 304);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(153, 23);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Сгенерировать";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.BackColor = System.Drawing.SystemColors.Menu;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtResult.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtResult.Location = new System.Drawing.Point(12, 660);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(258, 20);
            this.txtResult.TabIndex = 11;
            this.txtResult.Text = "Результаты: ожидает генерации";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(30, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(153, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Сброс";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 687);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbL);
            this.Controls.Add(this.rbCs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxforN);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1fX);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моделирование";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1fX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаГенератораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычислениеЧислаPiToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1fX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TextBox txtBoxforN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbCs;
        private System.Windows.Forms.RadioButton rbL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.Button btnClear;
    }
}

