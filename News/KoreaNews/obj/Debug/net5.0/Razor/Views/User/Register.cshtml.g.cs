#pragma checksum "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\User\Register.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "743d1a5eafe258c3b83212d9266b35acacae3d96da63875871c55cc68905b58c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Register), @"mvc.1.0.view", @"/Views/User/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"743d1a5eafe258c3b83212d9266b35acacae3d96da63875871c55cc68905b58c", @"/Views/User/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9308ce8eac1e482482e757ddc38014dd8f7fa05acb9964916373288ac8c056c2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("register"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "743d1a5eafe258c3b83212d9266b35acacae3d96da63875871c55cc68905b58c4395", async() => {
                WriteLiteral(@"
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">

    <style>
        html {
            color: cadetblue;
            background:cadetblue;
        }

        body {
            font-family: Arial, Helvetica, sans-serif;
            background-color: white;
        }

        .form-register {
            width: 50%;
            margin: 3% auto;
        }

            .form-register h1 {
                text-align: center;
                font-size: 40px;
            }

            .form-register * {
                box-sizing: border-box;
            }

            .form-register .container {
                padding: 16px;
                background-color: white;
            }

            .form-register input[type=text],
            .form-register input[type=email],
            .form-register input[type=password] {
                width: 100%;
                padding: 15px;
                margin: 5px 0 22px 0;
                display: inline-block;
                border: none;
    ");
                WriteLiteral(@"            background: #f1f1f1;
            }

                .form-register input[type=text]:focus,
                .form-register input[type=email]:focus,
                .form-register input[type=password]:focus {
                    background-color: #ddd;
                    outline: none;
                }

            .form-register hr {
                border: 1px solid #f1f1f1;
                margin-bottom: 25px;
            }

            .form-register .registerbtn {
                background-color: #d8302f;
                color: white;
                padding: 16px 20px;
                margin: 8px 0;
                border: none;
                cursor: pointer;
                width: 100%;
                opacity: 0.9;
            }

                .form-register .registerbtn:hover {
                    opacity: 1;
                }

            .form-register a {
                color: dodgerblue;
            }

            .form-register .signin {
                background-color: #f1f1f");
                WriteLiteral(@"1;
                text-align: center;
            }

            .form-register .alert {
                padding: 20px;
                background-color: #f44336;
                color: white;
                width: 100%;
                margin: 10px auto;
            }

            .form-register .closebtn {
                margin-left: 15px;
                color: white;
                font-weight: bold;
                float: right;
                font-size: 22px;
                line-height: 20px;
                cursor: pointer;
                transition: 0.3s;
            }

                .form-register .closebtn:hover {
                    color: black;
                }

            .form-register .imgcontainer {
                text-align: center;
                margin: 24px 0 12px 0;
            }
    </style>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "743d1a5eafe258c3b83212d9266b35acacae3d96da63875871c55cc68905b58c8343", async() => {
                WriteLiteral("\n    <div class=\"form-register\">\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "743d1a5eafe258c3b83212d9266b35acacae3d96da63875871c55cc68905b58c8666", async() => {
                    WriteLiteral("\n\n            <div class=\"container\">\n                <h1>Register</h1>\n                <hr>\n");
#nullable restore
#line 119 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\User\Register.cshtml"
                 if (ViewBag.Error1 != null)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <div class=\"alert\">\n                        <span class=\"closebtn\" onclick=\"this.parentElement.style.display = \'none\';\">&times;</span>\n                        ");
#nullable restore
#line 123 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\User\Register.cshtml"
                   Write(ViewBag.Error1);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\n                    </div>\n");
#nullable restore
#line 125 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\User\Register.cshtml"
                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                <label for=\"user\"><b>User Name</b></label>\n                <input type=\"text\" placeholder=\"Enter User Name\" name=\"Username\" id=\"user\" required>\n");
#nullable restore
#line 128 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\User\Register.cshtml"
                 if (ViewBag.Error2 != null)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <div class=\"alert\">\n                        <span class=\"closebtn\" onclick=\"this.parentElement.style.display = \'none\';\">&times;</span>\n                        ");
#nullable restore
#line 132 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\User\Register.cshtml"
                   Write(ViewBag.Error2);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\n                    </div>\n");
#nullable restore
#line 134 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\User\Register.cshtml"
                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                <label for=\"email\"><b>Email</b></label>\n                <input type=\"email\" placeholder=\"Enter Email\" name=\"Email\" id=\"email\" required>\n");
#nullable restore
#line 137 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\User\Register.cshtml"
                 if (ViewBag.Error3 != null)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <div class=\"alert\">\n                        <span class=\"closebtn\" onclick=\"this.parentElement.style.display = \'none\';\">&times;</span>\n                        ");
#nullable restore
#line 141 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\User\Register.cshtml"
                   Write(ViewBag.Error3);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\n                    </div>\n");
#nullable restore
#line 143 "C:\Users\DELL\Documents\PRN211-Project-Huyennkhe172519\News\KoreaNews\Views\User\Register.cshtml"
                }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                <label for=""psw""><b>Password</b></label>
                <input type=""password"" placeholder=""Enter Password"" name=""Password"" id=""psw"" required>

                <label for=""psw-repeat""><b>Confirm Password</b></label>
                <input type=""password"" placeholder=""Repeat Password"" name=""ConfirmPassword"" id=""psw-repeat"" required>
                <hr>

                <button type=""submit"" class=""registerbtn"">Register</button>
            </div>

            <div class=""container signin"">
                <p>Already have an account? <a href=""/User/Login"">Login</a>.</p>
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
                WriteLiteral("\n    </div>\n");
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
            WriteLiteral("\n</html>\n\n");
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
