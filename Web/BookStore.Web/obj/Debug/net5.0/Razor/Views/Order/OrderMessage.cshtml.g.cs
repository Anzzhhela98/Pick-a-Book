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
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Отиди на основата страница"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                <strong>Доставка за 2,90 лв.; При поръчки на стойност над 39 лв. – безплатна</strong>
            </li>
        </ul>
    </div>
</div>

<main id=""maincontent"" class=""page-main""><a href=""#"" id=""contentarea"" tabindex=""-1"" style=""visibility: hidden; display:none;"">skip</a>
<div class=""columns col1-layout""><div class=""container""><div class=""row""><div class=""col-lg-12 col-md-12""> <div class=""page-title-wrapper"">
<h2 class=""page-title"">
<span class=""base"" data-ui-id=""page-title-wrapper"">Доставка за 2,90 лв.; При поръчки на стойност над 39 лв. – безплатна</span> </h2>
</div>
<div class=""page messages""><div data-placeholder=""messages""></div>
<div data-bind=""scope: 'messages'"">
</div>

</div><div class=""column main""><input name=""form_key"" type=""hidden"" value=""vWC17MxvJFgsc6xM"">


<div></div><p>Вашите заявки се обработват всеки работен ден от 9,30 до 18,00 ч.<br><br>Направени до 16,00 ч. поръчки за страната и чужбина се пред");
            WriteLiteral(@"ават на куриерска служба в рамките на 3 работни&nbsp;дни&nbsp;или според графика за обслужване на съответното населено място. За страната Книгомания работи само с куриерска служба „Спиди"".</p>
<p><strong>Доставките за София на наличните заглавия се изпълняват от куриер на Книгомания в рамките на два работни&nbsp;дни.</strong></p>
<p><br><br><strong>Доставката в рамките на страната е 2,90 лв.</strong></p>
<p>&nbsp;</p>
<p><strong>При поръчки на стойност над 39 лв. доставката е безплатна.</strong></p>
<p><br><br>Всички посочени цени са в български левове с включен ДДС.<br><br>Приемат се плащания с наложен платеж, чрез e-Pay и PayPal.<br><br>&nbsp;<br>При работа на сайта в режим на английски език цените се преизчисляват автоматично според официалния курс на БНБ 1 евро за деня. Минималната цена за доставка в чужбина е 3,80 евро (за книги с тегло до 200 г. в рамките на ЕС) и нараства в зависимост от избраната държава.</p>
<p>&nbsp;</p>
<p><strong>ПРАВО НА ОТКАЗ при онлайн поръчки и стандартен формуляр КЗП</");
            WriteLiteral(@"strong></p>
<p>Стандартен формуляр за упражняване право на отказ при online покупки</p>
<p>Онлайн линк КЗП:&nbsp;<a href=""https://kzp.bg/standarten-formulyar-za-uprazhnyavane-pravo-na-otkaz-pri-online-pokupki"" target=""_blank"" rel=""noopener"">https://kzp.bg/standarten-formulyar-za-uprazhnyavane-pravo-na-otkaz-pri-online-pokupki</a></p>
<p>Изтеглете&nbsp;<span style=""text-decoration: underline;""><a href=""https://kzp.bg/data/content/u/8/upload/Formulqr%20otkaz%20online.docx"" target=""_blank"" rel=""noopener"">оттук</a>&nbsp;</span></p>
<p>Линк към&nbsp;<strong>Комисия за защита на потребителите (КЗП)&nbsp;</strong><span style=""text-decoration: underline;""><a href=""https://kzp.bg/"" target=""_blank"" rel=""noopener"">https://kzp.bg</a></span></p>
<p>Линк към платформата за решаване на потребителски спорове на Европейската комисия<span style=""text-decoration: underline;"">:&nbsp;<a href=""http://ec.europa.eu/consumers/odr"" target=""_blank"" rel=""noopener"">http://ec.europa.eu/consumers/odr</a></span></p>
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
