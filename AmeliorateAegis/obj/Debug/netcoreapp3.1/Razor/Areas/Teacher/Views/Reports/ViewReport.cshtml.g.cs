#pragma checksum "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91f1e5e656c52f053e4fa161a523c3ba3a89d443"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Teacher_Views_Reports_ViewReport), @"mvc.1.0.view", @"/Areas/Teacher/Views/Reports/ViewReport.cshtml")]
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
#line 1 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\_ViewImports.cshtml"
using AmeliorateAegis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\_ViewImports.cshtml"
using AmeliorateAegis.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91f1e5e656c52f053e4fa161a523c3ba3a89d443", @"/Areas/Teacher/Views/Reports/ViewReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55beccb9a00c1b368d959213ab0bacf2b3db22f4", @"/Areas/Teacher/Views/_ViewImports.cshtml")]
    public class Areas_Teacher_Views_Reports_ViewReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AmeliorateAegis.Models.ViewModels.ReportViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
  
    ViewData["Title"] = "View Report";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-10 offset-1"">
            <div class=""card"" style=""min-height: 100vh"">
                <div class=""card-body p-5"">
                    <div class=""row"">
                        <div class=""col-lg-6 col-sm-12"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "91f1e5e656c52f053e4fa161a523c3ba3a89d4434982", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <h4>Visionaries Center</h4>
                        </div>
                        <div class=""col-lg-6 col-sm-12 text-lg-right"">
                            <p>
                                123 Some Street<br />
                                Mount Croix<br />
                                Port Elizabeth<br />
                                6001
                            </p>
                        </div>
                    </div>

                    <div class=""d-flex justify-content-between align-items-center"">
                        <div>
                            <h5>");
#nullable restore
#line 29 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                           Write(Model.Pupil.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 29 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                                                  Write(Model.Pupil.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        </div>\r\n                        <div>\r\n");
#nullable restore
#line 32 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                             if (Model.TotalAverage < 50)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h5 class=\"text-danger\">Total Average: ");
#nullable restore
#line 34 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                                                                  Write(Model.TotalAverage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 35 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h5 class=\"text-success\">Total Average: ");
#nullable restore
#line 38 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                                                                   Write(Model.TotalAverage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 39 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n");
#nullable restore
#line 44 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                     if (Model.Pupil.Reports.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""row mt-5"">
                            <div class=""col-lg-3 col-md-6 col-sm-12"">
                                <h4 class=""bg-light p-2"">Term 1</h4>
                                <div class=""table-responsive"">
                                    <table class=""table table-hover"">
");
#nullable restore
#line 51 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                                         foreach (var item in Model.Term1)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 54 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                                               Write(Html.DisplayFor(model => item.Program.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 55 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                                               Write(Html.DisplayFor(model => item.Mark));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </table>
                                </div>
                            </div>
                            <div class=""col-lg-3 col-md-6 col-sm-12"">
                                <h4 class=""bg-light p-2"">Term 2</h4>
                                <div class=""table-responsive"">
                                    <table class=""table table-hover"">
");
#nullable restore
#line 65 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                                         foreach (var item in Model.Term2)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 68 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                                               Write(Html.DisplayFor(model => item.Program.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 69 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                                               Write(Html.DisplayFor(model => item.Mark));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 71 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </table>
                                </div>
                            </div>
                            <div class=""col-lg-3 col-md-6 col-sm-12"">
                                <h4 class=""bg-light p-2"">Term 3</h4>
                                <div class=""table-responsive"">
                                    <table class=""table table-hover"">
");
#nullable restore
#line 79 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                                         foreach (var item in Model.Term3)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 82 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                                               Write(Html.DisplayFor(model => item.Program.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 83 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                                               Write(Html.DisplayFor(model => item.Mark));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 85 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </table>
                                </div>
                            </div>
                            <div class=""col-lg-3 col-md-6 col-sm-12"">
                                <h4 class=""bg-light p-2"">Term 4</h4>
                                <div class=""table-responsive"">
                                    <table class=""table table-hover"">
");
#nullable restore
#line 93 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                                         foreach (var item in Model.Term4)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 96 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                                               Write(Html.DisplayFor(model => item.Program.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 97 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                                               Write(Html.DisplayFor(model => item.Mark));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 99 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </table>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 104 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""row mt-5"">
                            <div class=""col-12 text-center"">
                                <i class=""fa fa-hourglass fa-5x text-primary""></i>
                                <h5>No Marks Recorded</h5>
                            </div>
                        </div>
");
#nullable restore
#line 113 "C:\Users\Lundi Mapundu\source\repos\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Reports\ViewReport.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AmeliorateAegis.Models.ViewModels.ReportViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
