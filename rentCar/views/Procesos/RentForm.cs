using rentCar.DTO;
using System;
using System.Windows.Forms;

namespace rentCar.views
{
    public partial class RentForm : Form
    {
        
        public RentForm()
        {
            InitializeComponent();
        }

        public RentForm(InspectionDTO dto)
        {
            InitializeComponent();
         
            CarTX.Text = dto.CarDetails;
            CustomerTX.Text = dto.CustomerDetails;

            //Initialize form params
        }

        private void costPerDay_ValueChanged(object sender, System.EventArgs e)
        {
            totalTX.Text = "RD$ "+12 * 2 ;        
        }

        private void SaveRentBtn_Click(object sender, System.EventArgs e)
        {
            string date = Convert.ToString(fechaDeRenta.Value);
            string devolucion = Convert.ToString(fechaDevolucion.Value);

            MessageBox.Show(date + " devolbio : " + devolucion);
        }
    }
}
