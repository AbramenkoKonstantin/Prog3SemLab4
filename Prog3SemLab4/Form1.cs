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

namespace Prog3SemLab4
{
    public partial class Form1 : Form
    {
        static string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        static string ApplicationName = "Google Sheets API .NET Quickstart";

        public Form1()
        {
            InitializeComponent();
        }

        async private void StartBtnClick(object sender, EventArgs e)
        {
            try
            {
                int[] array = new int[dataGridView.RowCount];
                for (int index = 0; index < dataGridView.RowCount; ++index)
                {
                    array[index] = int.Parse(dataGridView[0, index].Value.ToString());
                }

                if (sortChoose.CheckedItems.Contains(sortChoose.Items[0]))
                {
                    await Task.Run(() => BubbleSort.Sort(array));
                }
                if (sortChoose.CheckedItems.Contains(sortChoose.Items[1]))
                {
                    await Task.Run(() => InsertionSort.Sort(array));
                }
                if (sortChoose.CheckedItems.Contains(sortChoose.Items[2]))
                {
                    await Task.Run(() => ShakerSort.Sort(array));
                }
                if (sortChoose.CheckedItems.Contains(sortChoose.Items[3]))
                {
                    await Task.Run(() => QuickSort.Sort(array));
                }
                if (sortChoose.CheckedItems.Contains(sortChoose.Items[4]))
                {
                    await Task.Run(() => BogoSort.Sort(array));
                }
            }
            catch
            {

            }
        }

        private void CloseBtnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GoogleSheetsItemClick(object sender, EventArgs e)
        {
            UserCredential credential;

            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.FromStream(stream).Secrets, Scopes, "user", CancellationToken.None, new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            String spreadsheetId = "1BxiMVs0XRA5nFMdKvBdBZjgmUUqptlbs74OgvE2upms";
            String range = "Class Data!A2:E";
            SpreadsheetsResource.ValuesResource.GetRequest request = service.Spreadsheets.Values.Get(spreadsheetId, range);

            // https://docs.google.com/spreadsheets/d/1BxiMVs0XRA5nFMdKvBdBZjgmUUqptlbs74OgvE2upms/edit
            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                Console.WriteLine("Name, Major");
                foreach (var row in values)
                {
                    Console.WriteLine("{0}, {1}", row[0], row[4]);
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }
            Console.Read();
        }

        private void ExcelClick(object sender, EventArgs e)
        {
            using (OpenFileDialog excelFile = new OpenFileDialog())
            {
                DialogResult result = excelFile.ShowDialog();
                if (result == DialogResult.OK && Path.GetExtension(excelFile.FileName) == ".xlsx")
                {
                    Microsoft.Office.Interop.Excel.Application objExcel = new Microsoft.Office.Interop.Excel.Application();
                    Workbook objWorkBook = objExcel.Workbooks.Open(excelFile.FileName);
                    Worksheet objWorkSheet = (Worksheet)objWorkBook.Sheets[1];

                    Range xRange = objWorkSheet.UsedRange.Columns[1];
                    Range yRange = objWorkSheet.UsedRange.Columns[2];

                    Array xCells = (Array)xRange.Cells.Value2;
                    Array yCells = (Array)yRange.Cells.Value2;

                    string[] xColumn = xCells.OfType<object>().Select(o => o.ToString()).ToArray();
                    string[] yColumn = yCells.OfType<object>().Select(o => o.ToString()).ToArray();

                    for (int index = 0; index < xRange.Cells.Count; ++index)
                    {
                        dataGridView.Rows.Add();
                        dataGridView.Rows[index].Cells[0].Value = xColumn[index];
                        dataGridView.Rows[index].Cells[1].Value = yColumn[index];
                    }

                    objWorkBook.Close();
                    objExcel.Quit();
                }
                else if (result == DialogResult.OK)
                {
                    MessageBox.Show("Ошибка!", "Неверное расширение файла.");
                }
            }
        }
    }
}
