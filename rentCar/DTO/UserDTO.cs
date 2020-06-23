namespace rentCar.DTO.user
{
    public class UserDTO
    {
        private int _userId;
        private int _employeeId;
        private string _rolCode;
        private string _identificationCard;
        private string _userName;
        private string _password;
        private bool _status;
        private string _message;

        public int UserId { get => _userId; set => _userId = value; }
        public int EmployeeId { get => _employeeId; set => _employeeId = value; }
        public string RolCode { get => _rolCode; set => _rolCode = value; }
        public string IdentificationCard { get => _identificationCard; set => _identificationCard = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
        public bool Status { get => _status; set => _status = value; }
        public string Message { get => _message; set => _message = value; }
    }
}
