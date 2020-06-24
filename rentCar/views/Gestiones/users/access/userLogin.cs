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
        private readonly LoginDao dao = new LoginDao();
        private UserDTO user = new UserDTO();

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

        private void validateUserBtn_Click(object sender, EventArgs e)
        {
            if (userNameTX.Text.Equals("") || passTX.Text.Equals(""))
            {
                MessageBox.Show("No puede dejar campos vacios");
            }
            else
            {
                user = dao.ValidateLoggin(userNameTX.Text, passTX.Text);

                if (user.Message.Equals("OK"))
                {
                    AppForm NewForm = new AppForm(user);
                    NewForm.Show();
                    this.Dispose(false);
                }
                else
                {
                    MessageBox.Show(user.Message);
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)

                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void recoverCredentials_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Favor contactar un administrador de sistemas.");
        }
    }
}
