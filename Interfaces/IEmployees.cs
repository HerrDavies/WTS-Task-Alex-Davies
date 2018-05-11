using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IEmployees
    {
        List<Common.Entities.Employee> Employees_Get();
    }
}
