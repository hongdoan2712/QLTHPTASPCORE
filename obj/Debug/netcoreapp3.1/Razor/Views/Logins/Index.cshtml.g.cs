<<<<<<< HEAD
#pragma checksum "D:\QLTHPTASPCORE\Views\Logins\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d62920eb44062643f7b4ae2c62cb953fe6d380f8"
=======
#pragma checksum "D:\DoAn2\QLTHPTASPCore\QLTHPT\Views\Logins\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e819f1536385367b79903020425a3441688bdbf"
>>>>>>> d653736b9351e4a87911b1f32699868e3b53a50f
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Logins_Index), @"mvc.1.0.view", @"/Views/Logins/Index.cshtml")]
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
#line 1 "D:\QLTHPTASPCORE\Views\_ViewImports.cshtml"
using QLTHPT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\QLTHPTASPCORE\Views\_ViewImports.cshtml"
using QLTHPT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e819f1536385367b79903020425a3441688bdbf", @"/Views/Logins/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"772303cc8cb73f667367781b9df5b6124072f5ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Logins_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QLTHPT.Models.Login>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-asp-controller", new global::Microsoft.AspNetCore.Html.HtmlString("Logins"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\QLTHPTASPCORE\Views\Logins\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout="~/Views/Shared/_LayoutLogin.cshtml";

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("  <div class=\"login-form-area mg-t-30 mg-b-40\">\r\n                <div class=\"container-fluid\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-lg-4\"></div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d62920eb44062643f7b4ae2c62cb953fe6d380f84251", async() => {
                WriteLiteral(@"
                            <div class=""col-lg-4"">
                                <div class=""login-bg"">
                                    <div class=""row"">
                                        <div class=""col-lg-12"">
                                            <div class=""logo"">
                                                <a href=""#""><img src=""img/logo/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 727, "\"", 733, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-12"">
                                            <div class=""login-title"">
                                                <h1>Login Form</h1>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-4"">
                                            <div class=""login-input-head"">
                                                <p>E-mail</p>
                                            </div>
                                        </div>
                                        <div class=""col-lg-");
                WriteLiteral(@"8"">
                                            <div class=""login-input-area"">
                                                <input type=""email"" name=""email"" />
                                                <i class=""fa fa-envelope login-user"" aria-hidden=""true""></i>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-4"">
                                            <div class=""login-input-head"">
                                                <p>Password</p>
                                            </div>
                                        </div>
                                        <div class=""col-lg-8"">
                                            <div class=""login-input-area"">
                                                <input type=""password"" name=""password"" />
             ");
                WriteLiteral(@"                                   <i class=""fa fa-lock login-user""></i>
                                            </div>
                                            <div class=""row"">
                                                <div class=""col-lg-12"">
                                                    <div class=""forgot-password"">
                                                        <a href=""#"">Forgot password?</a>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""row"">
                                                <div class=""col-lg-12"">
                                                    <div class=""login-keep-me"">
                                                        <label class=""checkbox"">
                                                            <input type=""checkbox"" name=""remember"" checked><i></i>Keep me ");
                WriteLiteral(@"logged in
                                                        </label>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-4"">

                                        </div>
                                        <div class=""col-lg-8"">
                                            <div class=""login-button-pro"">
                                                <button type=""submit"" class=""login-button login-button-rg"">Register</button>
                                                <button type=""submit"" class=""login-button login-button-lg"">Log in</button>
                                            </div>
                                        </div>
                            ");
                WriteLiteral("        </div>\r\n                                </div>\r\n                            </div>\r\n                        ");
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e819f1536385367b79903020425a3441688bdbf4344", async() => {
                WriteLiteral("\r\n    \r\n");
>>>>>>> d653736b9351e4a87911b1f32699868e3b53a50f
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QLTHPT.Models.Login>> Html { get; private set; }
    }
}
#pragma warning restore 1591
