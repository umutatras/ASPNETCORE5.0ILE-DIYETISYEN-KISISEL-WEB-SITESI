#pragma checksum "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\DietProg\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "333c058ca5601fb2acfc4b85131184e5885d134d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DietProg_Index), @"mvc.1.0.view", @"/Views/DietProg/Index.cshtml")]
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
#line 1 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\DietProg\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"333c058ca5601fb2acfc4b85131184e5885d134d", @"/Views/DietProg/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebd495df3e37bc636582426fbef36e26efe3a7c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DietProg_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DietProgram>>
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
#line 3 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\DietProg\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_ALayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n <html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "333c058ca5601fb2acfc4b85131184e5885d134d3899", async() => {
                WriteLiteral(@"
        <meta charset=""utf-8"">
        <meta http-equiv=""X-UA-Compatible"" content=""IE-edge"">
        <meta name=""viewport"" content=""width=device-width, intial-scale=1.0, maximum-scale=1.0, user-scalable=no"">
        <title>Blog Section</title>
        <!--Stylesheet----------------------------------->
        <link rel=""stylesheet"" type=""text/css"" href=""/blogsdetails/stil.css"" />
        <!--fav-icon------------------------------------->
        <link rel=""shortcut icon"" href=""images/fav-icon.svg"" />
        <!--poppins-font-family-------------------------->
        <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
        <link href=""https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap"" rel=""stylesheet"">
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "333c058ca5601fb2acfc4b85131184e5885d134d5760", async() => {
                WriteLiteral(@"
        <!--blog-section============================================================================-->
        <section id=""blog"">
            <!--blog-heading--------------->
            <div class=""blog-heading"">
                
                <h3>D??YET PROGRAMLARI</h3>
            </div>


            <!--container---------------->
            <div class=""blog-container"">

");
#nullable restore
#line 35 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\DietProg\Index.cshtml"
                foreach (var item in Model)
               {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"blog-box\">\r\n\r\n                 \r\n                    <div class=\"blog-img\">\r\n                        <img alt=\"blog\"");
                BeginWriteAttribute("src", " src=\"", 1653, "\"", 1670, 1);
#nullable restore
#line 41 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\DietProg\Index.cshtml"
WriteAttributeValue("", 1659, item.Image, 1659, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                    <!--text--->\r\n                    <div class=\"blog-text\">\r\n                        <span>");
#nullable restore
#line 45 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\DietProg\Index.cshtml"
                         Write(item.Dateinfo.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                        <a href=\"#\" class=\"blog-title\">");
#nullable restore
#line 46 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\DietProg\Index.cshtml"
                                                  Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                        <p>");
#nullable restore
#line 47 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\DietProg\Index.cshtml"
                      Write(item.Description.Substring(0,50));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2018, "\"", 2056, 2);
                WriteAttributeValue("", 2025, "/DietProg/DietRead/", 2025, 19, true);
#nullable restore
#line 48 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\DietProg\Index.cshtml"
WriteAttributeValue("", 2044, item.DietID, 2044, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Devam??n?? Oku...</a>\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 52 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Views\DietProg\Index.cshtml"
               }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n            </div>\r\n\r\n        </section>\r\n\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DietProgram>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
