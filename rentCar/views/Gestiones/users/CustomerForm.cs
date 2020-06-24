using rentCar.DAO;
using rentCar.DTO;
using rentCar.Utils;
using rentCar.views.car;
using rentCar.views.car.type;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace rentCar.views.customers
{
    public partial class CustomerForm : Form
    {
        private CustomerDAO dao = new CustomerDAO();
        private const string editCustomerParam = "Editar cliente";
        private const string createCustomerParam = "Crear cliente";
        private readonly CustomValidations validations = new CustomValidations();
        private int customerId;


        public CustomerForm()
        {
            InitializeComponent();
            CustomerStatusCheck.Checked = true;
            //Fill table.
            CustomerDV.DataSource = dao.GETALL();
            validateCustomerBtn.Text = createCustomerParam;
        }

        private void ReopenForm()
        {
            CustomerForm NewForm = new CustomerForm();
            NewForm.Show();
            this.Dispose(false);
        }

        //-------------------------------------------------------------------------------------Edit or Delete
        private void validateCustomerBtn_Click(object sender, EventArgs e)
        {
            if (!CustomerCedulaTX.Text.Equals("") && RNCTX.Text.Equals("") || RNCTX.Text.Equals("N/A")) //Es persona fisica
            {
                if (validations.checkCedula(CustomerCedulaTX.Text)) //If valid cedula 
                {
                    CustomerDTO customer = FillCustomerDTO();

                    ValidationContext validation = new ValidationContext(customer, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();

                    if (!Validator.TryValidateObject(customer, validation, errors, true)) //Form validations
                    {
                        foreach (ValidationResult result in errors)
                            MessageBox.Show(result.ErrorMessage);
                    }
                    else
                    {
                        if (dao.GetCustomerById(CustomerCedulaTX.Text, RNCTX.Text) && validateCustomerBtn.Text.Equals(createCustomerParam)) //Check duplicity
                        {
                            MessageBox.Show("Esta persona fisica ya existe en el sistema!");
                        }
                        else
                        {
                            if (validateCustomerBtn.Text.Equals(createCustomerParam)) //Create the customer
                            {
                                dao.ADD(customer);
                                MessageBox.Show("SUCCESS : Cliente creado!");

                                //Refresh data and reset form....
                                ReopenForm();
                            }
                            else if (validateCustomerBtn.Text.Equals(editCustomerParam)) //Edit the customer
                            {
                                dao.EDIT(customer);
                                MessageBox.Show("SUCCESS : cliente editado correctamente!");

                                //Refresh data and reset form...
                                ReopenForm();
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
            else if(CustomerCedulaTX.Text.Equals("") || CustomerCedulaTX.Text.Equals("N/A") && !RNCTX.Text.Equals("")) // Es juridica
            {

                //if (validations.checkRNC(RNCTX.Text)) //If valid RNC 
                //{
                CustomerDTO customer = FillCustomerDTO();

                ValidationContext validation = new ValidationContext(customer, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();

                if (!Validator.TryValidateObject(customer, validation, errors, true)) //Form validations
                {
                    foreach (ValidationResult result in errors)
                        MessageBox.Show(result.ErrorMessage);
                }
                else
                {
                    if (dao.GetCustomerById(CustomerCedulaTX.Text, RNCTX.Text) && validateCustomerBtn.Text.Equals(createCustomerParam)) //Check duplicity
                    {
                        MessageBox.Show("Esta persona juridica ya existe en el sistema!");
                    }
                    else
                    {
                        if (validateCustomerBtn.Text.Equals(createCustomerParam)) //Create the customer
                        {
                            dao.ADD(customer);
                            MessageBox.Show("SUCCESS : Cliente creado!");

                            //Refresh data and reset form....
                            ReopenForm();
                        }
                        else if (validateCustomerBtn.Text.Equals(editCustomerParam)) //Edit the customer
                        {
                            dao.EDIT(customer);
                            MessageBox.Show("SUCCESS : cliente editado correctamente!");

                            //Refresh data and reset form...
                            ReopenForm();
                        }
                        else
                        {
                            MessageBox.Show("ERROR : probleamas al ejecutar la operacion.");
                        }
                    }
                }
             //   }
                //else //No valid cedula.
                //{
                  //  MessageBox.Show("RNC invalido, favor corregir para proceder.");
                //    }
            }
        }
        //-------------------------------------------------------------------------------------Edit or Delete

        //-------------------------------------------------------------------------------------Choose action over record
        private void CustomerDV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dto = (CustomerDTO)CustomerDV.Rows[e.RowIndex].DataBoundItem;

            if (dto == null) return;

            ChooseAction2 chooseAction = new ChooseAction2();

            DialogResult dr = chooseAction.ShowDialog();

            if (dr == DialogResult.OK) //Wants to edit
            {
                FillCustomerForm(dto);
                validateCustomerBtn.Text = editCustomerParam;
            }
            else if (dr == DialogResult.Cancel) //Wants to delete
            {
                ConfirmAction confirmation = new ConfirmAction();

                //Confirmar que quiere eliminar
                DialogResult result = confirmation.ShowDialog();

                //Si, Elimino el record
                if (result == DialogResult.OK)
                {
                    dao.DELETE(dto.Id);
                    MessageBox.Show("Elemento eliminado!");
                    ReopenForm();
                }
                else
                {
                    MessageBox.Show("Problemas borrando...");
                }

            }
        }

        //-------------------------------------------------------------------------------------Choose action over record

        //-------------------------------------------------------------------------------------Search Customer action.
        private void SearchBarTX_TextChanged(object sender, EventArgs e)
        {
            CustomerDV.DataSource = dao.GetCustomerByCedulOrRnc(SearchBarTX.Text);
        }
        //-------------------------------------------------------------------------------------Search Customer action.

        //------------------------------------------------------------Utils

        private void FillCustomerForm(CustomerDTO dto)
        {
            customerId = dto.Id;
            RNCTX.Text = dto.RNC;
            CustomerNameTX.Text = dto.Name;
            CustomerLastNameTX.Text = dto.LastName;
            CreditCardTX.Text = dto.CreditCardNo;
            CustomerCedulaTX.Text = dto.IdentificationCard;
            CustomerTypeCB.SelectedItem = dto.Type;
            creditLimitTN.Value = dto.CreditLimit;
            CustomerStatusCheck.Checked = dto.Status;
        }

        private CustomerDTO FillCustomerDTO()
        {
            return new CustomerDTO
            {
                Id = customerId >= 1 ? customerId : 0,
                RNC = RNCTX.Text.Equals("") ? "N/A" : RNCTX.Text,
                Name = CustomerNameTX.Text,
                LastName = CustomerLastNameTX.Text,
                CreditCardNo = CreditCardTX.Text,
                IdentificationCard = CustomerCedulaTX.Text.Equals("") ? "N/A" : CustomerCedulaTX.Text,
                Type = Convert.ToString(CustomerTypeCB.SelectedItem),
                CreditLimit = Convert.ToInt32(creditLimitTN.Value),
                Status = CustomerStatusCheck.Checked ? true : false
            };
        }

        //------------------------------------------------------------Utils

    }
}
