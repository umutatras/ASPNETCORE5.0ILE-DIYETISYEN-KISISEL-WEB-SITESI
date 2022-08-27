#pragma checksum "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Areas\Admin\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "879e0d02c318d61bdd54ee5909538b8ecc286151"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Areas\Admin\Views\_ViewImports.cshtml"
using DiyetisyenProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Areas\Admin\Views\_ViewImports.cshtml"
using DiyetisyenProje.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Areas\Admin\Views\Blog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"879e0d02c318d61bdd54ee5909538b8ecc286151", @"/Areas/Admin/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d17764b4766f0c595daf7c3a08a624f2b0fbac5c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Areas\Admin\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<hr />
<br />

<div class=""container"">
    <p>
        <a class=""btn btn-primary"" href=""/Admin/Blog/Add/"">Yeni Blog Ekle</a>
    </p>
    <table class=""table table-bordered table-striped"" id=""myTable"">
        <thead>
            <tr>
                <th>
                    Resim
                </th>
                <th>
                    Başlık
                </th>
                <th>
                    Zaman
                </th>
                <th>
                    Kalori
                </th>
                <th>
                    İçerik
                </th>
                <th>
                    Açıklama
                </th>

                <th>Düzenle</th>
                <th>Sil</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 43 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Areas\Admin\Views\Blog\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n");
#nullable restore
#line 47 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Areas\Admin\Views\Blog\Index.cshtml"
                         if (item.Image != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 1162, "\"", 1179, 1);
#nullable restore
#line 49 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Areas\Admin\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1168, item.Image, 1168, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"85\" height=\"85\" />");
#nullable restore
#line 49 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Areas\Admin\Views\Blog\Index.cshtml"
                                                                            }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img src=\"/dietician/images/resim-yok.jpg\" width=\"85\" height=\"85\" />\r\n");
#nullable restore
#line 53 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Areas\Admin\Views\Blog\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 57 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Areas\Admin\Views\Blog\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 60 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Areas\Admin\Views\Blog\Index.cshtml"
                   Write(item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 63 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Areas\Admin\Views\Blog\Index.cshtml"
                   Write(item.Kcl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 66 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Areas\Admin\Views\Blog\Index.cshtml"
                   Write(item.Contents);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 69 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Areas\Admin\Views\Blog\Index.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1930, "\"", 1968, 2);
            WriteAttributeValue("", 1937, "/Admin/Blog/Update/", 1937, 19, true);
#nullable restore
#line 73 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Areas\Admin\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1956, item.BlogID, 1956, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Düzenle</a>\r\n                    </td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2062, "\"", 2100, 2);
            WriteAttributeValue("", 2069, "/Admin/Blog/Delete/", 2069, 19, true);
#nullable restore
#line 76 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Areas\Admin\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2088, item.BlogID, 2088, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a>\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 80 "C:\Users\Umut\Documents\GitHub\ASPNETCORE50ETICARET\DiyetisyenProje\DiyetisyenProje\Areas\Admin\Views\Blog\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
            $(document).ready(function () {
                $('#myTable').DataTable({
                    language: {
                        ""url"": ""//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Turkish.json"",
                    },
                });
            });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591