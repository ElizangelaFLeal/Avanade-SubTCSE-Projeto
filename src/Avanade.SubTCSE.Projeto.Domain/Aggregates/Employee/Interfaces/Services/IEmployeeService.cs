using System;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Interfaces.Services
{
    public interface  IEmployeeService
    {
        //Para utilizar threads do thread pool
        Task<Entities.Employee> AddEmployee(Entities.Employee employee);
    }
}
