#pragma checksum "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Views\Service\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7144d5c08dba598c03c96c45c05b4b0b1b1b863a63d79bad86dd1e0ef147be7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
#line 1 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7144d5c08dba598c03c96c45c05b4b0b1b1b863a63d79bad86dd1e0ef147be7f", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">

            <h4 class=""card-title"">Hizmetler</h4>

            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Başlık</th>
                            <th>Resim Linki</th>
                            <th>Sil</th>
                            <th>Düzenle</th>
                        </tr>
                    </thead>
");
#nullable restore
#line 26 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tbody>\r\n\r\n                            <tr>\r\n                                <td>");
#nullable restore
#line 31 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
                               Write(item.ServiceID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 32 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 33 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
                               Write(item.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1090, "\"", 1135, 2);
            WriteAttributeValue("", 1097, "/Service/DeleteService/", 1097, 23, true);
#nullable restore
#line 35 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
WriteAttributeValue("", 1120, item.ServiceID, 1120, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1220, "\"", 1263, 2);
            WriteAttributeValue("", 1227, "/Service/EditService/", 1227, 21, true);
#nullable restore
#line 36 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
WriteAttributeValue("", 1248, item.ServiceID, 1248, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n                            </tr>\r\n\r\n                        </tbody>\r\n");
#nullable restore
#line 40 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n                <a href=\"/Service/AddService/\" class=\"btn btn-outline-primary\">Hizmet Ekle</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
