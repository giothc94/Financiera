#pragma checksum "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddfd09c829006c4df645ecebb893b07aab824993"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Pago), @"mvc.1.0.view", @"/Views/Cliente/Pago.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Pago.cshtml", typeof(AspNetCore.Views_Cliente_Pago))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddfd09c829006c4df645ecebb893b07aab824993", @"/Views/Cliente/Pago.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bb21bbf8eed67fa51b118c2f544cdd116ad0e44", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Pago : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cliente>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Cliente/Refinanciar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(45, 437, true);
            WriteLiteral(@"
<nav aria-label=""breadcrumb"">
  <ol class=""breadcrumb"">
    <li class=""breadcrumb-item""><a href=""/Home/Index"">Inicio</a></li>
    <li class=""breadcrumb-item active"" aria-current=""page"">Refinanciamiento</li>
  </ol>
</nav>
<div class=""display-4 text-center"">Refinanciamiento</div>
<hr>
<div class=""row justify-content-center"">
    <div class=""col-6"">
        <nav class=""navbar navbar-light bg-light justify-content-center"">
            ");
            EndContext();
            BeginContext(482, 304, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddfd09c829006c4df645ecebb893b07aab8249934961", async() => {
                BeginContext(522, 257, true);
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
            BeginContext(786, 35, true);
            WriteLiteral("\n        </nav>\n    </div>\n</div>\n\n");
            EndContext();
#line 25 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
 if (Model == null || Model.id == 0)
{

#line default
#line hidden
            BeginContext(860, 61, true);
            WriteLiteral("    <div class=\"alert alert-info\">Realiza una consulta</div>\n");
            EndContext();
#line 28 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
}else
{

#line default
#line hidden
            BeginContext(929, 363, true);
            WriteLiteral(@"    <div class=""row justify-content-left mt-3"">
        <div class=""col-6"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""card-title h2"">Informacion del cliente</div>
                    <div class=""row"">
                        <div class=""col"">
                            <small><strong>C.I</strong><br>");
            EndContext();
            BeginContext(1293, 12, false);
#line 37 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                                                      Write(Model.cedula);

#line default
#line hidden
            EndContext();
            BeginContext(1305, 158, true);
            WriteLiteral("</small><br>\n                        </div>\n                        <div class=\"col\">\n                            <small><strong>Numero de cuenta</strong><br>");
            EndContext();
            BeginContext(1464, 21, false);
#line 40 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                                                                   Write(Model.cuenta.nrCuenta);

#line default
#line hidden
            EndContext();
            BeginContext(1485, 237, true);
            WriteLiteral("</small><br>                        \n                        </div>\n                    </div>\n                    <div class=\"row\">\n                        <div class=\"col\">\n                            <small><strong>Nombre</strong><br>");
            EndContext();
            BeginContext(1723, 12, false);
#line 45 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                                                         Write(Model.nombre);

#line default
#line hidden
            EndContext();
            BeginContext(1735, 150, true);
            WriteLiteral("</small><br>\n                        </div>\n                        <div class=\"col\">\n                            <small><strong>Apellido</strong><br>");
            EndContext();
            BeginContext(1886, 14, false);
#line 48 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                                                           Write(Model.apellido);

#line default
#line hidden
            EndContext();
            BeginContext(1900, 216, true);
            WriteLiteral("</small><br>\n                        </div>\n                    </div>\n                    <div class=\"row\">\n                        <div class=\"col\">\n                            <small><strong>Direccion</strong><br>");
            EndContext();
            BeginContext(2117, 15, false);
#line 53 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                                                            Write(Model.direccion);

#line default
#line hidden
            EndContext();
            BeginContext(2132, 146, true);
            WriteLiteral("</small>\n                        </div>\n                        <div class=\"col\">\n                            <small><strong>Telefono</strong><br>");
            EndContext();
            BeginContext(2279, 14, false);
#line 56 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                                                           Write(Model.telefono);

#line default
#line hidden
            EndContext();
            BeginContext(2293, 313, true);
            WriteLiteral(@"</small>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row mt-3"">
        <div class=""col-4"">
            <div class=""card"">
                <div class=""card-body"">
                    <strong>Disponible: </strong> $ ");
            EndContext();
            BeginContext(2607, 18, false);
#line 67 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                                               Write(Model.cuenta.monto);

#line default
#line hidden
            EndContext();
            BeginContext(2625, 69, true);
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n");
            EndContext();
#line 72 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
     foreach (var prestamo in @Model.prestamos)
    {

#line default
#line hidden
            BeginContext(2748, 334, true);
            WriteLiteral(@"        <div class=""row mt-3 "">
            <div class=""col"">
                <div class=""card"">
                    <div class=""card-title bg-light "">
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col-9"">
                                    ");
            EndContext();
            BeginContext(3083, 11, false);
#line 81 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                               Write(prestamo.id);

#line default
#line hidden
            EndContext();
            BeginContext(3094, 99, true);
            WriteLiteral("\n                                    <br><strong class=\"text-uppercase\">fecha Solicitado: </strong>");
            EndContext();
            BeginContext(3194, 47, false);
#line 82 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                                                                                             Write(prestamo.fechaSolicitado.ToString("MM/dd/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3241, 94, true);
            WriteLiteral("\n                                    <br><strong class=\"text-uppercase\">fecha Focal: </strong>");
            EndContext();
            BeginContext(3336, 42, false);
#line 83 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                                                                                        Write(prestamo.fechaFocal.ToString("MM/dd/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3378, 102, true);
            WriteLiteral("\n                                    <br><strong class=\"text-uppercase\">Efectivo solicitado: </strong>");
            EndContext();
            BeginContext(3481, 27, false);
#line 84 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                                                                                                Write(prestamo.efectivoSolicitado);

#line default
#line hidden
            EndContext();
            BeginContext(3508, 103, true);
            WriteLiteral("\n                                    <br><strong class=\"text-uppercase\">timpo Limite de pago: </strong>");
            EndContext();
            BeginContext(3612, 20, false);
#line 85 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                                                                                                 Write(prestamo.timpoLimite);

#line default
#line hidden
            EndContext();
            BeginContext(3632, 101, true);
            WriteLiteral(" meses\n                                    <br><strong class=\"text-uppercase\">tasa Interes: </strong>");
            EndContext();
            BeginContext(3734, 20, false);
#line 86 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                                                                                         Write(prestamo.tasaInteres);

#line default
#line hidden
            EndContext();
            BeginContext(3754, 96, true);
            WriteLiteral("\n                                    <br><strong class=\"text-uppercase\">monto interes: </strong>");
            EndContext();
            BeginContext(3851, 21, false);
#line 87 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                                                                                          Write(prestamo.montoInteres);

#line default
#line hidden
            EndContext();
            BeginContext(3872, 94, true);
            WriteLiteral("\n                                    <br><strong class=\"text-uppercase\">saldo Deuda: </strong>");
            EndContext();
            BeginContext(3967, 19, false);
#line 88 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                                                                                        Write(prestamo.saldoDeuda);

#line default
#line hidden
            EndContext();
            BeginContext(3986, 95, true);
            WriteLiteral("\n                                    <br><strong class=\"text-uppercase\">numero Pagos: </strong>");
            EndContext();
            BeginContext(4082, 20, false);
#line 89 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                                                                                         Write(prestamo.numeroPagos);

#line default
#line hidden
            EndContext();
            BeginContext(4102, 99, true);
            WriteLiteral("\n                                    <br><strong class=\"text-uppercase\">periodo de Pagos: </strong>");
            EndContext();
            BeginContext(4202, 20, false);
#line 90 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                                                                                             Write(prestamo.periodoPago);

#line default
#line hidden
            EndContext();
            BeginContext(4222, 221, true);
            WriteLiteral("\n                                </div>\n                                <div class=\"col-3\">\n                                    <input class=\"btn btn-outline-success\" type=\"button\" data-toggle=\"modal\" data-target=\"#modal_");
            EndContext();
            BeginContext(4444, 11, false);
#line 93 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                                                                                                                            Write(prestamo.id);

#line default
#line hidden
            EndContext();
            BeginContext(4455, 130, true);
            WriteLiteral("\" value=\"Refinanciar\">\n                                    <input class=\"btn btn-outline-info\" type=\"submit\" value=\"Mostrar pagos\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4585, "\"", 4616, 3);
            WriteAttributeValue("", 4595, "mostrar(", 4595, 8, true);
#line 94 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
WriteAttributeValue("", 4603, prestamo.id, 4603, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 4615, ")", 4615, 1, true);
            EndWriteAttribute();
            BeginContext(4617, 158, true);
            WriteLiteral(">\n                                </div>\n                            </div>\n                        </div>\n                    </div>\n                    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4775, "\"", 4792, 1);
#line 99 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
WriteAttributeValue("", 4780, prestamo.id, 4780, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4793, 43, true);
            WriteLiteral(" class=\"card-body\" style=\"display: none;\">\n");
            EndContext();
#line 100 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                           var sumTotal = 0.0;

#line default
#line hidden
            BeginContext(4884, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 101 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                         foreach (var pago in prestamo.pagos)
                        {

#line default
#line hidden
            BeginContext(4972, 234, true);
            WriteLiteral("                            <div class=\"row\">\n                                    <div class=\"col-10\">\n                                        <small>\n                                            <strong>Fecha limite de pago: </strong>");
            EndContext();
            BeginContext(5207, 39, false);
#line 106 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                                                                              Write(pago.fechaLimite.ToString("MM/dd/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(5246, 272, true);
            WriteLiteral(@"<br>
                                        </small>
                                    </div>
                                    <div class=""col-2"">
                                        <small>
                                            <strong>Saldo: </strong> $ ");
            EndContext();
            BeginContext(5519, 34, false);
#line 111 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                                                                  Write(pago.montoPagar.ToString("#00.00"));

#line default
#line hidden
            EndContext();
            BeginContext(5553, 132, true);
            WriteLiteral("\n                                        </small>\n                                    </div>\n                            </div><hr>\n");
            EndContext();
#line 115 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                            sumTotal += pago.montoPagar;
                        }

#line default
#line hidden
            BeginContext(5768, 317, true);
            WriteLiteral(@"                        <div class=""row"">
                                    <div class=""col-10"">
                                    </div>
                                    <div class=""col-2"">
                                        <small>
                                            <strong>Total: </strong> $ ");
            EndContext();
            BeginContext(6086, 27, false);
#line 122 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
                                                                  Write(sumTotal.ToString("#00.00"));

#line default
#line hidden
            EndContext();
            BeginContext(6113, 216, true);
            WriteLiteral("\n                                        </small>\n                                    </div>\n                            </div><hr>\n                    </div>\n                </div>\n            </div>\n        </div>\n");
            EndContext();
#line 130 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
    }

#line default
#line hidden
#line 131 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
     foreach (var prestamo in @Model.prestamos)
    {

#line default
#line hidden
            BeginContext(6389, 54, true);
            WriteLiteral("        <!-- Modal -->\n        <div class=\"modal fade\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 6443, "\"", 6466, 2);
            WriteAttributeValue("", 6448, "modal_", 6448, 6, true);
#line 134 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
WriteAttributeValue("", 6454, prestamo.id, 6454, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6467, 542, true);
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Refinanciamiento</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
                ");
            EndContext();
            BeginContext(7009, 1317, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddfd09c829006c4df645ecebb893b07aab82499324577", async() => {
                BeginContext(7059, 194, true);
                WriteLiteral("\n                    <div class=\"modal-body\">\n                        <small class=\"text-info\">* Llene todos los campos</small>\n                            <input type=\"hidden\" name=\"idPrestamo\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 7253, "\"", 7273, 1);
#line 146 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
WriteAttributeValue("", 7261, prestamo.id, 7261, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7274, 71, true);
                WriteLiteral(">\n                            <input type=\"hidden\" name=\"cedulaCliente\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 7345, "\"", 7366, 1);
#line 147 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
WriteAttributeValue("", 7353, Model.cedula, 7353, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7367, 952, true);
                WriteLiteral(@">
                            <div class=""form-group"">
                                <label for=""cantidad"">Cantidad de pagos</label>
                                <input id=""cantidad"" class=""form-control"" name=""cantidad"" type=""number"" placeholder=""Ejemplo. 1"" required>
                            </div>
                            <div class=""form-group"">
                                <label for=""periodo"">Periodos</label>
                                <input id=""periodo"" class=""form-control"" name=""periodo"" type=""number"" placeholder=""Ejemplo. 1"" required>
                            </div>
                            
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                        <button type=""submit"" class=""btn btn-primary"">Refinanciar</button>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8326, 73, true);
            WriteLiteral("\n            </div>\n        </div>\n        </div>\n        <!-- Modal -->\n");
            EndContext();
#line 167 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"

    }

#line default
#line hidden
#line 168 "/home/giothcode/Escritorio/MatematicaFinanciera/MatematicaFinanciera/Views/Cliente/Pago.cshtml"
     
}

#line default
#line hidden
            BeginContext(8408, 342, true);
            WriteLiteral(@"<script>
    function mostrar(id){
        if(document.getElementById(`${id}`).style.display != 'none'){
            document.getElementById(`${id}`).style.display = 'none'
        }else{
            document.getElementById(`${id}`).style.display = 'initial'
        }
    }
    function print(data){
        console.log(data)
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591
