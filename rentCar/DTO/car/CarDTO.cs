using System.ComponentModel.DataAnnotations;

namespace RentCarApp.DTO
{
    public class CarDTO
    {
        //Atributos
        int _CarId;
        string _type;
        string _brand;
        string _model;
        string _photoPath;
        string _CarStatus;
        string _fuelType;
        string _QuantityOfFuel; //max 30
        int _CarFabYear;
        string _CarChasisNum; //max 20
        string _CarEngineNum; //max 20
        string _CarLicensePlate; //max 20
        string _CarColor;//max 25
        int _CarNumberOfDoors;
        int _CarCapacityOfPassangers;
        string _CarConditions; //max 15
        string _CarUseInKM;// max 40
        string _CarInvComment; // max 200
       
        // Get <> Set property
        public int CarId { get => _CarId; set => _CarId = value; }
        
        [Display(Name = "Foto del carro")]
        public string CarBase64Photo { get => _photoPath; set => _photoPath = value; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Tipo de carro")]
        public string CarType { get => _type; set => _type = value; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Marca del carro")]
        public string CarBrand { get => _brand; set => _brand = value; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Modelo del carro")]
        public string CarModel { get => _model; set => _model = value; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Range(1, int.MaxValue, ErrorMessage = "Ingresar un valor mayor que {1}, en el campo {0}")]
        [Display(Name = "Año de fabricacion")]
        public int CarFabYear { get => _CarFabYear; set => _CarFabYear = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Numero de chasis")]
        [StringLength(17, MinimumLength = 10, ErrorMessage = "Los caracteres en el campo {0} entre 10 y 17.")]
        //[RegularExpression("[A-HJ-NPR-Z0-9]{13}[0-9]{4}", ErrorMessage = "Numero de chasis invalido.")]
        public string CarChasisNum { get => _CarChasisNum; set => _CarChasisNum = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Numero de motor")]
        public string CarEngineNum { get => _CarEngineNum; set => _CarEngineNum = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Numero de placa")]
        public string CarLicensePlate { get => _CarLicensePlate; set => _CarLicensePlate = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Color del vehiculo")]
        public string CarColor { get => _CarColor; set => _CarColor = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Tipo de combustible")]
        public string FuelType { get => _fuelType; set => _fuelType = value; }

        [Display(Name = "Cantidad de combustible")]
        public string QuantityOfFuel { get => _QuantityOfFuel; set => _QuantityOfFuel = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Range(1, int.MaxValue, ErrorMessage = "Ingresar un valor mayor que {1}, en el campo {0}")]
        [Display(Name = "Numero de puertas")]
        public int CarNumberOfDoors { get => _CarNumberOfDoors; set => _CarNumberOfDoors = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Numero de pasajeros")]
        [Range(1, int.MaxValue, ErrorMessage = "Ingresar un valor mayor que {1}, en el campo {0}")]
        public int CarCapacityOfPassangers { get => _CarCapacityOfPassangers; set => _CarCapacityOfPassangers = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Condicion del vehiculo")]
        public string CarConditions { get => _CarConditions; set => _CarConditions = value; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Uso en KM")]
        //[Range(1, int.MaxValue, ErrorMessage = "Ingresar un valor mayor que {1}, en el campo {0}")]
        public string CarUseInKM { get => _CarUseInKM; set => _CarUseInKM = value; }

        public string CarStatus { get => _CarStatus; set => _CarStatus = value; }
                
        [Display(Name = "Comentario")]
        public string CarInvComment { get => _CarInvComment; set => _CarInvComment = value; }       
    }

    public class CarModelDTO
    {
        private int _modelId;
        private string _modelDescription;
        private string _parentBrand;
        private int _parentBrandId;
        private string status;

        [Display(Name = "#")]
        public int ModelId { get => _modelId; set => _modelId = value; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Modelo")]
        public string ModelDescription { get => _modelDescription; set => _modelDescription = value; }
        [Display(Name = "Marca")]
        public string ParentBrand { get => _parentBrand; set => _parentBrand = value; }
        public int ParentBrandId { get => _parentBrandId; set => _parentBrandId = value; }
        public string Status { get => status; set => status = value; }
    }

    public class CarBrandDTO 
    {
        private int _brandId; 
        private string _brandDescription;
        private string _brandStatus;

        public int BrandId { get => _brandId; set => _brandId = value; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Marca")] 
        public string BrandDescription { get => _brandDescription; set => _brandDescription = value; }
        public string BrandStatus { get => _brandStatus; set => _brandStatus = value; }
    }

    public class CarTypeDTO
    {
        private int _carTypeId; 
        private string _carTypeDescription;
        private string _carTypeStatus;

        public int CarTypeId { get => _carTypeId; set => _carTypeId = value; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Tipo de carro")] 
        public string CarTypeDescription { get => _carTypeDescription; set => _carTypeDescription = value; }
        public string CarTypeStatus { get => _carTypeStatus; set => _carTypeStatus = value; }
    }

    public class CarFuelTypeDTO 
    {
        private int _fuelTypeId;
        private string _fuelType;
        private string _fuelStatus;
        
        public int FuelTypeId { get => _fuelTypeId; set => _fuelTypeId = value; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Se requiere completar campo {0}")]
        [Display(Name = "Tipo de combustible")] 
        public string FuelType { get => _fuelType; set => _fuelType = value; }
        public string FuelStatus { get => _fuelStatus; set => _fuelStatus = value; }
    }
}