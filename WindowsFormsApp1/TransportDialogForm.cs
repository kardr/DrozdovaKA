using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TransportDialogForm : Form
    {
        public TransportDialogForm()
        {
            InitializeComponent();
        }

        private void TransportDialogForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet4.Postavchik". При необходимости она может быть перемещена или удалена.
            this.postavchikTableAdapter.Fill(this.skladDataSet4.Postavchik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet3.Marka". При необходимости она может быть перемещена или удалена.
            this.markaTableAdapter.Fill(this.skladDataSet3.Marka);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet2.Vid". При необходимости она может быть перемещена или удалена.
            this.vidTableAdapter1.Fill(this.skladDataSet2.Vid);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet1.Vid". При необходимости она может быть перемещена или удалена.
            this.vidTableAdapter.Fill(this.skladDataSet1.Vid);

        }
    }
}
