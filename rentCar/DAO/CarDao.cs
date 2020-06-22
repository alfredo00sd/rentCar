using RentCarApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace rentCar.DAO
{
    class CarDAO : DBConnection
    {
        //Add
        public bool SaveCar(CarDTO carDTO)
        {
            string insertCarQuery = "INSERT INTO carInfo values (@CarType, @CarBrand, @CarModel, @Base64Photo, @FuelType, @CarStatus, @QuantityOfFuel, @CarFabYear, @CarChasisNum, @CarEngineNum, @CarLicensePlate, @CarColor, @CarNumberOfDoors, GETDATE(), @CarCapacityOfPassangers, @CarConditions, @CarUseInKM, null, @CarInvComment);";

            using (var cn = new SqlConnection(CONNECTION_STRING))
            {
                cn.Open();
                DataTable dt = new DataTable();
                try
                {
                    SqlCommand cmd = new SqlCommand(insertCarQuery, cn);

                    FillCarDtoParams(cmd, carDTO);

                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.ToString());
                    Console.WriteLine(e.ToString());
                    return false;
                }
                finally
                {
                    cn.Close();
                }
                return true;
            }
        }
        
        //Gets
        public List<CarDTO> SearchByCriteria(String criteria)
        {
            string sqlSearch = "select id, photo_path, type, brand, model, car_fabrication_year, car_chassis_number, car_engine_number, car_license_plate, car_color, fuel_type, quantity_of_fuel, car_number_of_doors, car_capacity_of_passangers, car_acquisition_date, car_conditions, use_in_km, car_status, car_inv_commentary from  carInfo where car_license_plate like @criteria + '%' or car_chassis_number like @criteria + '%' or car_engine_number like @criteria + '%' or car_fabrication_year like @criteria + '%' or brand like @criteria + '%' or model like @criteria + '%'";
            List<CarDTO> carDTOs = new List<CarDTO>();
            SqlDataReader reader;

            using (var cn = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sqlSearch, cn);
                    cmd.Parameters.AddWithValue("@criteria", criteria);

                    cn.Open();

                    reader = cmd.ExecuteReader();

                    carDTOs = FillCarDTOList(reader);
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    cn.Close();
                }
            }
            return carDTOs;
        }

        public List<CarDTO> GetAllCars()
        {
            string sqlSearch = " select id, photo_path, type, brand, model, car_fabrication_year, car_chassis_number, car_engine_number, car_license_plate, car_color, fuel_type, quantity_of_fuel, car_number_of_doors, car_capacity_of_passangers, car_acquisition_date, car_conditions, use_in_km, car_status, car_inv_commentary from  carInfo";
            List<CarDTO> carDTOs = new List<CarDTO>();
            SqlDataReader reader;

            using (var cn = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sqlSearch, cn);
                    cn.Open();

                    reader = cmd.ExecuteReader();

                    carDTOs = FillCarDTOList(reader);
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    cn.Close();
                }
            }
            return carDTOs;
        }

        public void GetCarById()
        {

        }
        
        //Edit
        public bool EditCar(CarDTO carDTO)
        {
            string updateQuery = "update carInfo set photo_path = @Base64Photo, type = @CarType, brand = @CarBrand, model = @CarModel, car_fabrication_year = @CarFabYear, car_chassis_number = @CarChasisNum, car_engine_number = @CarEngineNum, car_license_plate = @CarLicensePlate, car_color = @CarColor, fuel_type = @FuelType, car_number_of_doors = @CarNumberOfDoors, car_capacity_of_passangers = @CarCapacityOfPassangers, car_conditions = @CarConditions, use_in_km = @CarUseInKM, car_status = @CarStatus, car_inv_commentary = @CarInvComment where id = 1";//@CarId

            using (var cn = new SqlConnection(CONNECTION_STRING))
            {
                cn.Open();
                DataTable dt = new DataTable();
                try
                {
                    SqlCommand cmd = new SqlCommand(updateQuery, cn);

                    FillCarDtoParams(cmd, carDTO);
                    
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.ToString());
                    Console.WriteLine(e.ToString());
                    return false;
                }
                finally
                {
                    cn.Close();
                }
                return true;
            }
        }

        //Delete
        public bool DeleteCar(int carId)
        {
            using (var cn = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("delete from carInfo where id = @CarId ", cn);
                    cmd.Parameters.AddWithValue("@CarId", carId);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
                finally
                {
                    cn.Close();
                }
                return true;
            }
        }

        //Utils
        private void FillCarDtoParams(SqlCommand cmd, CarDTO carDTO)
        {    //Save foto in base64 table and give the id to save on car info table...
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@CarId", carDTO.CarId);
            cmd.Parameters.AddWithValue("@CarType", carDTO.CarType);
            cmd.Parameters.AddWithValue("@CarBrand", carDTO.CarBrand);
            cmd.Parameters.AddWithValue("@CarModel", carDTO.CarModel);
            cmd.Parameters.AddWithValue("@Base64Photo", "path/to/foto");//replace with dto path to photo
            cmd.Parameters.AddWithValue("@FuelType", carDTO.FuelType);
            cmd.Parameters.AddWithValue("@CarStatus", "Nuevo ingreso");//General tag to all new cars in inv
            cmd.Parameters.AddWithValue("@QuantityOfFuel", "Lleno");//General tag to all new cars in inv
            cmd.Parameters.AddWithValue("@CarFabYear", carDTO.CarFabYear);
            cmd.Parameters.AddWithValue("@CarChasisNum", carDTO.CarChasisNum.ToUpper());
            cmd.Parameters.AddWithValue("@CarEngineNum", carDTO.CarEngineNum.ToUpper());
            cmd.Parameters.AddWithValue("@CarLicensePlate", carDTO.CarLicensePlate.ToUpper());
            cmd.Parameters.AddWithValue("@CarColor", carDTO.CarColor);
            cmd.Parameters.AddWithValue("@CarNumberOfDoors", carDTO.CarNumberOfDoors);
            cmd.Parameters.AddWithValue("@CarCapacityOfPassangers", carDTO.CarCapacityOfPassangers);
            cmd.Parameters.AddWithValue("@CarConditions", carDTO.CarConditions);
            cmd.Parameters.AddWithValue("@CarUseInKM", carDTO.CarUseInKM);
            cmd.Parameters.AddWithValue("@CarInvComment", carDTO.CarInvComment);
        }

        public List<CarDTO> FillCarDTOList(SqlDataReader reader)
        {
            List<CarDTO> ListaGenerica = new List<CarDTO>();

            while (reader.Read())
            {
                ListaGenerica.Add(new CarDTO
                {
                    CarId = reader.GetInt32(0),
                    CarBase64Photo = reader.GetString(1), //can not be null reader.GetInt32(4)
                    CarType  = reader.GetString(2),
                    CarBrand = reader.GetString(3),
                    CarModel = reader.GetString(4), // not null
                    CarFabYear = reader.GetInt32(5),
                    CarChasisNum = reader.GetString(6),
                    CarEngineNum = reader.GetString(7),
                    CarLicensePlate = reader.GetString(8),
                    CarColor = reader.GetString(9),
                    FuelType = reader.GetString(10), //Not null
                    QuantityOfFuel = reader.GetString(11),
                    CarNumberOfDoors = reader.GetInt32(12),
                    CarCapacityOfPassangers = reader.GetInt32(13),
                    //14 Fecha de ingreso...
                    CarConditions = reader.GetString(15),
                    CarUseInKM = reader.GetString(16),//Convert.ToInt32(reader.GetString(17)), //problem casting type
                    CarStatus = reader.GetString(17),
                    CarInvComment = reader.GetString(18)//reader.GetString(18)
                });
            }

            reader.Close();

            return ListaGenerica;
        }
    }

    class CarModelCRUD : DBConnection
    {
        //Add
        public string AddNewModel(int brandId, string modelDes) 
        {
            string sqlInsert = "insert into car_model values (14, @CarBrandId, @CarModelDes)";

            //Validate duplicates
            if (GetModelByDes(modelDes))
            {
                return "Este modelo " + modelDes + " ya existe en el sistema";
            }
            else 
            {
                using (var cn = new SqlConnection(CONNECTION_STRING))
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(sqlInsert, cn);
                        cmd.Parameters.AddWithValue("@CarBrandId", brandId);
                        cmd.Parameters.AddWithValue("@CarModelDes", modelDes);
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(e.ToString());
                        Console.WriteLine(e.ToString());
                    }
                    finally
                    {
                        cn.Close();
                    }
                    return "Modelo agregado!";
                }
            }
        }

        //Gets by
        public bool GetModelByDes(string modelDes) 
        {
            string query = "select * from car_model where car_model_description = '"+modelDes+"'";

            SqlDataReader reader;
            
            using (var cn = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();

                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                        return true;
                    
                    reader.Close();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    cn.Close();
                }
            }
            return false;
        }
     
        public List<CarModelDTO> GetCarModelsByCondition(string condition)
        {
            string query = "select m.car_model_id as id, m.car_model_description as model, b.car_brand_description as parentBrand, b.car_brand_id as parentBrandId, g.general_status_description as modelStatus from car_model m, car_brand b, general_status g  where m.car_brand_id = b.car_brand_id and m.car_model_status = g.general_status_id and m.car_model_description like '"+condition+"%'";

            SqlDataReader reader;
            List<CarModelDTO> Lista = new List<CarModelDTO>();

            using (var cn = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Lista.Add(new CarModelDTO
                        {
                            ModelId = reader.GetInt32(0),
                            ModelDescription = reader.GetString(1),
                            ParentBrand = reader.GetString(2),
                            ParentBrandId = reader.GetInt32(3),
                            Status = reader.GetString(4)
                        });
                    }
                    reader.Close();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    cn.Close();
                }
            }
            return Lista;
        }
   
        public DataTable GetCarModelByBrand(String carBrandId)
        {
            string carModelByBrandQuery = "select car_model_id as id, car_model_description as modelo from car_model where car_brand_id = @carBrandId and car_model_status = 14";

            using (var cn = new SqlConnection(CONNECTION_STRING))
            {
                cn.Open();
                DataTable dt = new DataTable();
                try
                {
                    SqlCommand cmd = new SqlCommand(carModelByBrandQuery, cn);
                    cmd.Parameters.AddWithValue("@carBrandId", carBrandId);

                    SqlDataReader myReader = cmd.ExecuteReader();
                    dt.Load(myReader);
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    cn.Close();
                }

                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    dt.Rows.Add(new Object[] { 1, "N/A" });

                    return dt;
                }
            }
        }

        //Get
        public List<CarModelDTO> GetCarModels()
        {
            string query = "select m.car_model_id as id, m.car_model_description as model, b.car_brand_description as parentBrand, b.car_brand_id as parentBrandId, g.general_status_description as modelStatus from car_model m, car_brand b, general_status g where m.car_brand_id = b.car_brand_id and m.car_model_status = g.general_status_id";

            SqlDataReader reader;
            List<CarModelDTO> Lista = new List<CarModelDTO>();

            using (var cn = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Lista.Add(new CarModelDTO
                        {
                            ModelId = reader.GetInt32(0),
                            ModelDescription = reader.GetString(1),
                            ParentBrand = reader.GetString(2),
                            ParentBrandId = reader.GetInt32(3),
                            Status = reader.GetString(4)
                        });

                    }
                    reader.Close();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    cn.Close();
                }
            }
            return Lista;
        }

        //Edit
        public bool EditCarModel(CarModelDTO carModel) 
        {
            using (var cn = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("update car_model set car_model_status = @CarModelStatus, car_brand_id = @CarModelParentBrand, car_model_description = @CarModelDes where car_model_id = @CarModelId", cn);
                    cmd.Parameters.AddWithValue("@CarModelId", carModel.ModelId);
                    cmd.Parameters.AddWithValue("@CarModelParentBrand", carModel.ParentBrandId);
                    cmd.Parameters.AddWithValue("@CarModelDes", carModel.ModelDescription);
                    int modelStatus = carModel.Status.Equals("Activo") ? 14 : 15;
                    cmd.Parameters.AddWithValue("@CarModelStatus", modelStatus);

                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
                finally
                {
                    cn.Close();
                }
                return true;
            }
        }

        //Delete
        public bool DeleteCarModel(string carModelId)
        {
            using (var cn = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("delete from car_model where car_model_id = @CarModelId ", cn);
                    cmd.Parameters.AddWithValue("@CarModelId", carModelId);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
                finally
                {
                    cn.Close();
                }
                return true;
            }
        }
    }
}
