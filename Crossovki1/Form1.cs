using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crossovki1
{
    public partial class Form1 : Form
    {
        Data_BaseEntities_Unrecognized content = new Data_BaseEntities_Unrecognized();

        public Form1()
        {
            InitializeComponent();
        }

        private void BRefresh_Click(object sender, EventArgs e)
        {
            LabelMain.Text = "Подключение к базе...";
            Application.DoEvents();
            var myQuery = from items in content.f_REPORT_Mega_Base_Unrecognized_(null)
                          select items;
            DGTable.DataSource = myQuery.ToList();

            LAbelCount.Text = "Итого: " + DGTable.RowCount;

            LabelMain.Text = "Итоговая таблица:";
        }
    }
}
