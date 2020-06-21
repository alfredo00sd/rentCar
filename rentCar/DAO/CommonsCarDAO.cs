using RentCarApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace rentCar.DAO
{
    class CommonsCarDAO : DBConnection
    {

        //Get car type
        public List<CarTypeDTO> GetCartypes()
        {
            string query = "select t.car_type_id as id, t.car_type_description as carType, g.general_status_description from car_type t, general_status g where t.car_type_status = g.general_status_id";

            SqlDataReader reader;
            List<CarTypeDTO> Lista = new List<CarTypeDTO>();

            using (var cn = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Lista.Add(new CarTypeDTO
                        {
                            CarTypeId = reader.GetInt32(0),
                            CarTypeDescription = reader.GetString(1),
                            CarTypeStatus = reader.GetString(2)
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

        //Get car brand
        public List<CarBrandDTO> GetCarBrands()
        {
            string query = "select b.car_brand_id as id, car_brand_description as carBrand, g.general_status_description as brandStatus from car_brand b, general_status g where b.car_brand_status  = g.general_status_id";

            SqlDataReader reader;
            List<CarBrandDTO> Lista = new List<CarBrandDTO>();

            using (var cn = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Lista.Add(new CarBrandDTO
                        {
                            BrandId = reader.GetInt32(0),
                            BrandDescription = reader.GetString(1),
                            BrandStatus = reader.GetString(2)
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

        //Get car fuel type
        public List<CarFuelTypeDTO> GetCarFuelType()
        {
            string query = "select f.car_fuelType_id as id, f.car_fuelType_description fuelType, g.general_status_description as fuelStatus from car_fuelType f, general_status g where f.car_fuelType_status = g.general_status_id";

            SqlDataReader reader;
            List<CarFuelTypeDTO> Lista = new List<CarFuelTypeDTO>();

            using (var cn = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Lista.Add(new CarFuelTypeDTO
                        {
                            FuelTypeId = reader.GetInt32(0),
                            FuelType = reader.GetString(1),
                            FuelStatus = reader.GetString(2)
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

        //--------------------------------------------------------------------Generics

        //Get for
        public DataTable GetDataForCB(int Query)
        {
            String CarTypeQuery  = "select car_type_id     as id, car_type_description     as carType from car_type     where car_type_status     = 14";
            String CarBrandQuery = "select car_brand_id    as id, car_brand_description    as brand   from car_brand    where car_brand_status    = 14";
            String TypeOfFuel    = "select car_fuelType_id as id, car_fuelType_description as fuel    from car_fuelType where car_fuelType_status = 14";
            String RunQuery = "";

            switch (Query)
            {
                case 1: RunQuery = CarTypeQuery; break;
                case 2: RunQuery = CarBrandQuery; break;
                case 3: RunQuery = TypeOfFuel; break;
            }

            using (var cn = new SqlConnection(CONNECTION_STRING))
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

        //Gets by
        public bool GetByDescription(string description, string table)
        {
            string query = "select * from car_"+table+" where car_"+table+"_description = '" + description + "'";

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

        //Add
        public string Add(string description, string table)
        {
            string sqlInsert = table.Equals("fuelType") ? "insert into car_fuelType values (@description, 14)" : "insert into car_" +table+" values (14, @description)";

            //Validate duplicates
            if (GetByDescription(description, table))
            {
                return "Esta descripcion " + description + " ya existe en este mantenimiento.";
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
                        cmd.Parameters.AddWithValue("@description", description);
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
                    return "Elemento agregado!";
                }
            }
        }

        //Edit
        public bool Edit(string id, string description, string status, string table)
        {
            using (var cn = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("update car_" + table +  " set car_" + table + "_status = @status, car_" + table + "_description = @description where car_" + table + "_id = @id", cn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@status", status.Equals("Activo") ? 14 : 15);

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
        public bool Delete(string id, string table)
        {
            using (var cn = new SqlConnection(CONNECTION_STRING))
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("delete from car_" + table + " where car_" + table + "_id = @id ", cn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@table", table);
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

        //--------------------------------------------------------------------Generics
    }
}
