#pragma checksum "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Member\Views\Member\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96b259ce6893f821c8475e25a81004e53580c82b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Member_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Member/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96b259ce6893f821c8475e25a81004e53580c82b", @"/Areas/Member/Views/Member/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e44ae01019361e377f0244715cd5b6d7561d01a3", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Member_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 1 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Member\Views\Member\Index.cshtml"
  
    Layout = "~/Areas/Member/Views/Shared/_MemberLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96b259ce6893f821c8475e25a81004e53580c82b2993", async() => {
                WriteLiteral(@"
<div>

    <h5 class=""display-3 text-danger"">Personel Sayfasına Hoşgeldiniz</h5>

    <hr class=""border-dark"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""card"">
                    <div class=""card-body shadow"">
                        <h3>Bildirimler<i class=""fas fa-bell fa-1x ml-2""></i></h3>
                        <hr>
");
                WriteLiteral("                        ");
#nullable restore
#line 20 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Member\Views\Member\Index.cshtml"
                   Write(await Component.InvokeAsync("StaffNotification"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </div>
                <hr>
                <div class=""card"">
                    <div class=""card-body shadow"">
                        <h3>
                            Mesajlar <i class=""fas fa-envelope-square fa-1x ml-2 text-muted""></i>
                        </h3>
                        <hr>
");
                WriteLiteral("                        ");
#nullable restore
#line 31 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Member\Views\Member\Index.cshtml"
                   Write(await Component.InvokeAsync("Message"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""card"">
                    <div class=""card-body show text-center"">
                        <h5>Görevlerin'de Yazmış Olduğu Toplam Rapor Sayısı<i class=""fas fa-clipboard fa-1x ml-2""></i></h5>
                        <hr class=""border-info"">
");
#nullable restore
#line 40 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Member\Views\Member\Index.cshtml"
                         if (@ViewBag.NumberOfReportsWritten > 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <strong class=\"badge badge-info\" style=\"font-size: 15px;\">");
#nullable restore
#line 42 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Member\Views\Member\Index.cshtml"
                                                                                 Write(ViewBag.NumberOfReportsWritten);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n");
#nullable restore
#line 43 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Member\Views\Member\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <strong class=\"badge badge-danger\" style=\"font-size: 15px;\">Şuan Yazılan Rapor Yok</strong>\r\n");
#nullable restore
#line 47 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Member\Views\Member\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </div>
                </div>
                <br>
                <div class=""card"">
                    <div class=""card-body show text-center"">
                        <h5>Yapılacak Görev Sayısı<i class=""far fa-list-alt fa-1x ml-2""></i></h5>
                        <hr class=""border-dark"">
");
#nullable restore
#line 55 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Member\Views\Member\Index.cshtml"
                         if (@ViewBag.NumberOfTaskToBe > 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <strong class=\"badge badge-warning\" style=\"font-size: 15px;\">");
#nullable restore
#line 57 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Member\Views\Member\Index.cshtml"
                                                                                    Write(ViewBag.NumberOfTaskToBe);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n");
#nullable restore
#line 58 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Member\Views\Member\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <strong class=\"badge badge-danger\">Şuan Yapılması Gereken Görev Yok</strong>\r\n");
#nullable restore
#line 62 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Member\Views\Member\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </div>
                </div>
                <br>
                <div class=""card"">
                    <div class=""card-body show text-center"">
                        <h5>Toplam Bitmiş Görev Sayısı<i class=""fas fa-clipboard-check fa-1x ml-2""></i></h5>
                        <hr class=""border-secondary"">
");
#nullable restore
#line 70 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Member\Views\Member\Index.cshtml"
                         if (@ViewBag.NumberOfTasksPerformed > 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <strong class=\"badge badge-success\" style=\"font-size: 15px;\">");
#nullable restore
#line 72 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Member\Views\Member\Index.cshtml"
                                                                                    Write(ViewBag.NumberOfTasksPerformed);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n");
#nullable restore
#line 73 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Member\Views\Member\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <strong class=\"badge badge-danger\" style=\"font-size: 15px;\">Şuan Bitirilen Görev Yok</strong>\r\n");
#nullable restore
#line 77 "D:\Asp.netCoreMVC\Chase\Chase.UI\Areas\Member\Views\Member\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                </div>\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
