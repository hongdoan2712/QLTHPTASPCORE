#pragma checksum "D:\DoAn2\QLTHPTASPCore\QLTHPT\Views\THUs1\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a87c064c583e372b1dd7784d5252eab3f2f02599"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_THUs1_Create), @"mvc.1.0.view", @"/Views/THUs1/Create.cshtml")]
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
#nullable restore
#line 1 "D:\DoAn2\QLTHPTASPCore\QLTHPT\Views\_ViewImports.cshtml"
using QLTHPT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoAn2\QLTHPTASPCore\QLTHPT\Views\_ViewImports.cshtml"
using QLTHPT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a87c064c583e372b1dd7784d5252eab3f2f02599", @"/Views/THUs1/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"772303cc8cb73f667367781b9df5b6124072f5ca", @"/Views/_ViewImports.cshtml")]
    public class Views_THUs1_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QLTHPT.Models.Thu>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DoAn2\QLTHPTASPCore\QLTHPT\Views\THUs1\Create.cshtml"
  
    ViewBag.Title = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""data-table-area mg-b-15"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""sparkline13-list shadow-reset"">
                        <div class=""sparkline13-hd"">
                            <div class=""main-sparkline13-hd"">
                                <h4><strong>Tạo Mới</strong></h4>

                            </div>
                        </div>
                        <div class=""sparkline13-graph"">
");
#nullable restore
#line 20 "D:\DoAn2\QLTHPTASPCore\QLTHPT\Views\THUs1\Create.cshtml"
                             using (Html.BeginForm())
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\DoAn2\QLTHPTASPCore\QLTHPT\Views\THUs1\Create.cshtml"
                           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"form-horizontal\">\r\n                                ");
#nullable restore
#line 25 "D:\DoAn2\QLTHPTASPCore\QLTHPT\Views\THUs1\Create.cshtml"
                           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <div class=\"form-group-inner\" style=\"text-align: left;\">\r\n                                    ");
#nullable restore
#line 27 "D:\DoAn2\QLTHPTASPCore\QLTHPT\Views\THUs1\Create.cshtml"
                               Write(Html.LabelFor(model => model.ThuMa, "Mã", htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 28 "D:\DoAn2\QLTHPTASPCore\QLTHPT\Views\THUs1\Create.cshtml"
                               Write(Html.EditorFor(model => model.ThuMa, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 29 "D:\DoAn2\QLTHPTASPCore\QLTHPT\Views\THUs1\Create.cshtml"
                               Write(Html.ValidationMessageFor(model => model.ThuMa, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n\r\n                                <div class=\"form-group-inner\" style=\"text-align: left;\">\r\n                                    ");
#nullable restore
#line 33 "D:\DoAn2\QLTHPTASPCore\QLTHPT\Views\THUs1\Create.cshtml"
                               Write(Html.LabelFor(model => model.ThuTen, "Tên", htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 34 "D:\DoAn2\QLTHPTASPCore\QLTHPT\Views\THUs1\Create.cshtml"
                               Write(Html.EditorFor(model => model.ThuTen, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 35 "D:\DoAn2\QLTHPTASPCore\QLTHPT\Views\THUs1\Create.cshtml"
                               Write(Html.ValidationMessageFor(model => model.ThuTen, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>

                                <div class=""form-group"" style=""text-align: left;"">
                                    <div style="" padding-left: 15px;"">
                                        <input type=""submit"" value=""Tạo"" class=""btn btn-default"" /> |
                                        <a");
            BeginWriteAttribute("href", " href=\"", 2312, "\"", 2346, 1);
#nullable restore
#line 41 "D:\DoAn2\QLTHPTASPCore\QLTHPT\Views\THUs1\Create.cshtml"
WriteAttributeValue("", 2319, Url.Action("Index", "Thu"), 2319, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\" btn btn-custon-rounded-three btn-primary\"><i class=\"fa fa-undo\"></i></a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 45 "D:\DoAn2\QLTHPTASPCore\QLTHPT\Views\THUs1\Create.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QLTHPT.Models.Thu> Html { get; private set; }
    }
}
#pragma warning restore 1591
