#pragma checksum "E:\project\c#\LHC\Views\Customer\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1176fc080f88df8a0fbd1ff76657b2d5853fdcfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Register), @"mvc.1.0.view", @"/Views/Customer/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1176fc080f88df8a0fbd1ff76657b2d5853fdcfa", @"/Views/Customer/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f799a469c22ff79f64247b11e07f313ff96a02f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/khach-hang/dang-ky"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\project\c#\LHC\Views\Customer\Register.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Breadcrumb Section Begin -->
<div class=""breacrumb-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb-text"">
                    <a href=""#""><i class=""fa fa-home""></i> Trang chủ</a>
                    <span>Đăng kí</span>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Breadcrumb Form Section Begin -->

<!-- Register Section Begin -->
<div class=""register-login-section spad"" style=""padding-bottom:0"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 offset-lg-3"">
                <div class=""register-form"">
                    <h2>Đăng kí tài khoản</h2>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1176fc080f88df8a0fbd1ff76657b2d5853fdcfa5139", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 31 "E:\project\c#\LHC\Views\Customer\Register.cshtml"
                         if(ViewData["CreateCustomerSuccess"] != null){

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"alert alert-success\">\r\n                                ");
#nullable restore
#line 33 "E:\project\c#\LHC\Views\Customer\Register.cshtml"
                           Write(ViewData["CreateCustomerSuccess"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 35 "E:\project\c#\LHC\Views\Customer\Register.cshtml"
                        }
                        

                        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 40 "E:\project\c#\LHC\Views\Customer\Register.cshtml"
                         if (ViewData.ModelState.Any(x => x.Value.Errors.Any()))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"alert alert-danger\" role=\"alert\">\r\n                                <a class=\"close\" data-dismiss=\"alert\">×</a>\r\n");
#nullable restore
#line 44 "E:\project\c#\LHC\Views\Customer\Register.cshtml"
                                 foreach (var modelError in Html.ViewData.ModelState.SelectMany(keyValuePair =>
                                            keyValuePair.Value.Errors))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <p>");
#nullable restore
#line 47 "E:\project\c#\LHC\Views\Customer\Register.cshtml"
                                  Write(modelError.ErrorMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 48 "E:\project\c#\LHC\Views\Customer\Register.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n");
#nullable restore
#line 50 "E:\project\c#\LHC\Views\Customer\Register.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""form-group"">
                            <div class=""group-input"">
                                <label for=""username"">Tên tài khoản *</label>
                                <input type=""text"" id=""username"" name=""Username"">
                            </div>
                            <div class=""group-input"">
                                <label for=""username"">Email *</label>
                                <input type=""email"" id=""email"" name=""Email"">
                            </div>
                            <div class=""group-input"">
                                <label for=""pass"">Mật khẩu *</label>
                                <input type=""password"" id=""pass"" name=""Password"">
                            </div>
                            <div class=""group-input"">
                                <label for=""con-pass"">Xác nhận mật khẩu *</label>
                                <input type=""password"" id=""con-pass"" name=""ConfirmPassword"">
     ");
                WriteLiteral("                       </div>\r\n                            <button type=\"submit\" class=\"site-btn register-btn\">Đăng kí</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""switch-login"">
                        <a href=""./login.html"" class=""or-login"">Đăng nhập</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Register Form Section End -->");
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
