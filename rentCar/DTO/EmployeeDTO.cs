using System;
using System.ComponentModel.DataAnnotations;

namespace rentCar.DTO.Employee
{
    public class EmployeeDTO
    {     
        //Fields
        private int _employeeId;
        private string _identificationCard;
        private string _employeeCard;
        private string _workSession;
        private string _name;
        private string _lastName;
        private string _startDate;
        private string _workPosition;
        private int _comission;
        private bool status;

        //Mehtods
        public int EmployeeId { get => _employeeId; set => _employeeId = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Cedula")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Los caracteres en el campo {0} deben ser 11")]
        public string IdentificationCard { get => _identificationCard; set => _identificationCard = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Tarjeta de empleado")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Los caracteres en el campo {0} deben estar entre 20 y 8")]
        public string EmployeeCard { get => _employeeCard; set => _employeeCard = value; }

        public string WorkSession { get => _workSession; set => _workSession = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Nombre(s)")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Los caracteres en el campo {0} deben estar entre 30 y 3")]
        public string Name { get => _name; set => _name = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Apellido(s)")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Los caracteres en el campo {0} deben estar entre 60 y 3")]
        public string LastName { get => _lastName; set => _lastName = value; }

        public string StartDate { get => _startDate; set => _startDate = value; }

        public string WorkPosition { get => _workPosition; set => _workPosition = value; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Range(0, int.MaxValue, ErrorMessage = "Ingresar un valor mayor que {0}, en el campo {0}")]
        [Display(Name = "Comission")]
        public int Comission { get => _comission; set => _comission = value; }

        public bool Status { get => status; set => status = value; }
    }
}
