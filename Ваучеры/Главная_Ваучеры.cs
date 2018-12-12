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
    public partial class Главная_Ваучеры : Form
    {
        public int _Кат = 0;

        public Главная_Ваучеры()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.в_Ваучеры_Категории_ШКTableAdapter.Fill(this.sES_MAGDataSet.в_Ваучеры_Категории_ШК);
            this.в_Ваучеры_ШКTableAdapter.Fill(this.sES_MAGDataSet.в_Ваучеры_ШК);
            c1DockingTab1.SelectedIndex = 0;
        }
        private void заполнить_Ваучеры_по_Категории()
        {  
            
            string _Кат_ = c1TrueDBGrid_Категории.Columns["_Кат"].Value.ToString();
            if (_Кат_.Length != 0)
            {
                _Кат = Convert.ToInt32(_Кат_);
                //  this.вэ_мен_ден_блю_выхTableAdapter.FillBy(this.edaDataSet.вэ_мен_ден_блю_вых, кто_код, мдб_код, меню_код, еда_код);
                this.в_Ваучеры_ШКTableAdapter.FillBy_Кат(this.sES_MAGDataSet.в_Ваучеры_ШК, _Кат);
                c1SplitterPanel_Ваучеры.Text = "_Кат = " +
                    c1TrueDBGrid_Категории.Columns["_Кат"].Value.ToString() + "  Категория = " +
                    c1TrueDBGrid_Категории.Columns["Категория"].Value.ToString() + "     дата Созд = " +
                    c1TrueDBGrid_Категории.Columns["дата Созд"].Value.ToString() + "     Записей = " +
                    c1TrueDBGrid_Категории.Columns["Записей"].Value.ToString();
            }
        }

        private void ribbonButton_Печать_Лист_Click(object sender, EventArgs e)
        {
            SES_MAGDataSetTableAdapters.QueriesTableAdapter qq;
            qq = new SES_MAGDataSetTableAdapters.QueriesTableAdapter();
            qq.Отчеты_ШК_Категория(_Кат);

           Печать_Лист пл = new Печать_Лист();
            пл.Visible = true;
            пл.Activate();
        }

        private void ribbonButton_Обновить_Click(object sender, EventArgs e)
        {
            this.в_Ваучеры_Категории_ШКTableAdapter.Fill(this.sES_MAGDataSet.в_Ваучеры_Категории_ШК);
            this.в_Ваучеры_ШКTableAdapter.Fill(this.sES_MAGDataSet.в_Ваучеры_ШК);

        }

        private void c1TrueDBGrid_Категории_DoubleClick(object sender, EventArgs e)
        {
            заполнить_Ваучеры_по_Категории();
         }
    }
}
