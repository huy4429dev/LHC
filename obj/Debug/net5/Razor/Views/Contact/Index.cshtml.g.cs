#pragma checksum "E:\project\c#\LHC2\LHC\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e6e4ed23e9e7c8ed2a8495142e8d98e51029d16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e6e4ed23e9e7c8ed2a8495142e8d98e51029d16", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f799a469c22ff79f64247b11e07f313ff96a02f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-contact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/lien-he"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("comment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\project\c#\LHC2\LHC\Views\Contact\Index.cshtml"
  
    Layout = "_Layout";

    ViewData["CurrentPage"] = "contact";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!-- Breadcrumb Section Begin -->
    <div class=""breacrumb-section"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-text"">
                        <a href=""#""><i class=""fa fa-home""></i> Trang chủ</a>
                        <span>Liên hệ</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Breadcrumb Section Begin -->
<!-- Blog Details Section Begin -->
<section class=""blog-details spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""blog-details-inner"">
                    <div class=""blog-detail-title"">
                        <h2>TỔNG CÔNG TY ĐIỆN LỰC TỈNH ĐIỆN BIÊN</h2>
                        <p>Địa chỉ <span>Số 904 tổ 9 - Phường Mường Thanh - TP Điện Biên Phủ - Tỉnh Điện Biên</span></p>
                    </div>
                    <div class=""blog-l");
            WriteLiteral("arge-pic\">\r\n                        <img src=\"img/blog/onghaynghihuu.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1173, "\"", 1179, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""blog-detail-desc"">
                        <p>Công ty Điện lực Điện Biên tiền thân là Điện lực Lai Châu cũ, được thành lập tháng 4 năm 1990,
                             năm 2004 đổi tên thành Điện lực Điện Biên  do chia tách thành hai Điện lực: Điện lực Điện Biên 
                             và Điện lực Lai Châu theo quyết định số: 47/QĐ-EVN-HĐQT ngày 20 tháng 2 năm 2004 của Hội đồng 
                             Quản trị Tổng Công ty Điện lực Việt Nam. Ngày 14/4/2010, Điện lực Điện Biên chuyển đổi mô hình 
                             tổ chức thành Công ty Điện lực Điện Biên theo quyết định số: 223/QĐ-EVN của Tập đoàn Điện lực 
                             Việt Nam.
                        </p>
                    </div>
                    <div class=""blog-quote"">
                        <p>CÔNG TY ĐIỆN LỰC ĐIỆN BIÊN - 
                            20 NĂM XÂY DỰNG VÀ PHÁT TRIỂN</p>
                    </div>
                    <di");
            WriteLiteral("v class=\"blog-more\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-sm-4\">\r\n                                <img src=\"img/blog/blog-detail1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2389, "\"", 2395, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"col-sm-4\">\r\n                                <img src=\"img/blog/blog-detail2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2555, "\"", 2561, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"col-sm-4\">\r\n                                <img src=\"img/blog/blog-detail3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2721, "\"", 2727, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                    </div>
                    <p>     Công ty Điện lực Điện Biên là doanh nghiệp Nhà nước, trực thuộc Tổng công ty Điện lực Miền Bắc – Tập đoàn Điện lực Việt Nam, đóng trên địa bàn tỉnh Điện Biên, có trụ sở tại số 904- đường 7/5- Thành phố Điện Biên Phủ-Tỉnh Điện Biên. Mô hình tổ chức gồm Cơ quan văn phòng Công ty và 9 Điện lực, 2 đơn vị phụ trợ ( Phân xưởng phát điện và Phân xưởng thiết kế thí nghiệm)

                        Công ty Điện lực Điện Biên có chức năng nhiệm vụ chính là: Quản lý vận hành hệ thống lưới điện và kinh doanh bán điện trên địa bàn 7 huyện, 1 thị xã và thành phố Điện Biên phủ.
                         
                        Ngoài ra, Công ty Điện lực Điện Biên còn có chức năng, nhiệm vụ sau:
                         
                    <p>- Xây dựng và sửa chữa, cải tạo lưới điện.</p>
                         
                        <p>- Sửa chữa, thí nghiệm, hiệu chỉnh thiết bị và dụng");
            WriteLiteral(@" cụ đo điện.</p>
                         
                        <p>- Sửa chữa Máy biến áp lực.</p>
                         
                        <p>- Tư vấn đầu tư xây dựng các công trình lưới điện phân phối (đến35 KV)</p>
                         
                        <p>- Tư vấn giám sát thi công trình đến 110 KV</p>
                         
                        <p>-  Hoạt động sản xuất, kinh doanh, dịch vụ khác …</p>
                         
                        <p>Trong những năm xây dựng và trưởng thành, Công ty Điện lực Điện Biên không ngừng phát huy và kế thừa những truyền thống tốt đẹp, vượt mọi khó khăn để hoàn thành và hoàn thành xuất sắc mọi nhiệm vụ được giao. Phát triển hệ thống lưới điện rộng khắp địa bàn được quản lý, đảm bảo cung cấp điện an toàn, đáp ứng các nhu cầu kinh tế - chính trị - xã hội và đời sống dân sinh tại địa phương, góp phần tích cực vào sự nghiệp ""Công nghiệp hoá và hiện đại hoá"" đất nước.
                         
                        Nhìn lại");
            WriteLiteral(@" chặng đường  đã qua, Công ty Điện lực Điện Biên đã góp phần xứng đáng vào sự nghiệp xây dựng, phát triển và phát huy truyền thống vẻ vang của Ngành điện Việt Nam. Các thế hệ đi trước đã đóng góp nhiều công sức, trí tuệ tạo dựng cho những thế hệ đi sau một nền tảng vững chắc. CBCNV Công ty Điện lực Điện Biên luôn trân trọng,  quyết tâm phấn đấu và phát huy truyền thống quý báu đó để xứng đáng với niềm tin yêu của nhân dân các dân tộc trong Tỉnh.
                         
                        Quá trình xây dựng và trưởng thành, Công ty Điện lực Điện Biên đã đạt nhiều thành tích xuất sắc, được Đảng, Nhà nước và các cấp Bộ ngành, địa phương khen thưởng nhiều danh hiệu thi đua:
                         
                        </p><p>- 02 Huân chương lao động hạng Nhì và hạng Ba</p>
                         
                        <p>- 02 Bằng Khen của Thủ tướng Chính phủ về thành tích hoàn thành các chỉ tiêu KT-XH và thành tích đền ơn đáp nghĩa</p>
                         
                        <p");
            WriteLiteral(@">- 03 Bằng khen của Bộ Công nghiệp</p>
                         
                        <p>- 02 Bằng khen của Bộ công an về thành tích bảo vệ an ninh tổ quốc</p>
                         
                        <p>- 02 Bằng khen của Tổng Liên đoàn Lao động Việt Nam, 01 cờ chuyên đề về thành tích An toàn bảo hộ lao động.</p>
                         
                        <p>- 08 Bằng Khen của Tổng Công ty Điện lực Việt Nam</p>
                         
                        <p>- 120 Bằng khen của UBND Tỉnh cho các tập thể và cá nhân trực thuộc Điện lực Điện Biên.</p>
                         
                        <p>- 03 Bằng khen của Quân khu 2  về thành tích dân quân tự vệ.
                        </p>
                        <p>- 01 Bằng khen và cờ thi đua xuất sắc của TW Đoàn TNCS Hồ Chí Minh</p>
                        <p>- Nhiều giấy khen của các cấp, các ngành địa phương và cơ quan chủ quản cấp trên cho các tập thể và cá nhân trong Công ty Điện lực Điện Biên.</p>
                ");
            WriteLiteral(@"</div>
            </div>
        </div>
    </div>
</section>
<!-- Blog Details Section End -->
    <!-- Map Section Begin -->
    <div class=""map spad"">
        <div class=""container"">
            <div class=""map-inner"">
                <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3715.056090617663!2d103.01289531493865!3d21.38769598580504!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xe66e5d16fc9f8e7a!2zVOG7lW5nIGPDtG5nIHR5IMSQaeG7h24gbOG7sWMgbWnhu4FuIELhuq9jIC0gQ8O0bmcgdHkgxJBp4buHbiBM4buxYyDEkGnhu4duIEJpw6pu!5e0!3m2!1svi!2s!4v1601433160776!5m2!1svi!2s"" width=""600"" height=""450"" frameborder=""0"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 7488, "\"", 7506, 0);
            EndWriteAttribute();
            WriteLiteral(@" aria-hidden=""false"" tabindex=""0""></iframe>
                <div class=""icon"">
                    <i class=""fa fa-map-marker""></i>
                </div>
            </div>
        </div>
    </div>
    <!-- Map Section Begin -->

    <!-- Contact Section Begin -->
    <section class=""contact-section spad"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-5"">
                    <div class=""contact-title"">
                        <h4>Trụ sở</h4>
                    </div>
                    <div class=""contact-widget"">
                        <div class=""cw-item"">
                            <div class=""ci-icon"">
                                <i class=""ti-location-pin""></i>
                            </div>
                            <div class=""ci-text"">
                                <span>Địa chỉ</span>
                                <p>Số 904 tổ 9 - Phường Mường Thanh - TP Điện Biên Phủ - Tỉnh Điện Biên</p>
                  ");
            WriteLiteral(@"          </div>
                        </div>
                        <div class=""cw-item"">
                            <div class=""ci-icon"">
                                <i class=""ti-mobile""></i>
                            </div>
                            <div class=""ci-text"">
                                <span>Điện thoại</span>
                                <p>+848.888.5576</p>
                            </div>
                        </div>
                        <div class=""cw-item"">
                            <div class=""ci-icon"">
                                <i class=""ti-email""></i>
                            </div>
                            <div class=""ci-text"">
                                <span>Email:</span>
                                <p>cuongtetan@gmail.com</p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6 offset-lg-1"">
                    <d");
            WriteLiteral(@"iv class=""contact-form"">
                        <div class=""leave-comment"">
                            <h4>Liên hệ ngay với chúng tôi</h4>
                            <p>Đội ngũ tư vấn của chúng tôi luôn trực 24/24 để giải đáp thắc mắc của bạn</p>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e6e4ed23e9e7c8ed2a8495142e8d98e51029d1615915", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 167 "E:\project\c#\LHC2\LHC\Views\Contact\Index.cshtml"
                                 if (ViewData["SendContactSuccess"] != null)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"alert alert-success\">\r\n                                        ");
#nullable restore
#line 170 "E:\project\c#\LHC2\LHC\Views\Contact\Index.cshtml"
                                   Write(ViewData["SendContactSuccess"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 172 "E:\project\c#\LHC2\LHC\Views\Contact\Index.cshtml"
                                }
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 175 "E:\project\c#\LHC2\LHC\Views\Contact\Index.cshtml"
                                 if (ViewData.ModelState.Any(x => x.Value.Errors.Any()))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"alert alert-danger\" role=\"alert\">\r\n                                        <a class=\"close\" data-dismiss=\"alert\">×</a>\r\n");
#nullable restore
#line 179 "E:\project\c#\LHC2\LHC\Views\Contact\Index.cshtml"
                                         foreach (var modelError in Html.ViewData.ModelState.SelectMany(keyValuePair =>
                                        keyValuePair.Value.Errors))
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <p>");
#nullable restore
#line 182 "E:\project\c#\LHC2\LHC\Views\Contact\Index.cshtml"
                                          Write(modelError.ErrorMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 183 "E:\project\c#\LHC2\LHC\Views\Contact\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </div>\r\n");
#nullable restore
#line 185 "E:\project\c#\LHC2\LHC\Views\Contact\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                <div id=""alert-contact"" class=""pb-4"">
                                    Gửi liên hệ thành công
                                </div>
                                <div class=""row"">
                                    <div class=""col-lg-6"">
                                        <input name=""FullName""  type=""text"" placeholder=""Tên của bạn"" id=""fullname-contact"">
                                    </div>
                                    <div class=""col-lg-6"">
                                        <input  name=""Email"" type=""text"" placeholder=""Email của bạn"" id=""email-contact"">
                                    </div>
                                    <div class=""col-lg-12"">
                                        <textarea name=""Content""  placeholder=""Nội dung cần giả đáp"" id=""content-contact""></textarea>
                                        <button type=""button"" class=""site-btn""  id=""send-contact"">Đồng ý</button>
                                 ");
                WriteLiteral("   </div>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <!-- Contact Section End -->\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral(@"
            <script>
            
            let btnSendContact = document.querySelector('#send-contact');
            let inputEmailSendContact = document.querySelector('#email-contact');
            let inputContentSendContact = document.querySelector('#content-contact');
            let inputFullNameSendContact = document.querySelector('#fullname-contact');
            let alertSendContact = document.querySelector('#alert-contact');
            let formContact = document.querySelector('#form-contact');
            btnSendContact.addEventListener('click', customerSendContact);



            function customerSendContact() {

            const data = { email: inputEmailSendContact.value , fullname: inputFullNameSendContact.value, content: inputContentSendContact.value};


            alertSendContact.style.color = '#343a40 ';
            alertSendContact.innerHTML = loader;

            fetch('/lien-he', {
            method: 'POST',
            headers: {
            'Content-Type'");
                WriteLiteral(@": 'application/json',
            },
            body: JSON.stringify(data),
            })
            .then(response => response.json())
            .then(data => {
            if (data.success != null) {
                alertSendContact.style.color = 'green';
                alertSendContact.textContent = data.success;
                formContact.reset();
            }
            else {
            alertSendContact.style.color = 'red';
            alertSendContact.textContent = data.error[0].errorMessage;
            }
            })
            .catch((error) => {
            console.error('Error:', error);
            })
            }



        </script>
");
            }
            );
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
