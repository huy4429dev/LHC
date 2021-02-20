#pragma checksum "E:\project\c#\LHC\Views\Admin\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c8342f3802ef3724363d40c1cddfee4a560ca55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Dashboard_Index), @"mvc.1.0.view", @"/Views/Admin/Dashboard/Index.cshtml")]
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
#line 1 "E:\project\c#\LHC\Views\Admin\Dashboard\Index.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c8342f3802ef3724363d40c1cddfee4a560ca55", @"/Views/Admin/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f799a469c22ff79f64247b11e07f313ff96a02f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\project\c#\LHC\Views\Admin\Dashboard\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "Dashboard";

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\project\c#\LHC\Views\Admin\Dashboard\Index.cshtml"
                                               
    
    var Statistic = ViewData["Statistic"] as DashboardViewModel;

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\project\c#\LHC\Views\Admin\Dashboard\Index.cshtml"
                                                                                            
    
    var  StatisticOfDay =   JsonSerializer.Serialize(Statistic.StatisticOfDay);
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <main>
              
                    <div class=""container-fluid"">
                        <h1 class=""mt-4"">Dashboard</h1>
                        <ol class=""breadcrumb mb-4"">
                            <li class=""breadcrumb-item active"">Dashboard</li>
                        </ol>
                        <div class=""row"">
                            <div class=""col-xl-3 col-md-6"">
                                <div class=""card bg-primary text-white mb-4""  style=""background: #3498db !important; height: 115px;
    box-shadow: 1px 1px 2px 1px #8080807d;"">
                                    <div class=""card-body"">Khách hàng mới</div>
                                    <div class=""card-footer d-flex align-items-center justify-content-between"">
                                        <a class="" text-white stretched-link"" href=""#"">");
#nullable restore
#line 33 "E:\project\c#\LHC\Views\Admin\Dashboard\Index.cshtml"
                                                                                   Write(Statistic.NewCustomer);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-xl-3 col-md-6"">
                                <div class=""card bg-warning text-white mb-4"" style=""background: #f39c12 !important; height: 115px;
    box-shadow: 1px 1px 2px 1px #8080807d;"">
                                    <div class=""card-body"">Thắc mắc khiếu nại</div>
                                    <div class=""card-footer d-flex align-items-center justify-content-between"">
                                        <a class=""small text-white stretched-link"" href=""#"">");
#nullable restore
#line 42 "E:\project\c#\LHC\Views\Admin\Dashboard\Index.cshtml"
                                                                                        Write(Statistic.Contact);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-xl-3 col-md-6"">
                                <div class=""card bg-success text-white mb-4"" style=""background-color: #e74c3c !important; height: 115px;
    box-shadow: 1px 1px 2px 1px #8080807d;;"">
                                    <div class=""card-body"">Đơn hàng mới</div>
                                    <div class=""card-footer d-flex align-items-center justify-content-between"">
                                        <a class=""small text-white stretched-link"" href=""#"">");
