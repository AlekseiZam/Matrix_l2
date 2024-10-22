
namespace Matrix_l2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.fillButton = new System.Windows.Forms.Button();
            this.oneCalcButton = new System.Windows.Forms.Button();
            this.multiCalcButton = new System.Windows.Forms.Button();
            this.MARowTextBox = new System.Windows.Forms.TextBox();
            this.MAColTextBox = new System.Windows.Forms.TextBox();
            this.MBRowTextBox = new System.Windows.Forms.TextBox();
            this.MBColTextBox = new System.Windows.Forms.TextBox();
            this.MCRowTextBox = new System.Windows.Forms.TextBox();
            this.MCColTextBox = new System.Windows.Forms.TextBox();
            this.oneTimeLabel = new System.Windows.Forms.Label();
            this.multiTimeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtSteps = new System.Windows.Forms.TextBox();
            this.textS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(37, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(240, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Location = new System.Drawing.Point(295, 174);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(240, 183);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.ColumnHeadersVisible = false;
            this.dataGridView3.Location = new System.Drawing.Point(553, 174);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(240, 183);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(826, 174);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(164, 183);
            this.dataGridView4.TabIndex = 3;
            // 
            // fillButton
            // 
            this.fillButton.Location = new System.Drawing.Point(37, 24);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(86, 43);
            this.fillButton.TabIndex = 4;
            this.fillButton.Text = "Заполнить матрицы AxB";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // oneCalcButton
            // 
            this.oneCalcButton.Location = new System.Drawing.Point(169, 24);
            this.oneCalcButton.Name = "oneCalcButton";
            this.oneCalcButton.Size = new System.Drawing.Size(103, 55);
            this.oneCalcButton.TabIndex = 5;
            this.oneCalcButton.Text = "Умножить матрицы (одназадач.)";
            this.oneCalcButton.UseVisualStyleBackColor = true;
            this.oneCalcButton.Click += new System.EventHandler(this.oneCalcButton_Click);
            // 
            // multiCalcButton
            // 
            this.multiCalcButton.Location = new System.Drawing.Point(423, 24);
            this.multiCalcButton.Name = "multiCalcButton";
            this.multiCalcButton.Size = new System.Drawing.Size(142, 55);
            this.multiCalcButton.TabIndex = 6;
            this.multiCalcButton.Text = "Умножить матрицы \r\nКол-во задач = ";
            this.multiCalcButton.UseVisualStyleBackColor = true;
            this.multiCalcButton.Click += new System.EventHandler(this.multiCalcButton_Click);
            // 
            // MARowTextBox
            // 
            this.MARowTextBox.Location = new System.Drawing.Point(158, 116);
            this.MARowTextBox.Name = "MARowTextBox";
            this.MARowTextBox.Size = new System.Drawing.Size(100, 20);
            this.MARowTextBox.TabIndex = 7;
            // 
            // MAColTextBox
            // 
            this.MAColTextBox.Location = new System.Drawing.Point(158, 142);
            this.MAColTextBox.Name = "MAColTextBox";
            this.MAColTextBox.Size = new System.Drawing.Size(100, 20);
            this.MAColTextBox.TabIndex = 8;
            // 
            // MBRowTextBox
            // 
            this.MBRowTextBox.Location = new System.Drawing.Point(412, 117);
            this.MBRowTextBox.Name = "MBRowTextBox";
            this.MBRowTextBox.Size = new System.Drawing.Size(100, 20);
            this.MBRowTextBox.TabIndex = 9;
            // 
            // MBColTextBox
            // 
            this.MBColTextBox.Location = new System.Drawing.Point(412, 143);
            this.MBColTextBox.Name = "MBColTextBox";
            this.MBColTextBox.Size = new System.Drawing.Size(100, 20);
            this.MBColTextBox.TabIndex = 10;
            // 
            // MCRowTextBox
            // 
            this.MCRowTextBox.Location = new System.Drawing.Point(679, 113);
            this.MCRowTextBox.Name = "MCRowTextBox";
            this.MCRowTextBox.Size = new System.Drawing.Size(100, 20);
            this.MCRowTextBox.TabIndex = 11;
            // 
            // MCColTextBox
            // 
            this.MCColTextBox.Location = new System.Drawing.Point(679, 139);
            this.MCColTextBox.Name = "MCColTextBox";
            this.MCColTextBox.Size = new System.Drawing.Size(100, 20);
            this.MCColTextBox.TabIndex = 12;
            // 
            // oneTimeLabel
            // 
            this.oneTimeLabel.AutoSize = true;
            this.oneTimeLabel.Location = new System.Drawing.Point(155, 82);
            this.oneTimeLabel.Name = "oneTimeLabel";
            this.oneTimeLabel.Size = new System.Drawing.Size(143, 13);
            this.oneTimeLabel.TabIndex = 14;
            this.oneTimeLabel.Text = "Время выполнения (тики): ";
            // 
            // multiTimeLabel
            // 
            this.multiTimeLabel.AutoSize = true;
            this.multiTimeLabel.Location = new System.Drawing.Point(428, 82);
            this.multiTimeLabel.Name = "multiTimeLabel";
            this.multiTimeLabel.Size = new System.Drawing.Size(143, 13);
            this.multiTimeLabel.TabIndex = 15;
            this.multiTimeLabel.Text = "Время выполнения (тики): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Матрица А. Строки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Матрица А. Столбцы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Матрица В. Строки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Матрица В. Столбцы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(550, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Матрица АxВ. Строки";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(550, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Матрица АxВ. Столбцы";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(851, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Время одной задачи";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1081, 430);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.oneCalcButton);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.dataGridView4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.fillButton);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.multiCalcButton);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.MARowTextBox);
            this.tabPage1.Controls.Add(this.multiTimeLabel);
            this.tabPage1.Controls.Add(this.MAColTextBox);
            this.tabPage1.Controls.Add(this.oneTimeLabel);
            this.tabPage1.Controls.Add(this.MBRowTextBox);
            this.tabPage1.Controls.Add(this.MCColTextBox);
            this.tabPage1.Controls.Add(this.MBColTextBox);
            this.tabPage1.Controls.Add(this.MCRowTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1073, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Матрицы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.chartResults);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textS);
            this.tabPage2.Controls.Add(this.txtSteps);
            this.tabPage2.Controls.Add(this.txtEnd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1073, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "График";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(222, 23);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(100, 20);
            this.txtEnd.TabIndex = 0;
            // 
            // txtSteps
            // 
            this.txtSteps.Location = new System.Drawing.Point(386, 22);
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.Size = new System.Drawing.Size(100, 20);
            this.txtSteps.TabIndex = 1;
            // 
            // textS
            // 
            this.textS.Location = new System.Drawing.Point(563, 22);
            this.textS.Name = "textS";
            this.textS.Size = new System.Drawing.Size(100, 20);
            this.textS.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pmax";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Кол-во процессоров";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Доля последовательной части";
            // 
            // chartResults
            // 
            chartArea2.Name = "ChartArea1";
            this.chartResults.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartResults.Legends.Add(legend2);
            this.chartResults.Location = new System.Drawing.Point(86, 83);
            this.chartResults.Name = "chartResults";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartResults.Series.Add(series2);
            this.chartResults.Size = new System.Drawing.Size(879, 300);
            this.chartResults.TabIndex = 6;
            this.chartResults.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Построить график";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 468);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Button oneCalcButton;
        private System.Windows.Forms.Button multiCalcButton;
        private System.Windows.Forms.TextBox MARowTextBox;
        private System.Windows.Forms.TextBox MAColTextBox;
        private System.Windows.Forms.TextBox MBRowTextBox;
        private System.Windows.Forms.TextBox MBColTextBox;
        private System.Windows.Forms.TextBox MCRowTextBox;
        private System.Windows.Forms.TextBox MCColTextBox;
        private System.Windows.Forms.Label oneTimeLabel;
        private System.Windows.Forms.Label multiTimeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textS;
        private System.Windows.Forms.TextBox txtSteps;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Button button1;
    }
}

