#pragma checksum "C:\Users\user\source\repos\WebApplicationLearning\WebApplicationLearning\Views\Services\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a19210616951a4367c4b91c2af91780aab3ad1ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Show), @"mvc.1.0.view", @"/Views/Services/Show.cshtml")]
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
#line 2 "C:\Users\user\source\repos\WebApplicationLearning\WebApplicationLearning\Views\_ViewImports.cshtml"
using WebApplicationLearning.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\WebApplicationLearning\WebApplicationLearning\Views\_ViewImports.cshtml"
using WebApplicationLearning.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\source\repos\WebApplicationLearning\WebApplicationLearning\Views\_ViewImports.cshtml"
using WebApplicationLearning.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\source\repos\WebApplicationLearning\WebApplicationLearning\Views\_ViewImports.cshtml"
using WebApplicationLearning.Models.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a19210616951a4367c4b91c2af91780aab3ad1ce", @"/Views/Services/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e4326289c94cba032f0bccfdefce8e624dcf24a", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServiceItem>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\user\source\repos\WebApplicationLearning\WebApplicationLearning\Views\Services\Show.cshtml"
  
	ViewBag.Title = Model.MetaTitle;
	ViewBag.Description = Model.MetaDescription;
	ViewBag.Keywords = Model.MetaKeywords;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n\t<h1>\r\n\t\t");
#nullable restore
#line 10 "C:\Users\user\source\repos\WebApplicationLearning\WebApplicationLearning\Views\Services\Show.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</h1>\r\n\t<h2>\r\n\t\t");
#nullable restore
#line 13 "C:\Users\user\source\repos\WebApplicationLearning\WebApplicationLearning\Views\Services\Show.cshtml"
   Write(Model.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</h2>\r\n\t<div>\r\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a19210616951a4367c4b91c2af91780aab3ad1ce4866", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 262, "~/images/", 262, 9, true);
#nullable restore
#line 16 "C:\Users\user\source\repos\WebApplicationLearning\WebApplicationLearning\Views\Services\Show.cshtml"
AddHtmlAttributeValue("", 271, Model.TitleImagePath, 271, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t</div>\r\n</div>\r\n\r\n<div>\r\n\t");
#nullable restore
#line 21 "C:\Users\user\source\repos\WebApplicationLearning\WebApplicationLearning\Views\Services\Show.cshtml"
Write(Html.Raw(Model.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceItem> Html { get; private set; }
    }
}
#pragma warning restore 1591
