#pragma checksum "C:\Users\Aper\Desktop\NewShopApp\ShopApp\ShopApp.WebUI\Views\Shared\_categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9bfec7a9c23fe85cde940f5db016b6455237a69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__categories), @"mvc.1.0.view", @"/Views/Shared/_categories.cshtml")]
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
#line 1 "C:\Users\Aper\Desktop\NewShopApp\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aper\Desktop\NewShopApp\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9bfec7a9c23fe85cde940f5db016b6455237a69", @"/Views/Shared/_categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6351f46e2733193207b555021b0195a9a5c454c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Aper\Desktop\NewShopApp\ShopApp\ShopApp.WebUI\Views\Shared\_categories.cshtml"
 foreach (var category in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"mt-1\">\r\n        <a href=\"#\" class=\"list-group-item list-group-item-action\">");
#nullable restore
#line 6 "C:\Users\Aper\Desktop\NewShopApp\ShopApp\ShopApp.WebUI\Views\Shared\_categories.cshtml"
                                                              Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </div>\r\n");
#nullable restore
#line 8 "C:\Users\Aper\Desktop\NewShopApp\ShopApp\ShopApp.WebUI\Views\Shared\_categories.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
