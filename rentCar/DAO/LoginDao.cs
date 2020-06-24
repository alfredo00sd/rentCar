using rentCar.DTO.user;
using System;
using System.Data;
using System.Data.SqlClient;

namespace rentCar.DAO.user
{
    class LoginDao
    {
        private readonly DBConnection conexion = new DBConnection();
        private SqlDataReader reader;
        private readonly SqlCommand cmd = new SqlCommand();
        private UserDTO user;
        private bool status;

        public UserDTO ValidateLoggin(String userCard, String userClave)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select * from users where user_name = '"+userCard+"' and user_password = '"+userClave+"'";
            cmd.CommandType = CommandType.Text;
            //Remember to encode the password

            reader = cmd.ExecuteReader();

            if (reader.HasRows)//Exite el carro!
            {
                reader.Read();
                
                status = (bool)reader["user_status"];

                if (!status)
                {
                    user = new UserDTO
                    {
                        Message = "Usuario desactivado! favor contactar al administrador..."
                    };
                    reader.Close();
                    conexion.CerrarConexion();
                    return user;
                }
                else {

                    user = new UserDTO
                    {
                        UserId = reader.GetInt32(0),
                        EmployeeId = reader.GetInt32(1),
                        RolCode = reader.GetString(2),
                        IdentificationCard = reader.GetString(3),
                        UserName = reader.GetString(4),
                        Password = reader.GetString(5),
                        Status = status,
                        Message = "OK"
                    };
                    reader.Close();
                    conexion.CerrarConexion();
                    return user;
                }
            }
            else
            {
                user = new UserDTO
                {
                    Message = "Usuario o Clave erronea, favor validar o contactar al administrador!"
                };
                reader.Close();
                conexion.CerrarConexion();
                return user;
            }
        }
    }
}
