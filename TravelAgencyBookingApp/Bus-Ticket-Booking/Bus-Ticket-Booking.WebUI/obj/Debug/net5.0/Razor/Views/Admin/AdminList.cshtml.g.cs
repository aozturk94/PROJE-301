#pragma checksum "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf8108a76bd540c79b95f7890f139010b8e7e5c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminList), @"mvc.1.0.view", @"/Views/Admin/AdminList.cshtml")]
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
#line 1 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.WebUI.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf8108a76bd540c79b95f7890f139010b8e7e5c3", @"/Views/Admin/AdminList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31bb9bd4c9780feb471d09906480cb4b810a9ee8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RouteTicket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav__link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListRoute", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("CancelTicket"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<div class=""mt-3 container"">
    <div class=""row"">
        <div class=""col-sm-2"">
            <ul class=""text-center"">
                <li class=""nav__item"">
                    <a href=""/admin/role/list"" class=""nav__link"">Roles</a>
                </li>
                <li class=""nav__item mt-4"">
                    <a href=""/admin/user/list"" class=""nav__link"">Users</a>
                </li>
                <li class=""nav__item mt-4"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf8108a76bd540c79b95f7890f139010b8e7e5c37578", async() => {
                WriteLiteral("Routes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n                <li class=\"nav__item mt-4\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf8108a76bd540c79b95f7890f139010b8e7e5c39116", async() => {
                WriteLiteral("ÇIKIŞ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </li>
            </ul>
        </div>

        <div class=""col-md-10"">
            <h1 class=""h3""> Bilet Kontrol</h1> <hr /> <br />
            <table class=""table table table-bordered shadow-sm mt-3"">
                <thead>
                    <tr>
                        <th style=""width:20px;"">BiletID</th>
                        <th style=""width:145px;"">Ad - Soyad</th>
                        <th");
            BeginWriteAttribute("style", " style=\"", 1160, "\"", 1168, 0);
            EndWriteAttribute();
            WriteLiteral(@">Tel</th>
                        <th>Peron Number</th>
                        <th style=""width:25px;"">Başlangıç</th>
                        <th style=""width:25px;"">Bitiş</th>
                        <th style=""width:70px;"">KoltukNo</th>
                        <th style=""width:80px;"">Fiyat</th>
                        <th style=""width:85px;"">GüzergahNo</th>
                        <th style=""width:165px;"">İptal</th>
                    </tr>
                <tbody>
");
#nullable restore
#line 41 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
                     if (Model.Tickets.Count > 0)
                    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
         foreach (var item in Model.Tickets)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 46 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
   Write(item.TicketId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 47 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
   Write(item.CostumerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 47 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
                      Write(item.CosturmerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 48 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
   Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 49 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
   Write(item.PeronNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 50 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
   Write(item.TravelFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 51 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
   Write(item.TravelTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 52 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
   Write(item.SeatNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 53 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n    <td>");
#nullable restore
#line 54 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
   Write(item.RouteId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf8108a76bd540c79b95f7890f139010b8e7e5c315169", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"ticketId\"");
                BeginWriteAttribute("value", " value=\"", 2219, "\"", 2241, 1);
#nullable restore
#line 57 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
WriteAttributeValue("", 2227, item.TicketId, 2227, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <button type=\"submit\" class=\"btn btn-danger btn-md mr-2\" style=\"color: white;\">Bileti İptal Et</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </td>\r\n</tr>");
#nullable restore
#line 62 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
       }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td colspan=\"12\" class=\"text-center\">Sistemde henüz kayıtlı bilet yok!</td>\r\n</tr>");
#nullable restore
#line 67 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n\r\n            </table>\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RouteTicket> Html { get; private set; }
    }
}
#pragma warning restore 1591
