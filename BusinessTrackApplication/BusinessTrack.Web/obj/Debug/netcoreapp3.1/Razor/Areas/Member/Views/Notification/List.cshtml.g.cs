#pragma checksum "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Notification\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fda71f571908132ce5bfdc62e64fb96bbdf4e869"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Notification_List), @"mvc.1.0.view", @"/Areas/Member/Views/Notification/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fda71f571908132ce5bfdc62e64fb96bbdf4e869", @"/Areas/Member/Views/Notification/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"844f5977273afa707e59fc4b8e9f0f5e0dd9a588", @"/Areas/Member/_ViewImports.cshtml")]
    public class Areas_Member_Views_Notification_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NotificationListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Read", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Notification\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Areas/Member/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Notification\List.cshtml"
 if (Model.NotificationList.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        Okunmamış bildiriminiz bulunmamaktadır.\r\n    </div>\r\n");
#nullable restore
#line 12 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Notification\List.cshtml"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Notification\List.cshtml"
     foreach (var notification in Model.NotificationList)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-light p-3 my-2\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fda71f571908132ce5bfdc62e64fb96bbdf4e8696907", async() => {
                WriteLiteral("\r\n                <p class=\"lead\">\r\n                    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 556, "\"", 580, 1);
#nullable restore
#line 20 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Notification\List.cshtml"
WriteAttributeValue("", 564, notification.Id, 564, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    ");
#nullable restore
#line 21 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Notification\List.cshtml"
               Write(notification.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-light btn-sm float-right\">Okundu</button>\r\n                </p>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 26 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Notification\List.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\CihatSolak\Desktop\DERS\PROJE GELİŞTİREREK ASP.NET CORE MVC APİ ÖĞRENİN A-Z\BusinessTrackApplication\BusinessTrack.Web\Areas\Member\Views\Notification\List.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NotificationListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591