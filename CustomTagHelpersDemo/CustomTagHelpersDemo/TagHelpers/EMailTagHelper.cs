using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomTagHelpersDemo.TagHelpers
{
    public class EMailTagHelper : TagHelper
    {
        private const string _emailDomain = "mail.com";
        //Usage <email mail-to='...'>
        public string MailTo { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var address = MailTo + "@" + _emailDomain;
            output.Attributes.SetAttribute("href", "mailto:" + address);
            output.Content.SetContent(address);
        }
    }
}
