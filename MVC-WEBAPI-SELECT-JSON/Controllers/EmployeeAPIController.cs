using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVC_WEBAPI_SELECT_JSON.Models;
namespace MVC_WEBAPI_SELECT_JSON.Controllers
{
    public class EmployeeAPIController : ApiController
    {
        EmployeeEntity context = new EmployeeEntity();
        public IHttpActionResult GetEmployee()
        {
            var model = context.TABLE_EMPLOYEE.ToList();
            return Ok(model);
        }
    }
}
