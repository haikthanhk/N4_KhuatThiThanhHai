#pragma checksum "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\User\ForgotPassword.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c3813ad47b390208084aea3b5472af3f40cb6ee882d58262161c346d7d3ca5fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ForgotPassword), @"mvc.1.0.view", @"/Views/User/ForgotPassword.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\_ViewImports.cshtml"
using KoreaNews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\_ViewImports.cshtml"
using KoreaNews.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c3813ad47b390208084aea3b5472af3f40cb6ee882d58262161c346d7d3ca5fd", @"/Views/User/ForgotPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9308ce8eac1e482482e757ddc38014dd8f7fa05acb9964916373288ac8c056c2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_ForgotPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("forgotPassword"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3813ad47b390208084aea3b5472af3f40cb6ee882d58262161c346d7d3ca5fd4431", async() => {
                WriteLiteral(@"
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">

    <style>
        html {
            background: #007bff;
        }

        body {
            font-family: Arial, Helvetica, sans-serif;
        }

        .form-login {
            width: 50%;
            margin: 5% auto;
        }

            .form-login h2 {
                font-size: 40px;
                text-align: center;
            }

            .form-login form {
                border: 3px solid #f1f1f1;
            }

            .form-login .alert {
                padding: 20px;
                background-color: #f44336;
                color: white;
                width: 90%;
                margin: 0 auto;
            }

            .form-login .closebtn {
                margin-left: 15px;
                color: white;
                font-weight: bold;
                float: right;
                font-size: 22px;
                line-height: 20px;
                cursor: pointer;
                transition: 0.3");
                WriteLiteral(@"s;
            }

                .form-login .closebtn:hover {
                    color: black;
                }

            .form-login input[type=text],
            .form-login input[type=email],
            .form-login input[type=password] {
                width: 100%;
                padding: 12px 20px;
                margin: 8px 0;
                display: inline-block;
                border: 1px solid #ccc;
                box-sizing: border-box;
            }

            .form-login button {
                background-color: #d8302f;
                color: white;
                padding: 14px 20px;
                margin: 8px 0;
                border: none;
                cursor: pointer;
                width: 100%;
            }

            .form-login cancelbtn:hover {
                opacity: 0.8;
                text-decoration: none;
            }

            .form-login .cancelbtn {
                width: auto;
                padding: 10px 18px;
                background-color: #f4");
                WriteLiteral(@"4336;
                text-decoration: none;
                color: #fff;
            }

            .form-login .imgcontainer {
                text-align: center;
                margin: 24px 0 12px 0;
            }

            .form-login .container {
                padding: 16px;
            }

            .form-login span.psw {
                float: right;
                padding-top: 16px;
            }

            .form-login .private {
                margin: 20px 10px;
            }

            .form-login span.private {
                margin-left: 44%;
            }

        media screen and (max-width: 300px) {
            .form-login span.psw

        {
            display: block;
            float: none;
        }

        .form-login .cancelbtn {
            width: 100%;
        }

        }

        .form-login .imgcontainer {
            text-align: center;
            margin: 24px 0 12px 0;
        }
    </style>

    <title>Forgot Password</title>
");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3813ad47b390208084aea3b5472af3f40cb6ee882d58262161c346d7d3ca5fd8526", async() => {
                WriteLiteral("\n    <div class=\"form-login\">\n\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3813ad47b390208084aea3b5472af3f40cb6ee882d58262161c346d7d3ca5fd8848", async() => {
                    WriteLiteral("\n            <h2>Forgot Password</h2>\n");
#nullable restore
#line 135 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\User\ForgotPassword.cshtml"
             if (ViewBag.Error != null)
            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                <div class=\"alert\">\n                    <span class=\"closebtn\" onclick=\"this.parentElement.style.display = \'none\';\">&times;</span>\n                    ");
#nullable restore
#line 139 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\User\ForgotPassword.cshtml"
               Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\n                </div>\n");
#nullable restore
#line 141 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\User\ForgotPassword.cshtml"
            }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"            <div class=""container"">
                <label for=""email""><b>Email</b></label>
                <input type=""email"" placeholder=""Enter Email"" name=""Email"" required>

                <button type=""submit"">Gửi</button>
            </div>
        ");
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
                WriteLiteral("\n\n        <div class=\"container\" style=\"background-color:#f1f1f1\">\n            <a href=\"/User/Login\" class=\"cancelbtn\">Back</a>\n        </div>\n    </div>\n");
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
            WriteLiteral("\n</html>\n\n\n\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
