#pragma checksum "E:\project\c#\LHC2\LHC\Views\RegisterProduct\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9126e10bf2ceefc38f542fb09fd2260c61667596"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegisterProduct_Index), @"mvc.1.0.view", @"/Views/RegisterProduct/Index.cshtml")]
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
#line 1 "E:\project\c#\LHC2\LHC\Views\_ViewImports.cshtml"
using DVN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\project\c#\LHC2\LHC\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\project\c#\LHC2\LHC\Views\_ViewImports.cshtml"
using DVN.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\project\c#\LHC2\LHC\Views\_ViewImports.cshtml"
using DVN.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\project\c#\LHC2\LHC\Views\_ViewImports.cshtml"
using DVN.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\project\c#\LHC2\LHC\Views\RegisterProduct\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9126e10bf2ceefc38f542fb09fd2260c61667596", @"/Views/RegisterProduct/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f799a469c22ff79f64247b11e07f313ff96a02f2", @"/Views/_ViewImports.cshtml")]
    public class Views_RegisterProduct_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/dang-ky-su-dung"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("checkout-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "E:\project\c#\LHC2\LHC\Views\RegisterProduct\Index.cshtml"
  
    Layout = "_Layout";
    ViewData["CurrentPage"] = "registerProduct";
    var Customer = HttpContextAccessor.HttpContext.Session.Get<Customer>("customer");
    var CustomerInfo = ViewData["customerInfo"] as Customer;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Breadcrumb Section Begin -->
<div class=""breacrumb-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb-text product-more"">
                    <a href=""/dang-ky-su-dung""><i class=""fa fa-home""></i> Trang chủ</a>
                    <span>Đăng kí</span>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Breadcrumb Section Begin -->

<!-- Shopping Cart Section Begin -->
<section class=""checkout-section spad"">
    <div class=""container"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9126e10bf2ceefc38f542fb09fd2260c616675965732", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 31 "E:\project\c#\LHC2\LHC\Views\RegisterProduct\Index.cshtml"
             if (ViewData["RegisterProductSuccess"] != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"alert alert-success\">\r\n                    ");
#nullable restore
#line 34 "E:\project\c#\LHC2\LHC\Views\RegisterProduct\Index.cshtml"
               Write(ViewData["RegisterProductSuccess"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 36 "E:\project\c#\LHC2\LHC\Views\RegisterProduct\Index.cshtml"
            }
            

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 39 "E:\project\c#\LHC2\LHC\Views\RegisterProduct\Index.cshtml"
             if (ViewData.ModelState.Any(x => x.Value.Errors.Any()))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"alert alert-danger\" role=\"alert\">\r\n                    <a class=\"close\" data-dismiss=\"alert\">×</a>\r\n");
#nullable restore
#line 43 "E:\project\c#\LHC2\LHC\Views\RegisterProduct\Index.cshtml"
                     foreach (var modelError in Html.ViewData.ModelState.SelectMany(keyValuePair =>
                    keyValuePair.Value.Errors))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p>");
#nullable restore
#line 46 "E:\project\c#\LHC2\LHC\Views\RegisterProduct\Index.cshtml"
                      Write(modelError.ErrorMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 47 "E:\project\c#\LHC2\LHC\Views\RegisterProduct\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n");
#nullable restore
#line 49 "E:\project\c#\LHC2\LHC\Views\RegisterProduct\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-lg-6\">\r\n");
#nullable restore
#line 52 "E:\project\c#\LHC2\LHC\Views\RegisterProduct\Index.cshtml"
                     if (Customer == null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"checkout-content\">\r\n                            <a href=\"/khach-hang/dang-nhap\" class=\"content-btn\">Bấm vào đây để <b>đăng nhập</b></a>\r\n                        </div>\r\n");
