#pragma checksum "E:\project\c#\LHC\Views\Admin\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d0dd8838c0febe1abf65ccbd5efa839a45e92e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Product_Index), @"mvc.1.0.view", @"/Views/Admin/Product/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\project\c#\LHC\Views\_ViewImports.cshtml"
using DVN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\project\c#\LHC\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\project\c#\LHC\Views\_ViewImports.cshtml"
using DVN.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\project\c#\LHC\Views\_ViewImports.cshtml"
using DVN.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\project\c#\LHC\Views\_ViewImports.cshtml"
using DVN.Extension;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0dd8838c0febe1abf65ccbd5efa839a45e92e4", @"/Views/Admin/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f799a469c22ff79f64247b11e07f313ff96a02f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\project\c#\LHC\Views\Admin\Product\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "Product";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Day la trang quan ly sách</h2>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n   <style>\r\n       \r\n       h2{\r\n           color: red;\r\n       }\r\n   </style>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n   <script>\r\n       console.log(\"hello :)\");\r\n   </script>\r\n");
            }
            );
            WriteLiteral("   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
