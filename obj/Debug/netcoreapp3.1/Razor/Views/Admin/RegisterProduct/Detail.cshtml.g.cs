#pragma checksum "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95f9857f0fb9932dbc991cea380f3d39214d4c85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RegisterProduct_Detail), @"mvc.1.0.view", @"/Views/Admin/RegisterProduct/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95f9857f0fb9932dbc991cea380f3d39214d4c85", @"/Views/Admin/RegisterProduct/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f799a469c22ff79f64247b11e07f313ff96a02f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RegisterProduct_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterProduct>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "Chi tiết đơn đăng ký";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n <main>\r\n                    <div class=\"container-fluid\">\r\n                        <h4 class=\"mt-4\">CHI TIẾT ĐƠN ĐĂNG KÝ # ");
#nullable restore
#line 10 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
                                                           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    </div>\r\n                     <div class=\"card mb-4\">\r\n                              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95f9857f0fb9932dbc991cea380f3d39214d4c856231", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 13 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
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
#line 15 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
                             if(@TempData["message"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"alert alert-success\">\r\n                                    ");
#nullable restore
#line 18 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
                               Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 20 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
                             if(@TempData["error"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"alert alert-danger\">\r\n                                    ");
#nullable restore
#line 24 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
                               Write(TempData["error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 26 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n     <div class=\"col-8 mx-auto pb-5\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95f9857f0fb9932dbc991cea380f3d39214d4c859678", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95f9857f0fb9932dbc991cea380f3d39214d4c859952", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 30 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
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
#line 31 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
                     if(!String.IsNullOrEmpty(ViewBag.message)){

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"alert alert-success\">");
#nullable restore
#line 32 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
                                                    Write(ViewBag.message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 33 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"md-form mt-5\">\r\n                        <label for=\"form1\"> <span style=\"width: 200px; display:inline-block\"> Tên khách hàng:</span> ");
#nullable restore
#line 35 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
                                                                                                                Write(Model.Customer.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"md-form\">\r\n                        <label for=\"form1\"> <span style=\"width: 200px; display:inline-block\"> Điện thoại:</span> ");
#nullable restore
#line 38 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
                                                                                                            Write(Model.Customer.Phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"md-form\">\r\n                        <label for=\"form1\"> <span style=\"width: 200px; display:inline-block\"> Email:</span> ");
#nullable restore
#line 41 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
                                                                                                       Write(Model.Customer.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"md-form\">\r\n                        <label for=\"form1\"> <span style=\"width: 200px; display:inline-block\"> Địa chỉ:</span> ");
#nullable restore
#line 44 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
                                                                                                         Write(Model.Customer.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"md-form\">\r\n                        <label for=\"form1\"> <span style=\"width: 200px; display:inline-block\"> Diện tích lắp mái:</span> ");
#nullable restore
#line 47 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
                                                                                                                   Write(Model.Roof);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"md-form\">\r\n                        <label for=\"form1\"> <span style=\"width: 200px; display:inline-block\"> Công suất:</span> ");
#nullable restore
#line 50 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
                                                                                                           Write(Model.Wattage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"md-form\">\r\n                        <label for=\"form1\"> <span style=\"width: 200px; display:inline-block\"> Vị trí lắp đặt:</span> ");
#nullable restore
#line 53 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
                                                                                                                Write(Model.Place);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"md-form\">\r\n                        <label for=\"form1\"> <span style=\"width: 200px; display:inline-block\"> Đơn giá:</span> ");
#nullable restore
#line 56 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
                                                                                                         Write(Model.UnitPrice.ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VND</label>\r\n                    </div>\r\n                    <div class=\"md-form\">\r\n                        <label for=\"form1\"> <span style=\"width: 200px; display:inline-block\"> Thành tiền:</span> ");
#nullable restore
#line 59 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
                                                                                                            Write(Model.Amount.ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" VND</label>
                    </div>

                    <div class=""md-form"">
                        <label for=""form1""> <span style=""width: 200px; display:inline-block""> Trạng thái:</span></label>
                        <select class=""form-input"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95f9857f0fb9932dbc991cea380f3d39214d4c8517373", async() => {
                    WriteLiteral("Hủy");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95f9857f0fb9932dbc991cea380f3d39214d4c8518622", async() => {
                    WriteLiteral("Đang chờ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95f9857f0fb9932dbc991cea380f3d39214d4c8519876", async() => {
                    WriteLiteral("Hoàn thành");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </select>
                    </div>
                 
                    <div class=""mb-4 mt-4"">
                        <button class=""btn btn-primary btn-rounded btn-sm my-0"" type=""submit"">Cập nhật</button>
                    </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1112, "/admin/post/", 1112, 12, true);
#nullable restore
#line 29 "C:\Users\HUY 4\Desktop\C#\DVN\Views\Admin\RegisterProduct\Detail.cshtml"
AddHtmlAttributeValue("", 1124, Model.Id, 1124, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterProduct> Html { get; private set; }
    }
}
#pragma warning restore 1591
