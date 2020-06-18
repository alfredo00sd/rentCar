using rentCar.DAO;
using rentCar.views.car.type;
using RentCarApp.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace rentCar.views.car
{
    public partial class CommonCRUDS : Form
    {
        CarModelCRUD dao = new CarModelCRUD();
        CarDao carDao = new CarDao();

        public CommonCRUDS()
        {
            InitializeComponent();
            LoadCarModelDTVConfig(dao.GetCarModels());
        }

        ///Car model actions
        private void LoadCarModelDTVConfig(List<CarModelDTO> dataSource) 
        {
            //Car model dt view config
            modelsDataView.DataSource = dataSource;
            modelsDataView.Columns[3].Visible = false;

            modelsDataView.Columns[0].HeaderText = "#";
            modelsDataView.Columns[0].Width = 60;
            modelsDataView.Columns[4].Width = 80;
            modelsDataView.Columns[1].HeaderText = "Modelo";
            modelsDataView.Columns[2].HeaderText = "Marca";
            modelsDataView.Columns[4].HeaderText = "Status";
            modelsDataView.DefaultCellStyle.BackColor = Color.FromArgb(193,199,232);
            
            //Combox brands congig
            CarBrandCB.DropDownStyle = ComboBoxStyle.DropDownList;
            CarBrandCB.DataSource = carDao.GetDataForCB(2);
            CarBrandCB.ValueMember = "id";
            CarBrandCB.DisplayMember = "brand";
        }

        private void modelsDataView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var modelo = (CarModelDTO)modelsDataView.Rows[e.RowIndex].DataBoundItem;

            if (modelo == null) return;

            CarModelDEView editModelForm = new CarModelDEView(modelo);

            DialogResult dr = editModelForm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                //Edito el record
                //Here do refresh to the table...
                refreshDataView("model");
            }
            else if (dr == DialogResult.Cancel)
            {
                //Borro el record
                //Here do refresh to the table...
                refreshDataView("model");
            }
        }

        private void addNewModel_Click(object sender, System.EventArgs e)
        {
            int brandId = Convert.ToInt32(CarBrandCB.SelectedValue);
            string newModelDescription = modelInput.Text;

            if (newModelDescription != null && newModelDescription != "" && brandId > 0)
            {
                MessageBox.Show(dao.AddNewModel(brandId, newModelDescription));
                refreshDataView("model");
            }
            else
            {
                MessageBox.Show("Favor completar el campo modelo y marca a la que pertence para agregar.");
            }
        }

        private void modelInput_TextChanged(object sender, EventArgs e)
        {
            modelsDataView.DataSource = dao.GetCarModelsByCondition(modelInput.Text);
        }
        ///Car model actions

        //Car type actions
        private void LoadCarTypeDTVConfing() 
        {
            //Car type dt view config
            carTypeDTV.DataSource = dao.GetCarModels();
        }

        //Car type actions

        private void LoadCarBrandDTVConfig() 
        {
            //Car brand dt view config
            brandsDataView.DataSource = dao.GetCarModels();
        }

        private void LoadCarFuelTypeDTVConfig() 
        {
            //Car fuel type dt view config
            fuelTypeDTV.DataSource = dao.GetCarModels();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshDataView(string dataView) {

            switch (dataView) {

                case "model" : //Car model dt view config

                    LoadCarModelDTVConfig(dao.GetCarModels());
                    
                    break;

                default : break;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
