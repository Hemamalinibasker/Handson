#pragma checksum "C:\testingdemos\Asplog4net\Asplog4net\Views\Shared\CustomError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b06038b4d4e88b41306818f5393eb65198eeb7f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_CustomError), @"mvc.1.0.view", @"/Views/Shared/CustomError.cshtml")]
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
#line 1 "C:\testingdemos\Asplog4net\Asplog4net\Views\_ViewImports.cshtml"
using Asplog4net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\testingdemos\Asplog4net\Asplog4net\Views\_ViewImports.cshtml"
using Asplog4net.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b06038b4d4e88b41306818f5393eb65198eeb7f9", @"/Views/Shared/CustomError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"953c8c5bef5047ebebd87f7f2fd36233288e6473", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_CustomError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\testingdemos\Asplog4net\Asplog4net\Views\Shared\CustomError.cshtml"
   ViewData["Title"] = "CustomError";
    Exception ex = ViewData["HandleException"] as Exception;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\testingdemos\Asplog4net\Asplog4net\Views\Shared\CustomError.cshtml"
Write(ex.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div>");
#nullable restore
#line 6 "C:\testingdemos\Asplog4net\Asplog4net\Views\Shared\CustomError.cshtml"
Write(ex.StackTrace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
