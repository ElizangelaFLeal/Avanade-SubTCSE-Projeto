using Avanade_SubTCSE_Projeto.Apli.Dtos.EmployeeRole;
using System.Threading.Tasks;

namespace Avanade_SubTCSE_Projeto.Apli.Interfaces.EmployeeRole
{
    public interface IEmployeeRoleAppService
    {
        Task<EmployeeRoleDto> AddEmployeeRole(EmployeeRoleDto employeeRoleDto);
    }
}
