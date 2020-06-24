using rentCar.DAO;
using rentCar.views.car.type;
using RentCarApp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Windows.Forms;

namespace rentCar.views.car
{
    public partial class CarMantView : Form
    {
        private CommonsCarDAO dao = new CommonsCarDAO();
        private CarDAO carDao = new CarDAO();
        private CarModelCRUD modelCRUD = new CarModelCRUD();
        private int carId;

        public CarMantView()
        {
            InitializeComponent();
            
            ResetCarForm();
        }

        //-----------------------------------------------------------Loads
        private void loadCarDVData() 
        {
            carDV.DataSource = carDao.GETALL();
            carDV.Columns[0].HeaderText = "#";
            carDV.Columns[0].Width = 60;

            carDV.Columns[1].HeaderText = "Foto";
            carDV.Columns[2].HeaderText = "Tipo de carro";
            carDV.Columns[3].HeaderText = "Marca";
            carDV.Columns[4].HeaderText = "Modelo";
            carDV.Columns[5].HeaderText = "Año";
            carDV.Columns[6].HeaderText = "No. Chasis";
            carDV.Columns[7].HeaderText = "No. Motor";
            carDV.Columns[8].HeaderText = "No. Placa";
            carDV.Columns[9].HeaderText = "Color";
            //dgv.DefaultCellStyle.BackColor = Color.FromArgb(193, 199, 232);
            carDV.Columns[10].HeaderText = "Tipo de combustible";
            carDV.Columns[11].HeaderText = "Nivel combustible";
            carDV.Columns[12].HeaderText = "Cant. Puertas";
            carDV.Columns[13].HeaderText = "Cant.  Pasajeros";
            carDV.Columns[14].HeaderText = "Condicion";
            carDV.Columns[15].HeaderText = "Uso en KM";
            carDV.Columns[16].HeaderText = "Comentario";
            carDV.Columns[17].HeaderText = "Estado";
            carDV.Columns[18].HeaderText = "Ingresado el";

            List<CarDTO> dtos = new List<CarDTO>();
            //Do loop here...
            dtos.Add((CarDTO)carDV.Rows[0].DataBoundItem);
            
            string color = dtos[0].Color.Trim().ToLower();
            
            carDV.Columns[9].DefaultCellStyle.BackColor = Color.FromName(color);
            carDV.Columns[9].DefaultCellStyle.ForeColor = Color.FromName(color);

            //carDV.Columns[9].DefaultCellStyle.BackColor = Color.FromName("yellow");
        }
        //-----------------------------------------------------------Loads


        //-----------------------------------------------------------Fill combo boxes

        private void CarBrandCB_Leaves(object sender, System.EventArgs e)
        {
            CarBrandCB.ValueMember = "BrandId";

            if (IsNumeric(CarBrandCB.SelectedValue))
            {
                CarModelCB.DataSource = modelCRUD.GetCarModelByBrand(Convert.ToInt32(CarBrandCB.SelectedValue));
                CarModelCB.ValueMember = "ModelDescription";
                CarModelCB.DisplayMember = "ModelDescription";
            }
        }

        private void FillCarTypeCB() 
        {
            CarTypeCB.DropDownStyle = ComboBoxStyle.DropDownList;
            CarTypeCB.DataSource = dao.GetCartypes();
            CarTypeCB.ValueMember = "CarTypeDescription";
            CarTypeCB.DisplayMember = "CarTypeDescription";
        }

        private void FillCarBrandCB()
        {
            CarBrandCB.DropDownStyle = ComboBoxStyle.DropDownList;
            CarBrandCB.DataSource = dao.GetCarBrands();
            CarBrandCB.ValueMember = "BrandDescription";
            CarBrandCB.DisplayMember = "BrandDescription";
        }

        private void FillFuelTypeCB()
        {
            FuelTypeCB.DropDownStyle = ComboBoxStyle.DropDownList;
            FuelTypeCB.DataSource = dao.GetCarFuelType();
            FuelTypeCB.ValueMember = "FuelType";
            FuelTypeCB.DisplayMember = "FuelType";
        }

        //-----------------------------------------------------------Fill combo boxes

        //-----------------------------------------------------------Util methods        

        private void ResetCarForm() 
        {
            FillCarTypeCB();
            FillCarBrandCB();
            FillFuelTypeCB();
            loadCarDVData();

            viewTitle.Text = "Mantenimiento de vehiculos";
            SaveCarBtn.Text = "Agregar nuevo";

            placaInput.Text = "";
            chasisNoInput.Text = "";
            motorNoInput.Text = "";
            CarFabYearCB.SelectedItem = "";
            cantPuertas.SelectedItem = "";
            cantPasajeros.SelectedItem = "";
            CarCondition.SelectedItem = "";
            commentBox.Text = "";
            useInKm.Value = 0;
            colorContainer.BackColor = Color.FromName("white");//Try to use the dto value...
            carStatsCheck.Checked = true;
        }

        private bool IsNumeric(object Expression)
        {
            bool isNum;
            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out _);
            return isNum;
        }

        private void colorPicker_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorDialog1.FullOpen = true;

