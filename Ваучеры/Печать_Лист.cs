using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ваучеры
{
    public partial class Печать_Лист : Form
    {
        public Печать_Лист()
        {
            InitializeComponent();
        }

        private void Печать_Лист_Load(object sender, EventArgs e)
        {
            //string отчет_файл = @"d:\гостиница\отчеты\я_Отчеты_Период.xml";

            //Главная_фор гф = (Главная_фор) this.Owner;

            //c1Report_Отчеты_Пер_Все.ReportName = гф.о_отчет_имя;

            //c1Report_Отчеты_Пер_Все.Load(отчет_файл, гф.о_отчет_имя);

            //c1Report_Отчеты_Пер_Все.Render();

            //c1Report_Отчеты_Пер_Все.Layout.PaperSize = System.Drawing.Printing.PaperKind.A4;
            //c1Report_Отчеты_Пер_Все.Layout.Orientation = C1.C1Report.OrientationEnum.Portrait;
            //c1PrintPreviewControl1.PreviewPane.ZoomFactor = 1;

            c1Report1.Layout.PaperSize = System.Drawing.Printing.PaperKind.A4;
            c1Report1.Layout.Orientation = C1.C1Report.OrientationEnum.Portrait;
            c1PrintPreviewControl1.PreviewPane.ZoomFactor = 1;    
        }

        private void c1Button_Печать_PDF_Click(object sender, EventArgs e)
        {
          string отчет_файл = @"a:\Временные файлы\я_Отчеты_Категория.pdf";
          c1Report1.RenderToFile(отчет_файл, C1.C1Report.FileFormatEnum.PDFEmbedFonts);

            System.Diagnostics.Process.Start(отчет_файл);
        }
    }
}
