#pragma checksum "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e091fe185cafd63cb0396f780c818f51687c5ec1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administration_Views_Books_Details), @"mvc.1.0.view", @"/Areas/Administration/Views/Books/Details.cshtml")]
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
#line 1 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\_ViewImports.cshtml"
using BookStore.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\_ViewImports.cshtml"
using BookStore.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e091fe185cafd63cb0396f780c818f51687c5ec1", @"/Areas/Administration/Views/Books/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708faaeb98415dfb74d8da32f9a9971ba8f1fe6f", @"/Areas/Administration/Views/_ViewImports.cshtml")]
    public class Areas_Administration_Views_Books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookStore.Data.Models.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Book</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line (14,14)-(14,55) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line (17,14)-(17,51) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line (20,14)-(20,56) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line (23,14)-(23,52) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line (26,14)-(26,61) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line (29,14)-(29,57) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line (32,14)-(32,58) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line (35,14)-(35,54) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line (38,14)-(38,55) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line (41,14)-(41,51) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line (44,14)-(44,55) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Pages));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line (47,14)-(47,51) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.Pages));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line (50,14)-(50,55) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Cover));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line (53,14)-(53,51) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.Cover));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line (56,14)-(56,58) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line (59,14)-(59,54) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line (62,14)-(62,54) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line (65,14)-(65,50) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line (68,14)-(68,67) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayNameFor(model => model.DateOfPublication));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line (71,14)-(71,63) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.DateOfPublication));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line (74,14)-(74,62) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayNameFor(model => model.UniqueIdBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line (77,14)-(77,58) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.UniqueIdBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line (80,14)-(80,54) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayNameFor(model => model.ISBN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line (83,14)-(83,50) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.ISBN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line (86,14)-(86,65) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayNameFor(model => model.IsOnPromotional));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line (89,14)-(89,61) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.IsOnPromotional));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line (92,14)-(92,55) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line (95,14)-(95,54) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.Image.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line (98,14)-(98,58) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line (101,14)-(101,59) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.Category.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line (104,14)-(104,63) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayNameFor(model => model.CreatedByUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line (107,14)-(107,62) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.CreatedByUser.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line (110,14)-(110,59) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayNameFor(model => model.IsDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line (113,14)-(113,55) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.IsDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line (116,14)-(116,59) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayNameFor(model => model.DeletedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line (119,14)-(119,55) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.DeletedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line (122,14)-(122,59) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line (125,14)-(125,55) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line (128,14)-(128,60) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayNameFor(model => model.ModifiedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line (131,14)-(131,56) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.ModifiedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e091fe185cafd63cb0396f780c818f51687c5ec119248", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line (136,41)-(136,49) 13 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Areas\Administration\Views\Books\Details.cshtml"
WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e091fe185cafd63cb0396f780c818f51687c5ec121424", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookStore.Data.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
