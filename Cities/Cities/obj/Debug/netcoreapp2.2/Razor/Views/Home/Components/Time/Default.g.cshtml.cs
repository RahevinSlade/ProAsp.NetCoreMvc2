#pragma checksum "\\Mac\Home\Documents\Projects\Cities\Cities\Views\Home\Components\Time\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "768a551808e98be92c7987251ac365e798393b6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_Time_Default), @"mvc.1.0.view", @"/Views/Home/Components/Time/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Components/Time/Default.cshtml", typeof(AspNetCore.Views_Home_Components_Time_Default))]
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
#line 1 "\\Mac\Home\Documents\Projects\Cities\Cities\Views\_ViewImports.cshtml"
using Cities.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"768a551808e98be92c7987251ac365e798393b6e", @"/Views/Home/Components/Time/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c233f03937df15b211d1bc47f018300d0fef95e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_Time_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DateTime>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 60, true);
            WriteLiteral("\r\n<div class=\"m-1 p-1 bg-info text-white\">\r\n    Rendered at ");
            EndContext();
            BeginContext(78, 26, false);
#line 4 "\\Mac\Home\Documents\Projects\Cities\Cities\Views\Home\Components\Time\Default.cshtml"
           Write(Model.ToString("HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(104, 9, true);
            WriteLiteral("\r\n </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DateTime> Html { get; private set; }
    }
}
#pragma warning restore 1591
