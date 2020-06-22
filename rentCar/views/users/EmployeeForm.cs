using rentCar.DAO;
using rentCar.DTO.Employee;
using rentCar.Utils;
using rentCar.views.car.type;
using rentCar.views.users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace rentCar.user
{
    public partial class EmployeeForm : Form
    {
        private EmployeeDAO dao = new EmployeeDAO();
        private const string EDIT_EMPLOYEE_PARAM = "Editar empleado";
        private const string CREATE_EMPLOYEE_PARAM = "Crear empleado";
        private readonly CustomValidations validations = new CustomValidations();
        private int EMPLOYEE_ID;

        public EmployeeForm()
        {
            InitializeComponent();
            employeStateCheck.Checked = true;
            FillDataView();
            createUserBtn.Text = CREATE_EMPLOYEE_PARAM;
        }

        //------------------------------------------------------------Fills
        private void FillDataView() 
        {
            employeeDV.DataSource = dao.GETALL();
        }
        //------------------------------------------------------------Fills

        #pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        private void Refresh()
        #pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {
            EmployeeForm NewForm = new EmployeeForm();
            NewForm.Show();
            this.Dispose(false);
        }

        //------------------------------------------------------------Add Action
        
        private void createUserBtn_Click(object sender, EventArgs e)
        {
            //dominicanIDTX.Text = "40214810653";
            if (validations.checkCedula(dominicanIDTX.Text)) //If valid cedula 
            {
                EmployeeDTO employee = FillEmployeeDTO();

                ValidationContext validation = new ValidationContext(employee, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();

                if (!Validator.TryValidateObject(employee, validation, errors, true)) //Form validations
                {
                    foreach (ValidationResult result in errors)
                        MessageBox.Show(result.ErrorMessage);
                }
                else
                {
                    if (dao.GetEmployeeById(dominicanIDTX.Text) && createUserBtn.Text.Equals(CREATE_EMPLOYEE_PARAM)) //Check duplicity
                    {
                        MessageBox.Show("Esta persona ya existe en el sistema!");
                    }
                    else 
                    {
                        if (createUserBtn.Text.Equals(CREATE_EMPLOYEE_PARAM)) //Create the employee
                        {
                            dao.ADD(employee);
                            MessageBox.Show("SUCCESS : Empleado creado!");

                            //Refresh data and reset form....
                            Refresh();
                        }
                        else if (createUserBtn.Text.Equals(EDIT_EMPLOYEE_PARAM)) //Edit the employee
                        {
                            dao.EDIT(employee);
                            MessageBox.Show("SUCCESS : empleado editado correctamente!");

                            //Refresh data and reset form...
                            Refresh();
                        }
                        else
                        {
                            MessageBox.Show("ERROR : probleamas al ejecutar la operacion.");
                        }
                    }
                }
            }
            else //No valid cedula.
            {
                MessageBox.Show("Cedula invalida, favor corregir para proceder.");
            }
        }

        //------------------------------------------------------------Delete or Edit Action

        private void employeeDV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dto = (EmployeeDTO)employeeDV.Rows[e.RowIndex].DataBoundItem;

            if (dto == null) return;
            
            ChooseAction3 chooseAction = new ChooseAction3();

            DialogResult dr = chooseAction.ShowDialog();

            if (dr == DialogResult.OK) //Wants to edit
            {
                FillEmployeeForm(dto);
                createUserBtn.Text = EDIT_EMPLOYEE_PARAM;
            }
            else if (dr == DialogResult.Cancel) //Wants to delete
            {
                ConfirmAction confirmation = new ConfirmAction();

                //Confirmar que quiere eliminar
                DialogResult result = confirmation.ShowDialog();

                //Si, Elimino el record
                if (result == DialogResult.OK)
                {
                    dao.DELETE(dto.EmployeeId);
                    MessageBox.Show("Elemento eliminado!");
                    FillDataView();
                }
                else {
                    MessageBox.Show("Problemas borrando...");
                }
            
            }//Obtener usuario del empleado...
            else if (dr == DialogResult.Abort) { // Wants to get employee user credentials

                MessageBox.Show(dao.GetEmployeeUserCredentials(dto.EmployeeId, dto.IdentificationCard));
            }
        }

        //------------------------------------------------------------Delete or Edit Action

        //------------------------------------------------------------Utils
        
        private void FillEmployeeForm(EmployeeDTO dto) 
        {
            string rol;
            EMPLOYEE_ID = dto.EmployeeId;
            dominicanIDTX.Text = dto.IdentificationCard;
            employeeNameTX.Text = dto.Name;
            employeeLastNameTX.Text = dto.LastName;
            empoyeeCardTX.Text = dto.EmployeeCard;
            workSessionCB.SelectedItem = dto.WorkSession;

            switch (dto.WorkPosition) {
                
                case "GEST" :   rol = "Rentador";        break; 
                case "INSP" :   rol = "Insperctor";      break; 
                case "ADMI" :   rol = "Administrador";   break;
                default     :   rol = "NoRol";           break; 
            }

            workPositionCB.SelectedItem = rol;
            comissions.Value = dto.Comission;
            employeStateCheck.Checked = dto.Status;
        }
     
        private EmployeeDTO FillEmployeeDTO()
        {
            string rol;
            switch (Convert.ToString(workPositionCB.SelectedItem))
            {
                case "Rentador": rol = "GEST"; break;
                case "Insperctor": rol = "INSP"; break;
                case "Administrador": rol = "ADMI"; break;
                default: rol = "NoRol"; break;
            }

            return new EmployeeDTO
            {
                EmployeeId = EMPLOYEE_ID >= 1 ? EMPLOYEE_ID : 0,
                IdentificationCard = dominicanIDTX.Text,
                EmployeeCard = empoyeeCardTX.Text,
                Name = employeeNameTX.Text,
                LastName = employeeLastNameTX.Text,
                WorkSession = Convert.ToString(workSessionCB.SelectedItem),
                WorkPosition = rol,
                Comission = Convert.ToInt32(comissions.Value),
                Status = employeStateCheck.Checked ? true : false
            };
        }

        //------------------------------------------------------------Utils
    }
}
