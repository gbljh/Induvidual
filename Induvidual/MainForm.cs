using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using LibIntegral;

namespace Induvidual
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dataGridViewIntegral.AutoGenerateColumns = false;
            FormClosing += MainForm_FormClosing;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ви точно бажаєте вийти?", "Запитання",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }

        private void ToolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolStripButtonAdd_Click(object sender, EventArgs e)
        {
            LibIntegral.Integral integral = new LibIntegral.Integral();
            IntegralForm carForm = new IntegralForm(integral);
            if (carForm.ShowDialog() == DialogResult.OK)
            {
                IntegralBindingSource.Add(integral);
            }
        }

        private void ToolStripButtonClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте очистити?", "Запитання",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                IntegralBindingSource.Clear();
        }

        private void ToolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте видалити запис?", "Запитання",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                IntegralBindingSource.RemoveCurrent();
        }

        private void ToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            LibIntegral.Integral artist = IntegralBindingSource.List[IntegralBindingSource.Position] as LibIntegral.Integral;
            if (artist != null)
            {
                IntegralForm carForm = new IntegralForm(artist);
                if (carForm.ShowDialog() == DialogResult.OK)
                {
                    IntegralBindingSource.List[IntegralBindingSource.Position] = artist;
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.Columns.ColumnWidth = 25;
            ExcelApp.Cells[1, 1] = "Формула";
            ExcelApp.Cells[1, 2] = "xmin";
            ExcelApp.Cells[1, 3] = "xmax";
            ExcelApp.Cells[1, 4] = "dx";
            ExcelApp.Cells[1, 5] = "Лівих прямокутників";
            ExcelApp.Cells[1, 6] = "Правих прямокутників";
            ExcelApp.Cells[1, 7] = "Трапецій";
            ExcelApp.Cells[1, 8] = "Сімпсона";
            for (int i = 0; i < dataGridViewIntegral.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridViewIntegral.RowCount; j++)
                {
                    ExcelApp.Cells[j + 2, i + 1] = (dataGridViewIntegral[i, j].Value).ToString();
                }
            }
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Filter = "Excel files(*.xls)|*.xls";
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExcelApp.ActiveWorkbook.SaveAs(SaveFileDialog1.FileName);
              
            }
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {

            string fname = "";
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Excel File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fname = fdlg.FileName;
            }


            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fname);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            for (int i = 1; i < rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {

                        dataGridViewIntegral.Rows[i - 1].Cells[j - 1].Value = xlRange.Cells[i + 1, j].Value2;
                    }
                }
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }
        private void toolStripButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Про програму:\nПрограма рахує iнтеграли рiзними методами");
        }
    }
}
