using System.Data.SqlClient;

namespace rentCar
{
    class DBConnection
    {
        public const string CONNECTION_STRING = "Server=DESKTOP-EOOHF5T;DataBase=CarRentSA;Integrated Security = true";
        
        public SqlConnection Conexion = new SqlConnection("Server=DESKTOP-EOOHF5T;DataBase=CarRentSA;Integrated Security=true");
    }
}
