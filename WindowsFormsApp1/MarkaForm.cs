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
        public static string connectionString = @"Data Source=DESKTOP-8G1ENMJ\KRNALX;Initial Catalog=Sklad;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connectionString);
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
            string id = textBoxMarkaID.Text;
            string name = textBoxMarkaName.Text;
            conn.Open();
            string d = "INSERT INTO Marka(Id, Name) VALUES(" + id + ", '" + name + "')";
            SqlCommand command = new SqlCommand(d, conn);
            command.ExecuteNonQuery();
            conn.Close();
            this.markaTableAdapter.Fill(this.skladDataSet5.Marka);
            textBoxMarkaID.Text = "";
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
                string a = "DELETE FROM Marka WHERE Id = " + id.ToString();
                conn.Open();
                SqlCommand command = new SqlCommand(a, conn);
                command.ExecuteNonQuery();
                conn.Close();
                this.markaTableAdapter.Fill(this.skladDataSet5.Marka);
            }
            textBoxRedakMarkaID.Text = "";
            textBoxRedakMarkaName.Text = "";
        }

        private void RedaktirMarka_Click(object sender, EventArgs e)
        {
            int f = dataGridViewMarka.CurrentRow.Index;
            string name = textBoxRedakMarkaName.Text;
            int id = Convert.ToInt32(dataGridViewMarka[0, f].Value);
            string h = "UPDATE Marka set Name='" + name + "' WHERE Id=" + id + "";
            conn.Open();
            SqlCommand command = new SqlCommand(h, conn);
            command.ExecuteNonQuery();
            conn.Close();
            this.markaTableAdapter.Fill(this.skladDataSet5.Marka);
            textBoxRedakMarkaID.Text = "";
            textBoxRedakMarkaName.Text = "";
        }

        private void dataGridViewMarka_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = dataGridViewMarka.CurrentRow.Index;
            textBoxRedakMarkaName.Text = dataGridViewMarka[1, f].Value.ToString();
        }
    }
}
