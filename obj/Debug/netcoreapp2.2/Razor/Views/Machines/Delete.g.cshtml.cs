#pragma checksum "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Machines/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cb045f63b2d52936e92683fa9c5c930dc2b7079"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Machines_Delete), @"mvc.1.0.view", @"/Views/Machines/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Machines/Delete.cshtml", typeof(AspNetCore.Views_Machines_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cb045f63b2d52936e92683fa9c5c930dc2b7079", @"/Views/Machines/Delete.cshtml")]
    public class Views_Machines_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Machine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Machines/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(58, 97, true);
            WriteLiteral("<h1> | Machines | </h1><br>\n\n<h2>Are you sure you want to delete this Machine?</h2>\n\n<h3><strong>");
            EndContext();
            BeginContext(156, 15, false);
#line 10 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Machines/Delete.cshtml"
       Write(Html.Label("'"));

#line default
#line hidden
            EndContext();
            BeginContext(171, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(173, 43, false);
#line 10 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Machines/Delete.cshtml"
                        Write(Html.DisplayFor(model => model.MachineName));

#line default
#line hidden
            EndContext();
            BeginContext(216, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(218, 15, false);
#line 10 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Machines/Delete.cshtml"
                                                                     Write(Html.Label("'"));

#line default
#line hidden
            EndContext();
            BeginContext(233, 15, true);
            WriteLiteral("</strong></h3>\n");
            EndContext();
#line 11 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Machines/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(276, 65, true);
            WriteLiteral("  <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" />\n");
            EndContext();
#line 14 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Machines/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(343, 4, true);
            WriteLiteral("<br>");
            EndContext();
            BeginContext(348, 44, false);
#line 15 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Machines/Delete.cshtml"
Write(Html.ActionLink("Back to Machines", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(392, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(397, 40, false);
#line 16 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Machines/Delete.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(437, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Factory.Models.Machine> Html { get; private set; }
    }
}
#pragma warning restore 1591
