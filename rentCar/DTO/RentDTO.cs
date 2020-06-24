namespace rentCar.DTO
{
    class RentDTO
    {
        //Fields
        int _id;
        int _inspectionId;
        string _employeeInfo;
        int _carId;
        string _carInfo;
        string _customerInfo;
        string _rentDate;
        string _devolutionDate;
        int _montPerDay;
        int _quantityOfDays;
        string _comment;
        bool _state;

        //Methods
        public int Id { get => _id; set => _id = value; }
        public int InspectionId { get => _inspectionId; set => _inspectionId = value; }
        public string EmployeeInfo { get => _employeeInfo; set => _employeeInfo = value; }
        public int CarId { get => _carId; set => _carId = value; }
        public string CarInfo { get => _carInfo; set => _carInfo = value; }
        public string CustomerInfo { get => _customerInfo; set => _customerInfo = value; }
        public string RentDate { get => _rentDate; set => _rentDate = value; }
        public string DevolutionDate { get => _devolutionDate; set => _devolutionDate = value; }
        public int MontPerDay { get => _montPerDay; set => _montPerDay = value; }
        public int QuantityOfDays { get => _quantityOfDays; set => _quantityOfDays = value; }
        public string Comment { get => _comment; set => _comment = value; }
        public bool State { get => _state; set => _state = value; }
    }
}
