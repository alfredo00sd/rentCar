using rentCar.DAO;
using rentCar.views.car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rentCar.controllers
{
    class CarController
    {
        AddCarView Vista;

        public CarController(AddCarView View) 
        {
            Vista = View;
        //    Vista.Load = new EventHandler();
        
        }

        private void getAllCarTypes(Object sender, EventArgs e) 
        {

            CarDao dao = new CarDao();
           
        }
    }
}
