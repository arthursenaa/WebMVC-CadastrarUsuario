#pragma checksum "D:\senai\codigos\C#_E_HTML\Ex2_WebMVC\Views\Usuario\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15246a1c7e42d37e9a491cbb71840ea544112125"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listar), @"mvc.1.0.view", @"/Views/Usuario/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Listar.cshtml", typeof(AspNetCore.Views_Usuario_Listar))]
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
#line 1 "D:\senai\codigos\C#_E_HTML\Ex2_WebMVC\Views\Usuario\Listar.cshtml"
using Ex2_WebMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15246a1c7e42d37e9a491cbb71840ea544112125", @"/Views/Usuario/Listar.cshtml")]
    public class Views_Usuario_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\senai\codigos\C#_E_HTML\Ex2_WebMVC\Views\Usuario\Listar.cshtml"
  
    Layout = "MasterPage";
    ViewBag.Title = "Lista de Usuario";

#line default
#line hidden
            BeginContext(103, 45, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <br>\r\n    <h2>");
            EndContext();
            BeginContext(149, 20, false);
#line 9 "D:\senai\codigos\C#_E_HTML\Ex2_WebMVC\Views\Usuario\Listar.cshtml"
   Write(TempData["mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(169, 359, true);
            WriteLiteral(@"</h2>
    <table class=""table table-striped"">
        <thead class = ""thead-dark"">
            <tr>
                <th>Id</th>
                <th>Nome</th>
                <th>Email</th>
                <th>Senha</th>
                <th>Data de Nascimento</th>
                <th>Ações</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 22 "D:\senai\codigos\C#_E_HTML\Ex2_WebMVC\Views\Usuario\Listar.cshtml"
             foreach(var item in ViewData["usuarios"] as List<UsuarioModel>)
                {

#line default
#line hidden
            BeginContext(625, 62, true);
            WriteLiteral("                    <tr>\r\n                        <td><strong>");
            EndContext();
            BeginContext(688, 7, false);
#line 25 "D:\senai\codigos\C#_E_HTML\Ex2_WebMVC\Views\Usuario\Listar.cshtml"
                               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(695, 44, true);
            WriteLiteral("</strong></td>\r\n                        <td>");
            EndContext();
            BeginContext(740, 9, false);
#line 26 "D:\senai\codigos\C#_E_HTML\Ex2_WebMVC\Views\Usuario\Listar.cshtml"
                       Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(749, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(785, 10, false);
#line 27 "D:\senai\codigos\C#_E_HTML\Ex2_WebMVC\Views\Usuario\Listar.cshtml"
                       Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(795, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(831, 10, false);
#line 28 "D:\senai\codigos\C#_E_HTML\Ex2_WebMVC\Views\Usuario\Listar.cshtml"
                       Write(item.Senha);

#line default
#line hidden
            EndContext();
            BeginContext(841, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(877, 39, false);
#line 29 "D:\senai\codigos\C#_E_HTML\Ex2_WebMVC\Views\Usuario\Listar.cshtml"
                       Write(item.DataNascimento.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(916, 67, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href = \"", 983, "\"", 1019, 2);
            WriteAttributeValue("", 992, "/Usuario/Editar?id=", 992, 19, true);
#line 31 "D:\senai\codigos\C#_E_HTML\Ex2_WebMVC\Views\Usuario\Listar.cshtml"
WriteAttributeValue("", 1011, item.Id, 1011, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1020, 173, true);
            WriteLiteral(" class=\"btn btn-warning\">Editar</a>\r\n                            <a href = \"#\" class=\"btn btn-danger\">Excluir</a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 35 "D:\senai\codigos\C#_E_HTML\Ex2_WebMVC\Views\Usuario\Listar.cshtml"
                }

#line default
#line hidden
            BeginContext(1212, 46, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
