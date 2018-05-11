using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebAPI
{
    public class EmployeesController : ApiController
    {
        [HttpGet]
        public List<Common.Entities.Employee> test()
        {
            return Business.BLL.Employees.test();
        }
    }
}
