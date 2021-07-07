namespace Avanade.SubTCSE.Projeto.Data.Repositories.Base.Employee
{
    public class EmployeeRepository :
        BaseRepository<Domain.Aggregates.Employee.Entities.Employee, string>
        , IEmployeeRepository
    {

    }
}
