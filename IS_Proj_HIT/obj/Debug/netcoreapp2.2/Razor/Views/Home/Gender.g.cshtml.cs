#pragma checksum "C:\Users\ayerj\source\repos\IS_Proj_HIT\IS_Proj_HIT\Views\Home\Gender.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe0c7b78d87dd613c32a323066ec70e0c4769c27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Gender), @"mvc.1.0.view", @"/Views/Home/Gender.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Gender.cshtml", typeof(AspNetCore.Views_Home_Gender))]
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
#line 1 "C:\Users\ayerj\source\repos\IS_Proj_HIT\IS_Proj_HIT\Views\Home\Gender.cshtml"
using isprojectHiT.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe0c7b78d87dd613c32a323066ec70e0c4769c27", @"/Views/Home/Gender.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81723f7e80dbbbf32eeb61f6ac242e5522c57fa1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Gender : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Gender>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 6, true);
            WriteLiteral("<ul>\r\n");
            EndContext();
#line 4 "C:\Users\ayerj\source\repos\IS_Proj_HIT\IS_Proj_HIT\Views\Home\Gender.cshtml"
     if (Model != null)
    {
        

#line default
#line hidden
#line 6 "C:\Users\ayerj\source\repos\IS_Proj_HIT\IS_Proj_HIT\Views\Home\Gender.cshtml"
         foreach (Gender g in Model)
        {

#line default
#line hidden
            BeginContext(143, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(160, 6, false);
#line 8 "C:\Users\ayerj\source\repos\IS_Proj_HIT\IS_Proj_HIT\Views\Home\Gender.cshtml"
           Write(g.Name);

#line default
#line hidden
            EndContext();
            BeginContext(166, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 9 "C:\Users\ayerj\source\repos\IS_Proj_HIT\IS_Proj_HIT\Views\Home\Gender.cshtml"
        }

#line default
#line hidden
#line 9 "C:\Users\ayerj\source\repos\IS_Proj_HIT\IS_Proj_HIT\Views\Home\Gender.cshtml"
         
    }
    else
    {

#line default
#line hidden
            BeginContext(208, 35, true);
            WriteLiteral("        <li>No Genders found</li>\r\n");
            EndContext();
#line 14 "C:\Users\ayerj\source\repos\IS_Proj_HIT\IS_Proj_HIT\Views\Home\Gender.cshtml"
    }

#line default
#line hidden
            BeginContext(250, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Gender>> Html { get; private set; }
    }
}
#pragma warning restore 1591
