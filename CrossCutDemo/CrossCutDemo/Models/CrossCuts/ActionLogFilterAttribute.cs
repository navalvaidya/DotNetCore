using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrossCutDemo.Models.CrossCuts
{
    public class ActionLogFilterAttribute : ActionFilterAttribute//, IActionFilter
    {
        LoggerServiceDBContext ctx = new LoggerServiceDBContext();
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            TblActionLogs logEntry = new TblActionLogs
            {
                //Id is autogen
                TimeStamp = DateTime.Now,
                ActionName = context.ActionDescriptor.RouteValues["action"].ToString(),
                ControllerName = context.ActionDescriptor.RouteValues["controller"].ToString(),
                Ipaddress = context.HttpContext.Connection.RemoteIpAddress.ToString()
            };
            //Add the object
            ctx.TblActionLogs.Add(logEntry);
            ctx.SaveChanges();
            base.OnActionExecuting(context);
        }
    }
}
