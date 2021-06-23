using System;
using System.Threading.Tasks;

namespace Avanade_SubTCSE_Projeto.Doma.Aggregates.Employee.Interfaces.Services
{
    public interface  IEmployeeService
    {
        //Para utilização de threads, e assincronos
        Task<Entities.Employee> AddEmployee(Entities.Employee employee);
    }
}
