#pragma checksum "C:\Handson\EmployeeAsp\EmployeeAsp\Views\Home\GetEmployeeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fca2604cb552b9bf7eaa8ceab12990b57194298"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetEmployeeList), @"mvc.1.0.view", @"/Views/Home/GetEmployeeList.cshtml")]
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
#nullable restore
#line 1 "C:\Handson\EmployeeAsp\EmployeeAsp\Views\_ViewImports.cshtml"
using EmployeeAsp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Handson\EmployeeAsp\EmployeeAsp\Views\_ViewImports.cshtml"
using EmployeeAsp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fca2604cb552b9bf7eaa8ceab12990b57194298", @"/Views/Home/GetEmployeeList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31a57b79376005dff67616eec7ad83dd36ba162c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetEmployeeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeAsp.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Handson\EmployeeAsp\EmployeeAsp\Views\Home\GetEmployeeList.cshtml"
       ViewData["Title"] = "GetEmployeeList";
        Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>Employee List</h1>\r\n\r\n    <div class=\"Row\">\r\n\r\n\r\n        <span class=\"col-md-4\">\r\n            Name\r\n        </span>\r\n\r\n\r\n        <span class=\"col-md-4\">\r\n            Salary\r\n        </span>\r\n\r\n\r\n\r\n    </div>\r\n\r\n\r\n");
#nullable restore
#line 26 "C:\Handson\EmployeeAsp\EmployeeAsp\Views\Home\GetEmployeeList.cshtml"
     foreach (var emp in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Handson\EmployeeAsp\EmployeeAsp\Views\Home\GetEmployeeList.cshtml"
         if (@emp.IsPermanent)
        {



#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"Row\">\r\n\r\n\r\n                <span class=\"col-md-4\">\r\n                    <mark class=\"alert-dark\">\r\n                        ");
#nullable restore
#line 37 "C:\Handson\EmployeeAsp\EmployeeAsp\Views\Home\GetEmployeeList.cshtml"
                   Write(emp.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </mark>\r\n                </span>\r\n\r\n\r\n                <span class=\"col-md-4\">\r\n                    <mark class=\"alert-dark\">\r\n\r\n                        ");
#nullable restore
#line 45 "C:\Handson\EmployeeAsp\EmployeeAsp\Views\Home\GetEmployeeList.cshtml"
                   Write(emp.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </mark>\r\n                </span>\r\n            </div> ");
#nullable restore
#line 48 "C:\Handson\EmployeeAsp\EmployeeAsp\Views\Home\GetEmployeeList.cshtml"
                   }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"Row\">\r\n\r\n\r\n                <span class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 55 "C:\Handson\EmployeeAsp\EmployeeAsp\Views\Home\GetEmployeeList.cshtml"
               Write(emp.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n\r\n\r\n                <span class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 60 "C:\Handson\EmployeeAsp\EmployeeAsp\Views\Home\GetEmployeeList.cshtml"
               Write(emp.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </div>");
#nullable restore
#line 62 "C:\Handson\EmployeeAsp\EmployeeAsp\Views\Home\GetEmployeeList.cshtml"
                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Handson\EmployeeAsp\EmployeeAsp\Views\Home\GetEmployeeList.cshtml"
                   }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeAsp.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
