#pragma checksum "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Contact\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8c40430319d2d06aca86f3c59cbb959a4074f8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Contact), @"mvc.1.0.view", @"/Views/Contact/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8c40430319d2d06aca86f3c59cbb959a4074f8d", @"/Views/Contact/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708faaeb98415dfb74d8da32f9a9971ba8f1fe6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form contact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://knigomania.bg/contact/index/post/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-hasrequired", new global::Microsoft.AspNetCore.Html.HtmlString("* Задължителни полета"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\anzzh\OneDrive\Desktop\CSharp-Web\ASP.NET Core\Web\BookStore.Web\Views\Contact\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

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
                            <span class=""base"" data-ui-id=""page-title-wrapper"">За контакт</span>
                        </h2>
                    </div>
                    <div class=""page messages"">
                        <div data-placeholder=""messages""></div>
                        <div data-bind=""scope: 'messages'"">
                        </div>

                    </div><div class=""column main"">
                        <input name=""form_key"" type=""hidden"" value=""79ydPhlUvbpVD8ZD"">



                        <div></div><div class=""contact-us-page"">

                            <div class=""");
            WriteLiteral(@"row form-contact"">
                                <div class=""col-lg-4 col-md-4"">
                                    <div class=""contact-info"">
                                        <div class=""contact-content"">
                                            <p class=""contact-description"">При възникнали въпроси относно изпълнението на ваша поръчка, моля указвайте номера на поръчката.</p>
                                            <ul class=""address-info"">
                                                <li class=""add-icon"">София, 1408, ул. ""Д-р Стефан Сарафов"" 24,<br> блок 3, офис 1</li>
                                                <li class=""phone-icon"">
                                                    <strong>тел.:</strong> <a title=""Call"" href=""tel:02 421 58 51"">02 421 58 51</a>
                                                </li>
                                                <li class=""phone-icon"">
                                                    <strong>моб.:</strong> <a title=""C");
            WriteLiteral(@"all"" href=""tel:0893 305 100"">0893 305 100</a>
                                                </li>
                                                <li class=""email-icon"">
                                                    <strong>e-mail:</strong> <a title=""Send Email"" href=""mailto:online@knigomania.bg"">online@knigomania.bg</a>
                                                </li>
                                                <li class=""email-icon"">
                                                    <strong>e-mail:</strong> <a title=""Send Email"" href=""mailto:legacy@knigomania.bg"">legacy@knigomania.bg</a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-lg-8 col-md-8"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8c40430319d2d06aca86f3c59cbb959a4074f8d10182", async() => {
                WriteLiteral(@"
                                        <fieldset class=""fieldset"">
                                        <div class=""title-bonus-page"">
                                        <h2>Контактна форма</h2>
                                        </div>
                                        <div class=""left-input"">
                                        <div class=""field name required"">
                                        <div class=""control"">
                                        <input placeholder=""Име*"" name=""name"" id=""name"" title=""Име""");
                BeginWriteAttribute("value", " value=\"", 3788, "\"", 3796, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""input-text"" type=""text"" data-validate=""{required:true}"" aria-required=""true"">
                                        </div>
                                        </div>
                                        <div class=""field email required"">
                                        <div class=""control"">
                                        <input placeholder=""Email*"" name=""email"" id=""email"" title=""Имейл""");
                BeginWriteAttribute("value", " value=\"", 4224, "\"", 4232, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""input-text"" type=""email"" data-validate=""{required:true, 'validate-email':true}"" aria-required=""true"">
                                        </div>
                                        </div>
                                        <div class=""field telephone"">
                                        <div class=""control"">
                                        <input placeholder=""Телефон"" name=""telephone"" id=""telephone"" title=""Телефон""");
                BeginWriteAttribute("value", " value=\"", 4690, "\"", 4698, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""input-text"" type=""text"">
                                        </div>
                                        </div>
                                        </div>
                                        <div class=""field comment required"">
                                        <div class=""control"">
                                        <textarea placeholder=""Коментар*"" name=""comment"" id=""comment"" title=""Какво мислите?"" class=""input-text"" cols=""5"" rows=""3"" data-validate=""{required:true}"" aria-required=""true""></textarea>
                                        </div>
                                        </div>
                                        <div class=""field order_number"">
                                        <div class=""control"">
                                        <input placeholder=""Номер на поръчка"" name=""order_number"" id=""order_number"" title=""Номер на поръчка""");
                BeginWriteAttribute("value", " value=\"", 5619, "\"", 5627, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""input-text"" type=""text"">
                                        <small>При възникнали въпроси относно изпълнението на ваша поръчка, моля указвайте номера на поръчката.</small>
                                        </div>
                                        </div>
                                        <div class=""field-recaptcha"" id=""msp-recaptcha-d84b65fc916e7398083ea5f17089d8f1-container"" data-bind=""scope:'msp-recaptcha-d84b65fc916e7398083ea5f17089d8f1'"">
                                        </div>

                                        </fieldset>
                                        <div class=""actions-toolbar"">
                                        <div class=""primary"">
                                        <input type=""hidden"" name=""hideit"" id=""hideit""");
                BeginWriteAttribute("value", " value=\"", 6434, "\"", 6442, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8c40430319d2d06aca86f3c59cbb959a4074f8d14543", async() => {
                    WriteLiteral("Изпрати");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </div>\r\n                                        </div>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>");
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
