using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Transport
    {
        static string connectionString = @"Data Source=DESKTOP-8G1ENMJ\KRNALX;Initial Catalog=Sklad;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);

        public void Insert(int Vid_id, int Marka_id, int Postavchik_id, int Mass, string Opisanie)
        {
            conn.Open();
            string d = "INSERT INTO Transport(Vid_id, Marka_id,Postavchik_id,Mass, Opisanie) " +
                "VALUES( " + Vid_id + ", " + Marka_id + ", " + Postavchik_id + ", " + Mass + ",'" + Opisanie + "')";
            SqlCommand command = new SqlCommand(d, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(int Id)
        {
            string a = "DELETE FROM Transport WHERE Id = " + Id.ToString();
            conn.Open();
            SqlCommand command = new SqlCommand(a, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(int Vid_id, int Marka_id, int Postavchik_id, int Mass, string Opisanie, int id)
        {
            string h = "UPDATE Transport set  Vid_id=" + Vid_id + ", Marka_id=" + Marka_id + ", Postavchik_id=" + Postavchik_id + ", Mass=" + Mass + ", Opisanie='" + Opisanie + "' WHERE Id = " + id + "";
            conn.Open();
            SqlCommand command = new SqlCommand(h, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
