#pragma checksum "C:\Users\Riyaj\OneDrive\Desktop\New folder\ABC_Healthcare\Views\Cart\_PaypalPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c35be588d577e9d6211a4953a2bbad5d381a000"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart__PaypalPartial), @"mvc.1.0.view", @"/Views/Cart/_PaypalPartial.cshtml")]
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
#line 1 "C:\Users\Riyaj\OneDrive\Desktop\New folder\ABC_Healthcare\Views\_ViewImports.cshtml"
using HealthCare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Riyaj\OneDrive\Desktop\New folder\ABC_Healthcare\Views\_ViewImports.cshtml"
using HealthCare.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c35be588d577e9d6211a4953a2bbad5d381a000", @"/Views/Cart/_PaypalPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c96963c80250339d6033405a39578bdfed78282", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart__PaypalPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("paypalform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://www.paypal.com/us/cgi-bin/webscr"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Riyaj\OneDrive\Desktop\New folder\ABC_Healthcare\Views\Cart\_PaypalPartial.cshtml"
   
    int count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c35be588d577e9d6211a4953a2bbad5d381a0004536", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"cmd\" value=\"_cart\">\r\n    <input type=\"hidden\" name=\"upload\" value=\"1\">\r\n    <input type=\"hidden\" name=\"business\" value=\"riyajhingani238@gmail.com\">\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Riyaj\OneDrive\Desktop\New folder\ABC_Healthcare\Views\Cart\_PaypalPartial.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 372, "\"", 395, 2);
                WriteAttributeValue("", 379, "item_name_", 379, 10, true);
#nullable restore
#line 12 "C:\Users\Riyaj\OneDrive\Desktop\New folder\ABC_Healthcare\Views\Cart\_PaypalPartial.cshtml"
WriteAttributeValue("", 389, count, 389, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 396, "\"", 421, 1);
#nullable restore
#line 12 "C:\Users\Riyaj\OneDrive\Desktop\New folder\ABC_Healthcare\Views\Cart\_PaypalPartial.cshtml"
WriteAttributeValue("", 404, item.ProductName, 404, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 453, "\"", 473, 2);
                WriteAttributeValue("", 460, "amount_", 460, 7, true);
#nullable restore
#line 13 "C:\Users\Riyaj\OneDrive\Desktop\New folder\ABC_Healthcare\Views\Cart\_PaypalPartial.cshtml"
WriteAttributeValue("", 467, count, 467, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 474, "\"", 493, 1);
#nullable restore
#line 13 "C:\Users\Riyaj\OneDrive\Desktop\New folder\ABC_Healthcare\Views\Cart\_PaypalPartial.cshtml"
WriteAttributeValue("", 482, item.Price, 482, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 525, "\"", 547, 2);
                WriteAttributeValue("", 532, "quantity_", 532, 9, true);
#nullable restore
#line 14 "C:\Users\Riyaj\OneDrive\Desktop\New folder\ABC_Healthcare\Views\Cart\_PaypalPartial.cshtml"
WriteAttributeValue("", 541, count, 541, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 548, "\"", 570, 1);
#nullable restore
#line 14 "C:\Users\Riyaj\OneDrive\Desktop\New folder\ABC_Healthcare\Views\Cart\_PaypalPartial.cshtml"
WriteAttributeValue("", 556, item.Quantity, 556, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 15 "C:\Users\Riyaj\OneDrive\Desktop\New folder\ABC_Healthcare\Views\Cart\_PaypalPartial.cshtml"
        count++;
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"currency_code\" value=\"USD\">\r\n    <input type=\"image\" src=\"http://www.paypal.com/en_US/i/btn/x-click-but01.gif\" name=\"submit\" alt=\"Make payments with PayPal - it\'s fast, free and secure!\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
