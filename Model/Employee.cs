using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesSystem.Model
{
    class Employee
    {
        public String empId { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String address { get; set; }
        public String birthDate { get; set; }
        public String department { get; set; }

        public Employee(string empId, string firstName, string lastName, string address, string birthDate, string department)
        {
            this.empId = empId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.birthDate = birthDate;
            this.department = department;
        }

    }
}
