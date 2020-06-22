using rentCar.DAO;
using RentCarApp.DTO;
using System;
using System.Windows.Forms;

namespace rentCar.views.car.type
{
    public partial class CommonDEView : Form
    {
        CommonsCarDAO dao = new CommonsCarDAO();
        CarModelCRUD modelCRUD = new CarModelCRUD();

        public CommonDEView()
        {
            InitializeComponent();
            FillBrandCB();
        }

        public CommonDEView(CarModelDTO carModel) 
        {
            InitializeComponent();
            FillBrandCB();

            modelIdTB.Text = ""+carModel.ModelId;
            modeloTB.Text  = carModel.ModelDescription;
            CarBrandCB.SelectedValue = carModel.ParentBrandId;
            statusCheck.Checked = carModel.Status.Equals("Activo");
        }

        private void FillBrandCB() 
        {
            CarBrandCB.DropDownStyle = ComboBoxStyle.DropDownList;
            CarBrandCB.DataSource = dao.GetDataForCB(2);
            CarBrandCB.ValueMember = "id";
            CarBrandCB.DisplayMember = "brand";
        }

        //Edit
        private void iconButton1_Click(object sender, EventArgs e)
        {
            CarModelDTO carModel = new CarModelDTO();

            carModel.ModelId = Convert.ToInt32(modelIdTB.Text);
            carModel.ModelDescription = modeloTB.Text;
            carModel.ParentBrandId = Convert.ToInt32(CarBrandCB.SelectedValue);
            carModel.Status = statusCheck.Checked ? "Activo" : "Descativado";

            if (modelCRUD.EditCarModel(carModel))
            {
                MessageBox.Show("Cambios guardados!");
                this.Close();
            }
            else {
                MessageBox.Show("Promblemas al editar");
            }
        }
        
        //Delete
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ConfirmAction confirm = new ConfirmAction();

            DialogResult dr = confirm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                if (modelCRUD.DeleteCarModel(modelIdTB.Text))
                {
                    MessageBox.Show("Elemento eliminado!");
                    //Close edit form
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Problemas al borrar este modelo");
                }
            }
        }
    }
}