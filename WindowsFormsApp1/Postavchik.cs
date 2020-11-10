using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Postavchik
    {
        public static string connectionString = @"Data Source=DESKTOP-8G1ENMJ\KRNALX;Initial Catalog=Sklad;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connectionString);

        public void Insert(string name, string address, string tel)
        {
            conn.Open();
            string d = "INSERT INTO Postavchik( Name,Adress,Telefon) VALUES( '" + name + "', '" + address + "', '" + tel + "')";
            SqlCommand command = new SqlCommand(d, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(int Id)
        {
            string a = "DELETE FROM Postavchik WHERE Id = " + Id.ToString();
            conn.Open();
            SqlCommand command = new SqlCommand(a, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(string name, string address, string tel, int id)
        {
            string h = "UPDATE Postavchik set Name='" + name + "', Adress='" + address + "', Telefon='" + tel + "' WHERE Id=" + id + "";
            conn.Open();
            SqlCommand command = new SqlCommand(h, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
