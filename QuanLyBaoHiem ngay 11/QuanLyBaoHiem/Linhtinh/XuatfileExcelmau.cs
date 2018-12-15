using DevExpress.XtraEditors;
using Model.Dao;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaoHiem.Linhtinh
{
    public class XuatfileExcelmau
    {
        public void xuatexcelmau(string tenbang)
        {
            ExcelSuport exsp = new ExcelSuport();
            
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            List<string> listtencot = exsp.LayTenCot(tenbang);
            if (xlApp == null)
            {
                XtraMessageBox.Show("Excel chưa được cài đặt !!");
                return;
            }


            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            
            

            for (int i = 1; i <= listtencot.Count; i++)
            {
                xlWorkSheet.Cells[1, i] = listtencot[i - 1];
            }

            xlWorkSheet.Columns.ColumnWidth = 20;
            

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2010) (.xlsx)|*.xlsx ";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        
                        case ".xlsx":
                            xlWorkBook.SaveAs(exportFilePath, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook, misValue,
                            misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                            xlWorkBook.Close(true, misValue, misValue);
                            xlApp.Quit();
                            Marshal.ReleaseComObject(xlWorkSheet);
                            Marshal.ReleaseComObject(xlWorkBook);
                            Marshal.ReleaseComObject(xlApp);
                            XtraMessageBox.Show("Đã tạo file Excel mẫu", "Thông báo");
                            break;

                        default:
                            break;
                    }
                    
                }
            }


            

            
        }
    }
}
