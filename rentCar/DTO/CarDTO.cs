using System.ComponentModel.DataAnnotations;

namespace RentCarApp.DTO
{
    public class CarTypeDTO
    {
        private int _carTypeId;
        private string _carTypeDescription;
        private bool _carTypeStatus;

        public int CarTypeId { get => _carTypeId; set => _carTypeId = value; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Tipo de carro")]
        public string CarTypeDescription { get => _carTypeDescription; set => _carTypeDescription = value; }
        public bool CarTypeStatus { get => _carTypeStatus; set => _carTypeStatus = value; }
    }

    public class CarBrandDTO
    {
        private int _brandId;
        private string _brandDescription;
        private bool _brandStatus;

        public int BrandId { get => _brandId; set => _brandId = value; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Marca")]
        public string BrandDescription { get => _brandDescription; set => _brandDescription = value; }
        public bool BrandStatus { get => _brandStatus; set => _brandStatus = value; }
    }

    public class CarModelDTO
    {
        private int _modelId;
        private string _modelDescription;
        private int _parentBrandId;
        private string _parentBrand;
        private bool status;

        [Display(Name = "#")]
        public int ModelId { get => _modelId; set => _modelId = value; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Modelo")]
        public string ModelDescription { get => _modelDescription; set => _modelDescription = value; }
        public int ParentBrandId { get => _parentBrandId; set => _parentBrandId = value; }
        [Display(Name = "Marca")]
        public string ParentBrand { get => _parentBrand; set => _parentBrand = value; }
        public bool Status { get => status; set => status = value; }
    }

    public class CarFuelTypeDTO
    {
        private int _fuelTypeId;
        private string _fuelType;
        private bool _fuelStatus;

        public int FuelTypeId { get => _fuelTypeId; set => _fuelTypeId = value; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Tipo de combustible")]
        public string FuelType { get => _fuelType; set => _fuelType = value; }
        public bool FuelStatus { get => _fuelStatus; set => _fuelStatus = value; }
    }

    public class CarDTO
    {
        //Atributos
        int _id;
        string _photoPath;
        string _type;
        string _brand;
        string _model;
        int _fabYear;
        string _chasisNum; //max 20
        string _engineNum; //max 20
        string _licensePlate; //max 20
        string _color;//max 25
        string _fuelType;
        string _QuantityOfFuel; //max 30
        int _numberOfDoors;
        int _capacityOfPassangers;
        string _conditions; //max 15
        int _useInKM;// max 40
        string _comment; // max 200
        string _adquisitionDate;
        bool _status;

        // Get <> Set property
        public int Id { get => _id; set => _id = value; }

        [Display(Name = "Foto del carro")]
        public string PhotoPath { get => _photoPath; set => _photoPath = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Tipo de carro")]
        public string Type { get => _type; set => _type = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Marca del carro")]
        public string Brand { get => _brand; set => _brand = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Modelo del carro")]
        public string Model { get => _model; set => _model = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Range(1, int.MaxValue, ErrorMessage = "Ingresar un valor mayor que {1}, en el campo {0}")]
        [Display(Name = "Año de fabricacion")]
        public int FabYear { get => _fabYear; set => _fabYear = value; }

        [Display(Name = "Numero de chasis")]
        [StringLength(17, MinimumLength = 10, ErrorMessage = "Los caracteres en el campo {0} entre 10 y 17.")]
        //[RegularExpression("[A-HJ-NPR-Z0-9]{13}[0-9]{4}", ErrorMessage = "Numero de chasis invalido.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        public string ChasisNum { get => _chasisNum; set => _chasisNum = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Numero de motor")]
        public string EngineNum { get => _engineNum; set => _engineNum = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Numero de placa")]
        public string LicensePlate { get => _licensePlate; set => _licensePlate = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Color del vehiculo")]
        public string Color { get => _color; set => _color = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Tipo de combustible")]
        public string FuelType { get => _fuelType; set => _fuelType = value; }

        [Display(Name = "Cantidad de combustible")]
        public string QuantityOfFuel { get => _QuantityOfFuel; set => _QuantityOfFuel = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Range(1, int.MaxValue, ErrorMessage = "Ingresar un valor mayor que {1}, en el campo {0}")]
        [Display(Name = "Numero de puertas")]
        public int NumberOfDoors { get => _numberOfDoors; set => _numberOfDoors = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Numero de pasajeros")]
        [Range(1, int.MaxValue, ErrorMessage = "Ingresar un valor mayor que {1}, en el campo {0}")]
        public int CapacityOfPassangers { get => _capacityOfPassangers; set => _capacityOfPassangers = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Condicion del vehiculo")]
        public string Conditions { get => _conditions; set => _conditions = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Uso en KM")]
        //[Range(1, int.MaxValue, ErrorMessage = "Ingresar un valor mayor que {1}, en el campo {0}")]
        public int UseInKM { get => _useInKM; set => _useInKM = value; }

        [Display(Name = "Comentario")]
        public string Comment { get => _comment; set => _comment = value; }

        public bool Status { get => _status; set => _status = value; }
        public string AdquisitionDate { get => _adquisitionDate; set => _adquisitionDate = value; }
    }   
}