                colorContainer.BackColor = colorDialog1.Color;
            }
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para editar o borrar un vehiculo puedes hacer doble clic sobre el record que quieres editar o borrar. ");
        }

        private CarDTO FillUpCarDto()
        {
            return new CarDTO
            {
                Id = carId,
                PhotoPath = "path/to/photo",
                Type = Convert.ToString(CarTypeCB.SelectedValue),
                Brand = Convert.ToString(CarBrandCB.SelectedValue),
                Model = Convert.ToString(CarModelCB.SelectedValue),
                FuelType = Convert.ToString(FuelTypeCB.SelectedValue),
                QuantityOfFuel = "Lleno", //asumed is full as was recented adcquiered
                LicensePlate = placaInput.Text,
                ChasisNum = chasisNoInput.Text,
                EngineNum = motorNoInput.Text,
                FabYear = Convert.ToInt32(CarFabYearCB.SelectedItem),
                NumberOfDoors = Convert.ToInt32(cantPuertas.SelectedItem),
                CapacityOfPassangers = Convert.ToInt32(cantPasajeros.SelectedItem),
                Conditions = Convert.ToString(CarCondition.SelectedItem),
                UseInKM = Convert.ToInt32(useInKm.Value),
                Color = Convert.ToString(colorContainer.BackColor),
                Comment = commentBox.Text,
                Status = carStatsCheck.Checked
            }; 
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            ResetCarForm();
        }

        //-----------------------------------------------------------Util methods

        //-----------------------------------------------------------Save action

        private void SaveCarBtn_Click(object sender, EventArgs e)
        {
            CarBrandCB.ValueMember = "BrandDescription";//necesary to catpure car brand description and not the id.

            CarDTO Car = FillUpCarDto();
                
            ValidationContext validation = new ValidationContext(Car, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(Car, validation, errors, true))
            {
                foreach (ValidationResult result in errors)
                    MessageBox.Show(result.ErrorMessage);
            }
            else
            {//MessageBox.Show("type " + Car.CarTypeId + " modelo " + Car.CarModelId + " marca " + Car.CarBrandId + " combustible " + Car.FuelTypeId + " puertas " + Car.CarNumberOfDoors + " pasajeros " + Car.CarCapacityOfPassangers);

                if (SaveCarBtn.Text.Equals("Editar record"))
                {
                    carDao.EDIT(Car);
                    MessageBox.Show("SUCCESS : vehiculo editado correctamente!");
                    ResetCarForm();
                }
                else if (SaveCarBtn.Text.Equals("Agregar nuevo")) {
                    
                    carDao.ADD(Car);
                    MessageBox.Show("SUCCESS : vehiculo agregado correctamente!");
                    ResetCarForm();
                }
                else
                {
                    MessageBox.Show("ERROR : probleamas al ejecutar la operacion.");
                }
            }
        }

        //-----------------------------------------------------------Save action

        //---------------------------------------------------------------------------------Search action

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            viewTitle.Text = "Buscando Carro...";

            if (!textBox1.Text.Equals("") || textBox1.Text != null)
                carDV.DataSource = carDao.SearchByCriteria(textBox1.Text);
        }

        //---------------------------------------------------------------------------------Search action


        //------------------------------------------------------------------------------Edit or Delete Car events
        private void carDV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dto = (CarDTO) carDV.Rows[e.RowIndex].DataBoundItem;

            if (dto == null) return;

            //new GeneralCrud(dto.CarTypeId, dto.CarTypeDescription, dto.CarTypeStatus, "type");

            ChooseAction2 confirmAction = new ChooseAction2();

            DialogResult dr = confirmAction.ShowDialog();

            if (dr == DialogResult.OK)
            {
                //Prepare the form to edit record
                carId = dto.Id;
                EditMode(dto);
            }
            else if (dr == DialogResult.Cancel)
            {
                ConfirmAction confirm = new ConfirmAction();

                DialogResult result = confirm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ///Delete the record
                    carDao.DELETE(dto.Id);
                    MessageBox.Show("Elemento borrado!");
                    ResetCarForm();
                }
            }
        }

        //------------------------------------------------------------------------------Edit or Delete Car events

        //------------------------------------------------------------------------------Fill the form to edit the data
        private void EditMode(CarDTO dto) 
        {
            viewTitle.Text = "Edicion de registro";
            SaveCarBtn.Text = "Editar record";
         
            CarTypeCB.SelectedIndex  = CarTypeCB.FindStringExact(dto.Type); //dto.CarTypeId;
            CarBrandCB.SelectedIndex = CarBrandCB.FindStringExact(dto.Brand);
            CarModelCB.SelectedIndex = CarModelCB.FindStringExact(dto.Model);
            FuelTypeCB.SelectedIndex = FuelTypeCB.FindStringExact(dto.FuelType);
            placaInput.Text = dto.LicensePlate;
            chasisNoInput.Text = dto.ChasisNum;
            motorNoInput.Text = dto.EngineNum;
            CarFabYearCB.SelectedItem   = "" + dto.FabYear;
            cantPuertas.SelectedItem    = "" + dto.NumberOfDoors;
            cantPasajeros.SelectedItem  = "" + dto.CapacityOfPassangers;
            CarCondition.SelectedItem   = "" + dto.Conditions;
            commentBox.Text = dto.Comment;
            useInKm.Value = dto.UseInKM;
            colorContainer.BackColor = Color.FromName("red");//Try to use the dto value...
            carStatsCheck.Checked = dto.Status;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            viewTitle.Text = "Mantenimiento de vehiculos";
        }
        //------------------------------------------------------------------------------Fill the form to edit the data
    }
}
