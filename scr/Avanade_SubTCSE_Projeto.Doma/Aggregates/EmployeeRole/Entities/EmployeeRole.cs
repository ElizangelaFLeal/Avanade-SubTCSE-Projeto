namespace Avanade_SubTCSE_Projeto.Doma.Aggregates.EmployeeRole.Entities
{
    public record EmployeeRole : BaseEntity<string>
    {
        public EmployeeRole(string id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }

        public EmployeeRole(string roleName)
        {
            RoleName = roleName;
        }

        public string RoleName { get; init; }
    }
}
