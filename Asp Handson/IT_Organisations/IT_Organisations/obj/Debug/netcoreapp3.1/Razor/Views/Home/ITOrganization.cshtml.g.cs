#pragma checksum "C:\Handson\IT_Organisations\IT_Organisations\Views\Home\ITOrganization.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b29e065735d612ba64448f2f0432bfac9a9b6c98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ITOrganization), @"mvc.1.0.view", @"/Views/Home/ITOrganization.cshtml")]
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
#line 1 "C:\Handson\IT_Organisations\IT_Organisations\Views\_ViewImports.cshtml"
using IT_Organisations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Handson\IT_Organisations\IT_Organisations\Views\_ViewImports.cshtml"
using IT_Organisations.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b29e065735d612ba64448f2f0432bfac9a9b6c98", @"/Views/Home/ITOrganization.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b566b91ce07a2084ea36fc55ba1defa5d7190410", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ITOrganization : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Handson\IT_Organisations\IT_Organisations\Views\Home\ITOrganization.cshtml"
   ViewData["Title"] = "ITOrganizations";
Layout = "~/Views/Shared/_Layout.cshtml";
List<string> organizations = new List<string> { "Amazon", " TCS", "Google", "CTS www.cognizant.com", "Microsoft www. microsoft.com" }; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ITOrganizations in Hyderabad</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Handson\IT_Organisations\IT_Organisations\Views\Home\ITOrganization.cshtml"
 foreach (var company in organizations)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <span>\r\n");
#nullable restore
#line 12 "C:\Handson\IT_Organisations\IT_Organisations\Views\Home\ITOrganization.cshtml"
      if (company == "Amazon")
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <b>");
#nullable restore
#line 14 "C:\Handson\IT_Organisations\IT_Organisations\Views\Home\ITOrganization.cshtml"
    Write(company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> \r\n");
#nullable restore
#line 15 "C:\Handson\IT_Organisations\IT_Organisations\Views\Home\ITOrganization.cshtml"
     }
     else
    {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Handson\IT_Organisations\IT_Organisations\Views\Home\ITOrganization.cshtml"
Write(company);

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Handson\IT_Organisations\IT_Organisations\Views\Home\ITOrganization.cshtml"
            
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </span>\r\n</div>");
#nullable restore
#line 21 "C:\Handson\IT_Organisations\IT_Organisations\Views\Home\ITOrganization.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591