#pragma checksum "C:\Users\ENU\source\repos\Phd_ис\Phd\Phd\Views\PhdStudents\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "542a3e9e0578e6f271fe04069ce765ea893be45b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhdStudents_Details), @"mvc.1.0.view", @"/Views/PhdStudents/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PhdStudents/Details.cshtml", typeof(AspNetCore.Views_PhdStudents_Details))]
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
#line 1 "C:\Users\ENU\source\repos\Phd_ис\Phd\Phd\Views\_ViewImports.cshtml"
using Phd;

#line default
#line hidden
#line 2 "C:\Users\ENU\source\repos\Phd_ис\Phd\Phd\Views\_ViewImports.cshtml"
using Phd.Models;

#line default
#line hidden
#line 3 "C:\Users\ENU\source\repos\Phd_ис\Phd\Phd\Views\_ViewImports.cshtml"
using Phd.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"542a3e9e0578e6f271fe04069ce765ea893be45b", @"/Views/PhdStudents/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc0b2fd827f717c5d0f39ee61a5ca4a8741b80cc", @"/Views/_ViewImports.cshtml")]
    public class Views_PhdStudents_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Phd.Models.StudentReportViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateVote", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("builiten"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(44, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 6 "C:\Users\ENU\source\repos\Phd_ис\Phd\Phd\Views\PhdStudents\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(93, 41, true);
            WriteLiteral("\r\n\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"ru\">\r\n");
            EndContext();
            BeginContext(134, 17, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26e1a666150d4830a4f559f4aea090bf", async() => {
                BeginContext(140, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(151, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(153, 4064, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4559bbc15bf24bb695250ec166d2fb1b", async() => {
                BeginContext(159, 176, true);
                WriteLiteral("\r\n\r\n\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-10 offset-md-1\">\r\n                <div class=\"form-border\">\r\n                    ");
                EndContext();
                BeginContext(335, 3092, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7c2f305bd9d42f3ab6e08548d1bd78f", async() => {
                    BeginContext(383, 253, true);
                    WriteLiteral("\r\n                        <h4 class=\"text-center\">БЮЛЛЕТЕНЬ</h4>\r\n                        <p class=\"text-center\">к заседанию Диссертационного совета по направлению подготовки кадров</p>\r\n                        <center>\r\n                            <em>");
                    EndContext();
                    BeginContext(637, 55, false);
#line 29 "C:\Users\ENU\source\repos\Phd_ис\Phd\Phd\Views\PhdStudents\Details.cshtml"
                           Write(Html.DisplayFor(model => model.TrainingDirectionCypher));

#line default
#line hidden
                    EndContext();
                    BeginContext(692, 117, true);
                    WriteLiteral("  </em> <hr />\r\n                        </center>\r\n                        <center>\r\n                            <em>");
                    EndContext();
                    BeginContext(810, 59, false);
#line 32 "C:\Users\ENU\source\repos\Phd_ис\Phd\Phd\Views\PhdStudents\Details.cshtml"
                           Write(Html.DisplayFor(model => model.TrainingDirectionCypherName));

#line default
#line hidden
                    EndContext();
                    BeginContext(869, 216, true);
                    WriteLiteral("  </em> <hr />\r\n                        </center>\r\n                        <p class=\"text-center\">по защите докторских диссертаций в ЕНУ имени Л.Н. Гумилева</p>\r\n                        <p class=\"text-center\">от <em>");
                    EndContext();
                    BeginContext(1086, 47, false);
#line 35 "C:\Users\ENU\source\repos\Phd_ис\Phd\Phd\Views\PhdStudents\Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.ReleaseDate.Day));

#line default
#line hidden
                    EndContext();
                    BeginContext(1133, 10, true);
                    WriteLiteral("</em>.<em>");
                    EndContext();
                    BeginContext(1144, 49, false);
#line 35 "C:\Users\ENU\source\repos\Phd_ис\Phd\Phd\Views\PhdStudents\Details.cshtml"
                                                                                                           Write(Html.DisplayFor(model => model.ReleaseDate.Month));

#line default
#line hidden
                    EndContext();
                    BeginContext(1193, 10, true);
                    WriteLiteral("</em>.<em>");
                    EndContext();
                    BeginContext(1204, 48, false);
#line 35 "C:\Users\ENU\source\repos\Phd_ис\Phd\Phd\Views\PhdStudents\Details.cshtml"
                                                                                                                                                                       Write(Html.DisplayFor(model => model.ReleaseDate.Year));

#line default
#line hidden
                    EndContext();
                    BeginContext(1252, 575, true);
                    WriteLiteral(@"</em>  <hr /></p>

                        <center>
                            <table border=""1"">
                                <tr>
                                    <th>Фамилия, имя, отчество соискателя</th>
                                    <th>Присуждаемая степень</th>
                                    <th>Результаты голосования</th>
                                </tr>
                                <tr>
                                    <td>
                                        <center>
                                            <em> ");
                    EndContext();
                    BeginContext(1828, 37, false);
#line 47 "C:\Users\ENU\source\repos\Phd_ис\Phd\Phd\Views\PhdStudents\Details.cshtml"
                                            Write(Html.DisplayFor(model => model.LName));

#line default
#line hidden
                    EndContext();
                    BeginContext(1865, 57, true);
                    WriteLiteral(" </em>\r\n                                            <em> ");
                    EndContext();
                    BeginContext(1923, 37, false);
#line 48 "C:\Users\ENU\source\repos\Phd_ис\Phd\Phd\Views\PhdStudents\Details.cshtml"
                                            Write(Html.DisplayFor(model => model.FName));

#line default
#line hidden
                    EndContext();
                    BeginContext(1960, 57, true);
                    WriteLiteral(" </em>\r\n                                            <em> ");
                    EndContext();
                    BeginContext(2018, 37, false);
#line 49 "C:\Users\ENU\source\repos\Phd_ис\Phd\Phd\Views\PhdStudents\Details.cshtml"
                                            Write(Html.DisplayFor(model => model.MName));

#line default
#line hidden
                    EndContext();
                    BeginContext(2055, 394, true);
                    WriteLiteral(@" </em>
                                        </center>

                                    </td>
                                    <td>
                                        <center>
                                            </br>
                                            <p><b>Доктор PhD по специальности</b></p>
                                            <p><b>Шифр: </b>");
                    EndContext();
                    BeginContext(2450, 39, false);
#line 57 "C:\Users\ENU\source\repos\Phd_ис\Phd\Phd\Views\PhdStudents\Details.cshtml"
                                                       Write(Html.DisplayFor(model => model.MajCode));

#line default
#line hidden
                    EndContext();
                    BeginContext(2489, 132, true);
                    WriteLiteral(" </p>\r\n                                            <em></em>\r\n\r\n                                            <p><b>Наименование: </b>");
                    EndContext();
                    BeginContext(2622, 39, false);
#line 60 "C:\Users\ENU\source\repos\Phd_ис\Phd\Phd\Views\PhdStudents\Details.cshtml"
                                                               Write(Html.DisplayFor(model => model.MajName));

#line default
#line hidden
                    EndContext();
                    BeginContext(2661, 452, true);
                    WriteLiteral(@"</p>
                                            <em></em>
                                        </center>

                                    </td>
                                    <td>
                                        <center>
                                            <label><input type=""radio"" name=""dva"" /> За</label> <label><input type=""radio"" name=""dva"" /> Против</label> </br>
                                            ");
                    EndContext();
                    BeginContext(3113, 69, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4711d296ee854a43814608a750c53d88", async() => {
                        BeginContext(3167, 11, true);
                        WriteLiteral("Голосовать ");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#line 68 "C:\Users\ENU\source\repos\Phd_ис\Phd\Phd\Views\PhdStudents\Details.cshtml"
                                                                         WriteLiteral(ViewBag.Id);

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
                    BeginContext(3182, 238, true);
                    WriteLiteral("\r\n                                        </center>\r\n                                    </td>\r\n                                </tr>\r\n                            </table>\r\n                        </center>\r\n\r\n\r\n\r\n\r\n\r\n                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3427, 783, true);
                WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>




    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4217, 115, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Phd.Models.StudentReportViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
