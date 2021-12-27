using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Linq;
using System.IO;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Threading;
using System.Reflection;

namespace Prog3SemLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        async private void LaunchButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<System.Windows.Forms.GroupBox> sortBoxes = Controls.OfType<System.Windows.Forms.GroupBox>().ToList();
                sortBoxes.Reverse();

                double[] array = new double[arrayGrid.Rows.Count - 1];
                for (int index = 0; index < arrayGrid.Rows.Count - 1; ++index)
                {
                    if (!Double.TryParse(arrayGrid.Rows[index].Cells[0].Value.ToString(), out array[index]))
                    {
                        MessageBox.Show("Некорректное значение в ячейке таблицы.");
                        return;
                    }
                }

                bool isSorted = false;

                foreach (System.Windows.Forms.GroupBox sort in sortBoxes)
                {
                    if (IsSortChoosed(sort))
                    {
                        isSorted = true;
                        var chart = GetSortChart(sort);
                        var method = GetSortMethod(sort);
                        array = ArrayRead();

                        object[] parametrs = (method.Name == "QuickSort") ?
                            new object[] { array, IsSortIncreasing(), -1, -1 } :
                            new object[] { array, IsSortIncreasing() };

                        await Task.Run(() =>
                        {
                            object time = method.Invoke(this, parametrs);
                            System.Windows.Forms.TextBox timeResultBox = sort.Controls.OfType<System.Windows.Forms.TextBox>().Single();
                            Invoke((System.Action)(() => SortDraw(chart, array)));
                            Invoke((System.Action)(() => timeResultBox.Text = time.ToString()));
                        });

                    }
                }
                if (!isSorted)
                {
                    MessageBox.Show("Не выбрано ни одной сортировки.");
                    return;
                }
            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Пустое значение ячейки.");
            }
        }


        private double[] ArrayRead()
        {
            double[] array = new double[arrayGrid.Rows.Count - 1];
            for (int index = 0; index < arrayGrid.Rows.Count - 1; ++index)
            {
                Double.TryParse(arrayGrid.Rows[index].Cells[0].Value.ToString(), out array[index]);
            }
            return array;
        }


        private void SortDraw(System.Windows.Forms.DataVisualization.Charting.Chart chart, double[] array)
        {
            chart.Series[0].Points.Clear();
            for (int index = 0; index < array.Length; ++index)
            {
                chart.Series[0].Points.AddXY(index, array[index]);
            }
        }


        private System.Windows.Forms.DataVisualization.Charting.Chart GetSortChart(Control control)
        {
            var chart = control.Controls.OfType<System.Windows.Forms.DataVisualization.Charting.Chart>().Single();
            return chart;
        }


        private bool IsSortChoosed(System.Windows.Forms.GroupBox groupBox)
        {
            System.Windows.Forms.CheckBox checkBox = groupBox.Controls.OfType<System.Windows.Forms.CheckBox>().Single();
            if (checkBox.Checked)
            {
                return true;
            }
            return false;
        }


        private bool IsSortIncreasing()
        {
            var sortingChoosed = Controls.OfType<RadioButton>().Where(button => button.Checked == true).Single();
            if (sortingChoosed.Name.Contains("increasing"))
            {
                return true;
            }
            return false;
        }


        private MethodInfo GetSortMethod(Control control)
        {
            System.Windows.Forms.CheckBox checkBox = control.Controls.OfType<System.Windows.Forms.CheckBox>().Single();
            Type sortingClass = Type.GetType("Prog3SemLab4.Sortings");
            return sortingClass.GetMethod(checkBox.Tag.ToString());
        }


        private void CloseBtnClick(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void ExcelImport_Click(object sender, EventArgs e)
        {
            arrayGrid.Rows.Clear();
            using (OpenFileDialog excelFile = new OpenFileDialog())
            {
                DialogResult result = excelFile.ShowDialog();
                if (result == DialogResult.OK && Path.GetExtension(excelFile.FileName) == ".xlsx")
                {
                    Microsoft.Office.Interop.Excel.Application objExcel = new Microsoft.Office.Interop.Excel.Application();
                    Workbook objWorkBook = objExcel.Workbooks.Open(excelFile.FileName);
                    Worksheet objWorkSheet = (Worksheet)objWorkBook.Sheets[1];

                    try
                    {
                        Range range = objWorkSheet.UsedRange.Rows[1];
                        Array values = (Array)range.Cells.Value2;
                        string[] array = values.OfType<object>().Select(o => o.ToString()).ToArray();

                        arrayGrid.Rows.Add(array.Length);
                        for (int index = 0; index < array.Length; ++index)
                        {
                            arrayGrid.Rows[index].Cells[0].Value = array[index];
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка чтения.");
                    }

                    objWorkBook.Close();
                    objExcel.Quit();
                }
                else if (result == DialogResult.OK)
                {
                    MessageBox.Show("Неверное расширение файла.");
                }
            }
        }


        private async Task ReadAsync(SpreadsheetsResource.ValuesResource valuesResource, string SpreadsheetId, string ReadRange)
        {
            try
            {
                ValueRange response = await valuesResource.Get(SpreadsheetId, ReadRange).ExecuteAsync();
                var values = response.Values;
                for (int index = 0; index < values.Count; ++index)
                {
                    arrayGrid.Rows.Add();
                    arrayGrid.Rows[index].Cells[0].Value = values[0][index];
                }
            }
            catch
            {
                MessageBox.Show("Некорректная ссылка или доступ к таблице не открыт.");
            }
        }


        private void ArrayGeneration_Click(object sender, EventArgs e)
        {
            arrayGrid.Rows.Clear();
            try
            {
                Random randomizer = new Random();
                int.TryParse(randomCount.Text, out int rowCount);
                if (rowCount <= 1)
                {
                    MessageBox.Show("Количество генерации не может быть меньше 2");
                    return;
                }
                double[] array = new double[rowCount];

                arrayGrid.Rows.Add(rowCount);

                array[0] = DoubleRandom(randomizer);
                for (int index = 1; index < rowCount; ++index)
                {
                    double prevNumber = array[index - 1];
                    array[index] = Modulate(prevNumber, randomizer);
                }

                foreach (DataGridViewRow row in arrayGrid.Rows)
                {
                    row.Cells[0].Value = array[row.Index];
                }
            }

            catch
            {

            }

        }


        private double DoubleRandom(Random randomizer, int lowerBorder = -100, int upperBorder = 100)
        {
            return Math.Round(randomizer.NextDouble() * randomizer.Next(lowerBorder, upperBorder), 3);
        }


        private double Modulate(double value, Random randomizer)
        {
            return Math.Round(value + randomizer.Next(-10, 10) * randomizer.NextDouble(), 3);
        }


        private void FormClearButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    control.Text = String.Empty;
                }
                if (control is System.Windows.Forms.GroupBox)
                {
                    var groupBox = control as System.Windows.Forms.GroupBox;
                    foreach (Control boxControl in groupBox.Controls)
                    {
                        if (boxControl is System.Windows.Forms.TextBox)
                        {
                            boxControl.Text = String.Empty;
                        }
                        if (boxControl is System.Windows.Forms.DataVisualization.Charting.Chart)
                        {
                            var chart = boxControl as System.Windows.Forms.DataVisualization.Charting.Chart;
                            chart.Series[0].Points.Clear();
                        }
                        if (boxControl is RadioButton)
                        {
                            var button = boxControl as RadioButton;
                            button.Checked = false;
                            button.Enabled = false;
                        }
                        if (boxControl is System.Windows.Forms.CheckBox)
                        {
                            var checkBox = boxControl as System.Windows.Forms.CheckBox;
                            checkBox.Checked = false;
                        }
                    }
                }

            }
            arrayGrid.Rows.Clear();
        }
    }
}
