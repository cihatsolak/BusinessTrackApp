#pragma checksum "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96d1cca6e3e000212bf9c5891465f8eec438829f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Work_AssignedWork), @"mvc.1.0.view", @"/Areas/Member/Views/Work/AssignedWork.cshtml")]
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
#line 1 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\_ViewImports.cshtml"
using BusinessTrack.Web.Areas.Member.Models.Works;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\_ViewImports.cshtml"
using BusinessTrack.Web.Areas.Member.Models.Reports;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\_ViewImports.cshtml"
using BusinessTrack.Web.Areas.Member.Models.Home.Cards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\_ViewImports.cshtml"
using BusinessTrack.Web.Models.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\_ViewImports.cshtml"
using BusinessTrack.Web.Models.Notifications;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96d1cca6e3e000212bf9c5891465f8eec438829f", @"/Areas/Member/Views/Work/AssignedWork.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"844f5977273afa707e59fc4b8e9f0f5e0dd9a588", @"/Areas/Member/_ViewImports.cshtml")]
    public class Areas_Member_Views_Work_AssignedWork : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AssignedJobListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
  
    ViewData["Title"] = "AssignedWorkOrders";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
 foreach (var Job in Model.AssignedJobs)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card mb-2\">\r\n        <h5 class=\"card-header\">");
#nullable restore
#line 9 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
                           Write(Job.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 11 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
                              Write(Job.ExigencyDefinition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">");
#nullable restore
#line 12 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
                            Write(Job.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            <p>\r\n");
#nullable restore
#line 15 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
                 if (Job.ReportCount > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn btn-warning btn-sm\" data-toggle=\"collapse\"");
            BeginWriteAttribute("href", "\r\n                       href=\"", 521, "\"", 576, 2);
            WriteAttributeValue("", 552, "#reportCollapse", 552, 15, true);
#nullable restore
#line 18 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
WriteAttributeValue("", 567, Job.Id, 567, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 613, "\"", 652, 2);
            WriteAttributeValue("", 629, "reportCollapse", 629, 14, true);
#nullable restore
#line 18 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
WriteAttributeValue("", 643, Job.Id, 643, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        Reporlara Git<i class=\"fas fa-caret-down ml-1 mr-2\"></i>\r\n                        <span class=\"badge badge-info ml-1\">");
#nullable restore
#line 20 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
                                                       Write(Job.ReportCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </a>\r\n");
#nullable restore
#line 22 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96d1cca6e3e000212bf9c5891465f8eec438829f10015", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-plus-circle mr-2\"></i>\r\n                        Rapor Yaz\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-workId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
                                                       WriteLiteral(Job.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["workId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-workId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["workId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <p class=\"lead text-danger font-weight-bold font-italic\">\r\n                    Hiç rapor yazmamışsınız, görevinizdeki ilerlemelerinizden bahsedin.\r\n                </p>\r\n");
#nullable restore
#line 32 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"#\" class=\"btn btn-success btn-sm\" data-toggle=\"modal\" data-target=\"#assignmentCompleteModal\" data-id=\"");
#nullable restore
#line 33 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
                                                                                                                          Write(Job.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    Tamamlandı olarak işaretle\r\n                </a>\r\n                <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 1581, "\"", 1609, 2);
            WriteAttributeValue("", 1586, "reportCollapse", 1586, 14, true);
#nullable restore
#line 36 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
WriteAttributeValue("", 1600, Job.Id, 1600, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96d1cca6e3e000212bf9c5891465f8eec438829f14214", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-plus-circle mr-2\"></i>\r\n                        Rapor Yaz\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-workId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
                                                       WriteLiteral(Job.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["workId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-workId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["workId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <table class=""table table-hover table-bordered table-sm"">
                        <thead>
                            <tr>
                                <th>Tanım</th>
                                <th>Detay</th>
                                <th>İşlem</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 50 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
                             foreach (var report in Job.Reports)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 53 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
                                   Write(report.Definition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 54 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
                                   Write(report.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96d1cca6e3e000212bf9c5891465f8eec438829f18378", async() => {
                WriteLiteral("\r\n                                            <i class=\"far fa-edit mr-2\"></i>\r\n                                            Düzenle\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
                                                                     WriteLiteral(report.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 62 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 68 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Modal -->
<div class=""modal fade"" id=""assignmentCompleteModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""assignmentCompleteModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""assignmentCompleteModalLabel"">Uyarı</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Bu işlemi gerçekleştirmek istediğinizden emin misiniz?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Vazgeç</button>
                <button id=""complete-work"" type=""button"" class=""btn btn-primary"">İşlemi Tamamla</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Javascript", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#assignmentCompleteModal').on('show.bs.modal', function (event) {
                var button = $(event.relatedTarget);
                var btnAssignmentId = button.data('id');

                $(""#complete-work"").click(function () {
                    $.ajax({
                        type: ""GET"",
                        contentType: ""application/json; charset=utf-8"",
                        url: """);
#nullable restore
#line 102 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Work\AssignedWork.cshtml"
                         Write(Url.Action("AssignedCompleted", "Work"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                        data: { assignmentId: btnAssignmentId },
                        success: function (data) {
                            window.location.reload();
                        },
                        error: function (ex) {
                            alert(ex.responseText);
                        }
                    });
                });
            })
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AssignedJobListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
