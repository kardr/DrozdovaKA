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
    public partial class TransporForm : Form
    {
       
        public TransporForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet9.All_Transport2". При необходимости она может быть перемещена или удалена.
           this.all_Transport2TableAdapter1.Fill(this.skladDataSet9.All_Transport2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet8.All_Transport2". При необходимости она может быть перемещена или удалена.
            this.all_Transport2TableAdapter.Fill(this.skladDataSet8.All_Transport2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.All_Transport". При необходимости она может быть перемещена или удалена.
        

        }

        private void DobavlenieTransport_Click(object sender, EventArgs e)
        {
            TransportDialogForm f = new TransportDialogForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                int id_vid = Convert.ToInt32(f.comboBoxIDvid.SelectedValue);
                int id_marka = Convert.ToInt32(f.comboBoxIDmarka.SelectedValue);
                int id_post = Convert.ToInt32(f.comboBoxIDpostavchik.SelectedValue);
                int mass = Convert.ToInt32(f.textBoxMass.Text);
                string h_op = f.textBoxOpisanie.Text;
                Transport transport = new Transport();
                transport.Insert(id_vid, id_marka, id_post, mass, h_op);
                this.all_Transport2TableAdapter1.Fill(this.skladDataSet9.All_Transport2);
            }
        }

        private void RedaktirTransport_Click(object sender, EventArgs e)
        {
            int key = dataGridViewTransport.CurrentRow.Index;

            if (key == 0)
            {
                MessageBox.Show("Не выбрана строка для редактирования");
            }
            else
            {

                TransportDialogForm f = new TransportDialogForm();
                f.Text = "Редактирование";
           f.textBoxMass.Text= dataGridViewTransport[4, key].Value.ToString(); 
                f.textBoxOpisanie.Text = dataGridViewTransport[5, key].Value.ToString();
                f.textBox1.Text = dataGridViewTransport[0, key].Value.ToString();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    int id = Convert.ToInt32(f.textBox1.Text);
                    int id_vid = Convert.ToInt32(f.comboBoxIDvid.SelectedValue);
                    int id_marka = Convert.ToInt32(f.comboBoxIDmarka.SelectedValue);
                    int id_post = Convert.ToInt32(f.comboBoxIDpostavchik.SelectedValue);
                    int mass = Convert.ToInt32(f.textBoxMass.Text);
                    string h_op = f.textBoxOpisanie.Text;
                    Transport t = new Transport();
                    t.Update(id_vid, id_marka, id_post, mass, h_op, id);
                    this.all_Transport2TableAdapter1.Fill(this.skladDataSet9.All_Transport2);
                }
            }
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostavchikForm postavchik = new PostavchikForm();
            postavchik.Show();
        }

        private void видToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VidForm vid = new VidForm();
            vid.Show();
        }

        private void моделиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkaForm marka = new MarkaForm();
            marka.Show();
        }

        private void DeleteTransport_Click(object sender, EventArgs e)
        {
            int f = dataGridViewTransport.CurrentRow.Index;
            if (f == 0)
            {
                MessageBox.Show("Не выбрана строка для удаления");
            }
            else
            {
                int id = Convert.ToInt32(dataGridViewTransport[0, f].Value);
                Transport t = new Transport();
                t.Delete(id);
                this.all_Transport2TableAdapter1.Fill(this.skladDataSet9.All_Transport2);
            }
        }
    }
}
