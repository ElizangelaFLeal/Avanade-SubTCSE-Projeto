using Avanade_SubTCSE_Projeto.Apli.Dtos.Base;
using System;

namespace Avanade_SubTCSE_Projeto.Apli.Dtos.Employee
{
    public class EmployeeDto : BaseDto
    {
        public string PrimeiroNome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime Aniversario { get; set; }

        public bool Ativo { get; set; }

        public decimal Salario { get; set; }

        public EmployeeRole.EmployeeRoleDto Cargo { get; set; }
    }
}
