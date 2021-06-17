namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    public class EmployeeRole
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

        public string Id { get; private set; }

        public string RoleName { get; private set; }

        public void AddRole(string roleName)
        {
            RoleName = roleName;
        }
    }
}
