using rentCar.DAO.user;
using rentCar.DTO.user;
using System;
using System.Windows.Forms;

namespace rentCar.user
{
    public partial class userLogin : Form
    {
        //Start SINGLETON
        private static userLogin Instancia = null;
        LoginDao dao = new LoginDao();

        public userLogin()
        {
            InitializeComponent();
        }
        public static userLogin ObtenerInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new userLogin();
                Instancia.FormClosed += new FormClosedEventHandler(reset);//SOLO PARA FORMULARIOS
            }

            return Instancia;
        }
        private static void reset(object sender, FormClosedEventArgs e)//SOLO PARA FORMULARIOS
        {
            Instancia = null;
        }
        //End SINGLETON        


        private void userCard_TextChanged(object sender, EventArgs e)
        {

        }

        private void validateUserBtn_Click(object sender, EventArgs e)
        {
            if (userCard.Text.Equals("") || passwordInput.Text.Equals(""))
            {
                MessageBox.Show("No puede dejar campos vacios");
            }
            else 
            {
                if (dao.ValidateLoggin(userCard.Text, passwordInput.Text) != null)
                {
                    Application.Run(new AppForm());

                    //appForm.loggedUserConfig(dao.ValidateLoggin(userCard.Text, passwordInput.Text));

                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Datos erroneos, favor revisar sus credenciales e intentar de nuevo.");
                }
            }
        }
    }
}
