#pragma checksum "C:\Users\halil\source\repos\database_programming_week_seven\udemy_asp\middleware_edit\middleware_edit\Views\Shared\Components\News\Blue.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8c194d3d598ca98182a61b25e0841e230ed847bae54ae57621c2ae7062fa2da9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_News_Blue), @"mvc.1.0.view", @"/Views/Shared/Components/News/Blue.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\halil\source\repos\database_programming_week_seven\udemy_asp\middleware_edit\middleware_edit\Views\_ViewImports.cshtml"
using middleware_edit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\halil\source\repos\database_programming_week_seven\udemy_asp\middleware_edit\middleware_edit\Views\_ViewImports.cshtml"
using middleware_edit.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\halil\source\repos\database_programming_week_seven\udemy_asp\middleware_edit\middleware_edit\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8c194d3d598ca98182a61b25e0841e230ed847bae54ae57621c2ae7062fa2da9", @"/Views/Shared/Components/News/Blue.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"034120de8f71520af3b23015c05141c342e55b1e8fe2a3952a40a90d0fa74f42", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_News_Blue : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<News>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul class=\"list-group\">\r\n");
#nullable restore
#line 4 "C:\Users\halil\source\repos\database_programming_week_seven\udemy_asp\middleware_edit\middleware_edit\Views\Shared\Components\News\Blue.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item text-primary\"  aria-currrent=\"true\">");
#nullable restore
#line 6 "C:\Users\halil\source\repos\database_programming_week_seven\udemy_asp\middleware_edit\middleware_edit\Views\Shared\Components\News\Blue.cshtml"
                                                                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 7 "C:\Users\halil\source\repos\database_programming_week_seven\udemy_asp\middleware_edit\middleware_edit\Views\Shared\Components\News\Blue.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<News>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591