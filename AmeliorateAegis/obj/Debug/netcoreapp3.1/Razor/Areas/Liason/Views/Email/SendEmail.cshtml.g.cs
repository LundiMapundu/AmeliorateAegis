#pragma checksum "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Liason\Views\Email\SendEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "106c0f023e4ac4f83c078bdb3e1951c84ac72faf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Liason_Views_Email_SendEmail), @"mvc.1.0.view", @"/Areas/Liason/Views/Email/SendEmail.cshtml")]
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
#line 1 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Liason\Views\_ViewImports.cshtml"
using AmeliorateAegis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Liason\Views\_ViewImports.cshtml"
using AmeliorateAegis.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"106c0f023e4ac4f83c078bdb3e1951c84ac72faf", @"/Areas/Liason/Views/Email/SendEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55beccb9a00c1b368d959213ab0bacf2b3db22f4", @"/Areas/Liason/Views/_ViewImports.cshtml")]
    public class Areas_Liason_Views_Email_SendEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RegionalManager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Regionals", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary rounded-0 text-uppercase"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Liason\Views\Email\SendEmail.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<fieldset>\r\n    <legend>\r\n        Send Email\r\n    </legend>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Liason\Views\Email\SendEmail.cshtml"
     if (ViewBag.msg != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success\">");
#nullable restore
#line 12 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Liason\Views\Email\SendEmail.cshtml"
                                    Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 13 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Liason\Views\Email\SendEmail.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Liason\Views\Email\SendEmail.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Liason\Views\Email\SendEmail.cshtml"
   Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>From: </p>\r\n        <p>");
#nullable restore
#line 19 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Liason\Views\Email\SendEmail.cshtml"
      Write(Html.TextBoxFor(m => m.From));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>To: </p>\r\n        <p>");
#nullable restore
#line 21 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Liason\Views\Email\SendEmail.cshtml"
      Write(Html.TextBoxFor(m => m.To));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Subject: </p>\r\n        <p>");
#nullable restore
#line 23 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Liason\Views\Email\SendEmail.cshtml"
      Write(Html.TextBoxFor(m => m.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Body: </p>\r\n        <p>");
#nullable restore
#line 25 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Liason\Views\Email\SendEmail.cshtml"
      Write(Html.TextAreaFor(m => m.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <input type=\"submit\" value=\"Send\" />\r\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "106c0f023e4ac4f83c078bdb3e1951c84ac72faf7095", async() => {
                WriteLiteral("<i class=\"fas fa-fast-backward\"></i> Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\s217161227\Desktop\AmeliorateAegis\AmeliorateAegis\Areas\Liason\Views\Email\SendEmail.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</fieldset>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
