using System.Data;
using System.Data.SqlClient;

namespace rentCar
{
    class DBConnection
    {
        public const string CONNECTION_STRING = "Server=DESKTOP-EOOHF5T;DataBase=CarRentSA;Integrated Security = true";

        private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-EOOHF5T;DataBase=CarRentSA;Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
//        public SqlConnection Conexion = new SqlConnection("Server=DESKTOP-EOOHF5T;DataBase=CarRentSA;Integrated Security=true");
    }
}
