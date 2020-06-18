using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace rentCar
{
    class DBConnection
    {
        protected SqlConnection Conexion = new SqlConnection("Server=DESKTOP-EOOHF5T;DataBase=CarRentSA;Integrated Security=true");
    }
}
