#pragma checksum "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Book\Buy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d5d63fbfb9a92ddf32053f0f868434a233f9aa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Buy), @"mvc.1.0.view", @"/Views/Book/Buy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d5d63fbfb9a92ddf32053f0f868434a233f9aa9", @"/Views/Book/Buy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708faaeb98415dfb74d8da32f9a9971ba8f1fe6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Buy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookStore.Web.ViewModels.Books.BuyViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Payment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Charge", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Book\Buy.cshtml"
  
    this.ViewData["Title"] = "Shopping Cart";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d5d63fbfb9a92ddf32053f0f868434a233f9aa94780", async() => {
                WriteLiteral(@"
    <title>Shopping Cart</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" "">
    <link href=""https://fonts.googleapis.com/css?family=Montserrat"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""assets/css/style.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d5d63fbfb9a92ddf32053f0f868434a233f9aa96152", async() => {
                WriteLiteral(@"
    <main class=""page"">
        <section class=""shopping-cart dark"">
            <div class=""container"">
                <div class=""block-heading"">
                    <h2>Shopping Cart</h2>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc quam urna, dignissim nec auctor in, mattis vitae leo.</p>
                </div>
                <div class=""content"">
                    <div class=""row"">
                        <div class=""col-md-12 col-lg-8"">
                            <div class=""items"">
                                <div class=""product"">
                                    <div class=""row"">
                                        <div class=""col-md-3"">
                                            <img class=""img-fluid mx-auto d-block image""");
                BeginWriteAttribute("src", " src=\"", 1360, "\"", 1386, 1);
#nullable restore
#line (32,95)-(32,115) 30 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Book\Buy.cshtml"
WriteAttributeValue("", 1366, Model.ImageImageUrl, 1366, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                        </div>
                                        <div class=""col-md-8"">
                                            <div class=""info"">
                                                <div class=""row"">
                                                    <div class=""col-md-5 product-name"">
                                                        <div class=""product-name"">
                                                            <a href=""#"">");
#nullable restore
#line (39,74)-(39,85) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Book\Buy.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                                            <div class=\"product-info\">\r\n                                                                <div>Author: <span class=\"value\">");
#nullable restore
#line (41,99)-(41,111) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Book\Buy.cshtml"
Write(Model.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></div>\r\n                                                                <div>Language: <span class=\"value\">");
#nullable restore
#line (42,101)-(42,115) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Book\Buy.cshtml"
Write(Model.Language);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></div>\r\n                                                                <div>Pages: <span class=\"value\">");
#nullable restore
#line (43,98)-(43,109) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Book\Buy.cshtml"
Write(Model.Pages);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class=""col-md-4 quantity"">
                                                        <label for=""quantity"">Quantity:</label>
                                                        <input id=""quantity"" type=""number"" value=""1"" min = ""1""");
                BeginWriteAttribute("max", " max=\"", 2847, "\"", 2868, 1);
#nullable restore
#line (49,117)-(49,132) 30 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Book\Buy.cshtml"
WriteAttributeValue("", 2853, Model.Quantity, 2853, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control quantity-input\">\r\n                                                    </div>\r\n                                                    <div class=\"col-md-3 price\">\r\n                                                        <span id=\"price\">€");
#nullable restore
#line (52,76)-(52,87) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Book\Buy.cshtml"
Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                        <div class=""col-md-12 col-lg-4"">
                            <div class=""summary"">
                                <h3>Summary</h3>

                                <div class=""summary-item""><span class=""text"">Discount</span><span id=""discount"" class=""price"">0€</span></div>
                                <div class=""summary-item""><span class=""text"">Shipping</span><span id=""delivery"" class=""price"">€3.80</span></div>
                                <div class=""summary-item""><span class=""text"">Total</span><span id=""total"" class=""price"">");
#nullable restore
#line (68,122)-(68,133) 6 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Book\Buy.cshtml"
Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></div>\r\n\r\n                                <h3>Your details</h3>\r\n\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d5d63fbfb9a92ddf32053f0f868434a233f9aa912376", async() => {
                    WriteLiteral("\r\n                                    <input type=\"text\" name=\"FullName\"");
                    BeginWriteAttribute("value", " value=\"", 4365, "\"", 4373, 0);
                    EndWriteAttribute();
                    WriteLiteral(" class=\"mb-2 w-100\" placeholder=\"Enter your Name\" />\r\n                                    <input type=\"text\" name=\"City\"");
                    BeginWriteAttribute("value", " value=\"", 4494, "\"", 4502, 0);
                    EndWriteAttribute();
                    WriteLiteral(" class=\"mb-2 w-100\" placeholder=\"Enter your City\" />\r\n                                    <input type=\"text\" name=\"Address\"");
                    BeginWriteAttribute("value", " value=\"", 4626, "\"", 4634, 0);
                    EndWriteAttribute();
                    WriteLiteral(" class=\"mb-2 w-100\" placeholder=\"Enter your Address\" />\r\n                                    <input type=\"text\" name=\"Number\"");
                    BeginWriteAttribute("value", " value=\"", 4760, "\"", 4768, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" class=""mb-2 w-100"" placeholder=""Enter your Phone Number"" />
                                    <input id=""orderCount"" type=""hidden"" name=""Count"" value=""1"" class=""mb-2 w-100"" placeholder=""Enter Count"" />

                                    <script id=""sPrice"" src=""//checkout.stripe.com/v2/checkout.js""
                                            class=""stripe-button""
                                            data-key=""pk_test_51KkssRBK8vsMODVi3tyH3xsyANw4tQQExRG52qjaqirUPxA4z2ZkRUyBPIQg5lzmbAzvDlYEoFb1S3CuxRJPgd3t00PFM7ZXrZ""
                                            data-locate=""auto""
                                            data-description=""Sample Charge""
                                            data-amount="""">
                                    </script>



                                    <input id=""totalPriceTransfer"" type=""hidden"" name=""TotalPriceTransfer""");
                    BeginWriteAttribute("value", " value=\"", 5671, "\"", 5679, 0);
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line (72,99)-(72,107) 13 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Book\Buy.cshtml"
WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-12 col-lg-4\">\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n        </section>\r\n    </main>\r\n");
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
            WriteLiteral("\r\n<script src=\"https://code.jquery.com/jquery-3.2.1.min.js\"></script>\r\n<script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js\"></script>\r\n\r\n</html>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script type=""text/javascript"">
     var qnt = document.getElementById(""quantity"");
       let total = document.getElementById(""total"");

       total.textContent = (Number(total.textContent) + 3.80).toFixed(2)

      qnt.addEventListener(""click"", function(event)
     {
         event.preventDefault();
       let discount = document.getElementById(""discount"");
       let quantity = document.getElementById(""quantity"");
       let delivery = document.getElementById(""delivery"");
       let total = document.getElementById(""total"");
       let price = document.getElementById(""price"");

       let curQuantity = Number(quantity.value);
       let curDelivery = Number(delivery.textContent.split(""€"")[1]);
       let curPrice = Number(price.textContent.split(""€"")[1]);
       let curTotal = Number(total.textContent.split(""€"")[1]);

       let finalPrice = (curQuantity * curPrice) + curDelivery;

         if(Number(quantity.value) >= 10){
             discount.textContent = (finalPrice * 0.05).to");
                WriteLiteral(@"Fixed(2).toString()+""€"";
             finalPrice -= finalPrice * 0.05;
             discount.style.color = ""red"";
          }else{
               discount.textContent = ""€0""
          }

        total.textContent = finalPrice.toFixed(2).toString()+""€""
          $('#sPrice').attr('data-amount',finalPrice.toFixed(2) * 100);

    document.getElementById(""totalPriceTransfer"").value = finalPrice.toFixed(2) * 100;
    document.getElementById(""orderCount"").value = curQuantity;
     })
</script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookStore.Web.ViewModels.Books.BuyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
