#pragma checksum "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\Shared\Components\WorkerInformation\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b7b7fe4438a6658ba347f9dba5b87ae8a1acad4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WorkerInformation_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WorkerInformation/Default.cshtml")]
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
#line 1 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\_ViewImports.cshtml"
using BusinessAdvanceManagement.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\_ViewImports.cshtml"
using BusinessAdvanceManagement.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b7b7fe4438a6658ba347f9dba5b87ae8a1acad4", @"/Views/Shared/Components/WorkerInformation/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"022118d1e81ebe15fb9b12170db2a21bfce78f50", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WorkerInformation_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusinessAdvanceManagement.Domain.ViewModel.Worker.WorkerLabelVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\Shared\Components\WorkerInformation\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\Shared\Components\WorkerInformation\Default.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <p>");
#nullable restore
#line 9 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\Shared\Components\WorkerInformation\Default.cshtml"
      Write(Model.RoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 9 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\Shared\Components\WorkerInformation\Default.cshtml"
                        Write(Model.WorkerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\Shared\Components\WorkerInformation\Default.cshtml"
                                          Write(Model.WorkerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        \r\n    </div>\r\n");
#nullable restore
#line 12 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\Shared\Components\WorkerInformation\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusinessAdvanceManagement.Domain.ViewModel.Worker.WorkerLabelVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
