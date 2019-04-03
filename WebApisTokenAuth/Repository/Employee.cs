using System.Linq;
using WebApisTokenAuth.Models;

namespace WebApisTokenAuth.Repository
{
    public class Employees
    {
        //Get employees data from the Employees table in your database
        public dynamic GetEmployees()
        {
            return SimulationBase.Employees().AsEnumerable().Select(x => new { x.EmloyeeName, Designation = x.Designation, x.Address, x.Salary }).ToList();

        }
    }
}