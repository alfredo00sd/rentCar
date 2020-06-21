using rentCar.DAO;
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
        CommonsCarDAO dao = new CommonsCarDAO();
        CarDao carDao = new CarDao();
        CarModelCRUD modelCRUD = new CarModelCRUD();

        public CarMantView()
        {
            InitializeComponent();
            //ComboBox.DropDownStyle property to ComboBoxStyle.DropDownList.

            FillCarTypeCB();
            FillCarBrandCB();
            FillFuelTypeCB();
            loadCarDVData();
        }

        //-----------------------------------------------------------Loads
        private void loadCarDVData() 
        {
            carDV.DataSource = carDao.GetAllCars();
            carDV.Columns[9].HeaderText = "Color";

            //var dto = (CarDTO) carDV.Rows[2].DataBoundItem;

            //MessageBox.Show();

            carDV.Columns[9].DefaultCellStyle.BackColor = Color.FromName("black");

        }
        //-----------------------------------------------------------Loads


        //-----------------------------------------------------------Fill combo boxes

        private void CarBrandCB_Leaves(object sender, System.EventArgs e)
        {
            if (IsNumeric(CarBrandCB.SelectedValue))
            {
                CarModelCB.DataSource = modelCRUD.GetCarModelByBrand("" + CarBrandCB.SelectedValue);
                CarModelCB.ValueMember = "modelo";
                CarModelCB.DisplayMember = "modelo";
            }
        }

        private void FillCarTypeCB() 
        {
            CarTypeCB.DropDownStyle = ComboBoxStyle.DropDownList;
            CarTypeCB.DataSource = dao.GetDataForCB(1);
            CarTypeCB.ValueMember = "carType";
            CarTypeCB.DisplayMember = "carType";
        }

        private void FillCarBrandCB()
        {
            CarBrandCB.DropDownStyle = ComboBoxStyle.DropDownList;
            CarBrandCB.DataSource = dao.GetDataForCB(2);
            CarBrandCB.ValueMember = "id";
            CarBrandCB.DisplayMember = "brand";

            CarModelCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FillFuelTypeCB()
        {
            FuelTypeCB.DropDownStyle = ComboBoxStyle.DropDownList;
            FuelTypeCB.DataSource = dao.GetDataForCB(3);
            FuelTypeCB.ValueMember = "fuel";
            FuelTypeCB.DisplayMember = "fuel";
        }

        //-----------------------------------------------------------Fill combo boxes

        //-----------------------------------------------------------Util methods        

        private void ResetCarForm() 
        {
            CarMantView NewForm = new CarMantView();
            NewForm.Show();
            this.Dispose(false);
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
        {//Car.CarBase64Photo = CarPhoto.ToString;
            return new CarDTO
            {
                CarType = "" + CarTypeCB.SelectedValue,
                CarBrand = "" + CarBrandCB.SelectedValue,
                CarModel = "" + CarModelCB.SelectedValue,
                FuelType = "" + FuelTypeCB.SelectedValue,
                QuantityOfFuel = "Lleno", //asumed is full as was recented adcquiered
                CarLicensePlate = placaInput.Text,
                CarChasisNum = chasisNoInput.Text,
                CarEngineNum = motorNoInput.Text,
                CarFabYear = Convert.ToInt32(CarFabYearCB.SelectedItem),
                CarNumberOfDoors = Convert.ToInt32(cantPuertas.SelectedItem),
                CarCapacityOfPassangers = Convert.ToInt32(cantPasajeros.SelectedItem),
                CarConditions = Convert.ToString(CarCondition.SelectedItem),
                CarUseInKM = Math.Round(useInKm.Value, 0) + "",
                CarColor = Convert.ToString(colorContainer.BackColor),
                CarInvComment = commentBox.Text
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
            CarBrandCB.ValueMember = "brand";//necesary to catpure car brand description and not the id.

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

                if (SaveCarBtn.Text.Equals("Editar record") && carDao.EditCar(Car))
                {
                    MessageBox.Show("SUCCESS : vehiculo editado correctamente!");
                    ResetCarForm();
                }
                else if (SaveCarBtn.Text.Equals("Agregar nuevo") && carDao.SaveCar(Car)) {
                    
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

            ConfirmAction confirmAction = new ConfirmAction();

            DialogResult dr = confirmAction.ShowDialog();

            if (dr == DialogResult.OK)
            {
                //Prepare the form to edit record
                EditMode(dto);
            }
            else if (dr == DialogResult.Cancel) 
            {
                ///Delete the record
                if (carDao.DeleteCar(dto.CarId))
                {
                    MessageBox.Show("Elemento borrado!");
                    ResetCarForm();
                }
                else 
                {
                    MessageBox.Show("Inconvenientes al intentar borrar este record.");
                }
            }

        }

        //------------------------------------------------------------------------------Edit or Delete Car events

        //------------------------------------------------------------------------------Fill the form to edit the data
        private void EditMode(CarDTO dto) 
        {
            viewTitle.Text = "Editar";
            SaveCarBtn.Text = "Editar record";
         
            CarTypeCB.SelectedIndex  = CarTypeCB.FindStringExact(dto.CarType); //dto.CarTypeId;
            CarBrandCB.SelectedIndex = CarBrandCB.FindStringExact(dto.CarBrand);
            CarModelCB.SelectedIndex = CarModelCB.FindStringExact(dto.CarModel);
            FuelTypeCB.SelectedIndex = FuelTypeCB.FindStringExact(dto.FuelType);
            //QuantityOfFuel = "Lleno",//asumed is full as was recented adcquiered
            placaInput.Text = dto.CarLicensePlate;
            chasisNoInput.Text = dto.CarChasisNum;
            motorNoInput.Text = dto.CarEngineNum;
            CarFabYearCB.SelectedItem   = "" + dto.CarFabYear;
            cantPuertas.SelectedItem    = "" + dto.CarNumberOfDoors;
            cantPasajeros.SelectedItem  = "" + dto.CarCapacityOfPassangers;
            CarCondition.SelectedItem   = "" + dto.CarConditions;
            commentBox.Text = dto.CarInvComment;
            useInKm.Value = Convert.ToInt32(dto.CarUseInKM.Replace(",", "").Replace("Km", "").Trim());
            colorContainer.BackColor = Color.FromName("red");//Try to use the dto value...
        }
        //------------------------------------------------------------------------------Fill the form to edit the data
    }
}
