#pragma checksum "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\GetReportsAsync.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "110ffc5ba5cd7654f819419505678a361fcf8efd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhdStudents_GetReportsAsync), @"mvc.1.0.view", @"/Views/PhdStudents/GetReportsAsync.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PhdStudents/GetReportsAsync.cshtml", typeof(AspNetCore.Views_PhdStudents_GetReportsAsync))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"110ffc5ba5cd7654f819419505678a361fcf8efd", @"/Views/PhdStudents/GetReportsAsync.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5862ab1a422bd0536ad6439e39af672552c68ee", @"/Views/_ViewImports.cshtml")]
    public class Views_PhdStudents_GetReportsAsync : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Phd.Models.StudentReportViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\GetReportsAsync.cshtml"
  
    ViewData["Title"] = "Get reports";

#line default
#line hidden
            BeginContext(93, 124, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>PhdStudent</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(218, 41, false);
#line 15 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\GetReportsAsync.cshtml"
       Write(Html.DisplayNameFor(model => model.FName));

#line default
#line hidden
            EndContext();
            BeginContext(259, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(303, 37, false);
#line 18 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\GetReportsAsync.cshtml"
       Write(Html.DisplayFor(model => model.FName));

#line default
#line hidden
            EndContext();
            BeginContext(340, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(384, 41, false);
#line 21 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\GetReportsAsync.cshtml"
       Write(Html.DisplayNameFor(model => model.LName));

#line default
#line hidden
            EndContext();
            BeginContext(425, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(469, 37, false);
#line 24 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\GetReportsAsync.cshtml"
       Write(Html.DisplayFor(model => model.LName));

#line default
#line hidden
            EndContext();
            BeginContext(506, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(550, 56, false);
#line 27 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\GetReportsAsync.cshtml"
       Write(Html.DisplayNameFor(model => model.PositiveVoteQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(606, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(650, 52, false);
#line 30 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\GetReportsAsync.cshtml"
       Write(Html.DisplayFor(model => model.PositiveVoteQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(702, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(746, 56, false);
#line 33 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\GetReportsAsync.cshtml"
       Write(Html.DisplayNameFor(model => model.NegativeVoteQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(802, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(846, 52, false);
#line 36 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\GetReportsAsync.cshtml"
       Write(Html.DisplayFor(model => model.NegativeVoteQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(898, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(942, 55, false);
#line 39 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\GetReportsAsync.cshtml"
       Write(Html.DisplayNameFor(model => model.OverallVoteQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(997, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1041, 51, false);
#line 42 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\GetReportsAsync.cshtml"
       Write(Html.DisplayFor(model => model.OverallVoteQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 61, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n    </dl>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1153, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3445e7dbeb143868e49dfa1ea42a7f6", async() => {
                BeginContext(1175, 14, true);
                WriteLiteral("Назад к списку");
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
            BeginContext(1193, 12, true);
            WriteLiteral(" |\r\n</div>\r\n");
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