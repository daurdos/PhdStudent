#pragma checksum "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dce8af884fb025a1dd916632387a3b4aed1ba803"
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
#line 1 "C:\Users\ENU\source\repos\Phd\Phd\Views\_ViewImports.cshtml"
using Phd;

#line default
#line hidden
#line 2 "C:\Users\ENU\source\repos\Phd\Phd\Views\_ViewImports.cshtml"
using Phd.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dce8af884fb025a1dd916632387a3b4aed1ba803", @"/Views/PhdStudents/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5862ab1a422bd0536ad6439e39af672552c68ee", @"/Views/_ViewImports.cshtml")]
    public class Views_PhdStudents_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Phd.Models.PhdStudent>
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
            BeginContext(30, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(77, 124, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>PhdStudent</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(202, 41, false);
#line 15 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fname));

#line default
#line hidden
            EndContext();
            BeginContext(243, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(287, 37, false);
#line 18 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fname));

#line default
#line hidden
            EndContext();
            BeginContext(324, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(368, 41, false);
#line 21 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Lname));

#line default
#line hidden
            EndContext();
            BeginContext(409, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(453, 37, false);
#line 24 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Lname));

#line default
#line hidden
            EndContext();
            BeginContext(490, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(534, 41, false);
#line 27 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mname));

#line default
#line hidden
            EndContext();
            BeginContext(575, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(619, 37, false);
#line 30 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mname));

#line default
#line hidden
            EndContext();
            BeginContext(656, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(700, 43, false);
#line 33 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MajName));

#line default
#line hidden
            EndContext();
            BeginContext(743, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(787, 39, false);
#line 36 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MajName));

#line default
#line hidden
            EndContext();
            BeginContext(826, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(870, 46, false);
#line 39 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DisNameKaz));

#line default
#line hidden
            EndContext();
            BeginContext(916, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(960, 42, false);
#line 42 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Details.cshtml"
       Write(Html.DisplayFor(model => model.DisNameKaz));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1046, 46, false);
#line 45 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DisNameRus));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1136, 42, false);
#line 48 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Details.cshtml"
       Write(Html.DisplayFor(model => model.DisNameRus));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1222, 46, false);
#line 51 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DisNameEng));

#line default
#line hidden
            EndContext();
            BeginContext(1268, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1312, 42, false);
#line 54 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Details.cshtml"
       Write(Html.DisplayFor(model => model.DisNameEng));

#line default
#line hidden
            EndContext();
            BeginContext(1354, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1398, 47, false);
#line 57 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1445, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1489, 43, false);
#line 60 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1532, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1576, 45, false);
#line 63 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MajorCode));

#line default
#line hidden
            EndContext();
            BeginContext(1621, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1665, 41, false);
#line 66 "C:\Users\ENU\source\repos\Phd\Phd\Views\PhdStudents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MajorCode));

#line default
#line hidden
            EndContext();
            BeginContext(1706, 73, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(1779, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c25e553e14424d8098b3e07dee5099aa", async() => {
                BeginContext(1801, 14, true);
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
            BeginContext(1819, 20, true);
            WriteLiteral(" |\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Phd.Models.PhdStudent> Html { get; private set; }
    }
}
#pragma warning restore 1591
