#pragma checksum "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\DiemDanhBoPhan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdf91048aa3e686a376644fd09c2ba5df8280ab9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuanLy_DiemDanhBoPhan), @"mvc.1.0.view", @"/Views/QuanLy/DiemDanhBoPhan.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/QuanLy/DiemDanhBoPhan.cshtml", typeof(AspNetCore.Views_QuanLy_DiemDanhBoPhan))]
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
#line 2 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\DiemDanhBoPhan.cshtml"
using CaseStudy.Live.Models.QuanLy.Request;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdf91048aa3e686a376644fd09c2ba5df8280ab9", @"/Views/QuanLy/DiemDanhBoPhan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b6ab5c084b7527790fa663c194e85737c8f59d3", @"/Views/_ViewImports.cshtml")]
    public class Views_QuanLy_DiemDanhBoPhan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CaseStudy.Live.Models.QuanLy.Response.DiemDanh>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TaoDiemDanh", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "QuanLy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(113, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\DiemDanhBoPhan.cshtml"
  
    ViewData["Title"] = "DiemDanhBoPhan";

#line default
#line hidden
            BeginContext(165, 32, true);
            WriteLiteral("\r\n<h1>Điểm Danh Bộ Phận</h1>\r\n\r\n");
            EndContext();
            BeginContext(197, 2486, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdf91048aa3e686a376644fd09c2ba5df8280ab95775", async() => {
                BeginContext(252, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(258, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdf91048aa3e686a376644fd09c2ba5df8280ab96160", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 11 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\DiemDanhBoPhan.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(324, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 13 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\DiemDanhBoPhan.cshtml"
     if (TempData["Success"] != null)
    {

#line default
#line hidden
                BeginContext(374, 172, true);
                WriteLiteral("        <div class=\"alert alert-success alert-dismissible\">\r\n            <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n            <strong>");
                EndContext();
                BeginContext(547, 19, false);
#line 17 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\DiemDanhBoPhan.cshtml"
               Write(TempData["Success"]);

#line default
#line hidden
                EndContext();
                BeginContext(566, 27, true);
                WriteLiteral("</strong>\r\n        </div>\r\n");
                EndContext();
#line 19 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\DiemDanhBoPhan.cshtml"
    }

#line default
#line hidden
                BeginContext(600, 7, true);
                WriteLiteral("    <p>");
                EndContext();
                BeginContext(608, 40, false);
#line 20 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\DiemDanhBoPhan.cshtml"
  Write(Html.DisplayNameFor(model => model.Ngay));

#line default
#line hidden
                EndContext();
                BeginContext(648, 13, true);
                WriteLiteral("</p>\r\n    <p>");
                EndContext();
                BeginContext(661, 137, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fdf91048aa3e686a376644fd09c2ba5df8280ab99412", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 21 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\DiemDanhBoPhan.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().Ngay);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
#line 21 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\DiemDanhBoPhan.cshtml"
                                                                                WriteLiteral(Model.FirstOrDefault().Ngay.ToString("yyyy-MM-dd"));

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(798, 112, true);
                WriteLiteral("</p>\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(911, 41, false);
#line 27 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\DiemDanhBoPhan.cshtml"
               Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
                EndContext();
                BeginContext(952, 453, true);
                WriteLiteral(@"
                </th>
                <th>
                    Có mặt
                </th>
                <th>
                    Trễ
                </th>
                <th>
                    Không phép
                </th>
                <th>
                    Có phép
                </th>
                <th>
                    Theo quy định
                </th>
            </tr>
        </thead>
        <tbody>
");
                EndContext();
#line 47 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\DiemDanhBoPhan.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(1462, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1535, 135, false);
#line 51 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\DiemDanhBoPhan.cshtml"
                   Write(Html.ActionLink(item.HoTen, "DiemDanhNhanVien", "QuanLy", new LayDiemDanhNhanVienId { NhanVienId = item.NhanVienId, Ngay = item.Ngay }));

#line default
#line hidden
                EndContext();
                BeginContext(1670, 125, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <input type=\"radio\" name=\"TrangThai\" value=\"1\"");
                EndContext();
                BeginWriteAttribute("checked", " checked=\"", 1795, "\"", 1827, 1);
#line 54 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\DiemDanhBoPhan.cshtml"
WriteAttributeValue("", 1805, item.TrangThai == 1, 1805, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1828, 126, true);
                WriteLiteral(">\r\n                    </td>\r\n                    <td>\r\n                        <input type=\"radio\" name=\"TrangThai\" value=\"2\"");
                EndContext();
                BeginWriteAttribute("checked", " checked=\"", 1954, "\"", 1986, 1);
#line 57 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\DiemDanhBoPhan.cshtml"
WriteAttributeValue("", 1964, item.TrangThai == 2, 1964, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1987, 126, true);
                WriteLiteral(">\r\n                    </td>\r\n                    <td>\r\n                        <input type=\"radio\" name=\"TrangThai\" value=\"3\"");
                EndContext();
                BeginWriteAttribute("checked", " checked=\"", 2113, "\"", 2145, 1);
#line 60 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\DiemDanhBoPhan.cshtml"
WriteAttributeValue("", 2123, item.TrangThai == 3, 2123, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2146, 126, true);
                WriteLiteral(">\r\n                    </td>\r\n                    <td>\r\n                        <input type=\"radio\" name=\"TrangThai\" value=\"4\"");
                EndContext();
                BeginWriteAttribute("checked", " checked=\"", 2272, "\"", 2304, 1);
#line 63 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\DiemDanhBoPhan.cshtml"
WriteAttributeValue("", 2282, item.TrangThai == 4, 2282, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2305, 126, true);
                WriteLiteral(">\r\n                    </td>\r\n                    <td>\r\n                        <input type=\"radio\" name=\"TrangThai\" value=\"5\"");
                EndContext();
                BeginWriteAttribute("checked", " checked=\"", 2431, "\"", 2463, 1);
#line 66 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\DiemDanhBoPhan.cshtml"
WriteAttributeValue("", 2441, item.TrangThai == 5, 2441, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2464, 53, true);
                WriteLiteral(">\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 69 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\DiemDanhBoPhan.cshtml"
            }

#line default
#line hidden
                BeginContext(2532, 144, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <div class=\"form-group\">\r\n        <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2683, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2705, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 78 "F:\Back-end\QLNS\QLNS.Web\CaseStudy.Live\Views\QuanLy\DiemDanhBoPhan.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(2775, 245, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            // show the alert\r\n            setTimeout(function () {\r\n                $(\".alert\").alert(\'close\');\r\n            }, 5000);\r\n        });\r\n    </script>\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CaseStudy.Live.Models.QuanLy.Response.DiemDanh>> Html { get; private set; }
    }
}
#pragma warning restore 1591
