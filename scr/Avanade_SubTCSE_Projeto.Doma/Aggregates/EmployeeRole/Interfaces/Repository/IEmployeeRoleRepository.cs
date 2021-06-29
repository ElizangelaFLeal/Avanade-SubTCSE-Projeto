using System.Threading.Tasks;

namespace Avanade_SubTCSE_Projeto.Doma.Aggregates.EmployeeRole.Interfaces.Repository
{
    public interface IEmployeeRoleRepository
    {
        Task<Entities.EmployeeRole> AddEmployeeRole(Entities.EmployeeRole employeeRole);
    }
}
