using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
namespace AppInteropExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogoex = new SaveFileDialog();

            if (dialogoex.ShowDialog() == DialogResult.OK)
            {
                object obj = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook file = excel.Workbooks.Add(obj);
                Microsoft.Office.Interop.Excel.Worksheet hoja = file.Worksheets.Add();
                file.Activate();
                hoja.Cells[1, 1] = txttexto.Text;
                file.SaveAs(dialogoex.FileName);
                excel.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            if (dialogo.ShowDialog() != DialogResult.OK)
            { return; }
            string ruta = dialogo.FileName;
            var wordApp = new Word.Application();
            wordApp.Visible = true;
            wordApp.Documents.Add();
            string dato = txttexto.Text;
            wordApp.Selection.TypeText(dato);
            wordApp.ActiveDocument.SaveAs2(ruta);
        }
    }
}
