using rentCar.DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace rentCar.DAO
{
    class InspectionDAO
    {
        //Filds
        private DBConnection conexion = new DBConnection();
        SqlDataReader reader;
        readonly SqlCommand cmd = new SqlCommand();
        List<InspectionDTO> dtoList;

        private void FillRentParams(SqlCommand cmd, RentDTO dto)
        {
            cmd.Parameters.AddWithValue("@id", dto.Id);
            cmd.Parameters.AddWithValue("@employeeInfo", dto.EmployeeInfo);
            cmd.Parameters.AddWithValue("@inspectionId", dto.InspectionId);
            cmd.Parameters.AddWithValue("@carId", dto.CarId);
            cmd.Parameters.AddWithValue("@carInfo", dto.CarInfo);
            cmd.Parameters.AddWithValue("@customerInfo", dto.CustomerInfo);
            cmd.Parameters.AddWithValue("@rent_date", dto.RentDate);
            cmd.Parameters.AddWithValue("@devolution_date", dto.DevolutionDate);
            cmd.Parameters.AddWithValue("@mont_x_day", dto.MontPerDay);
            cmd.Parameters.AddWithValue("@quantity_of_days", dto.QuantityOfDays);
            cmd.Parameters.AddWithValue("@comment", dto.Comment);
            cmd.Parameters.AddWithValue("@status", 1);     
        }

        public List<RentDTO> GetActiveRents() 
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select * from rents where state = 1";
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();

            List<RentDTO> ListaGenerica = new List<RentDTO>();

            while (reader.Read())
            {
                ListaGenerica.Add(new RentDTO
                {
                    Id = reader.GetInt32(0),
                    InspectionId = reader.GetInt32(1),
                    EmployeeInfo = reader.GetString(2),
                    CarId = reader.GetInt32(3), //can not be null reader.GetInt32(4)
                    CarInfo = reader.GetString(4),
                    CustomerInfo = reader.GetString(5),
                    RentDate = reader.GetString(6),
                    DevolutionDate = reader.GetString(7),
                    MontPerDay = reader.GetInt32(8),
                    QuantityOfDays = reader.GetInt32(9),
                    Comment = reader.GetString(10),//reader.GetString(18)
                    State = (bool)reader["state"]
                });
            }

            conexion.CerrarConexion();
            reader.Close();

            return ListaGenerica;
        }
        //ADD
        public void ProcessRent(RentDTO dto) 
        {
            if (checkRecord("rents", dto.Id, 1))
            {
                MessageBox.Show("Este registro ya esta en el sistema, operacion invalida!", "Warn");
            }
            else 
            {
                //Save the rent 
                //Set rent status to 0.
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "insert into rents values (@inspectionId, @employeeInfo, @carId, @carInfo, @customerInfo, @rent_date, @devolution_date, @mont_x_day, @quantity_of_days, @comment, @status)";
                cmd.CommandType = CommandType.Text;

                FillRentParams(cmd, dto);

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                conexion.CerrarConexion();

                //set inspection status to 0.
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "update inspection set state = 0 where id = " + dto.InspectionId + "";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                conexion.CerrarConexion();

                //Set car status to 0.
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "update carInfo set status = 0 where id = " + dto.CarId + "";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                conexion.CerrarConexion();
            }
        }

        public void DevolutionProcess(RentDTO dto) 
        {
            if (checkRecord("rents", dto.Id, 0))
            {
                MessageBox.Show("Este registro ya fue devuelto en el sistema, operacion invalida!", "Warn");
            }
            else
            {
                //update rent
                //set rent status to 1.
                //add inspection comment as devolucion
                //update devolution date
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "update rents set state = 0, comment = 'Comentario de devolucion : " + dto.Comment + "', devolution_date = '" + dto.DevolutionDate + "' where id = " + dto.Id + " ";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                conexion.CerrarConexion();

                //set inspection status to 1.
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "update inspection set state = 1 where id = " + dto.InspectionId + "";//
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                conexion.CerrarConexion();

                //Set car status to 1.
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "update carInfo set status = 1 where id = " + dto.CarId + "";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                conexion.CerrarConexion();
            }
        }

        public List<RentDTO> GetRentsRepo() 
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select * from rents";
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();

            List<RentDTO> ListaGenerica = new List<RentDTO>();

            while (reader.Read())
            {
                ListaGenerica.Add(new RentDTO
                {
                    Id = reader.GetInt32(0),
                    InspectionId = reader.GetInt32(1),
                    EmployeeInfo = reader.GetString(2),
                    CarId = reader.GetInt32(3), //can not be null reader.GetInt32(4)
                    CarInfo = reader.GetString(4),
                    CustomerInfo = reader.GetString(5),
                    RentDate = reader.GetString(6),
                    DevolutionDate = reader.GetString(7),
                    MontPerDay = reader.GetInt32(8),
                    QuantityOfDays = reader.GetInt32(9),
                    Comment = reader.GetString(10),//reader.GetString(18)
                    State = (bool)reader["state"]
                });
            }

            conexion.CerrarConexion();
            reader.Close();

            return ListaGenerica;
        }

        //Utils
        public List<RentDTO> SearchRentBy(string criteria)
        { //Cliente, carro, fecha
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select * from rents where customerInfo like '%" + criteria + "%' or carInfo like '%" + criteria + "%' or rent_date like '%" + criteria + "%' and state = 1";
            cmd.CommandType = CommandType.Text;

            reader = cmd.ExecuteReader();

            List<RentDTO> ListaGenerica = new List<RentDTO>();

            while (reader.Read())
            {
                ListaGenerica.Add(new RentDTO
                {
                    Id = reader.GetInt32(0),
                    InspectionId = reader.GetInt32(1),
                    EmployeeInfo = reader.GetString(2),
                    CarId = reader.GetInt32(3), //can not be null reader.GetInt32(4)
                    CarInfo = reader.GetString(4),
                    CustomerInfo = reader.GetString(5),
                    RentDate = reader.GetString(6),
                    DevolutionDate = reader.GetString(7),
                    MontPerDay = reader.GetInt32(8),
                    QuantityOfDays = reader.GetInt32(9),
                    Comment = reader.GetString(10),//reader.GetString(18)
                    State = (bool)reader["state"]
                });
            }

            conexion.CerrarConexion();
            reader.Close();

            return ListaGenerica;
        }

        private bool checkRecord(string table, int id, byte status) {

            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select * from " + table + " where id = " + id + " and state = " + status + "";
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

        //-----------------------------------------------------------------------Inspection

        private void FillDtoParams(SqlCommand cmd, InspectionDTO dto)
        {
            cmd.Parameters.AddWithValue("@Id", dto.Id);
            cmd.Parameters.AddWithValue("@CarId", dto.CarId);
            cmd.Parameters.AddWithValue("@CarDetails", dto.CarDetails);
            cmd.Parameters.AddWithValue("@CustomerId", dto.CustomerId);
            cmd.Parameters.AddWithValue("@CustomerDetails", dto.CustomerDetails);
            cmd.Parameters.AddWithValue("@QuantityOfFuel", dto.QuantityOfFuel);
            cmd.Parameters.AddWithValue("@HasRefaction", dto.HasRefaction ? 1 : 0);
            cmd.Parameters.AddWithValue("@HasScratches", dto.HasScratches ? 1 : 0);
            cmd.Parameters.AddWithValue("@HasCat", dto.HasCat ? 1 : 0);
            cmd.Parameters.AddWithValue("@Wheel1", dto.Wheel1Check ? 1: 0);
            cmd.Parameters.AddWithValue("@Wheel2", dto.Wheel2Check ? 1 : 0);
            cmd.Parameters.AddWithValue("@Wheel3", dto.Wheel3Check ? 1 : 0);
            cmd.Parameters.AddWithValue("@Wheel4", dto.Wheel4Check ? 1 : 0);
            cmd.Parameters.AddWithValue("@DateOfInspection", dto.DateOfInspection);
            cmd.Parameters.AddWithValue("@InspectorId", dto.InspectorId);
            cmd.Parameters.AddWithValue("@Inspector", dto.Inspector);
            cmd.Parameters.AddWithValue("@Comment", dto.Comment);
            cmd.Parameters.AddWithValue("@Status", dto.State);
        }

        public List<InspectionDTO> FillDTOList(SqlDataReader reader)
        {
            List<InspectionDTO> ListaGenerica = new List<InspectionDTO>();

            while (reader.Read())
            {
                ListaGenerica.Add(new InspectionDTO
                {
                    Id = reader.GetInt32(0),
                    CarId = reader.GetInt32(1), //can not be null reader.GetInt32(4)
                    CarDetails = reader.GetString(2),
                    CustomerId = reader.GetInt32(3),
                    CustomerDetails = reader.GetString(4), // not null
                    QuantityOfFuel = reader.GetString(5),
                    HasRefaction = (bool)reader["has_refaction"],
                    HasScratches = (bool)reader["has_scratches"],
                    HasCat = (bool)reader["has_cat"],
                    Wheel1Check = (bool)reader["wheel_1_check"],
                    Wheel2Check = (bool)reader["wheel_2_check"], //Not null
                    Wheel3Check = (bool)reader["wheel_3_check"],
                    Wheel4Check = (bool)reader["wheel_4_check"],
                    DateOfInspection = reader.GetString(13),
                    InspectorId = reader.GetInt32(14),
                    Inspector = reader.GetString(15),//Convert.ToInt32(reader.GetString(17)), //problem casting type
                    Comment = reader.GetString(16),//reader.GetString(18)
                    State = (bool)reader["state"]
                });
            }
            return ListaGenerica;
        }


        //ADD
        public void ADD(InspectionDTO dto)
        {
            if (checkRecord("inspection", dto.Id, 1))
            {
                MessageBox.Show("ERROR : No se acepta duplicidad de registros en el sistema!!", "Warn");
            }
            else
            {
                //if (GetRecordById(dto.Id))
                //{
                //    MessageBox.Show("ERROR : No se acepta duplicidad de registros en el sistema!");
                //}
                //else
                //{
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "insert into inspection values (@CarId, @CarDetails, @CustomerId, @CustomerDetails, @QuantityOfFuel, @HasRefaction, @HasScratches, @HasCat, @Wheel1, @Wheel2, @Wheel3, @Wheel4, @DateOfInspection,  @InspectorId, @Inspector, @Comment, @Status)";
                cmd.CommandType = CommandType.Text;

                FillDtoParams(cmd, dto);

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                conexion.CerrarConexion();
            }
        }

        //Gets
        public List<InspectionDTO> GETALL()
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "select * from inspection where state = 1";
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();

            dtoList = FillDTOList(reader);

            conexion.CerrarConexion();
            reader.Close();

            return dtoList;
        }

        //EDIT
        public void EDIT(InspectionDTO dto)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "update inspection set car_id = @CarId, car_details = @CarDetails, customer_id = @CustomerId, customer_details = @CustomerDetails, quantity_of_fuel = @QuantityOfFuel, has_refaction = @HasRefaction, has_scratches = @HasScratches, has_cat = @HasCat, wheel_1_check = @Wheel1, wheel_2_check = @Wheel2, wheel_3_check = @Wheel3, wheel_4_check = @Wheel4, inspector_id = @InspectorId, inspector = @Inspector, comment = @Comment where id = @Id";
            cmd.CommandType = CommandType.Text;

            FillDtoParams(cmd, dto);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }

        //DELETE
        public void DELETE(int id)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "delete from inspection where id = @id ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }
        //Search
    }
}
