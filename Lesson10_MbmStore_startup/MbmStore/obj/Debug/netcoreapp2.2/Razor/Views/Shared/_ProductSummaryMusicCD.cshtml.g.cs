#pragma checksum "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Shared\_ProductSummaryMusicCD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f6cdde81034fab58d075f25197ad26d801ce344"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductSummaryMusicCD), @"mvc.1.0.view", @"/Views/Shared/_ProductSummaryMusicCD.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ProductSummaryMusicCD.cshtml", typeof(AspNetCore.Views_Shared__ProductSummaryMusicCD))]
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
#line 5 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\_ViewImports.cshtml"
using MbmStore.Models.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Shared\_ProductSummaryMusicCD.cshtml"
using MbmStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f6cdde81034fab58d075f25197ad26d801ce344", @"/Views/Shared/_ProductSummaryMusicCD.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1e27e96eba088818141acbdf1afd6992bd62d8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductSummaryMusicCD : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MbmStore.Models.MusicCD>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 53, true);
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-md-2\">\n        ");
            EndContext();
            BeginContext(107, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0f6cdde81034fab58d075f25197ad26d801ce3443819", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 117, "~/Images/", 117, 9, true);
#line 5 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Shared\_ProductSummaryMusicCD.cshtml"
AddHtmlAttributeValue("", 126, Model.ImageUrl, 126, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 5 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Shared\_ProductSummaryMusicCD.cshtml"
AddHtmlAttributeValue("", 148, Model.Title, 148, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(184, 71, true);
            WriteLiteral("\n    </div>\n    <div class=\"col-md-4\">\n        <strong>Album:</strong> ");
            EndContext();
            BeginContext(256, 11, false);
#line 8 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Shared\_ProductSummaryMusicCD.cshtml"
                           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(267, 40, true);
            WriteLiteral("<br />\n        <strong>Artist:</strong> ");
            EndContext();
            BeginContext(308, 12, false);
#line 9 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Shared\_ProductSummaryMusicCD.cshtml"
                            Write(Model.Artist);

#line default
#line hidden
            EndContext();
            BeginContext(320, 39, true);
            WriteLiteral("<br />\n        <strong>Price:</strong> ");
            EndContext();
            BeginContext(360, 11, false);
#line 10 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Shared\_ProductSummaryMusicCD.cshtml"
                           Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(371, 43, true);
            WriteLiteral("<br />\n        <strong>Publisher:</strong> ");
            EndContext();
            BeginContext(415, 11, false);
#line 11 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Shared\_ProductSummaryMusicCD.cshtml"
                               Write(Model.Label);

#line default
#line hidden
            EndContext();
            BeginContext(426, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(429, 14, false);
#line 11 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Shared\_ProductSummaryMusicCD.cshtml"
                                             Write(Model.Released);

#line default
#line hidden
            EndContext();
            BeginContext(443, 18, true);
            WriteLiteral(")\n    </div>\n\n    ");
            EndContext();
            BeginContext(462, 60, false);
#line 14 "C:\Users\ILKOKILLA\source\repos\Lesson10_MbmStore_startup\MbmStore\Views\Shared\_ProductSummaryMusicCD.cshtml"
Write(await Html.PartialAsync("_AddToCartButton", (Product) Model));

#line default
#line hidden
            EndContext();
            BeginContext(522, 8, true);
            WriteLiteral("\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MbmStore.Models.MusicCD> Html { get; private set; }
    }
}
#pragma warning restore 1591
