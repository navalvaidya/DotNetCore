using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomTagHelpersDemo.ViewComponents
{
    public class AllEmployeesViewComponent : ViewComponent
    {
        //View to be added in Shared-->Components-->AllEmployees
        public IViewComponentResult Invoke()
        {
            return View(EmployeeFactory.GetEmployees());
        }
    }
}
