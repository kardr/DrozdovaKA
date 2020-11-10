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
    public partial class VidForm : Form
    {
        public VidForm()
        {
            InitializeComponent();
        }

        private void VidForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet6.Vid". При необходимости она может быть перемещена или удалена.
            this.vidTableAdapter.Fill(this.skladDataSet6.Vid);

        }

        private void DobavlenieVid_Click(object sender, EventArgs e)
        {
            string name = textBoxVidName.Text;
            Vid v = new Vid();
            v.Insert(name);
            this.vidTableAdapter.Fill(this.skladDataSet6.Vid);
            textBoxVidName.Text = "";
        }

        private void DeleteVid_Click(object sender, EventArgs e)
        {
            int f = dataGridViewVid.CurrentRow.Index;
            if (f == 0)
            {
                MessageBox.Show("Не выбрана строка для удаления");
            }
            else
            {
                int id = Convert.ToInt32(dataGridViewVid[0, f].Value);
                Vid v = new Vid();
                v.Delete(id);
                this.vidTableAdapter.Fill(this.skladDataSet6.Vid);
            }
            textBoxRedakVidName.Text = "";
        }

        private void RedaktirVid_Click(object sender, EventArgs e)
        {
            int f = dataGridViewVid.CurrentRow.Index;
            string name = textBoxRedakVidName.Text;
            int id = Convert.ToInt32(dataGridViewVid[0, f].Value);
            Vid v = new Vid();
            v.Update(name,id);
            this.vidTableAdapter.Fill(this.skladDataSet6.Vid);
            textBoxRedakVidName.Text = "";
        }

        private void dataGridViewVid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = dataGridViewVid.CurrentRow.Index;
            textBoxRedakVidName.Text = dataGridViewVid[1, f].Value.ToString();
        }
    }
}
