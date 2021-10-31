using System;
using System.ComponentModel.DataAnnotations;

namespace RistoranteMVC.Models
{
    public class Employee
    {
        [Required]
        public Guid EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string JobRole { get; set; }
        public string Gender { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
    }
}
