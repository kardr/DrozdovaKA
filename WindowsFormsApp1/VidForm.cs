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
        public static string connectionString = @"Data Source=DESKTOP-8G1ENMJ\KRNALX;Initial Catalog=Sklad;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connectionString);
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
            string id = textBoxVidID.Text;
            string name = textBoxVidName.Text;
            conn.Open();
            string d = "INSERT INTO Vid(Id, Name) VALUES(" + id + ", '" + name + "')";
            SqlCommand command = new SqlCommand(d, conn);
            command.ExecuteNonQuery();
            conn.Close();
            this.vidTableAdapter.Fill(this.skladDataSet6.Vid);
            textBoxVidID.Text = "";
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
                string a = "DELETE FROM Vid WHERE Id = " + id.ToString();
                conn.Open();
                SqlCommand command = new SqlCommand(a, conn);
                command.ExecuteNonQuery();
                conn.Close();
                this.vidTableAdapter.Fill(this.skladDataSet6.Vid);
            }
            textBoxRedakVidID.Text = "";
            textBoxRedakVidName.Text = "";
        }

        private void RedaktirVid_Click(object sender, EventArgs e)
        {
            int f = dataGridViewVid.CurrentRow.Index;
            string name = textBoxRedakVidName.Text;
            int id = Convert.ToInt32(dataGridViewVid[0, f].Value);
            string h = "UPDATE Vid set Name='" + name + "' WHERE Id=" + id + "";
            conn.Open();
            SqlCommand command = new SqlCommand(h, conn);
            command.ExecuteNonQuery();
            conn.Close();
            this.vidTableAdapter.Fill(this.skladDataSet6.Vid);
            textBoxRedakVidID.Text = "";
            textBoxRedakVidName.Text = "";
        }

        private void dataGridViewVid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = dataGridViewVid.CurrentRow.Index;
            textBoxRedakVidName.Text = dataGridViewVid[1, f].Value.ToString();
        }
    }
}
