using System.Windows.Forms;

namespace rentCar.views.car
{
    public partial class ChooseAction2 : Form
    {
        public ChooseAction2()
        {
            InitializeComponent();
        }

        public ChooseAction2(string msg, string leftBtnText, string rightBtnText)
        {
            InitializeComponent();

            chooseMsg.Text = msg;
            rightBtn.Text = rightBtnText;
            leftBtn.Text = leftBtnText;
        }
    }
}
