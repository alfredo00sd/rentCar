using rentCar.DAO;
using rentCar.views.car.commonCruds;
using rentCar.views.car.type;
using RentCarApp.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace rentCar.views.car
{
    public partial class GeneralView : Form
    {
        readonly CarModelCRUD modelCRUD = new CarModelCRUD();
        readonly CommonsCarDAO dao = new CommonsCarDAO();

        public GeneralView()
        {
            InitializeComponent();

            //Load dts data
            LoadCarTypeDTVConfing();
            LoadCarBrandDTVConfig();
            LoadCarModelDTVConfig();
            LoadCarFuelTypeDTVConfig();
        }


        //----------------------------------------------------------------------Util methods
    
        private void refreshDataView(string dataView)
        {

            switch (dataView)
            {

                case "model": //Car model dt view config

                    LoadCarModelDTVConfig();
                    modelInput.Text = "";
                    break;

                case "type": //Car type dt view config

                    LoadCarTypeDTVConfing();
                    carTypeTX.Text = "";
                    break;

                case "brand": //Car brand dt view config

                    LoadCarBrandDTVConfig();
                    brandTX.Text = "";
                    break;

                case "fuel": //Car fuel type dt view config

                    LoadCarFuelTypeDTVConfig();
                    carFuelTypeTX.Text = "";
                    break;

                default: break;
            }
        }

        private void DtvCommonFormat(DataGridView dgv)
        {
            dgv.Columns[0].HeaderText = "#";
            dgv.Columns[0].Width = 60;
            dgv.Columns[1].HeaderText = "Descripcion";
            dgv.Columns[2].HeaderText = "Estado";
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(193, 199, 232);
        }

        //----------------------------------------------------------------------Util methods

        //----------------------------------------------------------------------Loads data actions

        private void LoadCarTypeDTVConfing() 
        {
            //Car type dt view config
            carTypeDTV.DataSource = dao.GetCartypes();
            DtvCommonFormat(carTypeDTV);
        }

        private void LoadCarBrandDTVConfig() 
        {
            //Car brand dt view config
            brandsDataView.DataSource = dao.GetCarBrands();
            DtvCommonFormat(brandsDataView);
        }

        private void LoadCarFuelTypeDTVConfig() 
        {
            //Car fuel type dt view config
            fuelTypeDTV.DataSource = dao.GetCarFuelType();
            DtvCommonFormat(fuelTypeDTV);
        }
        
        private void LoadCarModelDTVConfig()
        {
            //Car model dt view config
            modelsDataView.DataSource = modelCRUD.GetCarModels();
            modelsDataView.Columns[3].Visible = false;

            modelsDataView.Columns[0].HeaderText = "#";
            modelsDataView.Columns[0].Width = 60;
            modelsDataView.Columns[4].Width = 80;
            modelsDataView.Columns[1].HeaderText = "Modelo";
            modelsDataView.Columns[2].HeaderText = "Marca";
            modelsDataView.Columns[4].HeaderText = "Estado";
            modelsDataView.DefaultCellStyle.BackColor = Color.FromArgb(193, 199, 232);

            //Combox brands congig
            CarBrandCB.DropDownStyle = ComboBoxStyle.DropDownList;
            CarBrandCB.DataSource = dao.GetDataForCB(2);
            CarBrandCB.ValueMember = "id";
            CarBrandCB.DisplayMember = "brand";
        }

        //----------------------------------------------------------------------Loads data actions

        //------------------------------------------------------------------------Edit or Delete data event

        private void brandsDataView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dto = (CarBrandDTO) brandsDataView.Rows[e.RowIndex].DataBoundItem;

            if (dto == null) return;

            GeneralCrud editModelForm = new GeneralCrud(dto.BrandId, dto.BrandDescription, dto.BrandStatus, "brand");

            DialogResult dr = editModelForm.ShowDialog();

            if (dr == DialogResult.OK || dr == DialogResult.Cancel)
            {
                //Edito el record
                //Here do refresh to the table...
                refreshDataView("brand");
            }
        }

        private void modelsDataView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var modelo = (CarModelDTO)modelsDataView.Rows[e.RowIndex].DataBoundItem;

            if (modelo == null) return;

            CommonDEView editModelForm = new CommonDEView(modelo);

            DialogResult dr = editModelForm.ShowDialog();

            if (dr == DialogResult.OK || dr == DialogResult.Cancel)
            {
                //Here do refresh to the table...
                refreshDataView("model");
            }
        }

        private void carTypeDTV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dto = (CarTypeDTO) carTypeDTV.Rows[e.RowIndex].DataBoundItem;

            if (dto == null) return;

            GeneralCrud editModelForm = new GeneralCrud(dto.CarTypeId, dto.CarTypeDescription, dto.CarTypeStatus,"type");

            DialogResult dr = editModelForm.ShowDialog();

            if (dr == DialogResult.OK || dr == DialogResult.Cancel)
            {
                //Edito el record
                //Here do refresh to the table...
                refreshDataView("type");
            }
        }

        private void fuelTypeDTV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dto = (CarFuelTypeDTO) fuelTypeDTV.Rows[e.RowIndex].DataBoundItem;

            if (dto == null) return;

            GeneralCrud editModelForm = new GeneralCrud(dto.FuelTypeId, dto.FuelType, dto.FuelStatus, "fuelType");

            DialogResult dr = editModelForm.ShowDialog();

            if (dr == DialogResult.OK || dr == DialogResult.Cancel)
            {
                //Edito el record
                //Here do refresh to the table...
                refreshDataView("fuel");
            }
        }

        //------------------------------------------------------------------------Edit or Delete data event

        //-----------------------------------------------------------------------------Add data actions

        private void addBrand_Click(object sender, EventArgs e)
        {
            if (brandTX.Text.Equals("") || brandTX.Text == null)
            {
                MessageBox.Show("favor de completar el campo");
            }
            else {
                MessageBox.Show(dao.Add(brandTX.Text, "brand"));
                refreshDataView("brand");
            }
        }

        private void addCarType_Click(object sender, EventArgs e)
        {
            if (carTypeTX.Text.Equals("") || carFuelTypeTX.Text == null)
            {
                MessageBox.Show("favor de completar el campo");
            }
            else
            {
                MessageBox.Show(dao.Add(carTypeTX.Text, "type"));
                refreshDataView("type");
            }
        }

        private void addNewModel_Click(object sender, System.EventArgs e)
        {
            int brandId = Convert.ToInt32(CarBrandCB.SelectedValue);
            string newModelDescription = modelInput.Text;

            if (newModelDescription != null && newModelDescription != "" && brandId > 0)
            {
                MessageBox.Show(modelCRUD.AddNewModel(brandId, newModelDescription));
                refreshDataView("model");
            }
            else
            {
                MessageBox.Show("Favor completar el campo modelo y marca a la que pertence para agregar.");
            }
        }

        private void addCarFuelType_Click(object sender, EventArgs e)
        {
            if (carFuelTypeTX.Text.Equals("") || carFuelTypeTX.Text == null)
            {
                MessageBox.Show("favor de completar el campo");
            }
            else
            {
                MessageBox.Show(dao.Add(carFuelTypeTX.Text, "fuelType"));
                refreshDataView("fuel");
            }
        }

        //-----------------------------------------------------------------------------Add data actions

        //-----------------------------------------------------------------------------Text changed events

        private void modelInput_TextChanged(object sender, EventArgs e)
        {
            modelsDataView.DataSource = modelCRUD.GetCarModelsByCondition(modelInput.Text);
        }
        //-----------------------------------------------------------------------------Text changed events
    }
}
