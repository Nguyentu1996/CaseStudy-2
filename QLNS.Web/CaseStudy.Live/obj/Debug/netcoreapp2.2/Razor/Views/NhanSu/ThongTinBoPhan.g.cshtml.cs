#pragma checksum "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\NhanSu\ThongTinBoPhan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "740964749717124a39ae8fad58e1cc138149e28b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanSu_ThongTinBoPhan), @"mvc.1.0.view", @"/Views/NhanSu/ThongTinBoPhan.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NhanSu/ThongTinBoPhan.cshtml", typeof(AspNetCore.Views_NhanSu_ThongTinBoPhan))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"740964749717124a39ae8fad58e1cc138149e28b", @"/Views/NhanSu/ThongTinBoPhan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b6ab5c084b7527790fa663c194e85737c8f59d3", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanSu_ThongTinBoPhan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CaseStudy.Live.Models.NhanSu.Response.ThongTinBoPhanTheoId>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\NhanSu\ThongTinBoPhan.cshtml"
  
    ViewData["Title"] = "ThongTinBoPhan";

#line default
#line hidden
            BeginContext(119, 131, true);
            WriteLiteral("\r\n\r\n\r\n<div>\r\n    <h4>Thông Tin Bộ Phận</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\" hidden>\r\n            ");
            EndContext();
            BeginContext(251, 38, false);
#line 14 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\NhanSu\ThongTinBoPhan.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(289, 70, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\" hidden>\r\n            ");
            EndContext();
            BeginContext(360, 34, false);
#line 17 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\NhanSu\ThongTinBoPhan.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(394, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(457, 39, false);
#line 20 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\NhanSu\ThongTinBoPhan.cshtml"
       Write(Html.DisplayNameFor(model => model.Ten));

#line default
#line hidden
            EndContext();
            BeginContext(496, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(560, 35, false);
#line 23 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\NhanSu\ThongTinBoPhan.cshtml"
       Write(Html.DisplayFor(model => model.Ten));

#line default
#line hidden
            EndContext();
            BeginContext(595, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(658, 51, false);
#line 26 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\NhanSu\ThongTinBoPhan.cshtml"
       Write(Html.DisplayNameFor(model => model.DangHoatDongStr));

#line default
#line hidden
            EndContext();
            BeginContext(709, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(773, 47, false);
#line 29 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\NhanSu\ThongTinBoPhan.cshtml"
       Write(Html.DisplayFor(model => model.DangHoatDongStr));

#line default
#line hidden
            EndContext();
            BeginContext(820, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(883, 43, false);
#line 32 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\NhanSu\ThongTinBoPhan.cshtml"
       Write(Html.DisplayNameFor(model => model.SoLuong));

#line default
#line hidden
            EndContext();
            BeginContext(926, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(990, 39, false);
#line 35 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\NhanSu\ThongTinBoPhan.cshtml"
       Write(Html.DisplayFor(model => model.SoLuong));

#line default
#line hidden
            EndContext();
            BeginContext(1029, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1077, 99, false);
#line 40 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\NhanSu\ThongTinBoPhan.cshtml"
Write(Html.ActionLink("Sửa", "SuaBoPhan", "NhanSu", new { id = Model.Id },new {@class="btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1183, 101, false);
#line 41 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\NhanSu\ThongTinBoPhan.cshtml"
Write(Html.ActionLink("Trở Về", "Index", "NhanSu", new { id = Model.Id },new {@class="btn btn-secondary" }));

#line default
#line hidden
            EndContext();
            BeginContext(1284, 12, true);
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CaseStudy.Live.Models.NhanSu.Response.ThongTinBoPhanTheoId> Html { get; private set; }
    }
}
#pragma warning restore 1591