#pragma checksum "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Pupil\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29c4f7fe044459f728f2e65b44d47af0fe10f535"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Teacher_Views_Pupil_Index), @"mvc.1.0.view", @"/Areas/Teacher/Views/Pupil/Index.cshtml")]
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
#line 1 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\_ViewImports.cshtml"
using AmeliorateAegis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\_ViewImports.cshtml"
using AmeliorateAegis.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29c4f7fe044459f728f2e65b44d47af0fe10f535", @"/Areas/Teacher/Views/Pupil/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55beccb9a00c1b368d959213ab0bacf2b3db22f4", @"/Areas/Teacher/Views/_ViewImports.cshtml")]
    public class Areas_Teacher_Views_Pupil_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pupil>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateLesson", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Pupil\Index.cshtml"
  
    ViewData["Title"] = "Pupils";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card card-plain"">
                <div class=""card-header card-header-primary"">
                    <h4 class=""card-title mt-0""> Student List</h4>
                    <p class=""card-category""> Detail are listed below</p>
                </div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table table-hover"">
                            <tr");
            BeginWriteAttribute("class", " class=\"", 616, "\"", 624, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <th>
                                    ID
                                </th>
                                <th>
                                    First Name
                                </th>
                                <th>
                                    Last Surname
                                </th>
                                <th>
                                    Date Of Birth
                                </th>
                                <th>Actions</th>
                            </tr>
                            <tbody>
");
#nullable restore
#line 34 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Pupil\Index.cshtml"
                                 foreach (var item in Model)
                                {
                                    var dob = item.DoB.ToShortDateString();

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 39 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Pupil\Index.cshtml"
                                       Write(Html.DisplayFor(model => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 42 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Pupil\Index.cshtml"
                                       Write(Html.DisplayFor(model => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 45 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Pupil\Index.cshtml"
                                       Write(Html.DisplayFor(model => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n\r\n                                            ");
#nullable restore
#line 49 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Pupil\Index.cshtml"
                                       Write(Html.DisplayFor(model => dob));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                        </td>
                                        <td>
                                            <a href=""javascript:void(0)"" data-toggle=""modal"" data-target=""#exampleModal"">
                                                <i class=""material-icons text-success"">edit</i>
                                            </a>

                                            <a href=""javascript:void(0)"">
                                                <i class=""material-icons text-danger"">delete</i>
                                            </a>
                                        </td>
                                    </tr>
");
#nullable restore
#line 62 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Teacher\Views\Pupil\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Edit Pupil</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29c4f7fe044459f728f2e65b44d47af0fe10f5359405", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">First Name</label>
                                <input type=""text"" class=""form-control"" />
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-12"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Last Name</label>
                                <input type=""text"" class=""form-control"" />
                            </div>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-12"">
                            <div class=""form-group"">
                                <div class=""in");
                WriteLiteral(@"put-group"">
                                    <label class=""bmd-label-floating"">Date Of Birth</label>
                                    <input type=""text"" class=""form-control"" id=""selectedStartTime"" name=""startTime"" />
                                    <div class=""input-group-append"">
                                        <div class=""input-group-text""><i class=""fa fa-clock-o""></i></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-primary"">Save</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pupil>> Html { get; private set; }
    }
}
#pragma warning restore 1591
