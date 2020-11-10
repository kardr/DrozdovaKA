using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Avtorisazia : Form
    {
        public Avtorisazia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string login = textBoxLogin.Text;
                string password = textBoxPassword.Text;
                string s = "Persist Security Info = False; User ID = " + login + "; Password = " 
                    + password + "; Initial Catalog = Sklad; Server = DESKTOP-8G1ENMJ\\KRNALX";
                SqlConnection conn = new SqlConnection(s);
                conn.Open();
                TransporForm f = new TransporForm();
                f.Show();
                this.Visible = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
