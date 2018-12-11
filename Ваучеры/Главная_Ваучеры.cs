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
        public Главная_Ваучеры()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sES_MAGDataSet.в_Ваучеры_Категории_ШК". При необходимости она может быть перемещена или удалена.
            this.в_Ваучеры_Категории_ШКTableAdapter.Fill(this.sES_MAGDataSet.в_Ваучеры_Категории_ШК);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "sES_MAGDataSet1.в_Ваучеры_Категории_ШК". При необходимости она может быть перемещена или удалена.
            //this.в_Ваучеры_Категории_ШКTableAdapter.Fill(this.sES_MAGDataSet.в_Ваучеры_Категории_ШК);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sES_MAGDataSet.в_Ваучеры_ШК". При необходимости она может быть перемещена или удалена.
            this.в_Ваучеры_ШКTableAdapter.Fill(this.sES_MAGDataSet.в_Ваучеры_ШК);

        }

        private void ribbonButton_Печать_Лист_Click(object sender, EventArgs e)
        {
            //глав_HotelDataSetTableAdapters.пров_все_QueriesTableAdapter пв;
            //пв = new Hotel_2.глав_HotelDataSetTableAdapters.пров_все_QueriesTableAdapter();
            //пв.Отчеты_Стат_12_вэс_таблица_1(о_дата_с, о_дата_по, о_Орг_Хоз, о_Курс_долл_США);

            //Отчеты.Отчеты_Стат_12_вэс_таблица_1 от12 = new Отчеты.Отчеты_Стат_12_вэс_таблица_1();
            //от12.Visible = true;
            //от12.Activate();
         
           Печать_Лист пл = new Печать_Лист();
            пл.Visible = true;
            пл.Activate();
        }

        private void ribbonButton_Обновить_Click(object sender, EventArgs e)
        {
            this.в_Ваучеры_Категории_ШКTableAdapter.Fill(this.sES_MAGDataSet.в_Ваучеры_Категории_ШК);
            this.в_Ваучеры_ШКTableAdapter.Fill(this.sES_MAGDataSet.в_Ваучеры_ШК);
        }
    }
}
