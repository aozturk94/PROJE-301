#pragma checksum "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\ListRoute.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "700295744ad79d91a53aa5e15d70376f990e4c25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ListRoute), @"mvc.1.0.view", @"/Views/Admin/ListRoute.cshtml")]
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
#line 1 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"700295744ad79d91a53aa5e15d70376f990e4c25", @"/Views/Admin/ListRoute.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24bc4c41f081dad977726564d7837b3fb8df39dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ListRoute : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RouteTicket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav__link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateRoute", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditRoute", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("DeleteRoute"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n<div class=\"container mt-4\">\n    <div class=\"col-sm-12\">\n        <h1 class=\"h3\">Bilet Kontrol</h1> <hr />\n\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "700295744ad79d91a53aa5e15d70376f990e4c256812", async() => {
                WriteLiteral("Create Route");
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
            WriteLiteral(@"

        <br />
        <table class=""table table table-bordered shadow-sm mt-3"">
            <thead>
                <tr>
                    <th>Route ID</th>
                    <th>Start Location</th>
                    <th>First Station</th>
                    <th>Second Station</th>
                    <th>Third Station</th>
                    <th>End Station</th>
                    <th>Date</th>
                    <th>Time</th>
                    <th>Price</th>
                    <th width=""165"">Action</th>
                </tr>
            <tbody>
");
#nullable restore
#line 25 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\ListRoute.cshtml"
                 if (Model.Routes.Count > 0)
                {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\ListRoute.cshtml"
     foreach (var item in Model.Routes)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>");
#nullable restore
#line 30 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\ListRoute.cshtml"
       Write(item.RouteId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 31 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\ListRoute.cshtml"
       Write(item.StartLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <td>");
#nullable restore
#line 32 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\ListRoute.cshtml"
       Write(item.FirstStation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 33 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\ListRoute.cshtml"
       Write(item.SecondStation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 34 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\ListRoute.cshtml"
       Write(item.ThirdStation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 35 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\ListRoute.cshtml"
       Write(item.EndLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 36 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\ListRoute.cshtml"
       Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 37 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\ListRoute.cshtml"
       Write(item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 38 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\ListRoute.cshtml"
       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\n        <td>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "700295744ad79d91a53aa5e15d70376f990e4c2512161", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\ListRoute.cshtml"
                                        WriteLiteral(item.RouteId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "700295744ad79d91a53aa5e15d70376f990e4c2514467", async() => {
                WriteLiteral("\n                <input type=\"hidden\" name=\"routeId\"");
                BeginWriteAttribute("value", " value=\"", 1455, "\"", 1476, 1);
#nullable restore
#line 42 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\ListRoute.cshtml"
WriteAttributeValue("", 1463, item.RouteId, 1463, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                <button type=\"submit\" class=\"btn btn-danger btn-sm\" style=\"color: white;\">Delete Route</button>\n            ");
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
            WriteLiteral("\n\n        </td>\n    </tr>\n");
#nullable restore
#line 48 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\ListRoute.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\ListRoute.cshtml"
  }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>Sistemde henüz kayıtlı rota yok!</td>\n    </tr>\n");
#nullable restore
#line 54 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\ListRoute.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n\n        </table>\n    </div>\n</div>");
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
