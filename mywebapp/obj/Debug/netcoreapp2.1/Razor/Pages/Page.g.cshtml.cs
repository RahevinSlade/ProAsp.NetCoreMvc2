#pragma checksum "/Users/rahevin/Projects/mywebapp/Pages/Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e15aa3bdb3ace2c4ac409673975104092e7484b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Page), @"mvc.1.0.razor-page", @"/Pages/Page.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Page.cshtml", typeof(AspNetCore.Pages_Page), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e15aa3bdb3ace2c4ac409673975104092e7484b6", @"/Pages/Page.cshtml")]
    public class Pages_Page : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(6, 167, true);
            WriteLiteral("\n<h1>If you type \"/Page\" in the url you should be able to see this!</h1>\n\n<b>The page starts with an at symbol and \"page\", you can also get the current date time with ");
            EndContext();
            BeginContext(174, 12, false);
#line 5 "/Users/rahevin/Projects/mywebapp/Pages/Page.cshtml"
                                                                                        Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(186, 7, true);
            WriteLiteral(" </b>\n\n");
            EndContext();
#line 7 "/Users/rahevin/Projects/mywebapp/Pages/Page.cshtml"
  
    var i = 2 + 2;

#line default
#line hidden
            BeginContext(217, 28, true);
            WriteLiteral("\n<p>This is how we do math, ");
            EndContext();
            BeginContext(246, 1, false);
#line 11 "/Users/rahevin/Projects/mywebapp/Pages/Page.cshtml"
                      Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(247, 10, true);
            WriteLiteral(" pm </p>\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Page> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Page> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Page>)PageContext?.ViewData;
        public Pages_Page Model => ViewData.Model;
    }
}
#pragma warning restore 1591
