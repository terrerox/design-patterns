#pragma checksum "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\Form\Resultados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "093ad85e71d0475c9dfd3ebe5c9e9b5d3c4dc87b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Form_Resultados), @"mvc.1.0.view", @"/Views/Form/Resultados.cshtml")]
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
#line 1 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\_ViewImports.cshtml"
using strategy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\_ViewImports.cshtml"
using strategy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"093ad85e71d0475c9dfd3ebe5c9e9b5d3c4dc87b", @"/Views/Form/Resultados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2154f6e6506dc472239b9b5dc74d29d7561e398", @"/Views/_ViewImports.cshtml")]
    public class Views_Form_Resultados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<strategy.Models.FormData>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\Form\Resultados.cshtml"
  
    ViewData["Title"] = "Datos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Datos de ");
#nullable restore
#line 8 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\Form\Resultados.cshtml"
                              Write(ViewData["formato"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n\r\n<table class=\"table table-dark\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 14 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\Form\Resultados.cshtml"
       Write(Html.DisplayNameFor(model => model.Matricula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 17 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\Form\Resultados.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 20 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\Form\Resultados.cshtml"
       Write(Html.DisplayNameFor(model => model.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 23 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\Form\Resultados.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 26 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\Form\Resultados.cshtml"
       Write(Html.DisplayNameFor(model => model.Carrera));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 29 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\Form\Resultados.cshtml"
       Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 32 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\Form\Resultados.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 35 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\Form\Resultados.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 39 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\Form\Resultados.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 42 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\Form\Resultados.cshtml"
       Write(Html.DisplayFor(modelItem => item.Matricula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 45 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\Form\Resultados.cshtml"
       Write(Html.DisplayFor(modelItem => item.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 48 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\Form\Resultados.cshtml"
       Write(Html.DisplayFor(modelItem => item.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 51 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\Form\Resultados.cshtml"
       Write(Html.DisplayFor(modelItem => item.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 54 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\Form\Resultados.cshtml"
       Write(Html.DisplayFor(modelItem => item.Carrera));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 57 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\Form\Resultados.cshtml"
       Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 60 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\Form\Resultados.cshtml"
       Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 63 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\Form\Resultados.cshtml"
       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 66 "C:\Users\JFRANCISCO\Desktop\itla\pro2\strategy\Views\Form\Resultados.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<strategy.Models.FormData>> Html { get; private set; }
    }
}
#pragma warning restore 1591