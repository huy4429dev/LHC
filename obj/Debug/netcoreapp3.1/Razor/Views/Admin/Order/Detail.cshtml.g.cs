#pragma checksum "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "838598a2bfb09af8f793f025cda76eff5db28c8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Order_Detail), @"mvc.1.0.view", @"/Views/Admin/Order/Detail.cshtml")]
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
#line 1 "C:\Users\HUY 4\Desktop\C#\DVN\Views\_ViewImports.cshtml"
using DVN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HUY 4\Desktop\C#\DVN\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HUY 4\Desktop\C#\DVN\Views\_ViewImports.cshtml"
using DVN.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HUY 4\Desktop\C#\DVN\Views\_ViewImports.cshtml"
using DVN.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HUY 4\Desktop\C#\DVN\Views\_ViewImports.cshtml"
using DVN.Extension;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"838598a2bfb09af8f793f025cda76eff5db28c8d", @"/Views/Admin/Order/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f799a469c22ff79f64247b11e07f313ff96a02f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Order_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "Chi tiết đơn đăng ký";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n <main>\r\n                    <div class=\"container-fluid\">\r\n                        <h4 class=\"mt-4\">CHI TIẾT ĐƠN HÀNG # ");
#nullable restore
#line 10 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
                                                        Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    </div>\r\n                     <div class=\"card mb-4\">\r\n                              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838598a2bfb09af8f793f025cda76eff5db28c8d5622", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 13 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            \r\n");
#nullable restore
#line 15 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
                             if(@TempData["message"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"alert alert-success\">\r\n                                    ");
#nullable restore
#line 18 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
                               Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 20 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
                             if(@TempData["error"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"alert alert-danger\">\r\n                                    ");
#nullable restore
#line 24 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
                               Write(TempData["error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 26 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n     <div class=\"col-8 mx-auto pb-5\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838598a2bfb09af8f793f025cda76eff5db28c8d8999", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838598a2bfb09af8f793f025cda76eff5db28c8d9273", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 30 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
                     if(!String.IsNullOrEmpty(ViewBag.message)){

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"alert alert-success\">");
#nullable restore
#line 32 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
                                                    Write(ViewBag.message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 33 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"md-form mt-5\">\r\n                        <label for=\"form1\"> <span style=\"width: 200px; display:inline-block\"> Tên khách hàng:</span> ");
#nullable restore
#line 35 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
                                                                                                                Write(Model.Customer.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"md-form\">\r\n                        <label for=\"form1\"> <span style=\"width: 200px; display:inline-block\"> Điện thoại:</span> ");
#nullable restore
#line 38 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
                                                                                                            Write(Model.Customer.Phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"md-form\">\r\n                        <label for=\"form1\"> <span style=\"width: 200px; display:inline-block\"> Email:</span> ");
#nullable restore
#line 41 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
                                                                                                       Write(Model.Customer.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"md-form\">\r\n                        <label for=\"form1\"> <span style=\"width: 200px; display:inline-block\"> Địa chỉ:</span> ");
#nullable restore
#line 44 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
                                                                                                         Write(Model.Customer.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"md-form\">\r\n                        <label for=\"form1\"> <span style=\"width: 200px; display:inline-block\"> Đơn giá:</span> ");
#nullable restore
#line 47 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
                                                                                                         Write(Model.UnitPrice.ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VND</label>\r\n                    </div>\r\n                    <div class=\"md-form\">\r\n                        <label for=\"form1\"> <span style=\"width: 200px; display:inline-block\"> Thành tiền:</span> ");
#nullable restore
#line 50 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
                                                                                                            Write(Model.Amount.ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VND</label>\r\n                    </div>\r\n\r\n                    <div class=\"md-form\">\r\n                        <label for=\"form1\"> <span style=\"width: 200px; display:inline-block\"> Trạng thái:</span></label>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838598a2bfb09af8f793f025cda76eff5db28c8d14954", async() => {
                    WriteLiteral("\r\n                        ");
#nullable restore
#line 56 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
                    Write(Model.Status == false ? Html.Raw("<option value='0' selected >Hủy</option>") : Html.Raw(" <option value='0' >Hủy</option>"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("  \r\n                         ");
#nullable restore
#line 57 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
                     Write(Model.Status == true ? Html.Raw("<option value='1' selected >Hoàn thành</option>") : Html.Raw(" <option value='1' >Hoàn thành</option>"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("  \r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 55 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Status);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                 
                    <div class=""mb-4 mt-4"">
                        <button class=""btn btn-primary btn-rounded btn-sm my-0"" type=""submit"">Cập nhật</button>
                        <a class=""btn btn-success  btn-sm my-0""");
                BeginWriteAttribute("href", " href=\"", 3558, "\"", 3594, 2);
                WriteAttributeValue("", 3565, "/admin/order/export/", 3565, 20, true);
#nullable restore
#line 63 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
WriteAttributeValue("", 3585, Model.Id, 3585, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Xuất đơn hàng</a>\r\n                    </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1099, "/admin/product/register/", 1099, 24, true);
#nullable restore
#line 29 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\Order\Detail.cshtml"
AddHtmlAttributeValue("", 1123, Model.Id, 1123, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n                     </div>\r\n </main>\r\n");
            DefineSection("Css", async() => {
                WriteLiteral(" \r\n    <style>\r\n       .form-upload input[type=\"file\"]{\r\n         width: 100px;\r\n         z-index: 999;\r\n         opacity: 0;\r\n       }\r\n            .alert.alert-danger.validation-summary-valid {\r\n        display: none;\r\n            }\r\n    </style>\r\n  ");
            }
            );
            WriteLiteral("\r\n}");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; }
    }
}
#pragma warning restore 1591