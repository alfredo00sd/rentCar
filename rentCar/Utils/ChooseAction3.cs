using System.Windows.Forms;

namespace rentCar.views.users
{
    public partial class ChooseAction3 : Form
    {
        public ChooseAction3()
        {
            InitializeComponent();
        }

        public ChooseAction3(string AbortDialog, string OkDialog, string CancelDialog)
        {
            InitializeComponent();
            
            //Abort action
            btnInfo.Text = AbortDialog;
            
            //OK action
            btnEdit.Text = OkDialog;
            
            //Cancel action
            btnDelete.Text = CancelDialog;
        }
    }
}
