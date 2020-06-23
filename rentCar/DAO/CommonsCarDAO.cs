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
        private readonly DataTable dt = new DataTable();

        //Get car type
        public List<CarTypeDTO> GetCartypes()
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select * from type_of_car";
            cmd.CommandType = CommandType.Text;

            List<CarTypeDTO> carTypeDtoList = new List<CarTypeDTO>();

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

            List<CarBrandDTO> carBrandDtoList = new List<CarBrandDTO>(); 

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

            List<CarFuelTypeDTO> carFuelTypeDtoList = new List<CarFuelTypeDTO>();

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
            string consultQuery = "select * from " + table + " ";
          
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
            cmd.CommandText = "select description from " + table + " where description = '" + description + "' ";
            cmd.CommandType = CommandType.Text;
            
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
                return true;

            reader.Close();
            conexion.CerrarConexion();

            return false;
        }

        //Add
        public bool Add(string description, string table, bool status)
        {
            if (GetByDescription(description, table)) //Validate duplicates
            {
                MessageBox.Show("Esta descripcion " + description + " ya existe en este mantenimiento.");
                return false;
            }
            else
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "insert into " + table + " values ('" + description + "', " + (status ? 1 : 0) + ")";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                conexion.CerrarConexion();

                return true;
            }
        }

        //Edit
        public void Edit(string id, string description, bool status, string table)
        {
            ;
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "update " + table + " set description = '" + description + "', status = " + (status ? 1 : 0) + " where id = " + id + "";
            cmd.CommandType = CommandType.Text;
          
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }

        //Delete
        public void Delete(string id, string table)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "delete from " + table + " where id = " + id + " ";
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }
        //--------------------------------------------------------------------Generics
    }
}
