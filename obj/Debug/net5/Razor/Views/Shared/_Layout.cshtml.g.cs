#pragma checksum "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75417934ea907ca9b655304511e94b8de8bff88b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75417934ea907ca9b655304511e94b8de8bff88b", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f799a469c22ff79f64247b11e07f313ff96a02f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
  
    var Customer = HttpContextAccessor.HttpContext.Session.Get<Customer>("customer");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"zxx\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75417934ea907ca9b655304511e94b8de8bff88b4619", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""description"" content=""Fashi Template"">
    <meta name=""keywords"" content=""Fashi, unica, creative, html"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Fashi | Template</title>
    <!-- Google Font -->
    <link href=""https://fonts.googleapis.com/css?family=Muli:300,400,500,600,700,800,900&display=swap"" rel=""stylesheet"">
    <!-- Css Styles -->
    <link rel=""stylesheet"" href=""/assets/page/css/bootstrap.min.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""/assets/page/css/font-awesome.min.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""/assets/page/css/themify-icons.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""/assets/page/css/elegant-icons.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""/assets/page/css/owl.carousel.min.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""/assets/page/css/nice-select.css"" type=""text/css"">
");
                WriteLiteral(@"    <link rel=""stylesheet"" href=""/assets/page/css/jquery-ui.min.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""/assets/page/css/slicknav.min.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""/assets/page/css/style.css"" type=""text/css"">
    <style>
        .fix-center {
        display: flex;
        justify-content: center;
        align-items: center;
        }

        .box-logout{
            display: none;
        }
        .box-login:hover .box-logout{
            display: block;
        }
    </style>
");
#nullable restore
#line 43 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
     if (IsSectionDefined("Css"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
   Write(RenderSection("Css", required:true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
                                            
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75417934ea907ca9b655304511e94b8de8bff88b7861", async() => {
                WriteLiteral(@"
        <!-- Header Section Begin -->
        <header class=""header-section"">
            <div class=""header-top"">
                <div class=""container"">
                    <div class=""ht-left"">
                        <div class=""mail-service"">
                            <i class="" fa fa-envelope""></i>
                            cuongtetan@gmail.com
                        </div>
                        <div class=""phone-service"">
                            <i class="" fa fa-phone""></i>
                            +848.888.5576
                        </div>
                    </div>
                    <div class=""ht-right"">
");
#nullable restore
#line 66 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
                         if(Customer == null){

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a href=\"/khach-hang/dang-nhap\" class=\"login-panel\"><i class=\"fa fa-user\"></i>");
#nullable restore
#line 67 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
                                                                                                      Write(Customer?.Username
                                                        ?? "Đăng nhập");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a>
                            <div class=""top-social"">
                                <a href=""#""><i class=""ti-facebook""></i></a>
                                <a href=""#""><i class=""ti-twitter-alt""></i></a>
                                <a href=""#""><i class=""ti-linkedin""></i></a>
                           </div>
");
#nullable restore
#line 74 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
                        }
                        else{

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div class=""d-flex"">
                                <div class=""top-social"">
                                    <a href=""#""><i class=""ti-facebook""></i></a>
                                    <a href=""#""><i class=""ti-twitter-alt""></i></a>
                                    <a href=""#""><i class=""ti-linkedin""></i></a>
                                    </div>
                                 <div class=""position-relative box-login"">
                                <a href=""#"" class=""login-panel""><i class=""fa fa-user""></i>");
#nullable restore
#line 83 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
                                                                                      Write(Customer?.Username
                                                            ?? "Đăng nhập");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a>
                                <div class=""box-logout position-absolute""
                                    style="" top: 43px;
                                            background: #fafafa;
                                            padding: 13px;
                                            left: 18px;
                                            box-shadow: 1px 1px 1px grey;""
                                >
                                    <a class=""dropdown-item"" href=""/khach-hang/ho-so"">Hồ sơ</a>
                                    <a class=""dropdown-item"" href=""/khach-hang/kiem-tra-hoa-don"">Hóa đơn</a>
                                    <a class=""dropdown-item"" href=""/khach-hang/dang-xuat"">Đăng xuất</a>
                                </div>
                            </div>
                                
                            </div>
");
#nullable restore
#line 99 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </div>
                </div>
            </div>
            <div class=""container"">
                <div class=""inner-header"">
                    <div class=""row"">
                        <div class=""col-lg-2 col-md-2"">

                        </div>
                        <div class=""col-lg-7 col-md-7"">
                            <div class=""logo"">
                                <a href=""/"">
                                    <img src=""/assets/page/img/logo.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 5313, "\"", 5319, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""nav-item"">
                <div class=""container"">
                    <div class=""nav-depart"">
                        <div class=""depart-btn"">
                            <i class=""ti-menu""></i>
                            <span>Người sử dụng</span>
                            <ul class=""depart-hover"">
                                <li class=""active""><a href=""/dang-ky-su-dung"">Đăng kí sử dụng</a></li>
");
#nullable restore
#line 127 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
                                 if(Customer == null){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li><a href=\"/khach-hang/dang-nhap\">Đăng nhập</a></li>\r\n");
#nullable restore
#line 129 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li><a href=\"/khach-hang/kiem-tra-hoa-don\">Kiểm tra hoá đơn</a></li>\r\n");
#nullable restore
#line 131 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
                                 if(Customer == null){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li><a href=\"/khach-hang/dang-ky\">Đăng kí tài khoản</a></li>\r\n");
#nullable restore
#line 133 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"

                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </ul>\r\n                        </div>\r\n                    </div>\r\n                    <nav class=\"nav-menu mobile-menu\">\r\n                        <ul>\r\n                            <li");
                BeginWriteAttribute("class", " class=\"", 6638, "\"", 6707, 1);
#nullable restore
#line 140 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6646, (string)ViewData["CurrentPage"] == "home"  ? "active" : "", 6646, 61, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a href=\"/\">Trang\r\n                                    Chủ</a></li>\r\n                            <li");
                BeginWriteAttribute("class", " class=\"", 6809, "\"", 6878, 1);
#nullable restore
#line 142 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6817, (string)ViewData["CurrentPage"] == "news"  ? "active" : "", 6817, 61, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a\r\n                                href=\"/tin-tuc\">Tin tức</a></li>\r\n                            <li");
                BeginWriteAttribute("class", " class=\"", 6981, "\"", 7051, 1);
#nullable restore
#line 144 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6989, (string)ViewData["CurrentPage"] == "about"  ? "active" : "", 6989, 62, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a\r\n                                href=\"/gioi-thieu\">Giới thiệu</a></li>\r\n                            <li");
                BeginWriteAttribute("class", " class=\"", 7160, "\"", 7240, 1);
#nullable restore
#line 146 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7168, (string)ViewData["CurrentPage"] == "registerProduct"  ? "active" : "", 7168, 72, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a\r\n                                href=\"/dang-ky-su-dung\">Đăng kí sử dụng</a></li>\r\n                            <li");
                BeginWriteAttribute("class", " class=\"", 7359, "\"", 7431, 1);
#nullable restore
#line 148 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7367, (string)ViewData["CurrentPage"] == "contact"  ? "active" : "", 7367, 64, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a\r\n                                href=\"/lien-he\">Liên Hệ</a></li>\r\n");
                WriteLiteral("                        </ul>\r\n                    </nav>\r\n                    <div id=\"mobile-menu-wrap\"></div>\r\n                </div>\r\n            </div>\r\n        </header>\r\n        <!-- Header End -->\r\n        ");
#nullable restore
#line 160 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <!-- Footer Section Begin -->
        <footer class=""footer-section"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-3"">
                        <div class=""footer-left"">
                            <div class=""footer-logo"">
                                <a href=""#""><img src=""/assets/page/img/footer-logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 8333, "\"", 8339, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                            </div>
                            <ul>
                                <li>Trụ sở chính: Công ty Điện lực Điện Biên - Số 904 tổ 9 - Phường Mường Thanh - TP Điện
                                    Biên Phủ - Tỉnh Điện Biên</li>
                                <li>Điện thoại: 084.888.5576</li>
                                <li>Email: Cuongtetan@gmail.com</li>
                            </ul>
                            <div class=""footer-social"">
                                <a href=""#""><i class=""fa fa-facebook""></i></a>
                                <a href=""#""><i class=""fa fa-instagram""></i></a>
                                <a href=""#""><i class=""fa fa-twitter""></i></a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-2 offset-lg-1"">
                    </div>
                    <div class=""col-lg-2"">
                        <div class=""footer-widget"">
          ");
                WriteLiteral(@"              </div>
                    </div>
                    <div class=""col-lg-4"">
                        <div class=""newslatter-item"">
                            <h5>Giải đáp thắc mắc</h5>
                            <p>Hãy để email của bạn tại đây, chúng tôi sẽ liên lac với bạn sớm nhất có thể</p>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75417934ea907ca9b655304511e94b8de8bff88b19777", async() => {
                    WriteLiteral(@"
                                <input id=""send-email"" type=""text"" placeholder=""Enter Your Mail"">
                                <button id=""btn-send-email"" type=""button"" data-toggle=""modal""
                                data-target=""#modalCustomerSendEmail"">Gửi Email</button>
                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </footer>
        <div class=""modal fade"" id=""modalCustomerSendEmail"" tabindex=""-1"" role=""dialog""
        aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
            <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLongTitle"">Thông báo</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div id=""alert-send-mail"" class=""modal-body"">
                    </div>
                    <div class=""modal-footer"">
                    </div>
                </div>
            </div>
        </div>



      ");
                WriteLiteral(@"  <!-- Footer Section End -->

        <!-- Js Plugins -->
        <script src=""/assets/page/js/jquery-3.3.1.min.js""></script>
        <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/2.6.0/umd/popper.min.js"" integrity=""sha512-BmM0/BQlqh02wuK5Gz9yrbe7VyIVwOzD1o40yi1IsTjriX/NGF37NyXHfmFzIlMmoSIBXgqDiG1VNU6kB5dBbA=="" crossorigin=""anonymous""></script>
        <script src=""/assets/page/js/bootstrap.min.js""></script>
        <script src=""/assets/page/js/jquery-ui.min.js""></script>
        <script src=""/assets/page/js/jquery.countdown.min.js""></script>
        <script src=""/assets/page/js/jquery.nice-select.min.js""></script>
        <script src=""/assets/page/js/jquery.zoom.min.js""></script>
        <script src=""/assets/page/js/jquery.dd.min.js""></script>
        <script src=""/assets/page/js/jquery.slicknav.js""></script>
        <script src=""/assets/page/js/owl.carousel.min.js""></script>
        <script src=""/assets/page/js/main.js""></script>
        <script>

            const inputSend");
                WriteLiteral(@"Email = document.querySelector('#send-email');
            const btnSendEmail = document.querySelector('#btn-send-email');
            const formSubcrice = document.querySelector('.subscribe-form');
            const alertSendMail = document.querySelector('#alert-send-mail');

            let loader = `<div class=""fix-center    "">
            <div class=""spinner-border"" role=""status"">
            <span class=""sr-only"">Loading...</span>
            </div>
            </div>`;

            btnSendEmail.addEventListener('click', customerSendEmail)
            formSubcrice.addEventListener('submit', function (event) {
            event.preventDefault();
            $('#modalCustomerSendEmail').modal('show');
            customerSendEmail();
            })


            function customerSendEmail() {

            const data = { email: inputSendEmail.value };
            alertSendMail.style.color = '#343a40 ';
            alertSendMail.innerHTML = loader;

            fetch('/khach-hang/gui");
                WriteLiteral(@"-email', {
            method: 'POST',
            headers: {
            'Content-Type': 'application/json',
            },
            body: JSON.stringify(data),
            })
            .then(response => response.json())
            .then(data => {
            if (data.success != null) {
            alertSendMail.style.color = 'green';
            alertSendMail.textContent = data.success;
            }
            else {
            alertSendMail.style.color = 'red';
            alertSendMail.textContent = data.error[0].errorMessage;
            }
            })
            .catch((error) => {
            console.error('Error:', error);
            })
            }



        </script>
");
#nullable restore
#line 290 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
         if (IsSectionDefined("Script"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 292 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
   Write(RenderSection("Script", required:true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 292 "E:\project\c#\LHC2\LHC\Views\Shared\_Layout.cshtml"
                                               
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </html>\r\n");
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
