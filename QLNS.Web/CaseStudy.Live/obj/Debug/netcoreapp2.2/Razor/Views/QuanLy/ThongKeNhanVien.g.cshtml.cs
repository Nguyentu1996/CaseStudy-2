#pragma checksum "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93019f269b752feee7680a0fc1b6ee6a8f05be1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuanLy_ThongKeNhanVien), @"mvc.1.0.view", @"/Views/QuanLy/ThongKeNhanVien.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/QuanLy/ThongKeNhanVien.cshtml", typeof(AspNetCore.Views_QuanLy_ThongKeNhanVien))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\_ViewImports.cshtml"
using CaseStudy.Live;

#line default
#line hidden
#line 2 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\_ViewImports.cshtml"
using CaseStudy.Live.Models;

#line default
#line hidden
#line 2 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
using CaseStudy.Live.Models.QuanLy.Request;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93019f269b752feee7680a0fc1b6ee6a8f05be1c", @"/Views/QuanLy/ThongKeNhanVien.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b6ab5c084b7527790fa663c194e85737c8f59d3", @"/Views/_ViewImports.cshtml")]
    public class Views_QuanLy_ThongKeNhanVien : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CaseStudy.Live.Models.QuanLy.Response.ThongKe>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(112, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
  
    ViewData["Title"] = "ThongKeNhanVien";

#line default
#line hidden
            BeginContext(165, 44, true);
            WriteLiteral("\r\n<h1>Thống Kê Nhân Viên</h1>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(210, 93, false);
#line 11 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
Write(Html.ActionLink("Trở lại danh sách", "ThongKeBoPhan", "QuanLy", new LayThongKeBoPhanId() { }));

#line default
#line hidden
            EndContext();
            BeginContext(303, 96, true);
            WriteLiteral("\r\n</div>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(400, 39, false);
#line 18 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
           Write(Html.DisplayNameFor(model => model.Nam));

#line default
#line hidden
            EndContext();
            BeginContext(439, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(495, 41, false);
#line 21 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
           Write(Html.DisplayNameFor(model => model.Thang));

#line default
#line hidden
            EndContext();
            BeginContext(536, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(592, 41, false);
#line 24 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
           Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(633, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(689, 41, false);
#line 27 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
           Write(Html.DisplayNameFor(model => model.CoMat));

#line default
#line hidden
            EndContext();
            BeginContext(730, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(786, 39, false);
#line 30 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
           Write(Html.DisplayNameFor(model => model.Tre));

#line default
#line hidden
            EndContext();
            BeginContext(825, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(881, 45, false);
#line 33 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
           Write(Html.DisplayNameFor(model => model.KhongPhep));

#line default
#line hidden
            EndContext();
            BeginContext(926, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(982, 42, false);
#line 36 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
           Write(Html.DisplayNameFor(model => model.CoPhep));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1080, 47, false);
#line 39 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
           Write(Html.DisplayNameFor(model => model.TheoQuyDinh));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 45 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1262, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1323, 38, false);
#line 49 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nam));

#line default
#line hidden
            EndContext();
            BeginContext(1361, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1429, 40, false);
#line 52 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
               Write(Html.DisplayFor(modelItem => item.Thang));

#line default
#line hidden
            EndContext();
            BeginContext(1469, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1537, 40, false);
#line 55 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
               Write(Html.DisplayFor(modelItem => item.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(1577, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1645, 40, false);
#line 58 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
               Write(Html.DisplayFor(modelItem => item.CoMat));

#line default
#line hidden
            EndContext();
            BeginContext(1685, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1753, 38, false);
#line 61 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
               Write(Html.DisplayFor(modelItem => item.Tre));

#line default
#line hidden
            EndContext();
            BeginContext(1791, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1859, 44, false);
#line 64 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
               Write(Html.DisplayFor(modelItem => item.KhongPhep));

#line default
#line hidden
            EndContext();
            BeginContext(1903, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1971, 41, false);
#line 67 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
               Write(Html.DisplayFor(modelItem => item.CoPhep));

#line default
#line hidden
            EndContext();
            BeginContext(2012, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2080, 46, false);
#line 70 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
               Write(Html.DisplayFor(modelItem => item.TheoQuyDinh));

#line default
#line hidden
            EndContext();
            BeginContext(2126, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2194, 157, false);
#line 73 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
               Write(Html.ActionLink("Chi tiết", "ChiTietDiemDanh", "QuanLy", new LayDiemDanhNhanVienIdThang { NhanVienId = item.NhanVienId, Nam = item.Nam, Thang = item.Thang }));

#line default
#line hidden
            EndContext();
            BeginContext(2351, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 76 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\ThongKeNhanVien.cshtml"
        }

#line default
#line hidden
            BeginContext(2406, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CaseStudy.Live.Models.QuanLy.Response.ThongKe>> Html { get; private set; }
    }
}
#pragma warning restore 1591
