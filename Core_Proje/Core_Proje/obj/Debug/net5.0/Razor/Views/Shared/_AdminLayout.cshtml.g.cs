#pragma checksum "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Views\Shared\_AdminLayout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "845ef874fe40b3f71a0762567c14cf1ed09e352ae6cff0b213cb5cefbd1cb69f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Views/Shared/_AdminLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"845ef874fe40b3f71a0762567c14cf1ed09e352ae6cff0b213cb5cefbd1cb69f", @"/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Views\Shared\_AdminLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n    <!-- Head -->\r\n    ");
#nullable restore
#line 10 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Views\Shared\_AdminLayout.cshtml"
Write(await Html.PartialAsync("/Views/Admin/PartialHead.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "845ef874fe40b3f71a0762567c14cf1ed09e352ae6cff0b213cb5cefbd1cb69f4066", async() => {
                WriteLiteral(@"
    <!-- Sidenav -->
    <nav class=""sidenav navbar navbar-vertical  fixed-left  navbar-expand-xs navbar-light bg-white"" id=""sidenav-main"">
        <div class=""scrollbar-inner"">
            <!-- Brand -->
            <div class=""sidenav-header  align-items-center"">
                <a class=""navbar-brand"" href=""javascript:void(0)"">
                    <img src=""/argon-dashboard/assets/img/brand/blue.png"" class=""navbar-brand-img"" alt=""..."">
                </a>
            </div>
           
            ");
#nullable restore
#line 23 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Views\Shared\_AdminLayout.cshtml"
       Write(await Html.PartialAsync("/Views/Admin/PartialSideBar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n    </nav>\r\n    <!-- Main content -->\r\n    <div class=\"main-content\" id=\"panel\">\r\n\r\n\r\n        <!-- Topnav -->\r\n       ");
#nullable restore
#line 32 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Views\Shared\_AdminLayout.cshtml"
  Write(await Html.PartialAsync("/Views/Admin/PartialNavbar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n        <!-- NavigationPartial -->\r\n        ");
#nullable restore
#line 36 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Views\Shared\_AdminLayout.cshtml"
   Write(await Html.PartialAsync("/Views/Admin/NavigationPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n        <!-- Page content -->\r\n        <div class=\"container-fluid mt--6\">\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                        ");
#nullable restore
#line 43 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Views\Shared\_AdminLayout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n        <!-- Footer -->\r\n        ");
#nullable restore
#line 48 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Views\Shared\_AdminLayout.cshtml"
   Write(await Html.PartialAsync("/Views/Admin/PartialFooter.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n    <!-- Argon Scripts -->\r\n    ");
#nullable restore
#line 57 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Views\Shared\_AdminLayout.cshtml"
Write(await Html.PartialAsync("/Views/Admin/PartialScript.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
