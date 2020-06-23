using rentCar.DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace rentCar.DAO
{
    class CustomerDAO 
    {
        private DBConnection conexion = new DBConnection();
        SqlDataReader reader;
        readonly SqlCommand cmd = new SqlCommand();
        List<CustomerDTO> dtoList;

        //Fills
        private void FillCustomerDtoParams(SqlCommand cmd, CustomerDTO dto)
        {
            cmd.Parameters.AddWithValue("@id", dto.Id);
            cmd.Parameters.AddWithValue("@name", dto.Name);
            cmd.Parameters.AddWithValue("@lastName", dto.LastName);
            cmd.Parameters.AddWithValue("@cedula", dto.IdentificationCard);
            cmd.Parameters.AddWithValue("@type", dto.Type);
            cmd.Parameters.AddWithValue("@creditCard", dto.CreditCardNo);
            cmd.Parameters.AddWithValue("@creditLimit", dto.CreditLimit);
            cmd.Parameters.AddWithValue("@status", dto.Status ? 1 : 0);
            cmd.Parameters.AddWithValue("@RNC", dto.RNC);
        }

        private List<CustomerDTO> FillEmployeeDTOList(SqlDataReader reader)
        {
            List<CustomerDTO> ListaGenerica = new List<CustomerDTO>();

            while (reader.Read())
            {
                ListaGenerica.Add(new CustomerDTO
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    LastName = reader.GetString(2),
                    IdentificationCard = reader.GetString(3),
                    Type = reader.GetString(4),
                    CreditCardNo = reader.GetString(5),
                    CreditLimit = reader.GetInt32(6),
                    Status = (bool)reader["status"],
                    RNC = reader.GetString(8)
                });
            }

            reader.Close();

            return ListaGenerica;
        }

        //Add
        public void ADD(CustomerDTO dto)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "insert into customers values(@name, @lastName, @cedula, @type, @creditCard, @creditLimit, @status, @RNC)";
            cmd.CommandType = CommandType.Text;

            FillCustomerDtoParams(cmd, dto);
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }

        
        //Edit
        public void EDIT(CustomerDTO dto)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "update customers set name = @name, lastname = @lastName, identification_card = @cedula, type = @type, credit_card_no = @creditCard, credit_limit = @creditLimit, status = @status, RNC = @RNC where id = @id";
            cmd.CommandType = CommandType.Text;

            FillCustomerDtoParams(cmd, dto);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }

        //Get
        public List<CustomerDTO> GETALL()
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select * from customers";
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();

            dtoList = FillEmployeeDTOList(reader);

            conexion.CerrarConexion();
            reader.Close();

            return dtoList;
        }

        //Get by
        public bool GetCustomerById(string cedula, string rnc) 
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select * from customers where identification_card = '" + cedula + "' or RNC = '" + rnc + "'";
            cmd.CommandType = CommandType.Text;

            reader = cmd.ExecuteReader();

            if (reader.HasRows)//Exite esta persona, fisica o juridica
            {
                reader.Close();
                conexion.CerrarConexion();
                return true;
            }
            else
            {
                reader.Close();
                conexion.CerrarConexion();
                return false;
            }
        }

        //Searchs...
        public List<CustomerDTO> GetCustomerByCedulOrRnc(string criteria)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select * from customers where identification_card like '" + criteria + "%' or RNC like '" + criteria + "%' ";
            cmd.CommandType = CommandType.Text;

            reader = cmd.ExecuteReader();

            dtoList = FillEmployeeDTOList(reader);
            
            reader.Close();
            conexion.CerrarConexion();
            
            return dtoList;
        }

        //Delete
        public void DELETE(int id)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "delete from customers where id = @id ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
