using RentCarApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace rentCar.DAO
{
    class CarDAO 
    {
        //Filds
        private DBConnection conexion = new DBConnection();
        SqlDataReader reader;
        readonly SqlCommand cmd = new SqlCommand();
        List<CarDTO> dtoList;

        //Utils
        private void FillCarDtoParams(SqlCommand cmd, CarDTO carDTO)
        {    //Save foto in base64 table and give the id to save on car info table...
            cmd.Parameters.AddWithValue("@CarId", carDTO.Id);
            cmd.Parameters.AddWithValue("@CarType", carDTO.Type);
            cmd.Parameters.AddWithValue("@CarBrand", carDTO.Brand);
            cmd.Parameters.AddWithValue("@CarModel", carDTO.Model);
            cmd.Parameters.AddWithValue("@Base64Photo", carDTO.PhotoPath);//replace with dto path to photo
            cmd.Parameters.AddWithValue("@FuelType", carDTO.FuelType);
            cmd.Parameters.AddWithValue("@QuantityOfFuel", carDTO.QuantityOfFuel);//General tag to all new cars in inv
            cmd.Parameters.AddWithValue("@CarFabYear", carDTO.FabYear);
            cmd.Parameters.AddWithValue("@CarChasisNum", carDTO.ChasisNum.ToUpper());
            cmd.Parameters.AddWithValue("@CarEngineNum", carDTO.EngineNum.ToUpper());
            cmd.Parameters.AddWithValue("@CarLicensePlate", carDTO.LicensePlate.ToUpper());
            cmd.Parameters.AddWithValue("@CarColor", carDTO.Color);
            cmd.Parameters.AddWithValue("@CarNumberOfDoors", carDTO.NumberOfDoors);
            cmd.Parameters.AddWithValue("@CarCapacityOfPassangers", carDTO.CapacityOfPassangers);
            cmd.Parameters.AddWithValue("@CarConditions", carDTO.Conditions);
            cmd.Parameters.AddWithValue("@CarUseInKM", carDTO.UseInKM);
            cmd.Parameters.AddWithValue("@CarInvComment", carDTO.Comment);
            cmd.Parameters.AddWithValue("@CarStatus", carDTO.Status ? 1 : 0);//General tag to all new cars in inv
        }

        public List<CarDTO> FillCarDTOList(SqlDataReader reader)
        {
            List<CarDTO> ListaGenerica = new List<CarDTO>();

            while (reader.Read())
            {
                ListaGenerica.Add(new CarDTO
                {
                    Id = reader.GetInt32(0),
                    PhotoPath = reader.GetString(1), //can not be null reader.GetInt32(4)
                    Type = reader.GetString(2),
                    Brand = reader.GetString(3),
                    Model = reader.GetString(4), // not null
                    FabYear = reader.GetInt32(5),
                    ChasisNum = reader.GetString(6),
                    EngineNum = reader.GetString(7),
                    LicensePlate = reader.GetString(8),
                    Color = reader.GetString(9),
                    FuelType = reader.GetString(10), //Not null
                    QuantityOfFuel = reader.GetString(11),
                    NumberOfDoors = reader.GetInt32(12),
                    CapacityOfPassangers = reader.GetInt32(13),
                    Conditions = reader.GetString(15),
                    UseInKM = reader.GetInt32(16),//Convert.ToInt32(reader.GetString(17)), //problem casting type
                    Comment = reader.GetString(17),//reader.GetString(18)
                    //18 Fecha de ingreso...
                    //10 Fecha de salida...
                    Status = (bool)reader["status"]
                });
            }
            return ListaGenerica;
        }

        //Add
        public void ADD(CarDTO carDTO)
        {
            if (GetCarById(carDTO.LicensePlate, carDTO.ChasisNum, carDTO.EngineNum))
            {
                MessageBox.Show("ERROR : No se acepta duplicidad de registros. Este vehiculo, ya esta en el sistema! favor validar la placa: "+carDTO.LicensePlate+", el chasis: "+carDTO.ChasisNum+" o el numero de motor: "+carDTO.EngineNum);
            }
            else 
            { 
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "insert into carInfo values (@Base64Photo, @CarType, @CarBrand, @CarModel, @CarFabYear, @CarChasisNum, @CarEngineNum, @CarLicensePlate, @CarColor, @FuelType, @QuantityOfFuel, @CarNumberOfDoors, @CarCapacityOfPassangers,  @CarConditions, @CarUseInKM, @CarInvComment, GETDATE(), null, @CarStatus)";
                cmd.CommandType = CommandType.Text;

                FillCarDtoParams(cmd, carDTO);

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                conexion.CerrarConexion();
            }
        }
        
        //Searchs...
        public List<CarDTO> SearchByCriteria(String criteria)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select * from carInfo where license_plate like @criteria + '%' or chassis_number like @criteria + '%' or engine_number like @criteria + '%' or fabrication_year like @criteria + '%' or brand like @criteria + '%' or model like @criteria + '%'";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@criteria", criteria);

            reader = cmd.ExecuteReader();

            dtoList = FillCarDTOList(reader);

            reader.Close();
            conexion.CerrarConexion();

            return dtoList;
        }

        //Gets
        public List<CarDTO> GETALL()
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select * from carInfo";
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();

            dtoList = FillCarDTOList(reader);

            conexion.CerrarConexion();
            reader.Close();

            return dtoList;
        }

        public bool GetCarById(string placa, string chasis, string engine)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select * from carInfo where car_license_plate = '" + placa + "' or car_chassis_number = '" + chasis + "' or car_engine_number = '" + engine + "'";
            cmd.CommandType = CommandType.Text;

            reader = cmd.ExecuteReader();

            if (reader.HasRows)//Exite el carro!
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
        
        //Edit
        public void EDIT(CarDTO dto)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "update carInfo set photo_path = @Base64Photo, type = @CarType, brand = @CarBrand, model = @CarModel, car_fabrication_year = @CarFabYear, car_chassis_number = @CarChasisNum, car_engine_number = @CarEngineNum, car_license_plate = @CarLicensePlate, car_color = @CarColor, fuel_type = @FuelType, car_number_of_doors = @CarNumberOfDoors, car_capacity_of_passangers = @CarCapacityOfPassangers, car_conditions = @CarConditions, use_in_km = @CarUseInKM, car_status = @CarStatus, car_inv_commentary = @CarInvComment where id = @CarId";
            cmd.CommandType = CommandType.Text;

            FillCarDtoParams(cmd, dto);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }

        //Delete
        public void DELETE(int id)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "delete from carInfo where id = @id ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }

    class CarModelCRUD
    {
        //Filds
        private DBConnection conexion = new DBConnection();
        SqlDataReader reader;
        readonly SqlCommand cmd = new SqlCommand();
        List<CarModelDTO> dtoList;

        //Utils
        public List<CarDTO> FillCarModelDTOList(SqlDataReader reader)
        {
            List<CarDTO> ListaGenerica = new List<CarDTO>();

            while (reader.Read())
            {
                dtoList.Add(new CarModelDTO
                {
                    ModelId = reader.GetInt32(0),
                    ModelDescription = reader.GetString(1),
                    ParentBrandId = reader.GetInt32(2),
                    ParentBrand = reader.GetString(3),
                    Status = (bool)reader["status"]
                });
            }
            return ListaGenerica;
        }

        private void FillCarModelDtoParams(CarModelDTO carModel)
        {
            cmd.Parameters.AddWithValue("@CarModelDesId", carModel.ModelId);
            cmd.Parameters.AddWithValue("@CarModelDes", carModel.ModelDescription);
            cmd.Parameters.AddWithValue("@CarBrandId", carModel.ParentBrandId);
            cmd.Parameters.AddWithValue("@CarBrand", carModel.ParentBrand);
            cmd.Parameters.AddWithValue("@status", carModel.Status ? 1 : 0);
        }

        //Add
        public void AddNewModel(CarModelDTO carModelDTO) 
        {
            //Validate duplicates
            if (GetModelByDes(carModelDTO.ModelDescription))
            {
                MessageBox.Show("Este modelo " + carModelDTO.ModelDescription + " ya existe en el sistema");
            }
            else
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "insert into car_model values (@CarModelDes, @CarBrandId, @CarBrand, @status)";
                cmd.CommandType = CommandType.Text;
                
                FillCarModelDtoParams(carModelDTO); 
                
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                conexion.CerrarConexion();
            }
        }

        //Gets by
        public bool GetModelByDes(string modelDes) 
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select * from car_model where car_model_description = '" + modelDes + "'";
            cmd.CommandType = CommandType.Text;

            reader = cmd.ExecuteReader();

            if (reader.HasRows)//Exite el modelo!
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
     
        public List<CarModelDTO> GetCarModelsByCondition(string condition)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select * from car_model where description like '" + condition + "%'";
            cmd.CommandType = CommandType.Text;
           
            reader = cmd.ExecuteReader();

            FillCarModelDTOList(reader);

            reader.Close();
            conexion.CerrarConexion();

            return dtoList;
        }
   
        public List<CarModelDTO> GetCarModelByBrand(String carBrandId)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select id, description as modelo from car_model where car_brand_id = @carBrandId";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@carBrandId",carBrandId);
           
            reader = cmd.ExecuteReader();

            FillCarModelDTOList(reader);

            reader.Close();
            conexion.CerrarConexion();

            return dtoList;
        }

        //Get
        public List<CarModelDTO> GetCarModels()
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select m.id, m.description as modelo, b.id as marcaId, b.description as marca, m.status from car_model m, car_brand b where b.id = m.car_brand_id";
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();

            FillCarModelDTOList(reader);

            reader.Close();
            conexion.CerrarConexion();

            return dtoList;
        }

        //Edit
        public void EditCarModel(CarModelDTO dto) 
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "update car_model set description = @CarModelDes, car_brand_id = @CarBrandId, car_brandDes = CarBrand, status = @status where id = @CarModelDesId";
            cmd.CommandType = CommandType.Text;

            FillCarModelDtoParams(dto);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }

        //Delete
        public void DeleteCarModel(string carModelId)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "delete from car_model where car_model_id = @CarModelId";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@CarModelId", carModelId);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