#nullable restore
#line 51 "E:\project\c#\LHC\Views\Admin\Dashboard\Index.cshtml"
                                                                                        Write(Statistic.NewOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-xl-3 col-md-6"">
                                <div class=""card bg-danger text-white mb-4"" style=""background-color: #1abc9c !important; height: 115px;
    box-shadow: 1px 1px 2px 1px #8080807d;;"">
                                    <div class=""card-body"">Đơn hàng hủy bỏ</div>
                                    <div class=""card-footer d-flex align-items-center justify-content-between"">
                                        <a class=""small text-white stretched-link"" href=""#"">");
#nullable restore
#line 60 "E:\project\c#\LHC\Views\Admin\Dashboard\Index.cshtml"
                                                                                        Write(Statistic.OrderDispose);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <figure class=""highcharts-figure"">
                            <div id=""container""></div>
                            <p class=""highcharts-description"" style=""opacity: 0"">
                                Basic line chart showing trends in a dataset. This chart includes the
                                <code>series-label</code> module, which adds a label to each line for
                                enhanced readability.
                            </p>
                            </figure>
                        </div>
                        <div class=""card mb-4"">
                            <div class=""card-header"">
                                <i class=""fas fa-table mr-1""></i>
                                Log
                            </div>
          ");
            WriteLiteral(@"                  <div class=""card-body"">
                                <div class=""table-responsive"">
                                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                        <thead>
                                            <tr>
                                                <th>Đối tượng</th>
                                                <th>Hành động</th>
                                                <th>Người thực hiện</th>
                                                <th>Thời gian</th>
                                                <th>Nội dung</th>
                                            </tr>
                                        </thead>
                                        <tfoot>
                                            <tr>
                                                <th>Đối tượng</th>
                                                <th>Hành động</th>
                   ");
            WriteLiteral(@"                             <th>Người thực hiện</th>
                                                <th>Thời gian</th>
                                                <th>Nội dung</th>
                                            </tr>
                                        </tfoot>
                                        <tbody>
                                            <tr>
                                                <td>Liên hệ</td>
                                                <td>Gửi</td>
                                                <td>Nguyễn Văn X</td>
                                                <td>11/11/2020</td>
                                                <td>Đã gửi liên hệ đến hệ thống <a href=""#"">Xem liên hệ</a></td>
                                            </tr>
                                            <tr>
                                                <td>Nguyễn Văn X</td>
                                                <td>Accountant</td>
           ");
            WriteLiteral(@"                                     <td>Tokyo</td>
                                                <td>63</td>
                                                <td>2011/07/25</td>
                                            </tr>
                                            <tr>
                                                <td>Ashton Cox</td>
                                                <td>Junior Technical Author</td>
                                                <td>San Francisco</td>
                                                <td>66</td>
                                                <td>2009/01/12</td>
                                            </tr>
                                            <tr>
                                                <td>Cedric Kelly</td>
                                                <td>Senior Javascript Developer</td>
                                                <td>Edinburgh</td>
                                                <td>22</td>
");
            WriteLiteral(@"                                                <td>2012/03/29</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </main>
");
            DefineSection("Css", async() => {
                WriteLiteral(@"
    <style>
        .highcharts-figure, .highcharts-data-table table {
            margin: 1em auto;
            }

            .highcharts-data-table table {
                font-family: system-ui;
                border-collapse: collapse;
                border: 1px solid #EBEBEB;
                margin: 10px auto;
                text-align: center;
                width: 100%;
                max-width: 500px;
            }
            tspan {
                font-family: system-ui;
            }
            .highcharts-data-table caption {
            padding: 1em 0;
            font-size: 1.2em;
            color: #555;
               font-family: system-ui;  
            }
            .highcharts-data-table th {
            font-weight: 600;
            padding: 0.5em;
            }
            .highcharts-data-table td, .highcharts-data-table th, .highcharts-data-table caption {
            padding: 0.5em;
            }
            .highcharts-data-table thead tr, .hig");
                WriteLiteral("hcharts-data-table tr:nth-child(even) {\r\n            background: #f8f8f8;\r\n            }\r\n            .highcharts-data-table tr:hover {\r\n            background: #f1f7ff;\r\n            }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script src=""https://code.highcharts.com/highcharts.js""></script>
    <script src=""https://code.highcharts.com/modules/series-label.js""></script>
    <script src=""https://code.highcharts.com/modules/exporting.js""></script>
    <script src=""https://code.highcharts.com/modules/export-data.js""></script>
    <script src=""https://code.highcharts.com/modules/accessibility.js""></script>
    <script>
        function rhtmlspecialchars(str) {

            if (typeof(str) == ""string"") {
                str = str.replace(/&gt;/ig, "">"");
                str = str.replace(/&lt;/ig, ""<"");
                str = str.replace(/&#039;/g, ""'"");
                str = str.replace(/&quot;/ig, '""');
                str = str.replace(/&amp;/ig, '&'); /* must do &amp; last */
            }
            return str;

        }

        let timeNow = new Date();
        let data = rhtmlspecialchars('");
#nullable restore
#line 198 "E:\project\c#\LHC\Views\Admin\Dashboard\Index.cshtml"
                                 Write(StatisticOfDay);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"');
        let StatisticOfDay = JSON.parse(data);

        let minDay = 1;
        let maxDay = timeNow.getDay();
        let dayHasData = 0;

        for (const property in StatisticOfDay) {

            StatisticOfDay[property].Data = [];

            if( StatisticOfDay[property].length > 0) {

                let previousDay = minDay;

                for(let i = 0 ; i < maxDay; i ++ ){
                    let day = StatisticOfDay[property][i]?.Day;
                    if(day - i > 1)
                    { 
                        console.log(""index - "", i)
                        StatisticOfDay[property].Data = StatisticOfDay[property].Data.concat(Array(day - i - 1).fill(0));
                        StatisticOfDay[property].Data.push(StatisticOfDay[property][i].Count)
                        maxDay -= day - i - 1 ; // continue this day
                    }
                    else{

                        StatisticOfDay[property].Data.push(StatisticOfDay[property][i]?.Count ??");
                WriteLiteral(@" 0);
                    }
                }
            
            }
       
        }

        console.log(StatisticOfDay);


        Highcharts.chart('container', {

            title: {
                text: `Biểu đồ lượng tương tác tổng quan tháng ${timeNow.getMonth() + 1} - ${timeNow.getFullYear()}`
            },

            subtitle: {
                text: ''
            },

            yAxis: {
                allowDecimals: false,
                title: {
                text: 'Number of Employees'
                }
            },

            xAxis: {
                allowDecimals: false,
                accessibility: {
                rangeDescription: `Range: 1 to ${timeNow.getDay()}`
                }
            },

            legend: {
                layout: 'vertical',
                align: 'right',
                verticalAlign: 'middle'
            },

            plotOptions: {
                series: {
                label: {
          ");
                WriteLiteral(@"          connectorAllowed: false
                },
                pointStart: 1
                }
            },

            series: [{
                name: 'Khách hàng mới',
                data: StatisticOfDay.newCustomerOfDay.Data
            }, {
                name: 'Thắc mắc khiếu nại',
                data: StatisticOfDay.newContactOfDay.Data
            }, {
                name: 'Đơn hàng mới',
                data: StatisticOfDay.newOrderOfDay.Data
            }, {
                name: 'Đơn hàng hủy bỏ',
                data: StatisticOfDay.orderDespose.Data
            }
            ],

            responsive: {
                rules: [{
                condition: {
                    maxWidth: 500
                },
                chartOptions: {
                    legend: {
                    layout: 'horizontal',
                    align: 'center',
                    verticalAlign: 'bottom'
                    }
                }
                }]
");
                WriteLiteral("            }\r\n\r\n            });\r\n    </script>\r\n");
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
