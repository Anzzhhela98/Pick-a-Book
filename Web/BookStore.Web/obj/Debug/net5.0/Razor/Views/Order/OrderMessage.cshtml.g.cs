#pragma checksum "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Order\OrderMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26c7216cedc825464cad07ea7d605e5b5ff8af8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderMessage), @"mvc.1.0.view", @"/Views/Order/OrderMessage.cshtml")]
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
#line 1 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\_ViewImports.cshtml"
using BookStore.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\_ViewImports.cshtml"
using BookStore.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Order\OrderMessage.cshtml"
using BookStore.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26c7216cedc825464cad07ea7d605e5b5ff8af8f", @"/Views/Order/OrderMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708faaeb98415dfb74d8da32f9a9971ba8f1fe6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("?????????? ???? ???????????????? ????????????????"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Order\OrderMessage.cshtml"
  
    this.ViewData["Title"] = "Orders";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"breadcrumbs\">\r\n    <div class=\"container\">\r\n        <ul class=\"items\">\r\n            <li class=\"item home\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26c7216cedc825464cad07ea7d605e5b5ff8af8f4733", async() => {
                WriteLiteral("\r\n                   Main Page\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </li>
            <li class=""item cms_page"">
                <strong>???????????????? ???? 2,90 ????.; ?????? ?????????????? ???? ???????????????? ?????? 39 ????. ??? ??????????????????</strong>
            </li>
        </ul>
    </div>
</div>

<main id=""maincontent"" class=""page-main""><a href=""#"" id=""contentarea"" tabindex=""-1"" style=""visibility: hidden; display:none;"">skip</a>
<div class=""columns col1-layout""><div class=""container""><div class=""row""><div class=""col-lg-12 col-md-12""> <div class=""page-title-wrapper"">
<h2 class=""page-title"">
<span class=""base"" data-ui-id=""page-title-wrapper"">???????????????? ???? 2,90 ????.; ?????? ?????????????? ???? ???????????????? ?????? 39 ????. ??? ??????????????????</span> </h2>
</div>
<div class=""page messages""><div data-placeholder=""messages""></div>
<div data-bind=""scope: 'messages'"">
</div>

</div><div class=""column main""><input name=""form_key"" type=""hidden"" value=""vWC17MxvJFgsc6xM"">


<div></div><p>???????????? ???????????? ???? ???????????????????? ?????????? ?????????????? ?????? ???? 9,30 ???? 18,00 ??.<br><br>?????????????????? ???? 16,00 ??. ?????????????? ???? ???????????????? ?? ?????????????? ???? ????????");
            WriteLiteral(@"???????? ???? ?????????????????? ???????????? ?? ?????????????? ???? 3 ??????????????&nbsp;??????&nbsp;?????? ???????????? ?????????????? ???? ???????????????????? ???? ?????????????????????? ???????????????? ??????????. ???? ???????????????? ???????????????????? ???????????? ???????? ?? ?????????????????? ???????????? ?????????????"".</p>
<p><strong>???????????????????? ???? ?????????? ???? ?????????????????? ???????????????? ???? ???????????????????? ???? ???????????? ???? ???????????????????? ?? ?????????????? ???? ?????? ??????????????&nbsp;??????.</strong></p>
<p><br><br><strong>???????????????????? ?? ?????????????? ???? ???????????????? ?? 2,90 ????.</strong></p>
<p>&nbsp;</p>
<p><strong>?????? ?????????????? ???? ???????????????? ?????? 39 ????. ???????????????????? ?? ??????????????????.</strong></p>
<p><br><br>???????????? ???????????????? ???????? ???? ?? ?????????????????? ???????????? ?? ?????????????? ??????.<br><br>?????????????? ???? ???????????????? ?? ?????????????? ????????????, ???????? e-Pay ?? PayPal.<br><br>&nbsp;<br>?????? ???????????? ???? ?????????? ?? ?????????? ???? ?????????????????? ???????? ???????????? ???? ?????????????????????????? ?????????????????????? ???????????? ???????????????????? ???????? ???? ?????? 1 ???????? ???? ????????. ?????????????????????? ???????? ???? ???????????????? ?? ?????????????? ?? 3,80 ???????? (???? ?????????? ?? ?????????? ???? 200 ??. ?? ?????????????? ???? ????) ?? ???????????????? ?? ???????????????????? ???? ?????????????????? ??????????????.</p>
<p>&nbsp;</p>
<p><strong>?????????? ???? ?????????? ?????? ???????????? ?????????????? ?? ???????????????????? ???????????????? ??????</");
            WriteLiteral(@"strong></p>
<p>???????????????????? ???????????????? ???? ?????????????????????? ?????????? ???? ?????????? ?????? online ??????????????</p>
<p>???????????? ???????? ??????:&nbsp;<a href=""https://kzp.bg/standarten-formulyar-za-uprazhnyavane-pravo-na-otkaz-pri-online-pokupki"" target=""_blank"" rel=""noopener"">https://kzp.bg/standarten-formulyar-za-uprazhnyavane-pravo-na-otkaz-pri-online-pokupki</a></p>
<p>??????????????????&nbsp;<span style=""text-decoration: underline;""><a href=""https://kzp.bg/data/content/u/8/upload/Formulqr%20otkaz%20online.docx"" target=""_blank"" rel=""noopener"">??????????</a>&nbsp;</span></p>
<p>???????? ??????&nbsp;<strong>?????????????? ???? ???????????? ???? ?????????????????????????? (??????)&nbsp;</strong><span style=""text-decoration: underline;""><a href=""https://kzp.bg/"" target=""_blank"" rel=""noopener"">https://kzp.bg</a></span></p>
<p>???????? ?????? ?????????????????????? ???? ???????????????? ???? ?????????????????????????? ?????????????? ???? ???????????????????????? ??????????????<span style=""text-decoration: underline;"">:&nbsp;<a href=""http://ec.europa.eu/consumers/odr"" target=""_blank"" rel=""noopener"">http://ec.europa.eu/consumers/odr</a></span></p>
<p>&nbsp;</p>
<p>");
            WriteLiteral("&nbsp;</p></div></div></div></div></div></main>");
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
