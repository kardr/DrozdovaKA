using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Marka
    {
        static string connectionString = @"Data Source=DESKTOP-8G1ENMJ\KRNALX;Initial Catalog=Sklad;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);

        public void Insert(string Name)
        {
            conn.Open();
            string d = "INSERT INTO Marka(Name) VALUES( '" + Name + "')";
            SqlCommand command = new SqlCommand(d, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(int Id)
        {
            string a = "DELETE FROM Marka WHERE Id = " + Id.ToString();
            conn.Open();
            SqlCommand command = new SqlCommand(a, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(string name, int id)
        {
            string h = "UPDATE Marka set Name='" + name + "' WHERE Id=" + id + "";
            conn.Open();
            SqlCommand command = new SqlCommand(h, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
