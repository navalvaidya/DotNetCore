#pragma checksum "C:\Users\ADMIN\source\repos\CrossCutDemo\CrossCutDemo\Views\Shared\_FooterMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3c04c642a97728b4bb18f9b12751455826b5823"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FooterMenu), @"mvc.1.0.view", @"/Views/Shared/_FooterMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_FooterMenu.cshtml", typeof(AspNetCore.Views_Shared__FooterMenu))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\ADMIN\source\repos\CrossCutDemo\CrossCutDemo\Views\_ViewImports.cshtml"
using CrossCutDemo;

#line default
#line hidden
#line 2 "C:\Users\ADMIN\source\repos\CrossCutDemo\CrossCutDemo\Views\_ViewImports.cshtml"
using CrossCutDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3c04c642a97728b4bb18f9b12751455826b5823", @"/Views/Shared/_FooterMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4488774a4d63e1e5d4d4202bea530de3405aba9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FooterMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(137, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "C:\Users\ADMIN\source\repos\CrossCutDemo\CrossCutDemo\Views\Shared\_FooterMenu.cshtml"
   
    foreach (var element in Model)
    {

#line default
#line hidden
            BeginContext(189, 14, true);
            WriteLiteral("        <span>");
            EndContext();
            BeginContext(204, 7, false);
#line 9 "C:\Users\ADMIN\source\repos\CrossCutDemo\CrossCutDemo\Views\Shared\_FooterMenu.cshtml"
         Write(element);

#line default
#line hidden
            EndContext();
            BeginContext(211, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 10 "C:\Users\ADMIN\source\repos\CrossCutDemo\CrossCutDemo\Views\Shared\_FooterMenu.cshtml"
    }

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string[]> Html { get; private set; }
    }
}
#pragma warning restore 1591