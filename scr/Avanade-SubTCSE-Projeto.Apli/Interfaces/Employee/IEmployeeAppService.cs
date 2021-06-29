using Avanade_SubTCSE_Projeto.Apli.Dtos.Employee;
using System.Threading.Tasks;

namespace Avanade_SubTCSE_Projeto.Apli.Interfaces.Employee
{
    interface IEmployeeAppService
    {
        Task<EmployeeDto> AddEmployee(EmployeeDto employeeDto);
    }
}
