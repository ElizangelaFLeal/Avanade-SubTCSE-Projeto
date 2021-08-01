using Avanade.SubTCSE.Projeto.Application.Dtos.Employee;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.Interfaces.Employee
{
    interface IEmployeeAppService
    {
        Task<EmployeeDto> AddEmployeeAsync(EmployeeDto employeeDto);
    }
}
