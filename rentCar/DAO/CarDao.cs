using RentCarApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace rentCar.DAO
{
    class CarDao : DBConnection
    {
        public bool SaveCar(CarDTO carDTO)
        {
            string insertCarQuery = "INSERT INTO car_info values (@CarTypeId, @CarBrandId, @CarModelId, @Base64Photo, @FuelTypeId, @CarStatus, @QuantityOfFuel, @CarFabYear, @CarChasisNum, @CarEngineNum, @CarLicensePlate, @CarColor, @CarNumberOfDoors, GETDATE(), @CarCapacityOfPassangers, @CarConditions, @CarUseInKM, null, @CarInvComment);";

            using (var cn = Conexion)
            {
                cn.Open();
                DataTable dt = new DataTable();
                try
                {
                    SqlCommand cmd = new SqlCommand(insertCarQuery, cn);
                    cmd.Parameters.AddWithValue("@CarTypeId", carDTO.CarTypeId);
                    cmd.Parameters.AddWithValue("@CarBrandId", carDTO.CarBrandId);
                    cmd.Parameters.AddWithValue("@CarModelId", carDTO.CarModelId);
                    cmd.Parameters.AddWithValue("@Base64Photo", 1);
                    cmd.Parameters.AddWithValue("@FuelTypeId", carDTO.FuelTypeId);
                    cmd.Parameters.AddWithValue("@CarStatus", 1);//carDTO.CarStatus
                    cmd.Parameters.AddWithValue("@QuantityOfFuel", carDTO.QuantityOfFuel);
                    cmd.Parameters.AddWithValue("@CarFabYear", carDTO.CarFabYear);
                    cmd.Parameters.AddWithValue("@CarChasisNum", carDTO.CarChasisNum);
                    cmd.Parameters.AddWithValue("@CarEngineNum", carDTO.CarEngineNum);
                    cmd.Parameters.AddWithValue("@CarLicensePlate", carDTO.CarLicensePlate);
                    cmd.Parameters.AddWithValue("@CarColor", carDTO.CarColor);
                    cmd.Parameters.AddWithValue("@CarNumberOfDoors", carDTO.CarNumberOfDoors);
                    cmd.Parameters.AddWithValue("@CarCapacityOfPassangers", carDTO.CarCapacityOfPassangers);
                    cmd.Parameters.AddWithValue("@CarConditions", carDTO.CarConditions);
                    cmd.Parameters.AddWithValue("@CarUseInKM", carDTO.CarUseInKM);
                    cmd.Parameters.AddWithValue("@CarInvComment", "Nueva adquicision");

                    cmd.ExecuteNonQuery();
                    //Save foto in base64 table and give the id to save on car info table...
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
        public List<CarDTO> SearchByCriteria(String criteria)
        {
            string sqlSearch = "select * from car_info where car_chassis_number like @criteria + '%' or car_engine_number like @criteria + '%' or car_license_plate like @criteria + '%' ";
            List<CarDTO> carDTOs = new List<CarDTO>();
            SqlDataReader reader;

            using (var cn = new SqlConnection("Server=DESKTOP-EOOHF5T;DataBase=CarRentSA;Integrated Security=true"))
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
            string sqlSearch = "select c.car_info_id, t.car_type_description, brand.car_brand_description, photo.car_b64_photo, fuel.fuel_type, s.general_status_description, c.quantity_of_fuel, c.car_fabrication_year, c.car_chassis_number, c.car_engine_number, c.car_license_plate, c.car_color, c.car_number_of_doors, c.car_acquisition_date, c.car_capacity_of_passangers, c.car_conditions, c.use_in_km  from car_info c left join car_type t on c.car_type_id = t.car_type_id left join car_brand brand on c.car_brand_id = brand.car_brand_id left join car_model model on c.car_model_id = model.car_brand_id left join car_b64_photo photo on c.car_b64_photo_id = photo.car_b64_photo_id left join type_of_fuel fuel on c.fuel_type_id = fuel.fuel_type_id left join general_status s on c.car_status = s.general_status_id";
            List<CarDTO> carDTOs = new List<CarDTO>();
            SqlDataReader reader;

            using (var cn = Conexion)
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

        public void EditCar()
        {

        }

        public void DeleteCar()
        {

        }

        public List<CarDTO> FillCarDTOList(SqlDataReader reader)
        {
            List<CarDTO> ListaGenerica = new List<CarDTO>();

            while (reader.Read())
            {
                ListaGenerica.Add(new CarDTO
                {
                    CarId = reader.GetInt32(0),
                    CarTypeId = reader.GetInt32(1),
                    CarBrandId = reader.GetInt32(2),
                    CarModelId = reader.GetInt32(3),
                    CarBase64Photo = 1, //can not be null reader.GetInt32(4)
                    FuelTypeId = reader.GetInt32(5),
                    CarStatus = reader.GetInt32(6),
                    QuantityOfFuel = reader.GetString(7),
                    CarFabYear = reader.GetInt32(8),
                    CarChasisNum = reader.GetString(9),
                    CarEngineNum = reader.GetString(10),
                    CarLicensePlate = reader.GetString(11),
                    CarColor = reader.GetString(12),
                    CarNumberOfDoors = reader.GetInt32(13),
                    CarCapacityOfPassangers = reader.GetInt32(15),
                    CarConditions = reader.GetString(16),
                    CarUseInKM = 122,//Convert.ToInt32(reader.GetString(17)), //problem casting type
                    CarInvComment = "hola"//reader.GetString(18)
                });
            }

            reader.Close();

            return ListaGenerica;
        }

        public DataTable GetDataForCB(int Query)
        {
            String CarTypeQuery = "select car_type_id as id, car_type_description as carType from car_type where car_type_status = 1";
            String CarBrandQuery = "select car_brand_id as id, car_brand_description as brand from car_brand where car_brand_status = 1";
            String TypeOfFuel = "select fuel_type_id as id, fuel_type as fuel from type_of_fuel where fuel_status = 1";
            String RunQuery = "";

            switch (Query)
            {
                case 1: RunQuery = CarTypeQuery; break;
                case 2: RunQuery = CarBrandQuery; break;
                case 3: RunQuery = TypeOfFuel; break;
            }

            using (var cn = new SqlConnection("Server=DESKTOP-EOOHF5T;DataBase=CarRentSA;Integrated Security=true"))
            {
                cn.Open();
                DataTable dt = new DataTable();

                try
                {
                    SqlCommand cmd = new SqlCommand(RunQuery, cn);
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
                return dt;
            }
        }

        public DataTable GetCarModelByBrand(String carBrandId)
        {
            String carModelByBrandQuery = "select car_model_id as id, car_model_description as modelo from car_model where car_brand_id = @carBrandId and car_model_status = 1";

            using (var cn = new SqlConnection("Server=DESKTOP-EOOHF5T;DataBase=CarRentSA;Integrated Security=true"))
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
    }

    class CarTypeCRUD : DBConnection
    {
        //Add

        //Get
        public void GetCartypes()
        {

        }
        //Edit

        //Delete

    }

    class CarBrandCRUD : DBConnection
    {
        //Add

        //Get
        public void GetCarBrands()
        {

        }

        //Edit

        //Delete
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
                using (var cn = new SqlConnection("Server=DESKTOP-EOOHF5T;DataBase=CarRentSA;Integrated Security=true"))
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

        //Get by
        public bool GetModelByDes(string modelDes) 
        {
            string query = "select * from car_model where car_model_description = '"+modelDes+"'";

            SqlDataReader reader;
            
            using (var cn = new SqlConnection("Server=DESKTOP-EOOHF5T;DataBase=CarRentSA;Integrated Security=true"))
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

            using (var cn = new SqlConnection("Server=DESKTOP-EOOHF5T;DataBase=CarRentSA;Integrated Security=true"))
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

        //Get
        public List<CarModelDTO> GetCarModels()
        {
            string query = "select m.car_model_id as id, m.car_model_description as model, b.car_brand_description as parentBrand, b.car_brand_id as parentBrandId, g.general_status_description as modelStatus from car_model m, car_brand b, general_status g where m.car_brand_id = b.car_brand_id and m.car_model_status = g.general_status_id";

            SqlDataReader reader;
            List<CarModelDTO> Lista = new List<CarModelDTO>();

            using (var cn = new SqlConnection("Server=DESKTOP-EOOHF5T;DataBase=CarRentSA;Integrated Security=true"))
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
            using (var cn = new SqlConnection("Server=DESKTOP-EOOHF5T;DataBase=CarRentSA;Integrated Security=true"))
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
            using (var cn = new SqlConnection("Server=DESKTOP-EOOHF5T;DataBase=CarRentSA;Integrated Security=true"))
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

    class CarFuelTypeCRUD : DBConnection
    {
        //Add

        //Get
        public void GetCarFuelType()
        {

        }

        //Edit

        //Delete

    }
}
