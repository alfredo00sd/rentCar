
using rentCar.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace rentCar.DAO
{
    class EmployeeDAO 
    {
        private DBConnection conexion = new DBConnection();
        SqlDataReader reader;
        SqlCommand cmd = new SqlCommand();

        //Searchs...

        //Add
        public void ADD(EmployeeDTO dto) 
        {
            //string insert = "insert into employees values(@dominicanCard, @employeeCard, @workSession, @name, @lastName, getDate(), @workPosition, @comission, @status)";
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "insert into employees values(@dominicanCard, @employeeCard, @workSession, @name, @lastName, getDate(), @workPosition, @comission, @status)";
            cmd.CommandType = CommandType.Text;
            FillEmployeeDtoParams(cmd, dto);
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }

        //Fills
        private void FillEmployeeDtoParams(SqlCommand cmd, EmployeeDTO dto)
        {    //Save foto in base64 table and give the id to save on car info table...
            cmd.Parameters.AddWithValue("@id", dto.EmployeeId);
            cmd.Parameters.AddWithValue("@dominicanCard", dto.IdentificationCard);
            cmd.Parameters.AddWithValue("@employeeCard", dto.EmployeeCard);
            cmd.Parameters.AddWithValue("@workSession", dto.WorkSession);
            cmd.Parameters.AddWithValue("@name", dto.Name);
            cmd.Parameters.AddWithValue("@lastName", dto.LastName);
            cmd.Parameters.AddWithValue("@workPosition", dto.WorkPosition);
            cmd.Parameters.AddWithValue("@comission", dto.Comission);
            cmd.Parameters.AddWithValue("@status", dto.Status ? 1 : 0);
        }

        public List<EmployeeDTO> FillEmployeeDTOList(SqlDataReader reader)
        {
            List<EmployeeDTO> ListaGenerica = new List<EmployeeDTO>();
            string rol;

            while (reader.Read())
            {
                switch (reader.GetString(7))
                {
                    case "GEST": rol = "Rentador"; break;
                    case "INSP": rol = "Insperctor"; break;
                    case "ADMI": rol = "Administrador"; break;
                    default: rol = "NoRol"; break;
                }

                ListaGenerica.Add(new EmployeeDTO
                {
                    EmployeeId = reader.GetInt32(0),
                    IdentificationCard = reader.GetString(1),
                    EmployeeCard = reader.GetString(2),
                    WorkSession = reader.GetString(3),
                    Name = reader.GetString(4),
                    LastName = reader.GetString(5),
                    StartDate = Convert.ToString(reader.GetDateTime(6)),
                    WorkPosition = rol,
                    Comission = reader.GetInt32(8),
                    Status = (bool)reader["status"]
                }) ;
            }

            reader.Close();

            return ListaGenerica;
        }

        //Edit
        public void EDIT(EmployeeDTO dto)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "EditEmployee";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@employeeCard", dto.EmployeeCard);
            cmd.Parameters.AddWithValue("@workSession", dto.WorkSession);
            cmd.Parameters.AddWithValue("@name", dto.Name);
            cmd.Parameters.AddWithValue("@lastName", dto.LastName);
            cmd.Parameters.AddWithValue("@workPosition", dto.WorkPosition);
            cmd.Parameters.AddWithValue("@comission", dto.Comission);
            cmd.Parameters.AddWithValue("@status", dto.Status ? 1 : 0);
            cmd.Parameters.AddWithValue("@id", dto.EmployeeId);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }

        //Get
        public List<EmployeeDTO> GETALL()
        {
            List<EmployeeDTO> dtoList;

            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select * from employees";
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();
            
            dtoList = FillEmployeeDTOList(reader);

            conexion.CerrarConexion();
            reader.Close();

            return dtoList;
        }

        public string GetEmployeeUserCredentials(int employeeId, string empoyeeDominicanCard)
        {
            string user;
            string pass;

            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select user_name, user_password from users where identification = '" + empoyeeDominicanCard + "' and employee_id = '" + employeeId + "'";
            cmd.CommandType = CommandType.Text;
            
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                user = reader.GetString(0);
                pass = reader.GetString(1);
            }
            else
            {
                return "El usario no existe! favor contactar un developer... si aun paga el mantenimiento xD";
            }
            return "El usuario es : " + user + ", y la clave es : " + pass;
        }

        //Get by id
        public bool GetEmployeeById(string cedula) 
        {
            //string query = "select * from employees where identification_card = '" + cedula + "'";
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select * from employees where identification_card = '" + cedula + "'";
            cmd.CommandType = CommandType.Text;

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                conexion.CerrarConexion();

                return true;
            }
            else {
                reader.Close();
                conexion.CerrarConexion();

                return false;
            }
        }

        //Delete
        public void DELETE(int id)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "delete from employees where id = @id ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
