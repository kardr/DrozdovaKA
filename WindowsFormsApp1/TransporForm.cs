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
        public static string connectionString = @"Data Source=DESKTOP-8G1ENMJ\KRNALX;Initial Catalog=Sklad;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connectionString);
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
                string id = f.textboxIDtransport.Text;
                string id_vid = f.comboBoxIDvid.SelectedValue.ToString();
                string id_marka = f.comboBoxIDmarka.SelectedValue.ToString();
                string id_post = f.comboBoxIDpostavchik.SelectedValue.ToString();
                string mass = f.textBoxMass.Text.ToString();
                string h_op = f.textBoxOpisanie.Text;
                conn.Open();
                string d = "INSERT INTO Transport(ID, Vid_id, Marka_id,Postavchik_id,Mass, Opisanie) " +
                    "VALUES("+id+", "+id_vid+", "+id_marka+", "+id_post+", "+mass+",'"+h_op+"')";
                SqlCommand command = new SqlCommand(d, conn);
                command.ExecuteNonQuery();
                conn.Close();
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
                f.textboxIDtransport.Text = dataGridViewTransport[0, key].Value.ToString();
                f.textboxIDtransport.Enabled = false;
           f.textBoxMass.Text= dataGridViewTransport[4, key].Value.ToString(); 
                f.textBoxOpisanie.Text = dataGridViewTransport[5, key].Value.ToString(); 
                if (f.ShowDialog() == DialogResult.OK)
                {
                    string id = f.textboxIDtransport.Text;
                    string id_vid = f.comboBoxIDvid.SelectedValue.ToString();
                    string id_marka = f.comboBoxIDmarka.SelectedValue.ToString();
                    string id_post = f.comboBoxIDpostavchik.SelectedValue.ToString();
                    string mass = f.textBoxMass.Text.ToString();
                    string h_op = f.textBoxOpisanie.Text;
                    string h = "UPDATE Transport set  Vid_id="+ id_vid + ", Marka_id="+ id_marka + ", Postavchik_id="+ id_post+ ", Mass="+mass+", Opisanie='"+h_op+"' WHERE Id = "+id+"";
                    conn.Open();
                    SqlCommand command = new SqlCommand(h, conn);
                    command.ExecuteNonQuery();
                    conn.Close();
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
                string a = "DELETE FROM Transport WHERE Id = " + id.ToString();
                conn.Open();
                SqlCommand command = new SqlCommand(a, conn);
                command.ExecuteNonQuery();
                conn.Close();
                this.all_Transport2TableAdapter1.Fill(this.skladDataSet9.All_Transport2);
            }
        }
    }
}
