using rentCar.DAO;
using rentCar.DTO;
using rentCar.views.car;
using System;
using System.Windows.Forms;

namespace rentCar.views
{
    public partial class RentForm : Form
    {
        bool OnlyViewMode;
        
        string employee;
        int carId;
        string carInfo;
        string customerInfo;
        int inspectionId;
        int rentId;

        InspectionDAO dao = new InspectionDAO();

        private void devolutionMode(RentDTO dto) 
        {
            SaveRentBtn.Text = "Devolver";
            rentId = dto.Id;    
            employee = dto.CustomerInfo;
            carId = dto.CarId;
            carInfo = dto.CarInfo;
            customerInfo = dto.CustomerInfo;
            fechaDeRenta.Value = Convert.ToDateTime(dto.RentDate);
            fechaDevolucion.Value = Convert.ToDateTime(dto.DevolutionDate);
            costPerDay.Value = dto.MontPerDay;
            CatOfDays.Value = dto.QuantityOfDays;
            rentComment.Text = dto.Comment;
            inspectionId = dto.InspectionId;
            costPerDay.ReadOnly = true;
            CatOfDays.ReadOnly = true;
            rentComment.ReadOnly = true;
            fechaDeRenta.Enabled = false;
            fechaDevolucion.Enabled = false;
        }

        private void readOnlyMode() 
        {
            if (OnlyViewMode) 
            {
                costPerDay.ReadOnly = true;
                CatOfDays.ReadOnly = true;
                rentComment.ReadOnly = true;
                fechaDeRenta.Enabled = false;
                fechaDevolucion.Enabled = false;
            }
        }

        private RentDTO FillRentDto() {
            return new RentDTO {
                //id ?
                //state is 0 on the DAO... hardcoded!
                Id = rentId,
                InspectionId = inspectionId,
                EmployeeInfo = employee,
                CarId = carId,
                CarInfo = carInfo,
                CustomerInfo = customerInfo,
                RentDate = Convert.ToString(fechaDeRenta.Value),
                DevolutionDate = Convert.ToString(fechaDevolucion.Value),
                MontPerDay = Convert.ToInt32(costPerDay.Value),
                QuantityOfDays = Convert.ToInt32(CatOfDays.Value),
                Comment = rentComment.Text
            };
        }

        public RentForm()
        {
            InitializeComponent();
            OnlyViewMode = true;
            readOnlyMode();

            rentsDV.DataSource = dao.GetActiveRents();
        }

        public RentForm(InspectionDTO inspectionDto)
        {
            InitializeComponent();
            
            //Form
            OnlyViewMode = false; 
            CarTX.Text = inspectionDto.CarDetails;
            CustomerTX.Text = inspectionDto.CustomerDetails;
            SaveRentBtn.Text = "Procesar renta";

            //DTO params
            employee     = inspectionDto.Inspector;
            carId        = inspectionDto.CarId;
            carInfo      = inspectionDto.CarDetails;
            customerInfo = inspectionDto.CustomerDetails;
            inspectionId = inspectionDto.Id;

            rentsDV.DataSource = dao.GetActiveRents();
        }

        private void costPerDay_ValueChanged(object sender, System.EventArgs e)
        {
            int total = Convert.ToInt32(CatOfDays.Value) * Convert.ToInt32(costPerDay.Value);
            double totalFinal = total * 0.18f + total;
            totalTX.Text = "RD$ " + totalFinal.ToString("F2");
        }

        private void SaveRentBtn_Click(object sender, System.EventArgs e)
        {
            if (!OnlyViewMode)
            {
                if (SaveRentBtn.Text.Equals("Procesar renta"))
                {
                    //Process the rent
                    RentDTO dto = FillRentDto();
                    dao.ProcessRent(dto);

                    //Return to inspection container.
                    SaveRentBtn.DialogResult = DialogResult.OK;
                }

            } else if (SaveRentBtn.Text.Equals("Devolver")) 
            {
                RentDTO dto = FillRentDto();

                dao.DevolutionProcess(dto);
                rentsDV.DataSource = dao.GetActiveRents();
            }
            else
            {
                MessageBox.Show("Favor realizar una inspeccion primero. en este modo solo se pueden visualizar las rentas :D");
            }
        }

        private void rentsDV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var modelo = (RentDTO)rentsDV.Rows[e.RowIndex].DataBoundItem;

            if (modelo == null) return;

            
            ChooseAction2 chosee = new ChooseAction2("Desea devolver este vehiculo?", "Cancelar", "Si");
            
            DialogResult dr = chosee.ShowDialog();

            if (dr == DialogResult.OK)
            {
                devolutionMode(modelo);

                //refreshDataView("model");
            }
            else if (dr == DialogResult.Cancel) 
            {
                //Nothing...
            }
        }

        private void searchRentsTX_TextChanged(object sender, EventArgs e)
        {
            rentsDV.DataSource = dao.SearchRentBy(searchRentsTX.Text);
        }
    }
}
