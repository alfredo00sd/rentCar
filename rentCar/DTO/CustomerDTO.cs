using System.ComponentModel.DataAnnotations;

namespace rentCar.DTO
{
    class CustomerDTO
    {
        //Fields
        private int _id;
        private string _name;
        private string _lastName;
        private string _identificationCard;
        private string _RNC;
        private string _type;
        private string _creditCardNo;
        private int _creditLimit;
        private bool _status;
        
        //Methods
        public int Id { get => _id; set => _id = value; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Nombre(s)")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Los caracteres en el campo {0} deben estar entre 30 y 5")]
        public string Name { get => _name; set => _name = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Apellido(s)")]
        [StringLength(60, MinimumLength = 10, ErrorMessage = "Los caracteres en el campo {0} deben estar entre 60 y 10")]
        public string LastName { get => _lastName; set => _lastName = value; }

        //[Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        //[Display(Name = "Cedula")]
        //[StringLength(11, MinimumLength = 11, ErrorMessage = "Los caracteres en el campo {0} deben ser 11")]
        public string IdentificationCard { get => _identificationCard; set => _identificationCard = value; }
        
        public string Type { get => _type; set => _type = value; }
        [Required]
        public string CreditCardNo { get => _creditCardNo; set => _creditCardNo = value; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Range(1, int.MaxValue, ErrorMessage = "Ingresar un valor mayor que {1}, en el campo {0}")]
        [Display(Name = "Limite de credito")]
        public int CreditLimit { get => _creditLimit; set => _creditLimit = value; }
        
        public bool Status { get => _status; set => _status = value; }
        public string RNC { get => _RNC; set => _RNC = value; }
    }
}
