#pragma checksum "C:\Lab9_2_MVC_Application\Week9_Lab2_MVC_Application\FirstMVCApplication\Views\Employee\Thankyou.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1be7705d5127ddaaf132e6ec3e43bcab766eb76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Thankyou), @"mvc.1.0.view", @"/Views/Employee/Thankyou.cshtml")]
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
#line 1 "C:\Lab9_2_MVC_Application\Week9_Lab2_MVC_Application\FirstMVCApplication\Views\_ViewImports.cshtml"
using FirstMVCApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Lab9_2_MVC_Application\Week9_Lab2_MVC_Application\FirstMVCApplication\Views\_ViewImports.cshtml"
using FirstMVCApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1be7705d5127ddaaf132e6ec3e43bcab766eb76", @"/Views/Employee/Thankyou.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cab95630ffc5b3f9266633c2079a5a8f95a6bd3", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Thankyou : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Lab9_2_MVC_Application\Week9_Lab2_MVC_Application\FirstMVCApplication\Views\Employee\Thankyou.cshtml"
  
    ViewData["Title"] = "Thankyou";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Thankyou ");
#nullable restore
#line 6 "C:\Lab9_2_MVC_Application\Week9_Lab2_MVC_Application\FirstMVCApplication\Views\Employee\Thankyou.cshtml"
        Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "C:\Lab9_2_MVC_Application\Week9_Lab2_MVC_Application\FirstMVCApplication\Views\Employee\Thankyou.cshtml"
                         Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" for your registration.</h1>\r\n<br />\r\n\r\n<h2>Your email is ");
#nullable restore
#line 9 "C:\Lab9_2_MVC_Application\Week9_Lab2_MVC_Application\FirstMVCApplication\Views\Employee\Thankyou.cshtml"
             Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<br />\r\n\r\n<h2>Your password is ");
#nullable restore
#line 12 "C:\Lab9_2_MVC_Application\Week9_Lab2_MVC_Application\FirstMVCApplication\Views\Employee\Thankyou.cshtml"
                Write(Model.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
