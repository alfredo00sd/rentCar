using rentCar.DAO;
using rentCar.DTO;
using rentCar.views.car.type;
using rentCar.views.users;
using System;
using System.Windows.Forms;

namespace rentCar.views
{
    public partial class InspectionForm : Form
    {
        InspectionDAO dao = new InspectionDAO();
        CarDAO carDAO = new CarDAO();
        CustomerDAO customerDAO = new CustomerDAO();

        DateTime today = DateTime.Today;
        private int inspectionId;

        public InspectionForm()
        {
            InitializeComponent();

            formTile.Text = "Formulario de inspeccion";

            //Load inspection table data
            inspectionsDV.DataSource = dao.GETALL();

            //Load car data
            CarCB.DataSource = carDAO.GETALL();//Id
            CarCB.ValueMember = "FullCarDescription";
            CarCB.DisplayMember = "FullCarDescription";

            //Load customer data
            CustomerCB.DataSource = customerDAO.GETALL();//Id
            CustomerCB.ValueMember = "FullCustomerDescription";
            CustomerCB.DisplayMember = "FullCustomerDescription";
        }

        private void heplBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para realizar una renta, tras la inspeccion hacer doble clic sobre el registro de la inspeccion realizada y completar el formulario");
        }



        //Fills
        private void FillForm(InspectionDTO dto)
        {
            formTile.Text = "Formulario de edicion";
            SaveInspectionBtn.Text = "Editar inspeccion";
          
            inspectionId = dto.Id;
           
            CarCB.SelectedIndex = CarCB.FindStringExact(dto.CarDetails);
            CustomerCB.SelectedIndex = CustomerCB.FindStringExact(dto.CustomerDetails);
            QuantityOfFuelCB.SelectedIndex = QuantityOfFuelCB.FindStringExact(dto.QuantityOfFuel);
            inspector.Text = dto.Inspector;
            inspectionCommentTX.Text = dto.Comment;
            hasBotiquinChek.Checked = dto.HasCat;
            hasRefactionChek.Checked = dto.HasRefaction;
            hasScratchesChek.Checked = dto.HasScratches;
            checkLlanta1.Checked = dto.Wheel1Check;
            checkLlanta2.Checked = dto.Wheel2Check;
            checkLlanta3.Checked = dto.Wheel3Check;
            checkLlanta4.Checked = dto.Wheel4Check;
        }
        //------------------------------------------------------------------------------Fill the form to edit the data

        private InspectionDTO FillUpDto()
        {
            CarCB.ValueMember = "Id";
            int CarId = Convert.ToInt32(CarCB.SelectedValue);
            CarCB.ValueMember = "FullCarDescription";

            CustomerCB.ValueMember = "Id";
            int CustomerId = Convert.ToInt32(CustomerCB.SelectedValue);
            CustomerCB.ValueMember = "FullCustomerDescription";

            return new InspectionDTO
            {
                Id = inspectionId,
                CarId = CarId,
                CarDetails = Convert.ToString(CarCB.SelectedValue),
                CustomerId = CustomerId,
                CustomerDetails = Convert.ToString(CustomerCB.SelectedValue),
                QuantityOfFuel = QuantityOfFuelCB.Text,
                HasRefaction = hasRefactionChek.Checked,
                HasScratches = hasScratchesChek.Checked,
                HasCat = hasBotiquinChek.Checked,
                Wheel1Check = checkLlanta1.Checked,
                Wheel2Check = checkLlanta2.Checked,
                Wheel3Check = checkLlanta3.Checked,
                Wheel4Check = checkLlanta4.Checked,
                DateOfInspection = Convert.ToString(today),
                InspectorId = 1,
                Inspector = "Yolanda",
                Comment = inspectionCommentTX.Text,
                State = true
            };
        }

        private void ResetForm()
        {
            InspectionForm NewForm = new InspectionForm();
            NewForm.Show();
            this.Dispose(false);
        }

        private void SaveInspectionBtn_Click(object sender, EventArgs e)
        {
            InspectionDTO dto = FillUpDto();

            if (SaveInspectionBtn.Text.Equals("Editar inspeccion"))
            {
                dao.EDIT(dto);
                MessageBox.Show("SUCCESS : editado correctamente!");
                ResetForm();
            }
            else if (SaveInspectionBtn.Text.Equals("Guardar inspeccion"))
            {
                dao.ADD(dto);
                MessageBox.Show("SUCCESS : vehiculo agregado correctamente!");
                ResetForm();
            }
            else
            {
                MessageBox.Show("ERROR : probleamas al ejecutar la operacion.");
                ResetForm();
            }
        }

        private void inspectionsDV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Abrir form de renta.

            //Si se renta el vehiculo, desaparece de las inspecciones...
            //Refresh data table

            //Dialog rent(ABORT), edit(OK) or delete(CANCEL) inspection

            if (e.RowIndex < 0) return;

            var dto = (InspectionDTO)inspectionsDV.Rows[e.RowIndex].DataBoundItem;

            if (dto == null) return;

            //new GeneralCrud(dto.CarTypeId, dto.CarTypeDescription, dto.CarTypeStatus, "type");

            //
            ChooseAction3 confirmAction = new ChooseAction3("Rentar", "Editar", "Eliminar");

            DialogResult dr = confirmAction.ShowDialog();

            if (dr == DialogResult.OK) //Edit record
            {
                //Prepare the form to edit record
                FillForm(dto);
            }
            else if (dr == DialogResult.Abort) //Display Rent form...
            {
                RentForm rentForm = new RentForm(dto);

                DialogResult rentResult = rentForm.ShowDialog();

                if (rentResult == DialogResult.OK || dr == DialogResult.Cancel)
                {
                    //Here do refresh to the table...
                    inspectionsDV.Refresh();
                }

            }
            else if (dr == DialogResult.Cancel) //Delete record
            {
                ConfirmAction confirm = new ConfirmAction();

                DialogResult result = confirm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ///Delete the record
                    dao.DELETE(dto.Id);
                    MessageBox.Show("Elemento borrado!");
                    ResetForm();
                }
            }
        }
    }
}
