#pragma checksum "E:\project\c#\LHC2\LHC\Views\News\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83f1a8e38142f0dbe1f27ba1bdea948cc9d1ab3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Detail), @"mvc.1.0.view", @"/Views/News/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83f1a8e38142f0dbe1f27ba1bdea948cc9d1ab3c", @"/Views/News/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f799a469c22ff79f64247b11e07f313ff96a02f2", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/tin-tuc/tim-kiem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\project\c#\LHC2\LHC\Views\News\Detail.cshtml"
  
    Layout = "_Layout";
    ViewData["CurrentPage"] = "news";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Breadcrumb Section Begin -->
<div class=""breacrumb-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb-text"">
                    <a href=""#""><i class=""fa fa-home""></i> Home</a>
                    <span>Tin tức</span>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Breadcrumb Section Begin -->

<!-- Blog Section Begin -->
<section class=""blog-section spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3 col-md-6 col-sm-8 order-2 order-lg-1"">
                <div class=""blog-sidebar"">
                    <div class=""search-form"">
                        <h4>Tìm kiếm</h4>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83f1a8e38142f0dbe1f27ba1bdea948cc9d1ab3c4900", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" placeholder=\"Tìm kiếm . . .  \" name=\"query\">\r\n                            <button type=\"submit\"><i class=\"fa fa-search\"></i></button>\r\n                        ");
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
            WriteLiteral("\r\n                        <div class=\"recent-post\">\r\n                            <h4 style=\"margin:20px 0\">Bài viết liên quan</h4>\r\n");
#nullable restore
#line 35 "E:\project\c#\LHC2\LHC\Views\News\Detail.cshtml"
                             foreach (var item in ViewBag.recentPost)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"recent-blog\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1452, "\"", 1476, 2);
            WriteAttributeValue("", 1459, "/tin-tuc/", 1459, 9, true);
#nullable restore
#line 38 "E:\project\c#\LHC2\LHC\Views\News\Detail.cshtml"
WriteAttributeValue("", 1468, item.Id, 1468, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rb-item\">\r\n                                        <div class=\"rb-pic\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 1606, "\"", 1627, 1);
#nullable restore
#line 40 "E:\project\c#\LHC2\LHC\Views\News\Detail.cshtml"
WriteAttributeValue("", 1612, item.Thumbnail, 1612, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1628, "\"", 1634, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        </div>\r\n                                        <div class=\"rb-text\">\r\n                                            <h6>");
#nullable restore
#line 43 "E:\project\c#\LHC2\LHC\Views\News\Detail.cshtml"
                                            Write(item.Title.Length > 100 ? item.Title.SubString(0,100) + "..." : item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                            <p>");
#nullable restore
#line 44 "E:\project\c#\LHC2\LHC\Views\News\Detail.cshtml"
                                          Write(item.User.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>- ");
#nullable restore
#line 44 "E:\project\c#\LHC2\LHC\Views\News\Detail.cshtml"
                                                                     Write(item.CreatedAt.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                        </div>\r\n                                    </a>\r\n                                </div>\r\n");
#nullable restore
#line 48 "E:\project\c#\LHC2\LHC\Views\News\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-9"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h4 class=""card-title"">
                            ");
#nullable restore
#line 57 "E:\project\c#\LHC2\LHC\Views\News\Detail.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h4>\r\n                        <div class=\"d-flex justify-content-end\">\r\n                            <div>\r\n                                <span>");
#nullable restore
#line 61 "E:\project\c#\LHC2\LHC\Views\News\Detail.cshtml"
                                 Write(Model.User.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span>-</span>\r\n                                <span>");
#nullable restore
#line 63 "E:\project\c#\LHC2\LHC\Views\News\Detail.cshtml"
                                 Write(Model.CreatedAt.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card-content\">\r\n                        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 3004, "\"", 3026, 1);
#nullable restore
#line 68 "E:\project\c#\LHC2\LHC\Views\News\Detail.cshtml"
WriteAttributeValue("", 3010, Model.Thumbnail, 3010, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                        <div class=\"card-body\">\r\n                            <p class=\"card-text\">\r\n                                ");
#nullable restore
#line 71 "E:\project\c#\LHC2\LHC\Views\News\Detail.cshtml"
                           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            <div class=\"card-text\">\r\n                                ");
#nullable restore
#line 74 "E:\project\c#\LHC2\LHC\Views\News\Detail.cshtml"
                           Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"fb-comments\" data-href=\"https://localhost:5001/tin-tuc/");
#nullable restore
#line 77 "E:\project\c#\LHC2\LHC\Views\News\Detail.cshtml"
                                                                                      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-width=""100%"" data-numposts=""5""></div>
                    </div>
                </div>
            </div>
        </div>
</section>
<!-- Blog Section End -->

<!-- Partner Logo Section Begin -->
<div class=""partner-logo"">
    <div class=""container"">
        <div class=""logo-carousel owl-carousel"">
            <div class=""logo-item"">
                <div class=""tablecell-inner"">
                    <img src=""img/logo-carousel/logo-1.png""");
            BeginWriteAttribute("alt", " alt=\"", 3978, "\"", 3984, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <div class=\"logo-item\">\r\n                <div class=\"tablecell-inner\">\r\n                    <img src=\"img/logo-carousel/logo-2.png\"");
            BeginWriteAttribute("alt", " alt=\"", 4175, "\"", 4181, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <div class=\"logo-item\">\r\n                <div class=\"tablecell-inner\">\r\n                    <img src=\"img/logo-carousel/logo-3.png\"");
            BeginWriteAttribute("alt", " alt=\"", 4372, "\"", 4378, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <div class=\"logo-item\">\r\n                <div class=\"tablecell-inner\">\r\n                    <img src=\"img/logo-carousel/logo-4.png\"");
            BeginWriteAttribute("alt", " alt=\"", 4569, "\"", 4575, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <div class=\"logo-item\">\r\n                <div class=\"tablecell-inner\">\r\n                    <img src=\"img/logo-carousel/logo-5.png\"");
            BeginWriteAttribute("alt", " alt=\"", 4766, "\"", 4772, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div id=\"fb-root\"></div>\r\n<!-- Partner Logo Section End -->\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n    <script async defer crossorigin=\"anonymous\" src=\"https://connect.facebook.net/en_US/sdk.js#xfbml=1&version=v10.0&appId=543121906576699&autoLogAppEvents=1\" nonce=\"kdOynrSq\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591