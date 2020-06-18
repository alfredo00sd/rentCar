using rentCar.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rentCar.views.car
{
    public partial class CarCRUD : Form
    {
        CarDao carDao = new CarDao(); 

        public CarCRUD()
        {
            InitializeComponent();
            dataViewer.DataSource = carDao.GetAllCars();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            dataViewer.DataSource = carDao.SearchByCriteria(criterioDeBusqueda.Text);
        }
    }
}
