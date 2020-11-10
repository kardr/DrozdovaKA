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
    public partial class PostavchikForm : Form
    {
       
        public PostavchikForm()
        {
            InitializeComponent();
        }

        private void PostavchikForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet7.Postavchik". При необходимости она может быть перемещена или удалена.
            this.postavchikTableAdapter.Fill(this.skladDataSet7.Postavchik);

        }

        private void DobavleniePostav_Click(object sender, EventArgs e)
        {
            string name = textBoxPostavName.Text;
            string address = textBoxPostavAdress.Text;
            string tel = textBoxPostavTelefon.Text;
            Postavchik p = new Postavchik();
            p.Insert(name,address,tel);
            this.postavchikTableAdapter.Fill(this.skladDataSet7.Postavchik);
            textBoxPostavName.Text = "";
            textBoxPostavTelefon.Text = "";
            textBoxPostavAdress.Text = "";
        }

        private void DeletePostav_Click(object sender, EventArgs e)
        {
            int f = dataGridViewPostav.CurrentRow.Index;
            if (f == 0)
            {
                MessageBox.Show("Не выбрана строка для удаления");
            }
            else
            {
                int id = Convert.ToInt32(dataGridViewPostav[0, f].Value);
                Postavchik p = new Postavchik();
                p.Delete(id);
                this.postavchikTableAdapter.Fill(this.skladDataSet7.Postavchik);
            }
            textBoxPostavRedaAdres.Text = "";
            textBoxPostavRedakName.Text = "";
            textBoxPostavRedaTel.Text = "";
        }

        private void RedaktirPostav_Click(object sender, EventArgs e)
        {
            int f = dataGridViewPostav.CurrentRow.Index;
            string name = textBoxPostavRedakName.Text;
            string address = textBoxPostavRedaAdres.Text;
            string tel = textBoxPostavRedaTel.Text;
            int id = Convert.ToInt32(dataGridViewPostav[0, f].Value);
            Postavchik p = new Postavchik();
            p.Update(name, address, tel, id);
            this.postavchikTableAdapter.Fill(this.skladDataSet7.Postavchik);

            textBoxPostavRedaAdres.Text = "";
            textBoxPostavRedakName.Text = "";
            textBoxPostavRedaTel.Text = "";
        }
        private void dataGridViewPostav_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = dataGridViewPostav.CurrentRow.Index;
            textBoxPostavRedakName.Text = dataGridViewPostav[1, f].Value.ToString();
            textBoxPostavRedaAdres.Text = dataGridViewPostav[2, f].Value.ToString();
            textBoxPostavRedaTel.Text = dataGridViewPostav[3, f].Value.ToString();
        }
    }
}
