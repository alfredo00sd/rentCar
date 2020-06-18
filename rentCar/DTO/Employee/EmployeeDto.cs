using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentCar.DTO.Employee
{
    public class EmployeeDto
    {
        private int employeeId { get; set; }
        private String identificationCard { get; set; }
        private String employeeCard { get; set; }
        private int workSessionId { get; set; }
        [ForeignKey("workSessionId")]
        public WorkSession WorkSession { get; set; }
        private String name { get; set; }
        private String lastName { get; set; }
        private String address { get; set; }
        private String phoneNumber { get; set; }
        private String profession { get; set; }
        private int age { get; set; }
        private DateTime contractStaredAt { get; set; }
        private Decimal monthlyPayment { get; set; }
        private String workPosition { get; set; }
        private int comission { get; set; }
    }
    public class WorkSession
    {
        public int workSessionId { get; set; }
        public string workSessionTimeDescription { get; set; }
        public string workSessionDescription { get; set; }
        public ICollection<EmployeeDto> EmployeeDto { get; set; }
    }
}
