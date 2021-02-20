#pragma checksum "E:\project\c#\LHC\Views\Customer\CheckOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21116ee782f5550ce1a181c9ec37f8a2e2d51e69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_CheckOrder), @"mvc.1.0.view", @"/Views/Customer/CheckOrder.cshtml")]
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
#nullable restore
#line 1 "E:\project\c#\LHC\Views\Customer\CheckOrder.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21116ee782f5550ce1a181c9ec37f8a2e2d51e69", @"/Views/Customer/CheckOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f799a469c22ff79f64247b11e07f313ff96a02f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_CheckOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\project\c#\LHC\Views\Customer\CheckOrder.cshtml"
  
    Layout = "_Layout";
    ViewData["CurrentPage"] = "checkOrder";
    var Customer = HttpContextAccessor.HttpContext.Session.Get<Customer>("customer");
    var CustomerInfo = ViewData["customerInfo"] as Customer;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Breadcrumb Section Begin -->
<div class=""breacrumb-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb-text"">
                    <a href=""#""><i class=""fa fa-home""></i>Trang chủ</a>
                    <span>Hóa đơn</span>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Breadcrumb Form Section Begin -->
<!-- Shopping Cart Section Begin -->

");
#nullable restore
#line 26 "E:\project\c#\LHC\Views\Customer\CheckOrder.cshtml"
 if (Customer == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"checkout-content\">\r\n        <a href=\"/khach-hang/dang-nhap\" class=\"content-btn\">Bấm vào đây để <b>đăng nhập</b></a>\r\n    </div>\r\n");
#nullable restore
#line 31 "E:\project\c#\LHC\Views\Customer\CheckOrder.cshtml"
}

else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""shopping-cart spad"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""cart-table"">
                        <table>
                            <thead>
                                <tr>
                                    <th>Họ và tên</th>
                                    <th class=""p-name"">Địa chỉ</th>
                                    <th>SĐT</th>
                                    <th>Ngày tạo</th>
                                    <th>Số tiền</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 51 "E:\project\c#\LHC\Views\Customer\CheckOrder.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"cart-name first-row\">");
#nullable restore
#line 54 "E:\project\c#\LHC\Views\Customer\CheckOrder.cshtml"
                                                                   Write(item.Customer.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"cart-address first-row\">\r\n                                            ");
#nullable restore
#line 56 "E:\project\c#\LHC\Views\Customer\CheckOrder.cshtml"
                                       Write(item.Customer.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"p-price first-row\">");
#nullable restore
#line 58 "E:\project\c#\LHC\Views\Customer\CheckOrder.cshtml"
                                                                 Write(item.Customer.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"qua-col first-row\">");
#nullable restore
#line 59 "E:\project\c#\LHC\Views\Customer\CheckOrder.cshtml"
                                                                 Write(item.Customer.CreatTime.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"total-price first-row\">");
#nullable restore
#line 60 "E:\project\c#\LHC\Views\Customer\CheckOrder.cshtml"
                                                                     Write(item.Amount.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 62 "E:\project\c#\LHC\Views\Customer\CheckOrder.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                    <div class=""row"">
                        <div class=""col-lg-4"">
                        </div>
                        <div class=""col-lg-4 offset-lg-4"">
                            <div class=""proceed-checkout"">
                                <ul>
                                    <li class=""vat"">VAT(10%) <span>");
#nullable restore
#line 72 "E:\project\c#\LHC\Views\Customer\CheckOrder.cshtml"
                                                               Write((Model.Sum(item => item.Amount) + Model.Sum(item => item.Amount) * 10 / 100).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</span></li>\r\n                                    <li class=\"cart-total\">Total <span>");
#nullable restore
#line 73 "E:\project\c#\LHC\Views\Customer\CheckOrder.cshtml"
                                                                   Write(Model.Sum(item => item.Amount).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VND </span></li>
                                </ul>
                                <a href=""/khach-hang/xuat-hoa-don"" class=""proceed-btn"">In hóa đơn</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
");
#nullable restore
#line 83 "E:\project\c#\LHC\Views\Customer\CheckOrder.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Shopping Cart Section End -->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591