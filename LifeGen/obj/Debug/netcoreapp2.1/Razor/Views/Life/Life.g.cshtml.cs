#pragma checksum "C:\Users\Dan\Source\Repos\LifeGen\LifeGen\Views\Life\Life.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d7da1b2192b0730ecb7f0ff8c8e735ce7c2ba58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Life_Life), @"mvc.1.0.view", @"/Views/Life/Life.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Life/Life.cshtml", typeof(AspNetCore.Views_Life_Life))]
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
#line 1 "C:\Users\Dan\Source\Repos\LifeGen\LifeGen\Views\_ViewImports.cshtml"
using LifeGen;

#line default
#line hidden
#line 2 "C:\Users\Dan\Source\Repos\LifeGen\LifeGen\Views\_ViewImports.cshtml"
using LifeGen.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d7da1b2192b0730ecb7f0ff8c8e735ce7c2ba58", @"/Views/Life/Life.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3eeb7a532b1402839a665038351ee921ebfa80d", @"/Views/_ViewImports.cshtml")]
    public class Views_Life_Life : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LifeGen.Models.LifeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Dan\Source\Repos\LifeGen\LifeGen\Views\Life\Life.cshtml"
  
    ViewData["Title"] = "Life";

#line default
#line hidden
            BeginContext(79, 34, true);
            WriteLiteral("\r\n<h2>Life</h2>\r\n\r\n<div>\r\n    <h1>");
            EndContext();
            BeginContext(114, 24, false);
#line 10 "C:\Users\Dan\Source\Repos\LifeGen\LifeGen\Views\Life\Life.cshtml"
   Write(Model.Character.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(138, 14, true);
            WriteLiteral("</h1>\r\n    <p>");
            EndContext();
            BeginContext(153, 28, false);
#line 11 "C:\Users\Dan\Source\Repos\LifeGen\LifeGen\Views\Life\Life.cshtml"
  Write(Model.Character.GenderString);

#line default
#line hidden
            EndContext();
            BeginContext(181, 19, true);
            WriteLiteral("</p>\r\n    <p>Born: ");
            EndContext();
            BeginContext(201, 33, false);
#line 12 "C:\Users\Dan\Source\Repos\LifeGen\LifeGen\Views\Life\Life.cshtml"
        Write(Model.Character.DateOfBirthString);

#line default
#line hidden
            EndContext();
            BeginContext(234, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 13 "C:\Users\Dan\Source\Repos\LifeGen\LifeGen\Views\Life\Life.cshtml"
     foreach (var log in Model.Character.Logs)
    {

#line default
#line hidden
            BeginContext(295, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(307, 3, false);
#line 15 "C:\Users\Dan\Source\Repos\LifeGen\LifeGen\Views\Life\Life.cshtml"
      Write(log);

#line default
#line hidden
            EndContext();
            BeginContext(310, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 16 "C:\Users\Dan\Source\Repos\LifeGen\LifeGen\Views\Life\Life.cshtml"
    }

#line default
#line hidden
            BeginContext(323, 63, true);
            WriteLiteral("</div>\r\n<div>\r\n    <input type=\"button\"\r\n           value=\"Sim\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n           onclick=\"", 386, "\"", 450, 3);
            WriteAttributeValue("", 408, "location.href=\'", 408, 15, true);
#line 21 "C:\Users\Dan\Source\Repos\LifeGen\LifeGen\Views\Life\Life.cshtml"
WriteAttributeValue("", 423, Url.Action("Sim", "Life"), 423, 26, false);

#line default
#line hidden
            WriteAttributeValue("", 449, "\'", 449, 1, true);
            EndWriteAttribute();
            BeginContext(451, 78, true);
            WriteLiteral(" />\r\n</div>\r\n<div>\r\n    <input type=\"button\"\r\n           value=\"New Character\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n           onclick=\"", 529, "\"", 602, 3);
            WriteAttributeValue("", 551, "location.href=\'", 551, 15, true);
#line 26 "C:\Users\Dan\Source\Repos\LifeGen\LifeGen\Views\Life\Life.cshtml"
WriteAttributeValue("", 566, Url.Action("NewCharacter", "Life"), 566, 35, false);

#line default
#line hidden
            WriteAttributeValue("", 601, "\'", 601, 1, true);
            EndWriteAttribute();
            BeginContext(603, 13, true);
            WriteLiteral(" />\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LifeGen.Models.LifeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591