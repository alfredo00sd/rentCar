using RentCarApp.DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace rentCar.DAO
{
    class CommonsCarDAO
    {
        private readonly DBConnection conexion = new DBConnection();
        private SqlDataReader reader;
        private readonly SqlCommand cmd = new SqlCommand();
        private readonly List<CarTypeDTO> carTypeDtoList;
        private readonly List<CarBrandDTO> carBrandDtoList;
        private readonly List<CarFuelTypeDTO> carFuelTypeDtoList;
        private readonly DataTable dt = new DataTable();

        //Get car type
        public List<CarTypeDTO> GetCartypes()
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select * from type_of_car";
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                carTypeDtoList.Add(new CarTypeDTO
                {
                    CarTypeId = reader.GetInt32(0),
                    CarTypeDescription = reader.GetString(1),
                    CarTypeStatus = (bool)reader["status"]
                });
            }

            reader.Close();
            conexion.CerrarConexion();

            return carTypeDtoList;
        }

        //Get car brand
        public List<CarBrandDTO> GetCarBrands()
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select * from car_brand";
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                carBrandDtoList.Add(new CarBrandDTO
                {
                    BrandId = reader.GetInt32(0),
                    BrandDescription = reader.GetString(1),
                    BrandStatus = (bool)reader["status"]
                });
            }

            reader.Close();
            conexion.CerrarConexion();
            
            return carBrandDtoList;
        }

        //Get car fuel type
        public List<CarFuelTypeDTO> GetCarFuelType()
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select * from type_of_fuel";
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                carFuelTypeDtoList.Add(new CarFuelTypeDTO
                {
                    FuelTypeId = reader.GetInt32(0),
                    FuelType = reader.GetString(1),
                    FuelStatus = (bool)reader["status"]
                });
            }            
            reader.Close();
            conexion.CerrarConexion();

            return carFuelTypeDtoList;
        }

        //--------------------------------------------------------------------Generics

        //Get for
        public DataTable GetDataForCB(string table)
        {
            string consultQuery = "select * from "+table+"";
          
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = consultQuery;
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();

            dt.Load(reader);

            reader.Close();
            conexion.CerrarConexion();
           
            return dt;
        }

        //Gets by
        public bool GetByDescription(string description, string table)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select description from @table where description = @description";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@table", table);
            cmd.Parameters.AddWithValue("@description", description);
            
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
                return true;

            reader.Close();
            conexion.CerrarConexion();

            return false;
        }

        //Add
        public void Add(string description, string table, bool status)
        {
            if (GetByDescription(description, table)) //Validate duplicates
            {
                MessageBox.Show("Esta descripcion " + description + " ya existe en este mantenimiento.");
            }
            else
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "insert into @table values (@description, @status)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@table", description);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@status", status);

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                conexion.CerrarConexion();
            }
        }

        //Edit
        public void Edit(string id, string description, bool status, string table)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "update @table set description = @description, status = @status where id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@status", status ? 1 : 0);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }

        //Delete
        public void Delete(string id, string table)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "delete from @table where id = @id ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@table", table);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }
        //--------------------------------------------------------------------Generics
    }
}
