#pragma checksum "C:\Users\Rolando\source\repos\Santa-Maria\Santa-Maria\Views\Escuela\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71fa9dfa761eec5d001cced91343cf14f2a1003c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71fa9dfa761eec5d001cced91343cf14f2a1003c", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce6fa59f091134fbfb3775065008f007215885d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Rolando\source\repos\Santa-Maria\Santa-Maria\Views\Escuela\Index.cshtml"
  
    ViewData["Title"] = "Informacion Escuela";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Escuela ");
#nullable restore
#line 5 "C:\Users\Rolando\source\repos\Santa-Maria\Santa-Maria\Views\Escuela\Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h2>Nombre:");
#nullable restore
#line 6 "C:\Users\Rolando\source\repos\Santa-Maria\Santa-Maria\Views\Escuela\Index.cshtml"
      Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>Tipo de escuela: ");
#nullable restore
#line 7 "C:\Users\Rolando\source\repos\Santa-Maria\Santa-Maria\Views\Escuela\Index.cshtml"
                Write(Model.TipoEscuela);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<address>\r\n    <p>Direccion: ");
#nullable restore
#line 9 "C:\Users\Rolando\source\repos\Santa-Maria\Santa-Maria\Views\Escuela\Index.cshtml"
             Write(Model.Direcci??n);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    <p>Pais: ");
#nullable restore
#line 10 "C:\Users\Rolando\source\repos\Santa-Maria\Santa-Maria\Views\Escuela\Index.cshtml"
        Write(Model.Pais);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Ciudad: ");
#nullable restore
#line 11 "C:\Users\Rolando\source\repos\Santa-Maria\Santa-Maria\Views\Escuela\Index.cshtml"
          Write(Model.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</address>\r\n<p><strong>A??o fundaci??n:");
#nullable restore
#line 13 "C:\Users\Rolando\source\repos\Santa-Maria\Santa-Maria\Views\Escuela\Index.cshtml"
                    Write(Model.A??oDeCreaci??n);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong> </p>\r\n\r\n<p><i>");
#nullable restore
#line 15 "C:\Users\Rolando\source\repos\Santa-Maria\Santa-Maria\Views\Escuela\Index.cshtml"
 Write(ViewBag.DataDinamico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela> Html { get; private set; }
    }
}
#pragma warning restore 1591
