using Avanade_SubTCSE_Projeto.Doma.Aggregates.EmployeeRole.Interfaces.Services;
using System.Threading.Tasks;

namespace Avanade_SubTCSE_Projeto.Doma.Aggregates.EmployeeRole.Services
{
    public interface IEmployeeRoleService
    {
        Task<Entities.EmployeeRole> AddEmployeeRole(Entities.EmployeeRole employeeRole);
    }
}
