#pragma checksum "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SendMessage.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6334eea876a94a180f77037a00ea969b4c80dd18d73f88a639bfe7068b05a277"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Message_SendMessage), @"mvc.1.0.view", @"/Areas/Writer/Views/Message/SendMessage.cshtml")]
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
#line 1 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Areas\Writer\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Areas\Writer\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6334eea876a94a180f77037a00ea969b4c80dd18d73f88a639bfe7068b05a277", @"/Areas/Writer/Views/Message/SendMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Message_SendMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.WriterMessage>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SendMessage.cshtml"
  
    ViewData["Title"] = "SendMessage";
    Layout = "~/Views/Shared/_WriteLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Yeni Mesaj Olustur</h1>\r\n<br />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6334eea876a94a180f77037a00ea969b4c80dd18d73f88a639bfe7068b05a2774703", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 11 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SendMessage.cshtml"
Write(Html.HiddenFor(x=>x.WriterMessageID,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 13 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SendMessage.cshtml"
Write(Html.Label("Alıcı Mail"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 14 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SendMessage.cshtml"
Write(Html.TextBoxFor(x=>x.Receiver, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n\r\n    ");
#nullable restore
#line 17 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SendMessage.cshtml"
Write(Html.Label("Konu"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 18 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SendMessage.cshtml"
Write(Html.TextBoxFor(x=>x.Subject, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n\r\n    ");
#nullable restore
#line 21 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SendMessage.cshtml"
Write(Html.Label("Mesaj"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 22 "C:\Users\Byolcu\Desktop\Github Uploads\Asp.Net-Core-5.0-ile-Web-Gelistirme\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SendMessage.cshtml"
Write(Html.TextAreaFor(x=>x.MessageContent, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n\r\n    <button class=\"btn btn-outline-success\">Gönder</button>\r\n");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.WriterMessage> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
