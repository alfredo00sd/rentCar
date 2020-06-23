using rentCar.DAO;
using rentCar.views.car.type;
using System;
using System.Windows.Forms;

namespace rentCar.views.car.commonCruds
{
    public partial class GeneralCrud : Form
    {
        CommonsCarDAO dao = new CommonsCarDAO();
        string table;

        public GeneralCrud()
        {
            InitializeComponent();
        }

        public GeneralCrud(int id, string decription, bool status, string table)
        {
            InitializeComponent();

            idInput.Text = "" + id;
            descriptionInput.Text = decription;
            statusCheck.Checked = status;
            this.table = table;
        }

        private void saveEditBtn_Click(object sender, EventArgs e)
        {
            dao.Edit(idInput.Text, descriptionInput.Text, statusCheck.Checked, table);
            
            MessageBox.Show("Cambios guardados!");
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ConfirmAction confirm = new ConfirmAction();

            DialogResult dr = confirm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                dao.Delete(idInput.Text, table);
                MessageBox.Show("Elemento eliminado!");
                //Close edit form
                this.Close();
            }
        }
    }
}
