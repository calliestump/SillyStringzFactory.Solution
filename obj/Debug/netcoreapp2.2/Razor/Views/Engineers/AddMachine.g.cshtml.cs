#pragma checksum "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Engineers/AddMachine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "150b42d2c45d084a042385dd61d468d54f3d5e14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Engineers_AddMachine), @"mvc.1.0.view", @"/Views/Engineers/AddMachine.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Engineers/AddMachine.cshtml", typeof(AspNetCore.Views_Engineers_AddMachine))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"150b42d2c45d084a042385dd61d468d54f3d5e14", @"/Views/Engineers/AddMachine.cshtml")]
    public class Views_Engineers_AddMachine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Engineer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Engineers/AddMachine.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(59, 55, true);
            WriteLiteral("<h1> | Engineers | </h1>\n\n<h4>Add Machine to Engineer: ");
            EndContext();
            BeginContext(115, 44, false);
#line 8 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Engineers/AddMachine.cshtml"
                        Write(Html.DisplayFor(model => model.EngineerName));

#line default
#line hidden
            EndContext();
            BeginContext(159, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 10 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Engineers/AddMachine.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(197, 41, false);
#line 12 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Engineers/AddMachine.cshtml"
Write(Html.HiddenFor(model => model.EngineerId));

#line default
#line hidden
            EndContext();
            BeginContext(243, 28, false);
#line 14 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Engineers/AddMachine.cshtml"
Write(Html.Label("Select Machine"));

#line default
#line hidden
            EndContext();
            BeginContext(275, 30, false);
#line 15 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Engineers/AddMachine.cshtml"
Write(Html.DropDownList("MachineId"));

#line default
#line hidden
            EndContext();
            BeginContext(307, 63, true);
            WriteLiteral("  <input type=\"submit\" value=\"Save\" class=\"btn-btn-default\" />\n");
            EndContext();
#line 18 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Engineers/AddMachine.cshtml"
}

#line default
#line hidden
            BeginContext(372, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(376, 41, false);
#line 19 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Engineers/AddMachine.cshtml"
Write(Html.ActionLink("Engineer List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(417, 5, true);
            WriteLiteral("</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Factory.Models.Engineer> Html { get; private set; }
    }
}
#pragma warning restore 1591