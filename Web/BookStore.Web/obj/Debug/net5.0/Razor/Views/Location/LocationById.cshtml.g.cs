#pragma checksum "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Location\LocationById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "182260a86998ecff11307eae0fd6d624357425be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Location_LocationById), @"mvc.1.0.view", @"/Views/Location/LocationById.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"182260a86998ecff11307eae0fd6d624357425be", @"/Views/Location/LocationById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708faaeb98415dfb74d8da32f9a9971ba8f1fe6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Location_LocationById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookStore.Web.ViewModels.Location.LocationByIdViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Location\LocationById.cshtml"
  
    ViewData["Title"] = "Location";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main id=""maincontent"" class=""page-main"">
    <a href=""#"" id=""contentarea"" tabindex=""-1"" style=""visibility: hidden; display:none;"">skip</a>

    <div class=""columns col1-layout"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 col-md-12"">
                    <div class=""page-title-wrapper"">
                        <h2 class=""page-title"">
                            <span class=""base"" data-ui-id=""page-title-wrapper"">");
#nullable restore
#line (15,81)-(15,91) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Location\LocationById.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </h2>
                    </div>
                    <div class=""page messages"">
                        <div data-placeholder=""messages""></div>
                        <div data-bind=""scope: 'messages'"">
                            <!-- ko if: cookieMessages && cookieMessages.length > 0 --><!-- /ko -->
                            <!-- ko if: messages().messages && messages().messages.length > 0 --><!-- /ko -->
                        </div>

                    </div><div class=""column main"">
                        <input name=""form_key"" type=""hidden"" value=""ITNynr7jz0cdTJXS"">
                        <div></div><p><strong>адрес: </strong>");
#nullable restore
#line (27,64)-(27,77) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Location\LocationById.cshtml"
Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p><strong>телефон: </strong>");
#nullable restore
#line (28,55)-(28,72) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Location\LocationById.cshtml"
Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p><strong>e-mail</strong>: <a");
            BeginWriteAttribute("href", " href=\"", 1444, "\"", 1470, 2);
            WriteAttributeValue("", 1451, "mailto:", 1451, 7, true);
#nullable restore
#line (29,69)-(29,81) 30 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Location\LocationById.cshtml"
WriteAttributeValue("", 1458, Model.Email, 1458, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line (29,84)-(29,95) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Location\LocationById.cshtml"
Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                        <p>&nbsp;</p>\r\n                        <p><strong>Работно време:</strong></p>\r\n                        <p>Понeделник - петък: ");
#nullable restore
#line (32,49)-(32,66) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Location\LocationById.cshtml"
Write(Model.WorkingTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <p>Събота: 10,00 -18,00 ч.</p>
                        <p>Неделя: почивен ден</p>
                        <p>&nbsp;</p>
                        <p><strong>Местоположение:</strong></p>
                        <p><iframe style=""border: 0;"" src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2932.816383298338!2d23.32188841553484!3d42.68643167916633!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40aa850c1c23f80b%3A0x8312d322c834fb39!2z0JrQvdC40LPQvtC80LDQvdC40Y8!5e0!3m2!1sbg!2sbg!4v1490881489048"" width=""600"" height=""450""></iframe></p>
                        <p>&nbsp;</p>
                        <p><strong>Снимка от книжарницата:</strong></p>
                        <p><strong>
                         <img");
            BeginWriteAttribute("src", " src=\"", 2424, "\"", 2442, 1);
#nullable restore
#line (41,36)-(41,48) 30 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Location\LocationById.cshtml"
WriteAttributeValue("", 2430, Model.Image, 2430, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2443, "\"", 2449, 0);
            EndWriteAttribute();
            WriteLiteral("></strong></p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookStore.Web.ViewModels.Location.LocationByIdViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
