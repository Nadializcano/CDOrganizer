#pragma checksum "/Users/Guest/Desktop/CDOrganizer.Solutions/CDOrganizer/Views/CDs/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12ecdc90d4841d1746d96ed027f126da6ec1dd89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CDs_Show), @"mvc.1.0.view", @"/Views/CDs/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CDs/Show.cshtml", typeof(AspNetCore.Views_CDs_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12ecdc90d4841d1746d96ed027f126da6ec1dd89", @"/Views/CDs/Show.cshtml")]
    public class Views_CDs_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<h1>CD Details: </h1>\n\n<h2>");
            EndContext();
            BeginContext(28, 28, false);
#line 3 "/Users/Guest/Desktop/CDOrganizer.Solutions/CDOrganizer/Views/CDs/Show.cshtml"
Write(Model["cd"].GetDescription());

#line default
#line hidden
            EndContext();
            BeginContext(56, 20, true);
            WriteLiteral("</h2>\n<h3>Category: ");
            EndContext();
            BeginContext(77, 25, false);
#line 4 "/Users/Guest/Desktop/CDOrganizer.Solutions/CDOrganizer/Views/CDs/Show.cshtml"
         Write(Model["artist"].GetName());

#line default
#line hidden
            EndContext();
            BeginContext(102, 9, true);
            WriteLiteral("</h3>\n\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 111, "\'", 161, 3);
            WriteAttributeValue("", 118, "/artists/", 118, 9, true);
#line 6 "/Users/Guest/Desktop/CDOrganizer.Solutions/CDOrganizer/Views/CDs/Show.cshtml"
WriteAttributeValue("", 127, Model["category"].GetId(), 127, 26, false);

#line default
#line hidden
            WriteAttributeValue("", 153, "/cds/new", 153, 8, true);
            EndWriteAttribute();
            BeginContext(162, 155, true);
            WriteLiteral(">Add another CD</a>\n<a href=\'/artists\'>View all artists</a>\n<p><a href=\'/artists\'>Return to Artist list</a></p>\n<p><a href=\'/\'>Return to Main Page</a></p>\n");
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