#pragma checksum "\\Mac\Home\Documents\Projects\Views\Views\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "833043c2b394482206d44ce76439de0adae2f5d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"833043c2b394482206d44ce76439de0adae2f5d1", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("m-1 p-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 298, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "833043c2b394482206d44ce76439de0adae2f5d13250", async() => {
                BeginContext(31, 72, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(104, 13, false);
#line 5 "\\Mac\Home\Documents\Projects\Views\Views\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(117, 199, true);
                WriteLiteral("</title>\r\n    <link asp-href-include=\"lib/bootstrap/dist/css/*.min.css\" rel=\"stylesheet\" />\r\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\">\r\n");
                EndContext();
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
            EndContext();
            BeginContext(323, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(325, 519, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "833043c2b394482206d44ce76439de0adae2f5d15052", async() => {
                BeginContext(347, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(354, 23, false);
#line 10 "\\Mac\Home\Documents\Projects\Views\Views\Views\Shared\_Layout.cshtml"
Write(RenderSection("Header"));

#line default
#line hidden
                EndContext();
                BeginContext(377, 85, true);
                WriteLiteral("\r\n\r\n    <div class=\"bg-info\">\r\n        This is part of the layout\r\n    </div>\r\n\r\n    ");
                EndContext();
                BeginContext(463, 21, false);
#line 16 "\\Mac\Home\Documents\Projects\Views\Views\Views\Shared\_Layout.cshtml"
Write(RenderSection("Body"));

#line default
#line hidden
                EndContext();
                BeginContext(484, 81, true);
                WriteLiteral("\r\n\r\n    <div class=\"bg-info\">\r\n        This is part of the layout\r\n    </div>\r\n\r\n");
                EndContext();
#line 22 "\\Mac\Home\Documents\Projects\Views\Views\Views\Shared\_Layout.cshtml"
     if (IsSectionDefined("Footer"))
    {
        

#line default
#line hidden
                BeginContext(619, 23, false);
#line 24 "\\Mac\Home\Documents\Projects\Views\Views\Views\Shared\_Layout.cshtml"
   Write(RenderSection("Footer"));

#line default
#line hidden
                EndContext();
#line 24 "\\Mac\Home\Documents\Projects\Views\Views\Views\Shared\_Layout.cshtml"
                                
    }
    else
    {

#line default
#line hidden
                BeginContext(668, 45, true);
                WriteLiteral("        <h4>This is the default footer</h4>\r\n");
                EndContext();
#line 29 "\\Mac\Home\Documents\Projects\Views\Views\Views\Shared\_Layout.cshtml"
    }

#line default
#line hidden
                BeginContext(720, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(727, 31, false);
#line 31 "\\Mac\Home\Documents\Projects\Views\Views\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", false));

#line default
#line hidden
                EndContext();
                BeginContext(758, 79, true);
                WriteLiteral("\r\n\r\n    <div class=\"bg-info\">\r\n        This is part of the layout\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(844, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
