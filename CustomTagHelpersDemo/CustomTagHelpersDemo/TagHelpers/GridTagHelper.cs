using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CustomTagHelpersDemo.TagHelpers
{
    //[HtmlTargetElement(TagStructure = TagStructure.WithoutEndTag)]
    public class GridTagHelper : TagHelper
    {
        public List<Employee> ListToRender { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //ListToRender = EmployeeFactory.GetEmployees();
            output.TagName = "table";
            output.Attributes.SetAttribute("border", "1");
            var strContent = "<tr><th>Emp Id</th><th>Emp Name</th><th>Emp DOB</th></tr>";

            foreach(var emp in ListToRender)
            {
                strContent += "<tr><td>" + emp.Id + "</td><td>" + emp.Name + "</td><td>" +
                    emp.DOB.ToShortDateString() + "</td></tr>";
            }

            output.Content.SetHtmlContent(strContent);
        }

    }
}
