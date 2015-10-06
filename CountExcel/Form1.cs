using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void count_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application oExcelApp = null; // Excelオブジェクト
            Microsoft.Office.Interop.Excel.Workbook oExcelWBook = null;  // Excel Workbookオブジェクト
            try
            {
                this.label1.Text = "数えています。。。。。";
                oExcelApp = new Microsoft.Office.Interop.Excel.Application();
                oExcelApp.DisplayAlerts = false; // Excelの確認ダイアログ表示有無
                oExcelApp.Visible = false;       // Excel表示有無
                // Excelファイルをオープンする(第一パラメタ以外は省略可)
                oExcelWBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcelApp.Workbooks.Open(
                  this.excelPath.Text,      // Filename
                  Type.Missing,  // UpdateLinks
                  Type.Missing,  // ReadOnly
                  Type.Missing,  // Format
                  Type.Missing,  // Password
                  Type.Missing,  // WriteResPassword
                  Type.Missing,  // IgnoreReadOnlyRecommended
                  Type.Missing,  // Origin
                  Type.Missing,  // Delimiter
                  Type.Missing,  // Editable
                  Type.Missing,  // Notify
                  Type.Missing,  // Converter
                  Type.Missing,  // AddToMru
                  Type.Missing,  // Local
                  Type.Missing   // CorruptLoad
                ));

                List<DispBo> boList = new List<DispBo>();
                DispBo bo = new DispBo();
                int sheetCount = oExcelWBook.Worksheets.Count;
                for (int sheetId = 1; sheetId < sheetCount; sheetId++)
                {
                    bo = new DispBo();
                    this.calcEnableLineCount(bo, sheetId, oExcelWBook);
                    boList.Add(bo);
                }
                this.dataGridView1.DataSource = boList;
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show(
                "Excelファイルの操作に失敗しました。\n",
                System.Windows.Forms.Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            finally
            {
                oExcelWBook.Close(Type.Missing, Type.Missing, Type.Missing);
                oExcelApp.Quit();
            }
            this.label1.Text = "";
            MessageBox.Show("正常に読み込みました。");
        }

        private void calcEnableLineCount(DispBo dispBo, int sheetId, Microsoft.Office.Interop.Excel.Workbook oExcelWBook)
        {
            Microsoft.Office.Interop.Excel._Worksheet oWSheet =
                (Microsoft.Office.Interop.Excel._Worksheet)oExcelWBook.Worksheets[sheetId];

            int enableLineCount = 0;
            int lastRows = oWSheet.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row;

            for (int rowId = 1; rowId < lastRows; rowId++)
            {
                if (this.isEmptyRow(oWSheet, rowId))
                {
                    continue;
                }
                enableLineCount++;
            }
            dispBo.enabledLineCount = enableLineCount;
            dispBo.totalLineCount = lastRows;
            dispBo.sheetName = oWSheet.Name;
        }

        private void getEnableLineCount(DispBo bo)
        {
            throw new NotImplementedException();
        }

        private bool isEmptyRow(Microsoft.Office.Interop.Excel._Worksheet oWSheet, int rowId)
        {
            for (int colId = 1; colId < 30; colId++)
            {
                if (!String.IsNullOrEmpty(Convert.ToString(oWSheet.Cells[rowId, colId].Value)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