#nullable restore
#line 57 "E:\project\c#\LHC2\LHC\Views\RegisterProduct\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <h4>Thông tin đăng kí</h4>
                    <div class=""row"">
                        <div class=""col-lg-6"">
                            <label for=""fir"">Họ<span>*</span></label>
                            <input type=""text"" id=""fir"" name=""FirstName""");
                BeginWriteAttribute("value", " value=\"", 2475, "\"", 2509, 1);
#nullable restore
#line 62 "E:\project\c#\LHC2\LHC\Views\RegisterProduct\Index.cshtml"
WriteAttributeValue("", 2483, CustomerInfo?.FirstName, 2483, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"col-lg-6\">\r\n                            <label for=\"last\">Tên<span>*</span></label>\r\n                            <input type=\"text\" id=\"last\" name=\"LastName\"");
                BeginWriteAttribute("value", " value=\"", 2738, "\"", 2771, 1);
#nullable restore
#line 66 "E:\project\c#\LHC2\LHC\Views\RegisterProduct\Index.cshtml"
WriteAttributeValue("", 2746, CustomerInfo?.LastName, 2746, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"col-lg-12\">\r\n                            <label for=\"cun-name\">Địa chỉ</label>\r\n                            <input type=\"text\" id=\"cun-name\" name=\"Address\"");
                BeginWriteAttribute("value", " value=\"", 2998, "\"", 3030, 1);
#nullable restore
#line 70 "E:\project\c#\LHC2\LHC\Views\RegisterProduct\Index.cshtml"
WriteAttributeValue("", 3006, CustomerInfo?.Address, 3006, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"col-lg-12\">\r\n                            <label for=\"cun\">Số điện thoại<span>*</span></label>\r\n                            <input type=\"text\" id=\"cun\" name=\"Phone\"");
                BeginWriteAttribute("value", " value=\"", 3265, "\"", 3295, 1);
#nullable restore
#line 74 "E:\project\c#\LHC2\LHC\Views\RegisterProduct\Index.cshtml"
WriteAttributeValue("", 3273, CustomerInfo?.Phone, 3273, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""col-lg-12"">
                            <label for=""street"">Địa chỉ email<span>*</span></label>
                            <input type=""text"" id=""street"" class=""street-first"" name=""Email""");
                BeginWriteAttribute("value", " value=\"", 3557, "\"", 3587, 1);
#nullable restore
#line 78 "E:\project\c#\LHC2\LHC\Views\RegisterProduct\Index.cshtml"
WriteAttributeValue("", 3565, CustomerInfo?.Email, 3565, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""col-lg-12"">
                            <label for=""zip"">Diện tích mái cần lắp đặt (m2) <span>*</span></label>
                            <input type=""text"" id=""zip"" name=""Roof"">
                        </div>
                        <div class=""col-lg-12"">
                            <label for=""zip"">Công suất (KW)<span>*</span></label>
                            <input type=""text"" id=""zip"" name=""Wattage"">
                        </div>
                        <div class=""col-lg-12"">
                            <label for=""zip"">Vị trí lắp đặt<span>*</span></label>
                            <input type=""text"" id=""zip"" name=""Place"">
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
");
#nullable restore
#line 95 "E:\project\c#\LHC2\LHC\Views\RegisterProduct\Index.cshtml"
                     if (Customer == null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"checkout-content\">\r\n                            <span>Vui lòng đăng nhập trước khi đăng kí sử dụng dịch vụ</span>\r\n                        </div>\r\n");
#nullable restore
#line 100 "E:\project\c#\LHC2\LHC\Views\RegisterProduct\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""place-order"">
                        <h4>Giá thành dự kiến</h4>
                        <div class=""order-total"">
                            <ul class=""order-table"">
                                <li class=""total-price"" >Tổng <span id=""amount"">0 đ</span></li>
                            </ul>
                            <div class=""order-btn"">
                                <button type=""submit"" class=""site-btn place-btn"">Đăng kí</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</section>\r\n<!-- Shopping Cart Section End -->\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n    <script>\r\n        let wattage = document.querySelector(\'input[name=\"Wattage\"]\');\r\n        let amount = document.querySelector(\'#amount\');\r\n        let unitPrice = ");
#nullable restore
#line 123 "E:\project\c#\LHC2\LHC\Views\RegisterProduct\Index.cshtml"
                   Write(ViewData["unitPrice"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
        wattage.addEventListener('keyup',function(){
            let total = unitPrice * wattage.value;
            amount.textContent = (total).toLocaleString('it-IT', {style : 'currency', currency : 'VND'});

           
        })

    </script>   
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
