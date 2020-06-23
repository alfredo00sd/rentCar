using FontAwesome.Sharp;
using rentCar.DTO.user;
using rentCar.user;
using rentCar.views.car;
using rentCar.views.customers;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace rentCar
{
    public partial class AppForm : Form
    {
        //App fields
        private IconButton currentBtn;
        private readonly Panel leftPanelBtn;
        private Form currentChildForm;
        private struct RGBColors
        {
            public static Color darkRedTheme = Color.FromArgb(110, 0, 15);
            public static Color lightOrangeTheme = Color.FromArgb(250, 53, 0);
        }

        public AppForm(UserDTO user) {
            InitializeComponent();

            userName.Text = user.UserName;
        }

        public AppForm()
        {
            //userLogin logginForm = new userLogin();

            //DialogResult dr = logginForm.ShowDialog();

            //if (dr == DialogResult.OK)
            //{
                //General config to the app.
                InitializeComponent();

                leftPanelBtn = new Panel
                {
                    Size = new Size(7, 50)
                };
                menuPanel.Controls.Add(leftPanelBtn);

                //hide sub-menus
                HiddeSubMenus();

                //Unhide menu buttons
                gestiBtn.Visible = true;
                processBtn.Visible = true;

                //User status bar
                userStatus.Visible = true;
                userName.Text = "Alfredo Acosta";
                iconCurrentChildForm.Visible = true;
                lblTitleChildForm.Visible = true;

                //Form initial state
                this.Text = "";
                this.ControlBox = false;
                this.DoubleBuffered = true;
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
           // }
            //else
            //{
              //  MessageBox.Show("Login invalido!");
            //}
        }

        private void HiddeSubMenus()
        {
            gestiSubMenuPanel.Visible = false;
            processSubMenuPanel.Visible = false;
        }

        private void OpenChildForm(Form childForm)
        {
            //Open only one form, to multiple forms comment this
            if (currentChildForm != null)
                currentChildForm.Close();

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Size = new Size(1300, 650);
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            //Make the child form responsive
            childForm.Anchor = AnchorStyles.Top;
            childForm.Anchor = AnchorStyles.Left;
            childForm.Anchor = AnchorStyles.Right;
            childForm.Anchor = AnchorStyles.Bottom;


            panelDash.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            lblTitleChildForm.Text = childForm.Text;
        }

        //--------------------------------------------------------------Left panel visual effects

        private void ActivateBtn(Object senderBtn, Color color)
        {
            //Disable btn before ativate a new one...
            DisableBtn();

            if (senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = RGBColors.darkRedTheme;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftPanelBtn.BackColor = color;
                leftPanelBtn.Location = new Point(0, currentBtn.Location.Y);
                leftPanelBtn.Visible = true;
                leftPanelBtn.BringToFront();

                //Icon current child form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                lblTitleChildForm.Text = currentBtn.Text;
            }
        }
       
        private void DisableBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = RGBColors.darkRedTheme;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        
        private void Reset()
        {
            DisableBtn();
            leftPanelBtn.Visible = false;

            //Icon child form reset
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.White;
            lblTitleChildForm.Text = "Hola, Bienvenido";
        }
    
        private void AppLogo_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
                currentChildForm.Close();
            Reset();
        }

        //--------------------------------------------------------------Left panel visual effects

        //--------------------------------------------------------------Car Crud
        private void CarManagerBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CarMantView());
        }

        //--------------------------------------------------------------General car Crud
        private void GeneralManagerBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GeneralView());
        }

        //--------------------------------------------------------------Employee Crud
        private void EmployeeManagerBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeForm());
        }

        private void CustomerManagerBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerForm());
        }

        //--------------------------------------------------------------Inspection crud
        private void InspectorManagerBtn_Click(object sender, EventArgs e)
        {

        }

        //--------------------------------------------------------------Rent Crud
        private void RentManagerBtn_Click(object sender, EventArgs e)
        {

        }

        //--------------------------------------------------------------Reports
        private void ReportBtn_Click(object sender, EventArgs e)
        {

        }

        //--------------------------------------------------------------Consults
        private void ConsultBtn_Click(object sender, EventArgs e)
        {

        }

        //Panel de gestion
        private void GestiBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.lightOrangeTheme);

            if (gestiSubMenuPanel.Visible == true)
                gestiSubMenuPanel.Visible = false;
            else
                gestiSubMenuPanel.Visible = true;
        }

        //Panel de procesos
        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.lightOrangeTheme);

            if (processSubMenuPanel.Visible == true)
                processSubMenuPanel.Visible = false;
            else
                processSubMenuPanel.Visible = true;
        }

        //--------------------------------------------------------------Form Utils
        //Drag form from title bar
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Drag form import methods
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MaximizeBtn_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)

                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void MinimizeBtn_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //--------------------------------------------------------------Form Utils
    }
}
