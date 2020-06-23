using rentCar.DAO;
using RentCarApp.DTO;
using System;
using System.Windows.Forms;

namespace rentCar.views.car.type
{
    public partial class CarModelEditForm : Form
    {
        CommonsCarDAO dao = new CommonsCarDAO();
        CarModelCRUD modelCRUD = new CarModelCRUD();

        public CarModelEditForm()
        {
            InitializeComponent();
            FillBrandCB();
        }

        public CarModelEditForm(CarModelDTO carModel) 
        {
            InitializeComponent();
            FillBrandCB();

            modelIdTB.Text = ""+carModel.ModelId;
            modeloTB.Text  = carModel.ModelDescription;
            CarBrandCB.SelectedValue = carModel.ParentBrandId;
            statusCheck.Checked = carModel.Status;
        }

        private void FillBrandCB() 
        {
            CarBrandCB.DropDownStyle = ComboBoxStyle.DropDownList;
            CarBrandCB.DataSource = dao.GetDataForCB("car_brand");
            CarBrandCB.ValueMember = "id";
            CarBrandCB.DisplayMember = "description";
        }

        //Edit
        private void iconButton1_Click(object sender, EventArgs e)
        {
            CarModelDTO carModel = new CarModelDTO();

            carModel.ModelId = Convert.ToInt32(modelIdTB.Text);
            carModel.ModelDescription = modeloTB.Text;
            CarBrandCB.ValueMember = "description";
            carModel.ParentBrand = Convert.ToString(CarBrandCB.SelectedValue);
            CarBrandCB.ValueMember = "id";
            carModel.ParentBrandId = Convert.ToInt32(CarBrandCB.SelectedValue);
            carModel.Status = statusCheck.Checked;


            modelCRUD.EditCarModel(carModel);
            MessageBox.Show("Cambios guardados!");
            this.Close();
        }
        
        //Delete
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ConfirmAction confirm = new ConfirmAction();

            DialogResult dr = confirm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                modelCRUD.DeleteCarModel(modelIdTB.Text);
                MessageBox.Show("Elemento eliminado!");
                //Close edit form
                this.Close();   
            }
        }
    }
}