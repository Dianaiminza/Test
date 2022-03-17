using System.Collections.Generic;
using System.Linq;
using Vidly.Models.Repository;

namespace Vidly.Models.DataManager
{
    public class EmployeeManager : IDataRepository<Employee>
    {
        readonly RepositoryContext _repositoryContext;
        public EmployeeManager(RepositoryContext context)
        {
            _repositoryContext = context;
        }
        public IEnumerable<Employee> GetAll()
        {
            return _repositoryContext.Employees.ToList();
        }
        public Employee Get(long id)
        {
            return _repositoryContext.Employees
                  .FirstOrDefault(e => e.EmployeeId == id);
        }
        public void Add(Employee entity)
        {
            _repositoryContext.Employees.Add(entity);
            _repositoryContext.SaveChanges();
        }
        public void Update(Employee employee, Employee entity)
        {
            employee.FirstName = entity.FirstName;
            employee.LastName = entity.LastName;
            employee.Email = entity.Email;
            employee.DateOfBirth = entity.DateOfBirth;
            employee.PhoneNumber = entity.PhoneNumber;
            _repositoryContext.SaveChanges();
        }
        public void Delete(Employee employee)
        {
            _repositoryContext.Employees.Remove(employee);
            _repositoryContext.SaveChanges();
        }
    }
}
