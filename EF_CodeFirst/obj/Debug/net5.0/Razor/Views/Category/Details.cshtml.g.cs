#pragma checksum "C:\Users\Web ve Mobil Öğle.DESKTOP-MTU4EKB\Desktop\PROJELER\Ahmet-OZTURK\EF_CodeFirst\Views\Category\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93ab32354d6c8057f7683eb6dbc14f7ebf3a5382"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Details), @"mvc.1.0.view", @"/Views/Category/Details.cshtml")]
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
#line 1 "C:\Users\Web ve Mobil Öğle.DESKTOP-MTU4EKB\Desktop\PROJELER\Ahmet-OZTURK\EF_CodeFirst\Views\_ViewImports.cshtml"
using EF_Codefirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Web ve Mobil Öğle.DESKTOP-MTU4EKB\Desktop\PROJELER\Ahmet-OZTURK\EF_CodeFirst\Views\_ViewImports.cshtml"
using EF_Codefirst.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Web ve Mobil Öğle.DESKTOP-MTU4EKB\Desktop\PROJELER\Ahmet-OZTURK\EF_CodeFirst\Views\_ViewImports.cshtml"
using EF_CodeFirst.Models.Context;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Web ve Mobil Öğle.DESKTOP-MTU4EKB\Desktop\PROJELER\Ahmet-OZTURK\EF_CodeFirst\Views\_ViewImports.cshtml"
using EF_CodeFirst.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93ab32354d6c8057f7683eb6dbc14f7ebf3a5382", @"/Views/Category/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92d1a62ed322572dc8808c6cb7a0b06510b4d167", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EF_CodeFirst.Models.Entities.Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Web ve Mobil Öğle.DESKTOP-MTU4EKB\Desktop\PROJELER\Ahmet-OZTURK\EF_CodeFirst\Views\Category\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"diplay-4\">");
#nullable restore
#line 7 "C:\Users\Web ve Mobil Öğle.DESKTOP-MTU4EKB\Desktop\PROJELER\Ahmet-OZTURK\EF_CodeFirst\Views\Category\Details.cshtml"
                Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Details</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-sm-3\">\r\n        #\r\n    </div>\r\n    <div class=\"col-sm-5\">\r\n        ");
#nullable restore
#line 13 "C:\Users\Web ve Mobil Öğle.DESKTOP-MTU4EKB\Desktop\PROJELER\Ahmet-OZTURK\EF_CodeFirst\Views\Category\Details.cshtml"
   Write(Model.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-sm-3\">\r\n        Name:\r\n    </div>\r\n    <div class=\"col-sm-5\">\r\n        ");
#nullable restore
#line 21 "C:\Users\Web ve Mobil Öğle.DESKTOP-MTU4EKB\Desktop\PROJELER\Ahmet-OZTURK\EF_CodeFirst\Views\Category\Details.cshtml"
   Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-sm-3\">\r\n        Description\r\n    </div>\r\n    <div class=\"col-sm-5\">\r\n        ");
#nullable restore
#line 29 "C:\Users\Web ve Mobil Öğle.DESKTOP-MTU4EKB\Desktop\PROJELER\Ahmet-OZTURK\EF_CodeFirst\Views\Category\Details.cshtml"
   Write(Model.CategoryDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93ab32354d6c8057f7683eb6dbc14f7ebf3a53826161", async() => {
                WriteLiteral("Back to Categories Page");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EF_CodeFirst.Models.Entities.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
