#pragma checksum "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\StudentLessonApp\StudentLessonApp\Views\Student\AssignLesson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b08da5c8dc07fede9257fd83e031b1dfb401f70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_AssignLesson), @"mvc.1.0.view", @"/Views/Student/AssignLesson.cshtml")]
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
#line 1 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\StudentLessonApp\StudentLessonApp\Views\_ViewImports.cshtml"
using StudentLessonApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b08da5c8dc07fede9257fd83e031b1dfb401f70", @"/Views/Student/AssignLesson.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cb0b9b5d94cbab1addbc057f58c2fc442df91b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_AssignLesson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentLessonApp.Models.StudentModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AssignLesson", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h5 class=\"display-4\">Assign Lesson</h5>\r\n<hr />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b08da5c8dc07fede9257fd83e031b1dfb401f703814", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <div class=\"form-group\">\r\n                <label class=\"col-form-label text-danger\">First Name: </label>\r\n                <label class=\"col-form-label\">");
#nullable restore
#line 10 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\StudentLessonApp\StudentLessonApp\Views\Student\AssignLesson.cshtml"
                                         Write(Model.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"col-form-label text-danger\">Last Name: </label>\r\n                <label class=\"col-form-label\">");
#nullable restore
#line 14 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\StudentLessonApp\StudentLessonApp\Views\Student\AssignLesson.cshtml"
                                         Write(Model.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-8\">\r\n");
#nullable restore
#line 18 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\StudentLessonApp\StudentLessonApp\Views\Student\AssignLesson.cshtml"
             for (int i = 0; i < Model.SelectedLessons.Count; i++)
            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 787, "\"", 822, 3);
                WriteAttributeValue("", 794, "SelectedLessons[", 794, 16, true);
#nullable restore
#line 21 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\StudentLessonApp\StudentLessonApp\Views\Student\AssignLesson.cshtml"
WriteAttributeValue("", 810, i, 810, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 812, "].LessonId", 812, 10, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 823, "\"", 865, 1);
#nullable restore
#line 21 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\StudentLessonApp\StudentLessonApp\Views\Student\AssignLesson.cshtml"
WriteAttributeValue("", 831, Model.SelectedLessons[i].LessonId, 831, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 907, "\"", 944, 3);
                WriteAttributeValue("", 914, "SelectedLessons[", 914, 16, true);
#nullable restore
#line 22 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\StudentLessonApp\StudentLessonApp\Views\Student\AssignLesson.cshtml"
WriteAttributeValue("", 930, i, 930, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 932, "].LessonName", 932, 12, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 945, "\"", 989, 1);
#nullable restore
#line 22 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\StudentLessonApp\StudentLessonApp\Views\Student\AssignLesson.cshtml"
WriteAttributeValue("", 953, Model.SelectedLessons[i].LessonName, 953, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 23 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\StudentLessonApp\StudentLessonApp\Views\Student\AssignLesson.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\StudentLessonApp\StudentLessonApp\Views\Student\AssignLesson.cshtml"
             foreach (var item in (List<StudentLessonApp.Models.Entity.Lesson>)ViewBag.Lessons)
            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"form-check\">\r\n                    <input class=\"form-check-input\" type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 1233, "\"", 1255, 1);
#nullable restore
#line 28 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\StudentLessonApp\StudentLessonApp\Views\Student\AssignLesson.cshtml"
WriteAttributeValue("", 1241, item.LessonId, 1241, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"lessonIds\"");
                BeginWriteAttribute("id", " id=\"", 1273, "\"", 1299, 2);
                WriteAttributeValue("", 1278, "course_", 1278, 7, true);
#nullable restore
#line 28 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\StudentLessonApp\StudentLessonApp\Views\Student\AssignLesson.cshtml"
WriteAttributeValue("", 1285, item.LessonId, 1285, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 28 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\StudentLessonApp\StudentLessonApp\Views\Student\AssignLesson.cshtml"
                                                                                                                                   Write(Model.SelectedLessons.Any(x => x.LessonId == item.LessonId) ? "checked" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" />\r\n                    <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\"", 1436, "\"", 1463, 2);
                WriteAttributeValue("", 1442, "course_", 1442, 7, true);
#nullable restore
#line 29 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\StudentLessonApp\StudentLessonApp\Views\Student\AssignLesson.cshtml"
WriteAttributeValue("", 1449, item.LessonId, 1449, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 29 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\StudentLessonApp\StudentLessonApp\Views\Student\AssignLesson.cshtml"
                                                                           Write(item.LessonName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </div>\r\n");
#nullable restore
#line 31 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\StudentLessonApp\StudentLessonApp\Views\Student\AssignLesson.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"submit\" class=\"btn btn-primary\"/>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentLessonApp.Models.StudentModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
