#pragma checksum "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Home\Publishing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "604339a7b3c135f42d578f0f5d590e8df6a76b61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Publishing), @"mvc.1.0.view", @"/Views/Home/Publishing.cshtml")]
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
#line 1 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Home\Publishing.cshtml"
using BookStore.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"604339a7b3c135f42d578f0f5d590e8df6a76b61", @"/Views/Home/Publishing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708faaeb98415dfb74d8da32f9a9971ba8f1fe6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Publishing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Go to Home Page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Home\Publishing.cshtml"
  
    this.ViewData["Title"] = "Publishing";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"breadcrumbs\">\r\n<div class=\"container\">\r\n<ul class=\"items\">\r\n<li class=\"item home\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "604339a7b3c135f42d578f0f5d590e8df6a76b614665", async() => {
                WriteLiteral("\r\nHome ");
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
            WriteLiteral("\r\n</li>\r\n<li class=\"item cms_page\">\r\n<strong>");
#nullable restore
#line (14,10)-(14,32) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Home\Publishing.cshtml"
Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
</li>
</ul>
</div>
</div>
<div class=""column main""><input name=""form_key"" type=""hidden"" value=""IK9VSUJcmnjZhQVZ"">



<div></div><p><strong>Pick a book</strong> was established in 1992 and is the largest importer and distributor of foreign language literature in Bulgaria. The greatest merit of the company is supplying the Bulgarian market with the highest profile titles of the English and Russian literature simultaneously with their release in the respective countries.</p>
<p>The company’s professionalism and dedication have made it a preferred business partner in Bulgaria for leading publishers such as Harper Collins, Penguin, Oxford, Random House, Elsevier, h.f. Ullmann, Thames &amp; Hudson, Phaido, Hachette, Parrogon, Dorling Kindersley, ACT, EKSMO.</p>
<p>Pick a book is a leader in the publishing of quality picture albums, encyclopedias and reference books. The portfolio of the publishing house features over 540 titles from different fields: art, design, architecture, geography, natura");
            WriteLiteral(@"l and historical landmarks, gardening, transport, food and drink, military history, culinary art, psychology, naturopathy, photography, books on self-improvement, dictionaries, music, sports. Most of the books are from world famous series such as: <em>1001 Natural Wonders You Must See</em><em>, </em><em>501 Must Visit Cities</em><em>, Encyclopedia of the Sacred Places, The Wonderful Culinary Journey, The Golden Book of Chocolate, Art – The Whole Story, Historical&nbsp; Atlas, The Psychology Book, The History book, The Politic book, The Art book, The Math book, Curious History of Mathematics, Photography, The Whole Story</em><em>, How to Avoid a Climate Disaster</em><em>, </em>&nbsp;<em>The Power of Geography</em>, <em>The Art of Business Wars, Done! The Secret Deals that are Changing our World</em> and many others.</p>
<p><strong>Pick a book</strong> is also one of the leading publishers in the field of children's literature, including all genres and age segments. The books are of high print quality, giving ");
            WriteLiteral(@"the youngest readers not only knowledge but also teaching them values, encouraging independent thinking, imagination and various activities.</p>
<p>Apart from its own bookstores, <strong>Pick a book </strong>has over 21 exclusively managed commercial outlets for selling books at busy locations such as large retail chains, airport terminals, etc. It is also a leader in the sales of e-books through its website, <a");
            BeginWriteAttribute("href", " href=\"", 2785, "\"", 2792, 0);
            EndWriteAttribute();
            WriteLiteral("></a></p> \r\n");
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