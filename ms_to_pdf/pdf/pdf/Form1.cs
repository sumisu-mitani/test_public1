using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace pdf
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton2.Checked = true;
        }


        /* pdf変換対象のファイルか確認 */
        private bool chk_ms_file(string file_name)
        {
            bool wk_flg = false;
            string wk_file_category = System.IO.Path.GetExtension(file_name);

            if (wk_file_category == (".doc")|| wk_file_category == (".docx")
                || wk_file_category == (".xls") || wk_file_category == (".xlsx")
                || wk_file_category == (".ppt") || wk_file_category == (".pptx"))
            {
                wk_flg = true;
            }
            return (wk_flg);
        }

        /* 保存フォルダ設定 */
        private void button_set_save_folder_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.FileName = "SelectFolder";
            op.Filter = "Folder|.";
            op.CheckFileExists = false;
            
            DialogResult result = op.ShowDialog();
            if(result == DialogResult.OK)
            {
                textBox_save_folder.Text = System.IO.Path.GetDirectoryName(op.FileName);
            }
        }

        /* pdf変換(doc) */
        private void doc2pdf(string doc_file)
        {
            Microsoft.Office.Interop.Word.Application objWord = null;
            Microsoft.Office.Interop.Word.Documents objWordDocuments = null;
            Microsoft.Office.Interop.Word.Document objWordDocument = null;

            string strWordFilePath = string.Empty;
            string strPdfFilePath = string.Empty;

            try
            {
                strWordFilePath = doc_file;
                strPdfFilePath = System.IO.Path.GetDirectoryName(strWordFilePath) + @"/" + System.IO.Path.GetFileNameWithoutExtension(strWordFilePath) + @".pdf";
                objWord = new Microsoft.Office.Interop.Word.Application();
                objWordDocuments = objWord.Documents;
                objWordDocument = objWordDocuments.Open(strWordFilePath);

                objWordDocument.ExportAsFixedFormat
                    (strPdfFilePath,
                    Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF,
                    false,
                    Microsoft.Office.Interop.Word.WdExportOptimizeFor.wdExportOptimizeForPrint,
                    Microsoft.Office.Interop.Word.WdExportRange.wdExportAllDocument,
                    1, 1,
                    Microsoft.Office.Interop.Word.WdExportItem.wdExportDocumentContent,
                    false, true,
                    Microsoft.Office.Interop.Word.WdExportCreateBookmarks.wdExportCreateHeadingBookmarks);

            }
            catch
            {

            }
            finally
            {
                if (objWordDocument != null)
                {
                    objWordDocument.Close();
                }
                if (objWord != null)
                {
                    objWord.Quit();
                }
            }
        }
        /* pdf変換(xls) */
        private void xls2pdf(string xls_file)
        {
            Microsoft.Office.Interop.Excel.Application objExcel = null;
            Microsoft.Office.Interop.Excel.Workbooks objExcelWorkbooks = null;
            Microsoft.Office.Interop.Excel.Workbook objExcelWorkbook = null;

            string strExcelFilePath = xls_file;
            string strPdfFilePath = string.Empty;
            try
            {
                strPdfFilePath = System.IO.Path.GetDirectoryName(strExcelFilePath) + @"/" + System.IO.Path.GetFileNameWithoutExtension(strExcelFilePath) + @".pdf";
                objExcel = new Microsoft.Office.Interop.Excel.Application();
                objExcelWorkbooks = objExcel.Workbooks;
                objExcelWorkbook = objExcelWorkbooks.Open(strExcelFilePath);

                objExcelWorkbook.ExportAsFixedFormat(
                    Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF,
                    strPdfFilePath,
                    Microsoft.Office.Interop.Excel.XlFixedFormatQuality.xlQualityStandard,
                    true,
                    false,
                    Type.Missing,
                    Type.Missing,
                    false,
                    Type.Missing
                    );

            }
            catch
            {

            }
            finally
            {
                if (objExcelWorkbook != null)
                {
                    objExcelWorkbook.Close();
                }
                if (objExcel != null)
                {
                    objExcel.Quit();
                }
            }
        }

        /* pdf変換(ppt) */
        private void ppt2pdf(string xls_file)
        {
            Microsoft.Office.Interop.PowerPoint.Application objPPT = null;
            Microsoft.Office.Interop.PowerPoint.Presentations objPPTPresentations = null;
            Microsoft.Office.Interop.PowerPoint.Presentation objPPTPresentation = null;

            string strPPTFilePath = xls_file;
            string strPdfFilePath = string.Empty;
            try
            {
                strPdfFilePath = System.IO.Path.GetDirectoryName(strPPTFilePath) + @"/" + System.IO.Path.GetFileNameWithoutExtension(strPPTFilePath) + @".pdf";
                objPPT = new Microsoft.Office.Interop.PowerPoint.Application();
                objPPTPresentations = objPPT.Presentations;
                objPPTPresentation = objPPTPresentations.Open(strPPTFilePath);

                objPPTPresentation.ExportAsFixedFormat(
                    strPdfFilePath,
                    Microsoft.Office.Interop.PowerPoint.PpFixedFormatType.ppFixedFormatTypePDF,
                    Microsoft.Office.Interop.PowerPoint.PpFixedFormatIntent.ppFixedFormatIntentPrint
                   );

            }
            catch
            {

            }
            finally
            {
                if (objPPTPresentation != null)
                {
                    objPPTPresentation.Close();
                }
                if (objPPT != null)
                {
                    objPPT.Quit();
                }
            }
        }

        /* PDF変換 */
        private void button2_Click(object sender, EventArgs e)
        {
            string wk_file_path;
            string wk_file_category;
            if ((textBox_save_folder.Text != null)&& (listBox_work_files.Items.Count != 0))
            {
                for(int i = 0; i < listBox_work_files.Items.Count; i++)
                {
                    wk_file_category = System.IO.Path.GetExtension(listBox_work_files.Items[i].ToString());
                    wk_file_path = listBox_work_files.Items[i].ToString();
                    if ((wk_file_category == ".docx")|| (wk_file_category == ".doc"))
                    {
                        doc2pdf(wk_file_path);                    
                    }else if((wk_file_category == ".xls")||(wk_file_category == ".xlsx"))
                    {
                        xls2pdf(wk_file_path);
                    }else if((wk_file_category == ".ppt") || (wk_file_category == ".pptx"))
                    {
                        ppt2pdf(wk_file_path);
                    }
                }
            }
        }

/* リストBOX */
        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string wk_file_category;
            foreach (string item in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                if (System.IO.File.GetAttributes(item) == System.IO.FileAttributes.Directory)
                {
                    string[] files = System.IO.Directory.GetFiles(item);
                    foreach (string file in files)
                    {
                        wk_file_category = System.IO.Path.GetExtension(file);
                        if (chk_ms_file(file) == true)
                        {
                            listBox_work_files.Items.Add(file);
                        }
                    }
                }
                else
                {
                    wk_file_category = System.IO.Path.GetExtension(item);
                    if (chk_ms_file(item) == true)
                    {
                        listBox_work_files.Items.Add(item);
                    }
                }
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                listBox_work_files.Items.RemoveAt(listBox_work_files.SelectedIndex);
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

/* テキストBOX */
        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string item in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                if (System.IO.File.GetAttributes(item) == System.IO.FileAttributes.Directory)
                {
                    textBox_save_folder.Text = item;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox_work_files.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_save_file_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

