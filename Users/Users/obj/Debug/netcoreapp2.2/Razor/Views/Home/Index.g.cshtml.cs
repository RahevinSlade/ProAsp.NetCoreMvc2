#pragma checksum "\\Mac\Home\Documents\Projects\Users\Users\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c32ca1f97087dbd92a9b7f64733cabe8240c744"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c32ca1f97087dbd92a9b7f64733cabe8240c744", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e38fc85d67b46a9c29d34b86f463094dcec9fa2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<string, object>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 131, true);
            WriteLiteral("\r\n<div class=\"bg-primary m-1 p-1 text-white\"><h4>User Details</h4></div>\r\n\r\n<table class=\"table table-sm table-bordered m-1 p-1\">\r\n");
            EndContext();
#line 6 "\\Mac\Home\Documents\Projects\Users\Users\Views\Home\Index.cshtml"
     foreach(var kvp in Model)
    {

#line default
#line hidden
            BeginContext(205, 16, true);
            WriteLiteral("        <tr><th>");
            EndContext();
            BeginContext(222, 7, false);
#line 8 "\\Mac\Home\Documents\Projects\Users\Users\Views\Home\Index.cshtml"
           Write(kvp.Key);

#line default
#line hidden
            EndContext();
            BeginContext(229, 9, true);
            WriteLiteral("</th><td>");
            EndContext();
            BeginContext(239, 9, false);
#line 8 "\\Mac\Home\Documents\Projects\Users\Users\Views\Home\Index.cshtml"
                            Write(kvp.Value);

#line default
#line hidden
            EndContext();
            BeginContext(248, 12, true);
            WriteLiteral("</td></tr>\r\n");
            EndContext();
#line 9 "\\Mac\Home\Documents\Projects\Users\Users\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(267, 10, true);
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<string, object>> Html { get; private set; }
    }
}
#pragma warning restore 1591
