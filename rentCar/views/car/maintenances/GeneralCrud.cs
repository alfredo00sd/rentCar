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

        public GeneralCrud(int id, string decription, string status, string table)
        {
            InitializeComponent();

            idInput.Text = "" + id;
            descriptionInput.Text = decription;
            statusCheck.Checked = status.Equals("Activo");
            this.table = table;
        }

        private void saveEditBtn_Click(object sender, EventArgs e)
        {
            if (dao.Edit(idInput.Text, descriptionInput.Text, statusCheck.Checked ? "Activo" : "Descativado", table))
            {
                MessageBox.Show("Cambios guardados!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Promblemas al editar");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ConfirmAction confirm = new ConfirmAction();

            DialogResult dr = confirm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                if (dao.Delete(idInput.Text, table))
                {
                    MessageBox.Show("Elemento eliminado!");
                    //Close edit form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Problemas al borrar este elemento");
                }
            }
        }
    }
}
