#pragma checksum "C:\Users\ILKOKILLA\Documents\GitHub\backend2019-exercises\Lesson10_MbmStore_startup\MbmStore\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "965c75d496be2dd0f8b1f99d517079c632689531"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
#line 5 "C:\Users\ILKOKILLA\Documents\GitHub\backend2019-exercises\Lesson10_MbmStore_startup\MbmStore\Views\_ViewImports.cshtml"
using MbmStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ILKOKILLA\Documents\GitHub\backend2019-exercises\Lesson10_MbmStore_startup\MbmStore\Views\Customer\Index.cshtml"
using MbmStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"965c75d496be2dd0f8b1f99d517079c632689531", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1e27e96eba088818141acbdf1afd6992bd62d8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ILKOKILLA\Documents\GitHub\backend2019-exercises\Lesson10_MbmStore_startup\MbmStore\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Customer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Customers</h2>\n\n");
#nullable restore
#line 9 "C:\Users\ILKOKILLA\Documents\GitHub\backend2019-exercises\Lesson10_MbmStore_startup\MbmStore\Views\Customer\Index.cshtml"
 foreach (Customer c in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\n        ");
#nullable restore
#line 12 "C:\Users\ILKOKILLA\Documents\GitHub\backend2019-exercises\Lesson10_MbmStore_startup\MbmStore\Views\Customer\Index.cshtml"
   Write(c.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 12 "C:\Users\ILKOKILLA\Documents\GitHub\backend2019-exercises\Lesson10_MbmStore_startup\MbmStore\Views\Customer\Index.cshtml"
                 Write(c.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n        ");
#nullable restore
#line 13 "C:\Users\ILKOKILLA\Documents\GitHub\backend2019-exercises\Lesson10_MbmStore_startup\MbmStore\Views\Customer\Index.cshtml"
   Write(c.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n        ");
#nullable restore
#line 14 "C:\Users\ILKOKILLA\Documents\GitHub\backend2019-exercises\Lesson10_MbmStore_startup\MbmStore\Views\Customer\Index.cshtml"
   Write(c.Zip);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\ILKOKILLA\Documents\GitHub\backend2019-exercises\Lesson10_MbmStore_startup\MbmStore\Views\Customer\Index.cshtml"
          Write(c.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </p>\n");
#nullable restore
#line 16 "C:\Users\ILKOKILLA\Documents\GitHub\backend2019-exercises\Lesson10_MbmStore_startup\MbmStore\Views\Customer\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
