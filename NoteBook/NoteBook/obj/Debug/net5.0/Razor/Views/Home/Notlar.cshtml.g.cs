#pragma checksum "C:\Users\pc\Desktop\E-Commerce\NoteBook\NoteBook\Views\Home\Notlar.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "70821b19fef36f1c2f83649a2e3b3df9ac873ba26940f6e1c70aeb57dfb4e158"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Notlar), @"mvc.1.0.view", @"/Views/Home/Notlar.cshtml")]
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
#line 1 "C:\Users\pc\Desktop\E-Commerce\NoteBook\NoteBook\Views\_ViewImports.cshtml"
using NoteBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Desktop\E-Commerce\NoteBook\NoteBook\Views\_ViewImports.cshtml"
using NoteBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"70821b19fef36f1c2f83649a2e3b3df9ac873ba26940f6e1c70aeb57dfb4e158", @"/Views/Home/Notlar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e989d6510169e2d5dd5d2c8b767502a06dbd3420e19c2731e95412e4ddbaf93c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Notlar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NoteBook.Models.TblNotlar>>
    #nullable disable
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\pc\Desktop\E-Commerce\NoteBook\NoteBook\Views\Home\Notlar.cshtml"
  
    ViewData["Title"] = "Notlar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70821b19fef36f1c2f83649a2e3b3df9ac873ba26940f6e1c70aeb57dfb4e1583631", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Bot Kartları</title>
    <link href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"" rel=""stylesheet"">
    <style>
        .bot-card {
            margin: 20px;
            border-radius: 15px;
            overflow: hidden;
            position: relative;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
            transition: transform 0.3s;
            border: 3px solid transparent;
        }

            .bot-card img {
                border-bottom: 1px solid #ddd;
                transition: transform 0.3s;
            }

            .bot-card:hover img {
                transform: scale(1.1);
            }

            .bot-card:hover {
                animation: flameEffect 2s infinite;
            }

        ");
                WriteLiteral(@"@keyframes flameEffect {
            0% {
                border-color: rgba(255, 69, 0, 0.5);
                box-shadow: 0 0 10px rgba(255, 69, 0, 0.5), 0 0 20px rgba(255, 140, 0, 0.5), 0 0 30px rgba(255, 69, 0, 0.5);
            }

            50% {
                border-color: rgba(255, 140, 0, 0.8);
                box-shadow: 0 0 20px rgba(255, 69, 0, 0.8), 0 0 30px rgba(255, 140, 0, 0.8), 0 0 40px rgba(255, 69, 0, 0.8);
            }

            100% {
                border-color: rgba(255, 69, 0, 0.5);
                box-shadow: 0 0 10px rgba(255, 69, 0, 0.5), 0 0 20px rgba(255, 140, 0, 0.5), 0 0 30px rgba(255, 69, 0, 0.5);
            }
        }

        .bot-card .btn-chat {
            width: 48%; /* Butonların genişliğini ayarla */
        }

        .btn-tumunu-oku {
            width: 48%;
            margin-top: 10px;
        }

        .bot-description {
            white-space: nowrap;
            overflow: hidden;
            text-overflow: ellipsis;
      ");
                WriteLiteral("  }\r\n    </style>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70821b19fef36f1c2f83649a2e3b3df9ac873ba26940f6e1c70aeb57dfb4e1586646", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 73 "C:\Users\pc\Desktop\E-Commerce\NoteBook\NoteBook\Views\Home\Notlar.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"col-md-4\">\r\n                    <div class=\"card bot-card\">\r\n\r\n                        <div class=\"card-body text-center\">\r\n                            <h5 class=\"bot-name\">");
#nullable restore
#line 79 "C:\Users\pc\Desktop\E-Commerce\NoteBook\NoteBook\Views\Home\Notlar.cshtml"
                                            Write(item.NotTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                            <hr />\r\n                            <p class=\"bot-description\">");
#nullable restore
#line 81 "C:\Users\pc\Desktop\E-Commerce\NoteBook\NoteBook\Views\Home\Notlar.cshtml"
                                                        if (item.NotText.Length > 30)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\pc\Desktop\E-Commerce\NoteBook\NoteBook\Views\Home\Notlar.cshtml"
                               Write(item.NotText.Substring(0, 30));

#line default
#line hidden
#nullable disable
                WriteLiteral("<span>...</span>\r\n");
#nullable restore
#line 84 "C:\Users\pc\Desktop\E-Commerce\NoteBook\NoteBook\Views\Home\Notlar.cshtml"
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\pc\Desktop\E-Commerce\NoteBook\NoteBook\Views\Home\Notlar.cshtml"
                               Write(item.NotText);

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\pc\Desktop\E-Commerce\NoteBook\NoteBook\Views\Home\Notlar.cshtml"
                                                 
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <div class=\"d-flex justify-content-between\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 2969, "\"", 3005, 2);
                WriteAttributeValue("", 2976, "/Home/NotGuncelle/", 2976, 18, true);
#nullable restore
#line 90 "C:\Users\pc\Desktop\E-Commerce\NoteBook\NoteBook\Views\Home\Notlar.cshtml"
WriteAttributeValue("", 2994, item.NotID, 2994, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-warning btn-chat\" >Düzenle</a>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 3096, "\"", 3127, 2);
                WriteAttributeValue("", 3103, "/Home/NotSil/", 3103, 13, true);
#nullable restore
#line 91 "C:\Users\pc\Desktop\E-Commerce\NoteBook\NoteBook\Views\Home\Notlar.cshtml"
WriteAttributeValue("", 3116, item.NotID, 3116, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-danger btn-chat\">Sil</a>\r\n                            </div>\r\n                            <br />\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 3280, "\"", 3314, 2);
                WriteAttributeValue("", 3287, "/Home/TumunuOku/", 3287, 16, true);
#nullable restore
#line 94 "C:\Users\pc\Desktop\E-Commerce\NoteBook\NoteBook\Views\Home\Notlar.cshtml"
WriteAttributeValue("", 3303, item.NotID, 3303, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-primary\">Tümünü Oku</a>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 99 "C:\Users\pc\Desktop\E-Commerce\NoteBook\NoteBook\Views\Home\Notlar.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            
        </div>
        <br />
        <br />
        <a href=""/Home/NotEkle/"" class=""btn btn-outline-info"">NOT EKLE</a>

    </div>

    <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""></script>
");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NoteBook.Models.TblNotlar>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
