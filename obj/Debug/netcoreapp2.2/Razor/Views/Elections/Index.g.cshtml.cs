#pragma checksum "/home/shunjid/Documents/7th/eChartiFy/Views/Elections/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebad80ecc5f580c331e735f3f1f3e4682087bcd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Elections_Index), @"mvc.1.0.view", @"/Views/Elections/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Elections/Index.cshtml", typeof(AspNetCore.Views_Elections_Index))]
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
#line 1 "/home/shunjid/Documents/7th/eChartiFy/Views/_ViewImports.cshtml"
using electionDbAnalytics;

#line default
#line hidden
#line 2 "/home/shunjid/Documents/7th/eChartiFy/Views/_ViewImports.cshtml"
using electionDbAnalytics.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebad80ecc5f580c331e735f3f1f3e4682087bcd9", @"/Views/Elections/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58e089a0dde2abdb61d1b13939118ce91353a68d", @"/Views/_ViewImports.cshtml")]
    public class Views_Elections_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<electionDbAnalytics.Models.Election>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/shunjid/Documents/7th/eChartiFy/Views/Elections/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Dashboard.cshtml";

#line default
#line hidden
            BeginContext(150, 12, true);
            WriteLiteral("<br/><br/>\r\n");
            EndContext();
#line 8 "/home/shunjid/Documents/7th/eChartiFy/Views/Elections/Index.cshtml"
 if (ViewBag.message == "Index0")
{
    

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(222, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 11 "/home/shunjid/Documents/7th/eChartiFy/Views/Elections/Index.cshtml"
          
            await Html.RenderPartialAsync("_LoadChartIndex0");
        

#line default
#line hidden
                BeginContext(311, 4, true);
                WriteLiteral("    ");
                EndContext();
            }
            );
#line 14 "/home/shunjid/Documents/7th/eChartiFy/Views/Elections/Index.cshtml"
     
}

#line default
#line hidden
            BeginContext(321, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "/home/shunjid/Documents/7th/eChartiFy/Views/Elections/Index.cshtml"
 if (ViewBag.message == "Index1")
{
    

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(383, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 20 "/home/shunjid/Documents/7th/eChartiFy/Views/Elections/Index.cshtml"
          
            await Html.RenderPartialAsync("_LoadChartIndex1");
        

#line default
#line hidden
                BeginContext(472, 4, true);
                WriteLiteral("    ");
                EndContext();
            }
            );
#line 23 "/home/shunjid/Documents/7th/eChartiFy/Views/Elections/Index.cshtml"
     
}

#line default
#line hidden
            BeginContext(482, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 26 "/home/shunjid/Documents/7th/eChartiFy/Views/Elections/Index.cshtml"
 if (ViewBag.message == "Index2")
{
    

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(544, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 29 "/home/shunjid/Documents/7th/eChartiFy/Views/Elections/Index.cshtml"
          
            await Html.RenderPartialAsync("_LoadChartIndex2");
        

#line default
#line hidden
                BeginContext(633, 4, true);
                WriteLiteral("    ");
                EndContext();
            }
            );
#line 32 "/home/shunjid/Documents/7th/eChartiFy/Views/Elections/Index.cshtml"
     
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<electionDbAnalytics.Models.Election>> Html { get; private set; }
    }
}
#pragma warning restore 1591
