using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repository;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Data.Repositories.Base.EmployeeRole
{
    public class EmployeeRoleRepository 
        : BaseRepository<Domain.Aggregates.Employee.Entities.Employee, string>
        , IEmployeeRoleRepository
    {
        override 
    }
}
