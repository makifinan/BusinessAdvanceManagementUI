#pragma checksum "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\Shared\_sidebarpartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8ab02ab53a7746af4e1da7648cb81a6e63a99ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__sidebarpartial), @"mvc.1.0.view", @"/Views/Shared/_sidebarpartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8ab02ab53a7746af4e1da7648cb81a6e63a99ae", @"/Views/Shared/_sidebarpartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"022118d1e81ebe15fb9b12170db2a21bfce78f50", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__sidebarpartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BusinessAdvanceManagement.Domain.DTOs.PageRole.PageRoleListDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Dashboard/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d8ab02ab53a7746af4e1da7648cb81a6e63a99ae4129", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\Shared\_sidebarpartial.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"#\" class=\"list-group-item list-group-item-action bg-transparent second-text active\">\r\n        <i class=\"fas fa-tachometer-alt me-2\"></i>");
#nullable restore
#line 6 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\Shared\_sidebarpartial.cshtml"
                                             Write(item.PageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </a>\r\n");
#nullable restore
#line 8 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\Shared\_sidebarpartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BusinessAdvanceManagement.Domain.DTOs.PageRole.PageRoleListDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
