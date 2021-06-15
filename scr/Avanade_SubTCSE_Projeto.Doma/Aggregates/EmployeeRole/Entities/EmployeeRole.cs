namespace Avanade_SubTCSE_Projeto.Doma.Aggregates.EmployeeRole.Entities
{
    public class EmployeeRole
    {
        public EmployeeRole(string id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }

        public string Id { get; private set; }

        public string RoleName { get; init; }
    }
}
