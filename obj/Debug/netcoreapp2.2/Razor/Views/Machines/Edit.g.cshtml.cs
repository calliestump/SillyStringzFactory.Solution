#pragma checksum "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Machines/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b206f65c378b83f0d171f7a324fcd5cc73df2e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Machines_Edit), @"mvc.1.0.view", @"/Views/Machines/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Machines/Edit.cshtml", typeof(AspNetCore.Views_Machines_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b206f65c378b83f0d171f7a324fcd5cc73df2e3", @"/Views/Machines/Edit.cshtml")]
    public class Views_Machines_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Machine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Machines/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(58, 55, true);
            WriteLiteral("<h1> | Machines | </h1>\n\n<h4>Edit Machine Information: ");
            EndContext();
            BeginContext(114, 43, false);
#line 8 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Machines/Edit.cshtml"
                         Write(Html.DisplayFor(model => model.MachineName));

#line default
#line hidden
            EndContext();
            BeginContext(157, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 10 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Machines/Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(195, 40, false);
#line 12 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Machines/Edit.cshtml"
Write(Html.HiddenFor(model => model.MachineId));

#line default
#line hidden
            EndContext();
            BeginContext(240, 41, false);
#line 14 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Machines/Edit.cshtml"
Write(Html.LabelFor(model => model.MachineName));

#line default
#line hidden
            EndContext();
            BeginContext(285, 42, false);
#line 15 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Machines/Edit.cshtml"
Write(Html.EditorFor(model => model.MachineName));

#line default
#line hidden
            EndContext();
            BeginContext(329, 62, true);
            WriteLiteral("  <input type=\"submit\" value=\"Save\" class=\"btn btn-default\"/>\n");
            EndContext();
#line 18 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Machines/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(393, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(397, 40, false);
#line 19 "/Users/callie/Desktop/Week11/SillyStringzFactory.Solution/Factory/Views/Machines/Edit.cshtml"
Write(Html.ActionLink("Machine List", "Index"));

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
