using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteMVC.Application.Features.Employees.Queries.GetAllEmployees
{
    public class EmployeeListVm
    {
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobRole { get; set; }
    }
}
