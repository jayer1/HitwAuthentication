#pragma checksum "C:\Users\ayerj\source\repos\IS_Proj_HIT\IS_Proj_HIT\Views\Home\Sex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3c8a033d6cf15d08d62d9d7039083bed6f30f24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Sex), @"mvc.1.0.view", @"/Views/Home/Sex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Sex.cshtml", typeof(AspNetCore.Views_Home_Sex))]
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
#line 1 "C:\Users\ayerj\source\repos\IS_Proj_HIT\IS_Proj_HIT\Views\_ViewImports.cshtml"
using IS_Proj_HIT;

#line default
#line hidden
#line 2 "C:\Users\ayerj\source\repos\IS_Proj_HIT\IS_Proj_HIT\Views\_ViewImports.cshtml"
using IS_Proj_HIT.Models;

#line default
#line hidden
#line 1 "C:\Users\ayerj\source\repos\IS_Proj_HIT\IS_Proj_HIT\Views\Home\Sex.cshtml"
using isprojectHiT.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3c8a033d6cf15d08d62d9d7039083bed6f30f24", @"/Views/Home/Sex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81723f7e80dbbbf32eeb61f6ac242e5522c57fa1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Sex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Sex>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 118, true);
            WriteLiteral("<table>\r\n    <thead>\r\n        <tr><th>Sex ID</th><th>Name</th><th>Last Modified</th></tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 8 "C:\Users\ayerj\source\repos\IS_Proj_HIT\IS_Proj_HIT\Views\Home\Sex.cshtml"
         if (Model != null)
        {
            

#line default
#line hidden
#line 10 "C:\Users\ayerj\source\repos\IS_Proj_HIT\IS_Proj_HIT\Views\Home\Sex.cshtml"
             foreach (Sex s in Model)
            {

#line default
#line hidden
            BeginContext(265, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(312, 7, false);
#line 13 "C:\Users\ayerj\source\repos\IS_Proj_HIT\IS_Proj_HIT\Views\Home\Sex.cshtml"
                   Write(s.SexId);

#line default
#line hidden
            EndContext();
            BeginContext(319, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(351, 6, false);
#line 14 "C:\Users\ayerj\source\repos\IS_Proj_HIT\IS_Proj_HIT\Views\Home\Sex.cshtml"
                   Write(s.Name);

#line default
#line hidden
            EndContext();
            BeginContext(357, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(389, 14, false);
#line 15 "C:\Users\ayerj\source\repos\IS_Proj_HIT\IS_Proj_HIT\Views\Home\Sex.cshtml"
                   Write(s.LastModified);

#line default
#line hidden
            EndContext();
            BeginContext(403, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 17 "C:\Users\ayerj\source\repos\IS_Proj_HIT\IS_Proj_HIT\Views\Home\Sex.cshtml"
            }

#line default
#line hidden
#line 17 "C:\Users\ayerj\source\repos\IS_Proj_HIT\IS_Proj_HIT\Views\Home\Sex.cshtml"
             
        }
        else
        {

#line default
#line hidden
            BeginContext(484, 39, true);
            WriteLiteral("                <p>No Sexes found</p>\r\n");
            EndContext();
#line 22 "C:\Users\ayerj\source\repos\IS_Proj_HIT\IS_Proj_HIT\Views\Home\Sex.cshtml"
        }

#line default
#line hidden
            BeginContext(534, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Sex>> Html { get; private set; }
    }
}
#pragma warning restore 1591
