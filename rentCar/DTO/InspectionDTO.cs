
namespace rentCar.DTO
{
    public class InspectionDTO
    {
        private int _id;
        private int _carId;
        private string _carDetails;
        private int customerId;
        private string _customerDetails;
        private string _quantityOfFuel;
        private bool _hasRefaction;
        private bool _hasScratches;
        private bool _hasCat;
        private bool _wheel1Check;
        private bool _wheel2Check;
        private bool _wheel3Check;
        private bool _wheel4Check;
        private string _dateOfInspection;
        private int _inspectorId;
        private string _inspector;
        private string _comment;
        private bool _state;

        public int Id { get => _id; set => _id = value; }
        public int CarId { get => _carId; set => _carId = value; }
        public string CarDetails { get => _carDetails; set => _carDetails = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public string CustomerDetails { get => _customerDetails; set => _customerDetails = value; }
        public string QuantityOfFuel { get => _quantityOfFuel; set => _quantityOfFuel = value; }
        public bool HasRefaction { get => _hasRefaction; set => _hasRefaction = value; }
        public bool HasScratches { get => _hasScratches; set => _hasScratches = value; }
        public bool HasCat { get => _hasCat; set => _hasCat = value; }
        public bool Wheel1Check { get => _wheel1Check; set => _wheel1Check = value; }
        public bool Wheel2Check { get => _wheel2Check; set => _wheel2Check = value; }
        public bool Wheel3Check { get => _wheel3Check; set => _wheel3Check = value; }
        public bool Wheel4Check { get => _wheel4Check; set => _wheel4Check = value; }
        public string DateOfInspection { get => _dateOfInspection; set => _dateOfInspection = value; }
        public int InspectorId { get => _inspectorId; set => _inspectorId = value; }
        public string Inspector { get => _inspector; set => _inspector = value; }
        public string Comment { get => _comment; set => _comment = value; }
        public bool State { get => _state; set => _state = value; }
    }
}
