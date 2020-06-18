using rentCar.DAO;
using RentCarApp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace rentCar.views.car
{
    public partial class AddCarView : Form
    {
        CarDao dao = new CarDao();

        public AddCarView()
        {
            InitializeComponent();
            //ComboBox.DropDownStyle property to ComboBoxStyle.DropDownList.

            FillCarTypeCB();
            FillCarBrandCB();
            FillFuelTypeCB();
        }

        private void FillCarTypeCB() 
        {
            CarTypeCB.DropDownStyle = ComboBoxStyle.DropDownList;
            CarTypeCB.DataSource = dao.GetDataForCB(1);
            CarTypeCB.ValueMember = "id";
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

        private void CarBrandCB_Leaves(object sender, System.EventArgs e) 
        {
            if (IsNumeric(CarBrandCB.SelectedValue)) 
            {
                CarModelCB.DataSource = dao.GetCarModelByBrand(""+CarBrandCB.SelectedValue);
                CarModelCB.ValueMember = "id";
                CarModelCB.DisplayMember = "modelo";
            }
        }

        private void FillFuelTypeCB()
        {
            FuelTypeCB.DropDownStyle = ComboBoxStyle.DropDownList;
            FuelTypeCB.DataSource = dao.GetDataForCB(3);
            FuelTypeCB.ValueMember = "id";
            FuelTypeCB.DisplayMember = "fuel";
        }

        private bool IsNumeric(object Expression)
        {
            bool isNum;
            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out _);
            return isNum;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorDialog1.FullOpen = true;

                colorContainer.BackColor = colorDialog1.Color;
            }
        }

        private void SaveCarBtn_Click(object sender, EventArgs e)
        {
            
            CarDTO Car = new CarDTO
            {
                CarTypeId               = Convert.ToInt32(CarTypeCB.SelectedValue),
                CarBrandId              = Convert.ToInt32(CarBrandCB.SelectedValue),
                CarModelId              = Convert.ToInt32(CarModelCB.SelectedValue),
                FuelTypeId              = Convert.ToInt32(FuelTypeCB.SelectedValue),
                QuantityOfFuel          = "Lleno",//asumed is full as was recented adcquiered
                CarLicensePlate         = placaInput.Text,
                CarChasisNum            = chasisNoInput.Text,
                CarEngineNum            = motorNoInput.Text,
                CarFabYear              = Convert.ToInt32(CarFabYearCB.SelectedItem),
                CarNumberOfDoors        = Convert.ToInt32(cantPuertas.SelectedItem),
                CarCapacityOfPassangers = Convert.ToInt32(cantPasajeros.SelectedItem),
                CarConditions           = Convert.ToString(CarCondition.SelectedItem),
                CarUseInKM              = Convert.ToInt32(Math.Round(useInKm.Value, 0)),
                CarColor                = Convert.ToString(colorContainer.BackColor)
            };
                //Car.CarBase64Photo = CarPhoto.ToString;
    
            ValidationContext validation = new ValidationContext(Car, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(Car, validation, errors, true))
            {
                foreach (ValidationResult result in errors)
                    MessageBox.Show(result.ErrorMessage);
            }
            else
            {
                //MessageBox.Show("type " + Car.CarTypeId + " modelo " + Car.CarModelId + " marca " + Car.CarBrandId + " combustible " + Car.FuelTypeId + " puertas " + Car.CarNumberOfDoors + " pasajeros " + Car.CarCapacityOfPassangers);

                //MessageBox.Show("Correcto...");

                if (dao.SaveCar(Car))
                {

                    MessageBox.Show("SUCCESS : vehiculo agregado correctamente!");

                    AddCarView NewForm = new AddCarView();
                    NewForm.Show();
                    this.Dispose(false);
                }
                else 
                {
                    MessageBox.Show("ERROR : agregando vehiculo");
                }
            }
        }

        public void ResetView() 
        {
        
        }

        private void editCarBtn_Click(object sender, EventArgs e)
        {
            viewTitle.Text = "Editar Carro";

        }

        private void searchCarBtn_Click(object sender, EventArgs e)
        {
            viewTitle.Text = "Buscar Carro";

        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            viewTitle.Text = "Agregar Carro";

        }

        private void deleteCarBtn_Click(object sender, EventArgs e)
        {
            viewTitle.Text = "Remover Carro";
        }
    }
}
