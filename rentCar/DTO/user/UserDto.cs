using rentCar.DTO.Employee;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace rentCar.DTO.user
{
    public class UserDTO
    {
        private int userId { get; set; }
        private int employeeId { get; set; }
        [ForeignKey("employeeId")]
        private EmployeeDTO employee { get; set; }
        private int rolId { get; set; }
        [ForeignKey("rolId")]
        private RolDto RolDTO { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        private String email { get; set; }
        private byte status { get; set; }
        public String rolKey { get; set; }

    }

    class RolDto
    {
        private int rolId { get; set; }
        public String rolKey { get; set; }
        private String description { get; set; }
        private byte status { get; set; }
    }
}
