#pragma checksum "C:\Users\Rolando\source\repos\Santa-Maria\Santa-Maria\Views\Shared\AsignaturaSimple.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebd1c94613ab97145f2f70a685d669f966cd559a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AsignaturaSimple), @"mvc.1.0.view", @"/Views/Shared/AsignaturaSimple.cshtml")]
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
#line 1 "C:\Users\Rolando\source\repos\Santa-Maria\Santa-Maria\Views\_ViewImports.cshtml"
using Santa_Maria;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rolando\source\repos\Santa-Maria\Santa-Maria\Views\_ViewImports.cshtml"
using Santa_Maria.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebd1c94613ab97145f2f70a685d669f966cd559a", @"/Views/Shared/AsignaturaSimple.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce6fa59f091134fbfb3775065008f007215885d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AsignaturaSimple : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Asignatura>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>\r\n    Nombre:");
#nullable restore
#line 3 "C:\Users\Rolando\source\repos\Santa-Maria\Santa-Maria\Views\Shared\AsignaturaSimple.cshtml"
      Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    Id: ");
#nullable restore
#line 4 "C:\Users\Rolando\source\repos\Santa-Maria\Santa-Maria\Views\Shared\AsignaturaSimple.cshtml"
   Write(Model.UniqueId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Asignatura> Html { get; private set; }
    }
}
#pragma warning restore 1591