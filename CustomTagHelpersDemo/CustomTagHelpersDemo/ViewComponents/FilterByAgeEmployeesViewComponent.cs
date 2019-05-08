using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomTagHelpersDemo.ViewComponents
{
    public class FilterByAgeEmployeesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int AgeAbove)
        {
            var emps = EmployeeFactory.GetEmployees();
            var elderEmployees = emps.Where(emp => emp.DOB.Year <= DateTime.Now.AddYears(-AgeAbove).Year);       
            return View(elderEmployees.ToList());
        }

    }
}

/*
 The runtime searches for the view in the following paths:

        /Views/{Controller Name}/Components/{View Component Name}/{View Name}
        /Views/Shared/Components/{View Component Name}/{View Name}
        /Pages/Shared/Components/{View Component Name}/{View Name}

 The default view name for a view component is Default, 
 which means your view file will typically be named Default.cshtml. 
 You can specify a different view name when creating the view component result or when calling the View method.

 We recommend you name the view file Default.cshtml and 
 use the Views/Shared/Components/{View Component Name}/{View Name} path

*/
