using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteMVC.Application.Features.Employees.Queries.GetAllEmployees
{
    public class GetAllEmployeesQuery : IRequest<List<EmployeeListVm>>
    {
    }
}
