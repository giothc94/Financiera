#pragma checksum "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Transacciones.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71bb79c44eeff82a46a62c3627d11540021d0feb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Transacciones), @"mvc.1.0.view", @"/Views/Cliente/Transacciones.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Transacciones.cshtml", typeof(AspNetCore.Views_Cliente_Transacciones))]
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
#line 1 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/_ViewImports.cshtml"
using MatematicaFinanciera;

#line default
#line hidden
#line 2 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/_ViewImports.cshtml"
using MatematicaFinanciera.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71bb79c44eeff82a46a62c3627d11540021d0feb", @"/Views/Cliente/Transacciones.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bb21bbf8eed67fa51b118c2f544cdd116ad0e44", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Transacciones : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cliente>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Transacciones.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(45, 381, true);
            WriteLiteral(@"
<nav aria-label=""breadcrumb"">
  <ol class=""breadcrumb"">
    <li class=""breadcrumb-item""><a href=""/Home/Index"">Inicio</a></li>
    <li class=""breadcrumb-item active"" aria-current=""page"">Consulta de transaccion</li>
  </ol>
</nav>
<div class=""row justify-content-center"">
    <div class=""col-6"">
        <nav class=""navbar navbar-light bg-light justify-content-center"">
            ");
            EndContext();
            BeginContext(426, 304, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71bb79c44eeff82a46a62c3627d11540021d0feb4615", async() => {
                BeginContext(466, 257, true);
                WriteLiteral(@"
                <input name=""cedula"" class=""form-control mr-sm-2"" type=""search"" placeholder=""C.I del cliente"" aria-label=""C.I del cliente"">
                <button class=""btn btn-outline-info my-2 my-sm-0"" type=""submit"">Buscar cliente</button>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(730, 34, true);
            WriteLiteral("\n        </nav>\n    </div>\n</div>\n");
            EndContext();
#line 22 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Transacciones.cshtml"
 if (Model == null)
{

#line default
#line hidden
            BeginContext(786, 61, true);
            WriteLiteral("    <div class=\"alert alert-info\">Realiza una consulta</div>\n");
            EndContext();
#line 25 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Transacciones.cshtml"
}else
{

#line default
#line hidden
            BeginContext(855, 349, true);
            WriteLiteral(@"  <div class=""row justify-content-center mt-3"">
      <div class=""col-6"">
          <div class=""card"">
              <div class=""card-body"">
                  <div class=""card-title h2"">Informacion del cliente</div>
                  <div class=""row"">
                      <div class=""col"">
                          <small><strong>C.I</strong><br>");
            EndContext();
            BeginContext(1205, 12, false);
#line 34 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Transacciones.cshtml"
                                                    Write(Model.cedula);

#line default
#line hidden
            EndContext();
            BeginContext(1217, 152, true);
            WriteLiteral("</small><br>\n                      </div>\n                      <div class=\"col\">\n                          <small><strong>Numero de cuenta</strong><br>");
            EndContext();
            BeginContext(1370, 21, false);
#line 37 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Transacciones.cshtml"
                                                                 Write(Model.cuenta.nrCuenta);

#line default
#line hidden
            EndContext();
            BeginContext(1391, 227, true);
            WriteLiteral("</small><br>                        \n                      </div>\n                  </div>\n                  <div class=\"row\">\n                      <div class=\"col\">\n                          <small><strong>Nombre</strong><br>");
            EndContext();
            BeginContext(1619, 12, false);
#line 42 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Transacciones.cshtml"
                                                       Write(Model.nombre);

#line default
#line hidden
            EndContext();
            BeginContext(1631, 144, true);
            WriteLiteral("</small><br>\n                      </div>\n                      <div class=\"col\">\n                          <small><strong>Apellido</strong><br>");
            EndContext();
            BeginContext(1776, 14, false);
#line 45 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Transacciones.cshtml"
                                                         Write(Model.apellido);

#line default
#line hidden
            EndContext();
            BeginContext(1790, 206, true);
            WriteLiteral("</small><br>\n                      </div>\n                  </div>\n                  <div class=\"row\">\n                      <div class=\"col\">\n                          <small><strong>Direccion</strong><br>");
            EndContext();
            BeginContext(1997, 15, false);
#line 50 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Transacciones.cshtml"
                                                          Write(Model.direccion);

#line default
#line hidden
            EndContext();
            BeginContext(2012, 140, true);
            WriteLiteral("</small>\n                      </div>\n                      <div class=\"col\">\n                          <small><strong>Telefono</strong><br>");
            EndContext();
            BeginContext(2153, 14, false);
#line 53 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Transacciones.cshtml"
                                                         Write(Model.telefono);

#line default
#line hidden
            EndContext();
            BeginContext(2167, 416, true);
            WriteLiteral(@"</small>
                      </div>
                  </div>
              </div>
          </div>
      </div>
  </div>
  <div class=""row justify-content-center"">
    <div class=""col-6"">
      <table class=""w-100 mt-4"">
        <thead>
          <th class=""border border-dark p-3"">Tipo de transaccion</th>
          <th class=""border border-dark p-3"">Monto de la transaccion</th>
        </thead>
        <tbody>
");
            EndContext();
#line 68 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Transacciones.cshtml"
           foreach (var registro in @Model.cuenta.registros)
          {

#line default
#line hidden
            BeginContext(2656, 66, true);
            WriteLiteral("            <tr>\n              <td class=\"border border-dark p-3\">");
            EndContext();
            BeginContext(2723, 21, false);
#line 71 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Transacciones.cshtml"
                                            Write(registro.tipoRegistro);

#line default
#line hidden
            EndContext();
            BeginContext(2744, 55, true);
            WriteLiteral("</td>\n              <td class=\"border border-dark p-3\">");
            EndContext();
            BeginContext(2800, 14, false);
#line 72 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Transacciones.cshtml"
                                            Write(registro.monto);

#line default
#line hidden
            EndContext();
            BeginContext(2814, 24, true);
            WriteLiteral("</td>\n            </tr>\n");
            EndContext();
#line 74 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Transacciones.cshtml"
          }

#line default
#line hidden
            BeginContext(2850, 52, true);
            WriteLiteral("        </tbody>\n      </table>\n    </div>\n  </div>\n");
            EndContext();
#line 79 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Transacciones.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591
