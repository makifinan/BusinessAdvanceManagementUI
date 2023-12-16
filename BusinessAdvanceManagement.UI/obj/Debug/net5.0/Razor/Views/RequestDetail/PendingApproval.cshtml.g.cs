#pragma checksum "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38918dac83e3644fe9dbd72e5762583335bc38bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RequestDetail_PendingApproval), @"mvc.1.0.view", @"/Views/RequestDetail/PendingApproval.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38918dac83e3644fe9dbd72e5762583335bc38bd", @"/Views/RequestDetail/PendingApproval.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"022118d1e81ebe15fb9b12170db2a21bfce78f50", @"/Views/_ViewImports.cshtml")]
    public class Views_RequestDetail_PendingApproval : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusinessAdvanceManagement.Domain.ViewModel.RequestDetail.PendingApprovalPageVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .table-container {
        overflow-x: auto;
    }
</style>
<div class=""container-fluid"">
    <h1>Onay Bekleyen Avans Talepleri</h1>

    <div class=""table-responsive table-container"">
        <table class=""table table-bordered border-dark"">
");
#nullable restore
#line 12 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
             if (Model.RolID == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <thead>
                    <tr>
                        <th>Çalışanın Adı:</th>
                        <th>Unvanı</th>
                        <th>Birimi</th>
                        <th>Talep Durumu</th>
                        <th>Talep Oluşturma Tarihi</th>
                        <th>Talep Tutarı</th>
                        <th>İstenilen Tarih</th>
                        <th>Proje</th>
                        <th>Detay</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 28 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                     foreach (var item in Model.ConfirmAdvanceListDTOs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 31 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                           Write(item.WorkerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 31 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                                            Write(item.WorkerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 32 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                           Write(item.RoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 33 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                           Write(item.UnitName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                           Write(item.StatuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 35 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                           Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 36 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                           Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 37 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                           Write(item.DesiredDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                           Write(item.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </td>
                            <td>
                                <a  class=""btn btn-link"">
                                    <i class=""far fa-hand-point-right""></i>
                                </a>
                            </td>
                        </tr>
");
#nullable restore
#line 45 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n");
#nullable restore
#line 50 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <thead>
                    <tr>
                        <th>Çalışanın Adı:</th>
                        <th>Unvanı</th>
                        <th>Birimi</th>
                        <th>Talep Durumu</th>
                        <th>Talep Oluşturma Tarihi</th>
                        <th>Talep Tutarı</th>
                        <th>İstenilen Tarih</th>
                        <th>Proje</th>
                        <th>Son Onaylayan</th>
                        <th>Son Onaylayan Unvan</th>
                        <th>Son Onaylanma Tarihi</th>
                        <th>Son Onaylanan Tutar</th>
                        <th>Detay</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 71 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                     foreach (var item in Model.ConfirmAdvanceListDTOs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 74 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                       Write(item.WorkerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 74 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                                        Write(item.WorkerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 75 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                       Write(item.RoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 76 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                       Write(item.UnitName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 77 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                       Write(item.StatuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 78 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                       Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 79 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                       Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 80 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                       Write(item.DesiredDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 81 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                       Write(item.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 82 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                       Write(item.EndConfirmWorkerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 82 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                                                  Write(item.EndConfirmWorkerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 83 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                       Write(item.EndConfirmRoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 84 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                       Write(item.EndConfirmDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 85 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
                       Write(item.EndConfirmAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        <td>
                            <a class=""btn btn-link"">
                                <i class=""far fa-hand-point-right""></i>
                            </a>
                        </td>
                    </tr>
");
#nullable restore
#line 92 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n");
#nullable restore
#line 97 "C:\Users\Akif\Desktop\BusinessAdvanceManagement\MVCUI\BusinessAdvanceManagement\BusinessAdvanceManagement.UI\Views\RequestDetail\PendingApproval.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusinessAdvanceManagement.Domain.ViewModel.RequestDetail.PendingApprovalPageVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
