#pragma checksum "C:\Users\JAYANTA GHOSH\Desktop\ASPDOTNET_Apps\Experiment\Experiment\Views\DynamicPartialView\_DynamicListViewFromDB.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb8d699b1b33e7316cf139c3408ab53f119be135"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DynamicPartialView__DynamicListViewFromDB), @"mvc.1.0.view", @"/Views/DynamicPartialView/_DynamicListViewFromDB.cshtml")]
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
#nullable restore
#line 1 "C:\Users\JAYANTA GHOSH\Desktop\ASPDOTNET_Apps\Experiment\Experiment\Views\_ViewImports.cshtml"
using Experiment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JAYANTA GHOSH\Desktop\ASPDOTNET_Apps\Experiment\Experiment\Views\_ViewImports.cshtml"
using Experiment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb8d699b1b33e7316cf139c3408ab53f119be135", @"/Views/DynamicPartialView/_DynamicListViewFromDB.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faf0ffdfc37e829f0a6ace78ab6ffd92b50a618d", @"/Views/_ViewImports.cshtml")]
    public class Views_DynamicPartialView__DynamicListViewFromDB : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Experiment.ModelViewDTO.DynamicPartialViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n<div id=\"btn\" class=\"text-center p-2\">\r\n");
#nullable restore
#line 10 "C:\Users\JAYANTA GHOSH\Desktop\ASPDOTNET_Apps\Experiment\Experiment\Views\DynamicPartialView\_DynamicListViewFromDB.cshtml"
     foreach (var data in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>Controller: ");
#nullable restore
#line 12 "C:\Users\JAYANTA GHOSH\Desktop\ASPDOTNET_Apps\Experiment\Experiment\Views\DynamicPartialView\_DynamicListViewFromDB.cshtml"
                   Write(data.ControllerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h4>Action : ");
#nullable restore
#line 13 "C:\Users\JAYANTA GHOSH\Desktop\ASPDOTNET_Apps\Experiment\Experiment\Views\DynamicPartialView\_DynamicListViewFromDB.cshtml"
                Write(data.ActionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h4>Button Name : ");
#nullable restore
#line 14 "C:\Users\JAYANTA GHOSH\Desktop\ASPDOTNET_Apps\Experiment\Experiment\Views\DynamicPartialView\_DynamicListViewFromDB.cshtml"
                     Write(data.ValueName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 15 "C:\Users\JAYANTA GHOSH\Desktop\ASPDOTNET_Apps\Experiment\Experiment\Views\DynamicPartialView\_DynamicListViewFromDB.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Experiment.ModelViewDTO.DynamicPartialViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
