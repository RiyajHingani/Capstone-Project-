#pragma checksum "C:\Users\Riyaj\OneDrive\Desktop\New folder\ABC_Healthcare\Areas\Admin\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0882da88c7b17b1814a8fe4cb5f12db9ab21c8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Index.cshtml")]
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
#line 1 "C:\Users\Riyaj\OneDrive\Desktop\New folder\ABC_Healthcare\Areas\Admin\Views\_ViewImports.cshtml"
using HealthCare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Riyaj\OneDrive\Desktop\New folder\ABC_Healthcare\Areas\Admin\Views\_ViewImports.cshtml"
using HealthCare.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0882da88c7b17b1814a8fe4cb5f12db9ab21c8d", @"/Areas/Admin/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c96963c80250339d6033405a39578bdfed78282", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppUser>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Riyaj\OneDrive\Desktop\New folder\ABC_Healthcare\Areas\Admin\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Users";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Users</h1>


<table class=""table"">
    <thead>
        <tr>
            <th>
               Id
            </th>
            <th>
               UserName
            </th>
            <th>
               Email
            </th>
           
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 26 "C:\Users\Riyaj\OneDrive\Desktop\New folder\ABC_Healthcare\Areas\Admin\Views\Users\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n              ");
#nullable restore
#line 29 "C:\Users\Riyaj\OneDrive\Desktop\New folder\ABC_Healthcare\Areas\Admin\Views\Users\Index.cshtml"
         Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n               ");
#nullable restore
#line 32 "C:\Users\Riyaj\OneDrive\Desktop\New folder\ABC_Healthcare\Areas\Admin\Views\Users\Index.cshtml"
          Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n               ");
#nullable restore
#line 35 "C:\Users\Riyaj\OneDrive\Desktop\New folder\ABC_Healthcare\Areas\Admin\Views\Users\Index.cshtml"
          Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n           \r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Riyaj\OneDrive\Desktop\New folder\ABC_Healthcare\Areas\Admin\Views\Users\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
