#pragma checksum "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e79b9d595e7504dcec9fe67e152a37f72d3b1f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhdStudents_Index), @"mvc.1.0.view", @"/Views/PhdStudents/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PhdStudents/Index.cshtml", typeof(AspNetCore.Views_PhdStudents_Index))]
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
#line 1 "C:\Users\ENU\source\repos\Phd\Phd\Views\_ViewImports.cshtml"
using Phd;

#line default
#line hidden
#line 2 "C:\Users\ENU\source\repos\Phd\Phd\Views\_ViewImports.cshtml"
using Phd.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e79b9d595e7504dcec9fe67e152a37f72d3b1f8", @"/Views/PhdStudents/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5862ab1a422bd0536ad6439e39af672552c68ee", @"/Views/_ViewImports.cshtml")]
    public class Views_PhdStudents_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Phd.Models.PhdStudent>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateVote", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetReportsAsync", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(87, 41, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n\r\n\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(128, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "281b7adc69f5460287c29a0ce98c944f", async() => {
                BeginContext(151, 18, true);
                WriteLiteral("Создать докторанта");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(173, 120, true);
            WriteLiteral("\r\n    </p>\r\n\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(294, 44, false);
#line 20 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(338, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(406, 45, false);
#line 23 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(451, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(519, 46, false);
#line 26 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(565, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(633, 45, false);
#line 29 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MajorCode));

#line default
#line hidden
            EndContext();
            BeginContext(678, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(746, 45, false);
#line 32 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MajorName));

#line default
#line hidden
            EndContext();
            BeginContext(791, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(859, 49, false);
#line 35 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ThesisNameRus));

#line default
#line hidden
            EndContext();
            BeginContext(908, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(976, 49, false);
#line 38 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ThesisComDate));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1093, 54, false);
#line 41 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.EducationDirection));

#line default
#line hidden
            EndContext();
            BeginContext(1147, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1215, 54, false);
#line 44 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.EducationDirection));

#line default
#line hidden
            EndContext();
            BeginContext(1269, 112, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n\r\n\r\n\r\n        <tbody>\r\n");
            EndContext();
#line 53 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
             foreach (var item in Model)
            {
                

#line default
#line hidden
#line 55 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
                 if (item.ThesisComDate == DateTime.Today)
                {

#line default
#line hidden
            BeginContext(1517, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1602, 43, false);
#line 59 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1645, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1737, 44, false);
#line 62 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1781, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1873, 45, false);
#line 65 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.MiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(1918, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2010, 52, false);
#line 68 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Major.MajorCypher));

#line default
#line hidden
            EndContext();
            BeginContext(2062, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2154, 56, false);
#line 71 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Major.MajorCypherName));

#line default
#line hidden
            EndContext();
            BeginContext(2210, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2302, 48, false);
#line 74 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ThesisNameRus));

#line default
#line hidden
            EndContext();
            BeginContext(2350, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2442, 48, false);
#line 77 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ThesisComDate));

#line default
#line hidden
            EndContext();
            BeginContext(2490, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2582, 76, false);
#line 80 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TrainingDirection.TrainingDirectionCypher));

#line default
#line hidden
            EndContext();
            BeginContext(2658, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2750, 80, false);
#line 83 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TrainingDirection.TrainingDirectionCypherName));

#line default
#line hidden
            EndContext();
            BeginContext(2830, 148, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                <td>\r\n                    \r\n                    \r\n                    \r\n");
            EndContext();
#line 90 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
                     if (User.IsInRole("moderator"))
                    {





#line default
#line hidden
            BeginContext(3063, 122, true);
            WriteLiteral("                        <table style=\"width:100%\">\r\n                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(3185, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12b5854503b440718c933d6ae39ca657", async() => {
                BeginContext(3233, 10, true);
                WriteLiteral("Бюллетень|");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 98 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
                                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3247, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3290, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecb1d5d7171c4c84829c42bf599e9180", async() => {
                BeginContext(3341, 11, true);
                WriteLiteral("Голосовать|");
                EndContext();
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
#line 99 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
                                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3356, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3399, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07ed5dc74b71466d9ef9aa7c20caeadd", async() => {
                BeginContext(3455, 11, true);
                WriteLiteral("Результаты|");
                EndContext();
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
#line 100 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
                                                                      WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3470, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3513, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2911cdd1bef841578754f7d44449bd0d", async() => {
                BeginContext(3589, 8, true);
                WriteLiteral("Изменить");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 101 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3601, 48, true);
            WriteLiteral("</td>\r\n</tr>\r\n                        </table>\r\n");
            EndContext();
#line 104 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"

                    }

                    else if (User.IsInRole("user"))
                    {

#line default
#line hidden
            BeginContext(3752, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3776, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0f46beea0014150be5edc41881430aa", async() => {
                BeginContext(3858, 10, true);
                WriteLiteral("Голосовать");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 109 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3872, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 110 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(3897, 97, true);
            WriteLiteral("\r\n                    <!--   <a class=\"btn btn-sm btn-primary\" asp-action=\"Delete\" asp-route-id=\"");
            EndContext();
            BeginContext(3995, 7, false);
#line 112 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
                                                                                          Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4002, 71, true);
            WriteLiteral("\">Удалить</a> -->\r\n                     \r\n\r\n\r\n\r\n                </td>\r\n");
            EndContext();
#line 118 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"


            }

#line default
#line hidden
#line 120 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Index.cshtml"
             
            }

#line default
#line hidden
            BeginContext(4107, 54, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n            </tbody>\r\n        </table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Phd.Models.PhdStudent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
