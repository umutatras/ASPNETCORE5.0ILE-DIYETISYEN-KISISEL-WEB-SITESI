#pragma checksum "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\Makale\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0052187bbc8304232edbbb6a99e9ea5e76e9f078"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Makale_Index), @"mvc.1.0.view", @"/Views/Makale/Index.cshtml")]
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
#line 1 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\_ViewImports.cshtml"
using DiyetisyenProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\_ViewImports.cshtml"
using DiyetisyenProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\Makale\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0052187bbc8304232edbbb6a99e9ea5e76e9f078", @"/Views/Makale/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebd495df3e37bc636582426fbef36e26efe3a7c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Makale_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Makale>>
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
#line 3 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\Makale\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_ALayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"zxx\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0052187bbc8304232edbbb6a99e9ea5e76e9f0783919", async() => {
                WriteLiteral(@"

    <link href=""/blogsdetails/css/bootstrap.css"" rel='stylesheet' type='text/css' />
    <link href=""/blogsdetails/css/style.css"" rel='stylesheet' type='text/css' />
    <link href=""/blogsdetails/css/fontawesome-all.css"" rel=""stylesheet"">
    <link href=""//fonts.googleapis.com/css?family=Poppins:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800""
          rel=""stylesheet"">   

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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0052187bbc8304232edbbb6a99e9ea5e76e9f0785305", async() => {
                WriteLiteral(@"
    <div class=""banner-inner"">
    </div>
    <ol class=""breadcrumb"">
    </ol>

    <section class=""main-content-w3layouts-agileits"">
        <div class=""container"">
            <h3 class=""tittle"">Yazılarım</h3>
            <div class=""inner-sec"">
                <!--left-->
                <div class=""left-blog-info-w3layouts-agileits text-left"">
                    <div class=""row"">
");
#nullable restore
#line 36 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\Makale\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-lg-4 card\">\r\n\r\n                               <a> <img style=\"width:480px;height:380px\"");
                BeginWriteAttribute("src", " src=\"", 1228, "\"", 1245, 1);
#nullable restore
#line 40 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\Makale\Index.cshtml"
WriteAttributeValue("", 1234, item.Image, 1234, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"card-img-top img-fluid\"");
                BeginWriteAttribute("alt", " alt=\"", 1277, "\"", 1283, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>

                                <div class=""card-body"">
                                    <ul class=""blog-icons my-4"">
                                        <li>

                                            <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 46 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\Makale\Index.cshtml"
                                                                           Write(item.Dateinfo.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                        </li>\r\n\r\n\r\n                                    </ul>\r\n                                    <h5 class=\"card-title\">\r\n                                        <a>");
#nullable restore
#line 53 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\Makale\Index.cshtml"
                                      Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                    </h5>\r\n                                    <p class=\"card-text mb-3\">\r\n                                        ");
#nullable restore
#line 56 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\Makale\Index.cshtml"
                                   Write(item.Description.Substring(0,35));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ..\r\n                                    </p>\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 2103, "\"", 2143, 2);
                WriteAttributeValue("", 2110, "/Makale/MakaleRead/", 2110, 19, true);
#nullable restore
#line 59 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\Makale\Index.cshtml"
WriteAttributeValue("", 2129, item.MakaleID, 2129, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary read-m\">Devamını Oku...</a>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 62 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\Makale\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n\r\n\r\n");
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
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Makale>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
