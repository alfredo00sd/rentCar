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

            RefreshForm();
            formatDV();
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

        private void formatDV() 
        {
            this.inspectionsDV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.inspectionsDV.Columns[0].HeaderText = "#";
            inspectionsDV.Columns[1].Visible = false;
            inspectionsDV.Columns[3].Visible = false;
            //this.inspectionsDV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.inspectionsDV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //this.inspectionsDV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.inspectionsDV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.inspectionsDV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.inspectionsDV.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.inspectionsDV.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.inspectionsDV.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.inspectionsDV.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.inspectionsDV.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.inspectionsDV.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.inspectionsDV.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.inspectionsDV.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.inspectionsDV.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

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

        private void RefreshForm()
        {
            formTile.Text = "Formulario de inspeccion";
            SaveInspectionBtn.Text = "Guardar inspeccion";

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
            
            inspectionId = 0;

            inspector.Text = "";
            inspectionCommentTX.Text = "";
            hasBotiquinChek.Checked = false;
            hasRefactionChek.Checked = false;
            hasScratchesChek.Checked = false;
            checkLlanta1.Checked = false;
            checkLlanta2.Checked = false;
            checkLlanta3.Checked = false;
            checkLlanta4.Checked = false;
        }

        private void SaveInspectionBtn_Click(object sender, EventArgs e)
        {
            InspectionDTO dto = FillUpDto();

            if (SaveInspectionBtn.Text.Equals("Editar inspeccion"))
            {
                dao.EDIT(dto);
                MessageBox.Show("SUCCESS : editado correctamente!");
                RefreshForm();
            }
            else if (SaveInspectionBtn.Text.Equals("Guardar inspeccion"))
            {
                dao.ADD(dto);
                MessageBox.Show("SUCCESS : vehiculo agregado correctamente!");
                RefreshForm();
            }
            else
            {
                MessageBox.Show("ERROR : probleamas al ejecutar la operacion.");
                RefreshForm();
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
                    RefreshForm();
                }
            }
        }
    }
}
