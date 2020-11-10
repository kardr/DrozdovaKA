using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class MarkaForm : Form
    {
        public MarkaForm()
        {
            InitializeComponent();
        }

        private void MarkaForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet5.Marka". При необходимости она может быть перемещена или удалена.
            this.markaTableAdapter.Fill(this.skladDataSet5.Marka);

        }

        private void DobavlenieMarka_Click(object sender, EventArgs e)
        {
            string name = textBoxMarkaName.Text;
            Marka m = new Marka();
            m.Insert(name);
            this.markaTableAdapter.Fill(this.skladDataSet5.Marka);
            textBoxMarkaName.Text = "";
        }

        private void DeleteMarka_Click(object sender, EventArgs e)
        {
            int f = dataGridViewMarka.CurrentRow.Index;
            if (f == 0)
            {
                MessageBox.Show("Не выбрана строка для удаления");
            }
            else
            {
                int id = Convert.ToInt32(dataGridViewMarka[0, f].Value);
                Marka m = new Marka();
                m.Delete(id);
                this.markaTableAdapter.Fill(this.skladDataSet5.Marka);
            }
            textBoxRedakMarkaName.Text = "";
        }

        private void RedaktirMarka_Click(object sender, EventArgs e)
        {
            int f = dataGridViewMarka.CurrentRow.Index;
            string name = textBoxRedakMarkaName.Text;
            int id = Convert.ToInt32(dataGridViewMarka[0, f].Value);
            Marka m = new Marka();
            m.Update(name,id);
            this.markaTableAdapter.Fill(this.skladDataSet5.Marka);
            textBoxRedakMarkaName.Text = "";

        }

        private void dataGridViewMarka_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = dataGridViewMarka.CurrentRow.Index;
            textBoxRedakMarkaName.Text = dataGridViewMarka[1, f].Value.ToString();
        }
    }
}
