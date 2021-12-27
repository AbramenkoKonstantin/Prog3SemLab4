
namespace Prog3SemLab4
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
            System.Windows.Forms.Label bogoTimeLable;
            System.Windows.Forms.Label quickTimeLabel;
            System.Windows.Forms.Label shakerTimeLabel;
            System.Windows.Forms.Label insetionTimeLabel;
            System.Windows.Forms.Label bubbleTimeLabel;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.launchButton = new System.Windows.Forms.ToolStripMenuItem();
            this.arrayImport = new System.Windows.Forms.ToolStripMenuItem();
            this.excelImport = new System.Windows.Forms.ToolStripMenuItem();
            this.randomGeneration = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.formClearButton = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.randomCount = new System.Windows.Forms.TextBox();
            this.decreasingSort = new System.Windows.Forms.RadioButton();
            this.increasingSort = new System.Windows.Forms.RadioButton();
            this.bogoSort = new System.Windows.Forms.GroupBox();
            this.bogoChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bogoTimeBox = new System.Windows.Forms.TextBox();
            this.bogoCheck = new System.Windows.Forms.CheckBox();
            this.quickSort = new System.Windows.Forms.GroupBox();
            this.quickChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.quickTimeBox = new System.Windows.Forms.TextBox();
            this.quickCheck = new System.Windows.Forms.CheckBox();
            this.shakerSort = new System.Windows.Forms.GroupBox();
            this.shakerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.shakerTimeBox = new System.Windows.Forms.TextBox();
            this.shakerCheck = new System.Windows.Forms.CheckBox();
            this.insertionSort = new System.Windows.Forms.GroupBox();
            this.insertionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.insertionTimeBox = new System.Windows.Forms.TextBox();
            this.insertionCheck = new System.Windows.Forms.CheckBox();
            this.bubbleSort = new System.Windows.Forms.GroupBox();
            this.bubbleChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bubbleTimeBox = new System.Windows.Forms.TextBox();
            this.bubbleCheck = new System.Windows.Forms.CheckBox();
            this.arrayGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bogoTimeLable = new System.Windows.Forms.Label();
            quickTimeLabel = new System.Windows.Forms.Label();
            shakerTimeLabel = new System.Windows.Forms.Label();
            insetionTimeLabel = new System.Windows.Forms.Label();
            bubbleTimeLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.bogoSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bogoChart)).BeginInit();
            this.quickSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quickChart)).BeginInit();
            this.shakerSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shakerChart)).BeginInit();
            this.insertionSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertionChart)).BeginInit();
            this.bubbleSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrayGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bogoTimeLable
            // 
            bogoTimeLable.AutoSize = true;
            bogoTimeLable.Location = new System.Drawing.Point(6, 58);
            bogoTimeLable.Name = "bogoTimeLable";
            bogoTimeLable.Size = new System.Drawing.Size(102, 13);
            bogoTimeLable.TabIndex = 36;
            bogoTimeLable.Text = "Время сортировки";
            // 
            // quickTimeLabel
            // 
            quickTimeLabel.AutoSize = true;
            quickTimeLabel.Location = new System.Drawing.Point(6, 58);
            quickTimeLabel.Name = "quickTimeLabel";
            quickTimeLabel.Size = new System.Drawing.Size(102, 13);
            quickTimeLabel.TabIndex = 34;
            quickTimeLabel.Text = "Время сортировки";
            // 
            // shakerTimeLabel
            // 
            shakerTimeLabel.AutoSize = true;
            shakerTimeLabel.Location = new System.Drawing.Point(6, 58);
            shakerTimeLabel.Name = "shakerTimeLabel";
            shakerTimeLabel.Size = new System.Drawing.Size(102, 13);
            shakerTimeLabel.TabIndex = 32;
            shakerTimeLabel.Text = "Время сортировки";
            // 
            // insetionTimeLabel
            // 
            insetionTimeLabel.AutoSize = true;
            insetionTimeLabel.Location = new System.Drawing.Point(6, 58);
            insetionTimeLabel.Name = "insetionTimeLabel";
            insetionTimeLabel.Size = new System.Drawing.Size(102, 13);
            insetionTimeLabel.TabIndex = 30;
            insetionTimeLabel.Text = "Время сортировки";
            // 
            // bubbleTimeLabel
            // 
            bubbleTimeLabel.AutoSize = true;
            bubbleTimeLabel.Location = new System.Drawing.Point(6, 56);
            bubbleTimeLabel.Name = "bubbleTimeLabel";
            bubbleTimeLabel.Size = new System.Drawing.Size(102, 13);
            bubbleTimeLabel.TabIndex = 28;
            bubbleTimeLabel.Text = "Время сортировки";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launchButton,
            this.arrayImport,
            this.exitButton,
            this.formClearButton});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(898, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // launchButton
            // 
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(57, 20);
            this.launchButton.Text = "Запуск";
            this.launchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // arrayImport
            // 
            this.arrayImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelImport,
            this.randomGeneration});
            this.arrayImport.Name = "arrayImport";
            this.arrayImport.Size = new System.Drawing.Size(63, 20);
            this.arrayImport.Text = "Импорт";
            // 
            // excelImport
            // 
            this.excelImport.Name = "excelImport";
            this.excelImport.Size = new System.Drawing.Size(116, 22);
            this.excelImport.Text = "Excel";
            this.excelImport.Click += new System.EventHandler(this.ExcelImport_Click);
            // 
            // randomGeneration
            // 
            this.randomGeneration.Name = "randomGeneration";
            this.randomGeneration.Size = new System.Drawing.Size(116, 22);
            this.randomGeneration.Text = "Рандом";
            this.randomGeneration.Click += new System.EventHandler(this.ArrayGeneration_Click);
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(54, 20);
            this.exitButton.Text = "Выход";
            this.exitButton.Click += new System.EventHandler(this.CloseBtnClick);
            // 
            // formClearButton
            // 
            this.formClearButton.Name = "formClearButton";
            this.formClearButton.Size = new System.Drawing.Size(109, 20);
            this.formClearButton.Text = "Очистка формы";
            this.formClearButton.Click += new System.EventHandler(this.FormClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Количество чисел";
            // 
            // randomCount
            // 
            this.randomCount.Location = new System.Drawing.Point(10, 467);
            this.randomCount.Name = "randomCount";
            this.randomCount.Size = new System.Drawing.Size(102, 20);
            this.randomCount.TabIndex = 38;
            // 
            // decreasingSort
            // 
            this.decreasingSort.AutoSize = true;
            this.decreasingSort.Location = new System.Drawing.Point(10, 524);
            this.decreasingSort.Name = "decreasingSort";
            this.decreasingSort.Size = new System.Drawing.Size(93, 17);
            this.decreasingSort.TabIndex = 32;
            this.decreasingSort.TabStop = true;
            this.decreasingSort.Tag = "DecreasingSort";
            this.decreasingSort.Text = "По убыванию";
            this.decreasingSort.UseVisualStyleBackColor = true;
            // 
            // increasingSort
            // 
            this.increasingSort.AutoSize = true;
            this.increasingSort.Location = new System.Drawing.Point(10, 503);
            this.increasingSort.Name = "increasingSort";
            this.increasingSort.Size = new System.Drawing.Size(109, 17);
            this.increasingSort.TabIndex = 31;
            this.increasingSort.TabStop = true;
            this.increasingSort.Tag = "IncreasingSort";
            this.increasingSort.Text = "По возрастанию";
            this.increasingSort.UseVisualStyleBackColor = true;
            // 
            // bogoSort
            // 
            this.bogoSort.Controls.Add(this.bogoChart);
            this.bogoSort.Controls.Add(this.bogoTimeBox);
            this.bogoSort.Controls.Add(bogoTimeLable);
            this.bogoSort.Controls.Add(this.bogoCheck);
            this.bogoSort.Location = new System.Drawing.Point(137, 447);
            this.bogoSort.Name = "bogoSort";
            this.bogoSort.Size = new System.Drawing.Size(739, 100);
            this.bogoSort.TabIndex = 36;
            this.bogoSort.TabStop = false;
            // 
            // bogoChart
            // 
            chartArea1.Name = "ChartArea1";
            this.bogoChart.ChartAreas.Add(chartArea1);
            this.bogoChart.Location = new System.Drawing.Point(114, 19);
            this.bogoChart.Name = "bogoChart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.bogoChart.Series.Add(series1);
            this.bogoChart.Size = new System.Drawing.Size(608, 75);
            this.bogoChart.TabIndex = 36;
            this.bogoChart.Tag = "BOGOSort";
            // 
            // bogoTimeBox
            // 
            this.bogoTimeBox.Enabled = false;
            this.bogoTimeBox.Location = new System.Drawing.Point(9, 74);
            this.bogoTimeBox.Name = "bogoTimeBox";
            this.bogoTimeBox.Size = new System.Drawing.Size(99, 20);
            this.bogoTimeBox.TabIndex = 37;
            // 
            // bogoCheck
            // 
            this.bogoCheck.AutoSize = true;
            this.bogoCheck.Location = new System.Drawing.Point(13, 19);
            this.bogoCheck.Name = "bogoCheck";
            this.bogoCheck.Size = new System.Drawing.Size(57, 17);
            this.bogoCheck.TabIndex = 26;
            this.bogoCheck.Tag = "BOGOSort";
            this.bogoCheck.Text = "BOGO";
            this.bogoCheck.UseVisualStyleBackColor = true;
            // 
            // quickSort
            // 
            this.quickSort.Controls.Add(this.quickChart);
            this.quickSort.Controls.Add(this.quickTimeBox);
            this.quickSort.Controls.Add(quickTimeLabel);
            this.quickSort.Controls.Add(this.quickCheck);
            this.quickSort.Location = new System.Drawing.Point(137, 342);
            this.quickSort.Name = "quickSort";
            this.quickSort.Size = new System.Drawing.Size(739, 100);
            this.quickSort.TabIndex = 37;
            this.quickSort.TabStop = false;
            // 
            // quickChart
            // 
            chartArea2.Name = "ChartArea1";
            this.quickChart.ChartAreas.Add(chartArea2);
            this.quickChart.Location = new System.Drawing.Point(114, 19);
            this.quickChart.Name = "quickChart";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.quickChart.Series.Add(series2);
            this.quickChart.Size = new System.Drawing.Size(608, 75);
            this.quickChart.TabIndex = 34;
            this.quickChart.Tag = "quickSort";
            // 
            // quickTimeBox
            // 
            this.quickTimeBox.Enabled = false;
            this.quickTimeBox.Location = new System.Drawing.Point(9, 74);
            this.quickTimeBox.Name = "quickTimeBox";
            this.quickTimeBox.Size = new System.Drawing.Size(99, 20);
            this.quickTimeBox.TabIndex = 35;
            // 
            // quickCheck
            // 
            this.quickCheck.AutoSize = true;
            this.quickCheck.Location = new System.Drawing.Point(13, 19);
            this.quickCheck.Name = "quickCheck";
            this.quickCheck.Size = new System.Drawing.Size(70, 17);
            this.quickCheck.TabIndex = 23;
            this.quickCheck.Tag = "QuickSort";
            this.quickCheck.Text = "Быстрая";
            this.quickCheck.UseVisualStyleBackColor = true;
            // 
            // shakerSort
            // 
            this.shakerSort.Controls.Add(this.shakerChart);
            this.shakerSort.Controls.Add(this.shakerTimeBox);
            this.shakerSort.Controls.Add(shakerTimeLabel);
            this.shakerSort.Controls.Add(this.shakerCheck);
            this.shakerSort.Location = new System.Drawing.Point(137, 237);
            this.shakerSort.Name = "shakerSort";
            this.shakerSort.Size = new System.Drawing.Size(739, 100);
            this.shakerSort.TabIndex = 35;
            this.shakerSort.TabStop = false;
            // 
            // shakerChart
            // 
            chartArea3.Name = "ChartArea1";
            this.shakerChart.ChartAreas.Add(chartArea3);
            this.shakerChart.Location = new System.Drawing.Point(114, 19);
            this.shakerChart.Name = "shakerChart";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.shakerChart.Series.Add(series3);
            this.shakerChart.Size = new System.Drawing.Size(608, 75);
            this.shakerChart.TabIndex = 31;
            this.shakerChart.Tag = "shakerSort";
            // 
            // shakerTimeBox
            // 
            this.shakerTimeBox.Enabled = false;
            this.shakerTimeBox.Location = new System.Drawing.Point(9, 74);
            this.shakerTimeBox.Name = "shakerTimeBox";
            this.shakerTimeBox.Size = new System.Drawing.Size(99, 20);
            this.shakerTimeBox.TabIndex = 33;
            // 
            // shakerCheck
            // 
            this.shakerCheck.AutoSize = true;
            this.shakerCheck.Location = new System.Drawing.Point(13, 19);
            this.shakerCheck.Name = "shakerCheck";
            this.shakerCheck.Size = new System.Drawing.Size(83, 17);
            this.shakerCheck.TabIndex = 19;
            this.shakerCheck.Tag = "ShakerSort";
            this.shakerCheck.Text = "Шейкерная";
            this.shakerCheck.UseVisualStyleBackColor = true;
            // 
            // insertionSort
            // 
            this.insertionSort.Controls.Add(this.insertionChart);
            this.insertionSort.Controls.Add(this.insertionTimeBox);
            this.insertionSort.Controls.Add(insetionTimeLabel);
            this.insertionSort.Controls.Add(this.insertionCheck);
            this.insertionSort.Location = new System.Drawing.Point(137, 132);
            this.insertionSort.Name = "insertionSort";
            this.insertionSort.Size = new System.Drawing.Size(739, 100);
            this.insertionSort.TabIndex = 34;
            this.insertionSort.TabStop = false;
            // 
            // insertionChart
            // 
            chartArea4.Name = "ChartArea1";
            this.insertionChart.ChartAreas.Add(chartArea4);
            this.insertionChart.Location = new System.Drawing.Point(114, 19);
            this.insertionChart.Name = "insertionChart";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1";
            this.insertionChart.Series.Add(series4);
            this.insertionChart.Size = new System.Drawing.Size(608, 73);
            this.insertionChart.TabIndex = 31;
            this.insertionChart.Tag = "insertionSort";
            // 
            // insertionTimeBox
            // 
            this.insertionTimeBox.Enabled = false;
            this.insertionTimeBox.Location = new System.Drawing.Point(9, 74);
            this.insertionTimeBox.Name = "insertionTimeBox";
            this.insertionTimeBox.Size = new System.Drawing.Size(99, 20);
            this.insertionTimeBox.TabIndex = 31;
            // 
            // insertionCheck
            // 
            this.insertionCheck.AutoSize = true;
            this.insertionCheck.Location = new System.Drawing.Point(13, 19);
            this.insertionCheck.Name = "insertionCheck";
            this.insertionCheck.Size = new System.Drawing.Size(82, 17);
            this.insertionCheck.TabIndex = 19;
            this.insertionCheck.Tag = "InsertionSort";
            this.insertionCheck.Text = "Вставками";
            this.insertionCheck.UseVisualStyleBackColor = true;
            // 
            // bubbleSort
            // 
            this.bubbleSort.Controls.Add(this.bubbleChart);
            this.bubbleSort.Controls.Add(this.bubbleTimeBox);
            this.bubbleSort.Controls.Add(bubbleTimeLabel);
            this.bubbleSort.Controls.Add(this.bubbleCheck);
            this.bubbleSort.Location = new System.Drawing.Point(137, 27);
            this.bubbleSort.Name = "bubbleSort";
            this.bubbleSort.Size = new System.Drawing.Size(739, 100);
            this.bubbleSort.TabIndex = 33;
            this.bubbleSort.TabStop = false;
            // 
            // bubbleChart
            // 
            chartArea5.Name = "ChartArea1";
            this.bubbleChart.ChartAreas.Add(chartArea5);
            this.bubbleChart.Location = new System.Drawing.Point(114, 19);
            this.bubbleChart.Name = "bubbleChart";
            series5.ChartArea = "ChartArea1";
            series5.Name = "Series1";
            this.bubbleChart.Series.Add(series5);
            this.bubbleChart.Size = new System.Drawing.Size(608, 73);
            this.bubbleChart.TabIndex = 30;
            this.bubbleChart.Tag = "bubbleSort";
            // 
            // bubbleTimeBox
            // 
            this.bubbleTimeBox.Enabled = false;
            this.bubbleTimeBox.Location = new System.Drawing.Point(9, 72);
            this.bubbleTimeBox.Name = "bubbleTimeBox";
            this.bubbleTimeBox.Size = new System.Drawing.Size(99, 20);
            this.bubbleTimeBox.TabIndex = 29;
            // 
            // bubbleCheck
            // 
            this.bubbleCheck.AutoSize = true;
            this.bubbleCheck.Location = new System.Drawing.Point(13, 19);
            this.bubbleCheck.Name = "bubbleCheck";
            this.bubbleCheck.Size = new System.Drawing.Size(95, 17);
            this.bubbleCheck.TabIndex = 15;
            this.bubbleCheck.Tag = "BubbleSort";
            this.bubbleCheck.Text = "Пузырьковая";
            this.bubbleCheck.UseVisualStyleBackColor = true;
            // 
            // arrayGrid
            // 
            this.arrayGrid.AllowUserToResizeColumns = false;
            this.arrayGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.arrayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arrayGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.arrayGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.arrayGrid.EnableHeadersVisualStyles = false;
            this.arrayGrid.Location = new System.Drawing.Point(12, 27);
            this.arrayGrid.Name = "arrayGrid";
            this.arrayGrid.RowHeadersVisible = false;
            this.arrayGrid.Size = new System.Drawing.Size(102, 415);
            this.arrayGrid.TabIndex = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Массив";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 563);
            this.Controls.Add(this.arrayGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomCount);
            this.Controls.Add(this.decreasingSort);
            this.Controls.Add(this.increasingSort);
            this.Controls.Add(this.bogoSort);
            this.Controls.Add(this.quickSort);
            this.Controls.Add(this.shakerSort);
            this.Controls.Add(this.insertionSort);
            this.Controls.Add(this.bubbleSort);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.bogoSort.ResumeLayout(false);
            this.bogoSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bogoChart)).EndInit();
            this.quickSort.ResumeLayout(false);
            this.quickSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quickChart)).EndInit();
            this.shakerSort.ResumeLayout(false);
            this.shakerSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shakerChart)).EndInit();
            this.insertionSort.ResumeLayout(false);
            this.insertionSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertionChart)).EndInit();
            this.bubbleSort.ResumeLayout(false);
            this.bubbleSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrayGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem launchButton;
        private System.Windows.Forms.ToolStripMenuItem arrayImport;
        private System.Windows.Forms.ToolStripMenuItem excelImport;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox randomCount;
        private System.Windows.Forms.RadioButton decreasingSort;
        private System.Windows.Forms.RadioButton increasingSort;
        private System.Windows.Forms.GroupBox bogoSort;
        private System.Windows.Forms.DataVisualization.Charting.Chart bogoChart;
        private System.Windows.Forms.TextBox bogoTimeBox;
        private System.Windows.Forms.CheckBox bogoCheck;
        private System.Windows.Forms.GroupBox quickSort;
        private System.Windows.Forms.DataVisualization.Charting.Chart quickChart;
        private System.Windows.Forms.TextBox quickTimeBox;
        private System.Windows.Forms.CheckBox quickCheck;
        private System.Windows.Forms.GroupBox shakerSort;
        private System.Windows.Forms.DataVisualization.Charting.Chart shakerChart;
        private System.Windows.Forms.TextBox shakerTimeBox;
        private System.Windows.Forms.CheckBox shakerCheck;
        private System.Windows.Forms.GroupBox insertionSort;
        private System.Windows.Forms.DataVisualization.Charting.Chart insertionChart;
        private System.Windows.Forms.TextBox insertionTimeBox;
        private System.Windows.Forms.CheckBox insertionCheck;
        private System.Windows.Forms.GroupBox bubbleSort;
        private System.Windows.Forms.DataVisualization.Charting.Chart bubbleChart;
        private System.Windows.Forms.TextBox bubbleTimeBox;
        private System.Windows.Forms.CheckBox bubbleCheck;
        private System.Windows.Forms.ToolStripMenuItem randomGeneration;
        private System.Windows.Forms.ToolStripMenuItem formClearButton;
        private System.Windows.Forms.DataGridView arrayGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

