using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using MatematicaFinanciera.Models;
using MatematicaFinanciera.Models.DAO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MatematicaFinanciera.Controllers
{
    public class ClienteController : Controller
    {
        NumberFormatInfo nfi = new CultureInfo( "en-US", false ).NumberFormat;
        ClienteDaoImplements cdi = new ClienteDaoImplements();
        CuentaDaoImplements cudi = new CuentaDaoImplements();
        RegistroDaoImplements rdi = new RegistroDaoImplements();
        PrestamoDaoImplements pdi = new PrestamoDaoImplements();

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            Cuenta cuenta = new Cuenta(form["cedula"] + "-" + form["nombre"].ToString().Substring(0, 3).ToUpper(), Convert.ToDouble(form["monto"]));
            Cliente cliente = new Cliente(form["nombre"], form["apellido"], form["cedula"], form["direccion"], form["telefono"], cuenta);
            var verif = cdi.CrearCliente(cliente);
            ViewBag.mensaje = " * El cliente se registro correctamente-* La apertura de la cuenta se realizo corectamente-* Primer registro realizado";
            if (verif)
            {
                return View("Correcto", ViewBag);
            }
            else
            {
                return View();
            }
        }
        public IActionResult Prestamo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Refinanciar(IFormCollection form)
        {
            var idPrestamo = Convert.ToInt16(form["idPrestamo"]); 
            var cantidad = Convert.ToInt16(form["cantidad"]); 
            var periodo = Convert.ToInt16(form["periodo"]); 
            var pdi = new PrestamoDaoImplements();
            var cdi = new ClienteDaoImplements();
            var pp = new PagoPrestamo();
            ViewBag.Prestamo = pdi.getPrestamoId(idPrestamo);
            ViewBag.Cliente = cdi.GetClienteId(ViewBag.prestamo.idCliente);
            ViewBag.ListaFechas = pp.listarFechasIntermedias(DateTime.Now,ViewBag.Prestamo.fechaFocal,cantidad,periodo);
            return View(ViewBag);
        }

        [HttpPost]
        [Route("/Servicio/Refinanciado", Name = "ConfirmacionRefinanciacion")]
        public IActionResult Refinanciamiento(IFormCollection form)
        {   
            List<PagoPrestamo> listaPagos = new List<PagoPrestamo>();
            List<DateTime> listFechas = new List<DateTime>();
            var prestamoId = Convert.ToInt16(form["prestamoId"]);
            var checkInteres = form["checkInteres"];
            var fechas = form["fechas[]"];
            var interesMes = form["interesMes[]"];
            var fechaFocal = form["fechaFocal"];
            var monto = Convert.ToDouble(form["monto"],NumberFormatInfo.InvariantInfo);
            foreach (var fecha in fechas)
            {
                listFechas.Add(DateTime.Parse(fecha));
            }


            var p = new Prestamo();
            if(checkInteres == "on")
            {
                var interesFijo = Convert.ToDouble(form["interesFijo"],NumberFormatInfo.InvariantInfo);
                listaPagos = p.recalculoPagos(prestamoId,listFechas,Convert.ToDateTime(fechaFocal),monto,tasaInteres: interesFijo);
            }
            else
            {
                double[] tIntereses = new double[listFechas.ToArray().Length];
                var cont = 0;
                foreach (var tinteres in interesMes)
                {
                    tIntereses[cont] = Convert.ToDouble(tinteres,NumberFormatInfo.InvariantInfo);
                    cont++;
                }
                listaPagos = p.recalculoPagos(prestamoId,listFechas,Convert.ToDateTime(fechaFocal),monto,tIntereses:tIntereses);
            }
            var pdi = new PrestamoDaoImplements();
            if (pdi.removerPagos(prestamoId))
            {
                if (pdi.ingresarPagos(listaPagos))
                {
                    ViewBag.mensaje = "Refinanciamiento exitoso, puede revisar el la vista de refinanciamientos";
                    return View("Correcto",ViewBag);
                }
                else
                {
                    ViewBag.mensaje += " - * No se Ingresaron los pagos de forma correcta"; 
                    return View("ErrorUser",ViewBag);
                }
            }
            else
            {
                ViewBag.mensaje += " - * No se eliminaron los pagos anteriores de forma correcta"; 
                return View("ErrorUser",ViewBag);
            }
        }
        [HttpPost]
        [Route("/Servicio/Prestamo", Name = "Presta")]
        public IActionResult RealizarPrestamo(IFormCollection form)
        {
            var pp = new PagoPrestamo();
            var pdi = new PrestamoDaoImplements();
            var cdi = new CuentaDaoImplements();


          NumberFormatInfo nfi = new CultureInfo( "en-US", false ).NumberFormat;
          nfi.NumberDecimalSeparator = ".";

            // Variables del formulario
            var cuenta = Convert.ToInt16(form["id-cuenta"]);
            var cliente = Convert.ToInt16(form["id-cliente"]);
            var efectivoSolicitado = Convert.ToDouble(form["efectivo-solicitado"], NumberFormatInfo.InvariantInfo);
            var tasaInteres = Convert.ToDouble(form["tasa-interes"], nfi);
            var limiteAño = Convert.ToInt16(form["limite-año"]);
            var limiteMes = Convert.ToInt16(form["limite-mes"]);
            var periodoPagos = Convert.ToInt16(form["periodo-pagos"]);
            var totalDeuda = Convert.ToDouble(form["total-deuda"], NumberFormatInfo.InvariantInfo);
            //  Fin variables del formulario
            var cantidadMeses = pp.YearToMonth(limiteAño) + limiteMes;
            var cuotas = cantidadMeses / periodoPagos;
            if (cuotas < 1)
            {
                ViewBag.mensaje = "No se pudo realizar la transaccion, el plazo limite es menor que el periodo de cuotas";
                ViewBag.path = "/Cliente/Prestamo";
                return View("ErrorUser", ViewBag);
            }
            else
            {
                var mensualidad = totalDeuda / cuotas;
                var prestamo = new Prestamo(cliente, efectivoSolicitado, tasaInteres, cantidadMeses, periodoPagos, totalDeuda, false, cuotas, 0, DateTime.Now.AddMonths(cantidadMeses));
                var id = pdi.ingresarPrestamo(prestamo);

                if (id > 0)
                {
                    List<PagoPrestamo> lpp = new List<PagoPrestamo>();
                    for (int i = periodoPagos; i <= cantidadMeses; i += periodoPagos)
                    {
                        pp = new PagoPrestamo(id, DateTime.Now.AddMonths(i).Month, pp.NumberToMonth(DateTime.Now.AddMonths(i).Month), mensualidad, false, DateTime.Now.AddMonths(i));
                        lpp.Add(pp);
                    }
                    var verif = pdi.ingresarPagos(lpp);
                    if (verif)
                    {
                        ViewBag.mensaje = "* El prestamo y la transaccion se realizaron de forma correcta";
                        ViewBag.mensaje += "- * Registro de pagos correcto";
                        Registro registro = new Registro("ABONO-PRESTAMO", efectivoSolicitado, efectivoSolicitado, cuenta);
                        rdi.ingresarRegistros(registro);
                        cdi.SumarEfectivoCuenta(cuenta, prestamo.efectivoSolicitado);
                    }
                    if (!verif) ViewBag.mensaje += "- * Registro de pagos INCORRECTO";
                }
                if (id < 1) ViewBag.mensaje += "- * Registro de prestamo INCORRECTO";
            }
            return View("Correcto", ViewBag);
        }

        [HttpPost]
        public IActionResult Prestamo(IFormCollection form)
        {
            Cliente cliente = cdi.GetCliente(form["cedula"]);
            Cuenta cuenta = cudi.GetCuenta(cliente.idCuenta);
            List<Registro> registros = rdi.getRegistros(cliente.idCuenta);

            cuenta.registros = registros;
            cliente.cuenta = cuenta;

            return View(cliente);
        }
        public IActionResult Pago()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Pago(IFormCollection form)
        {
            Cliente cliente = cdi.GetCliente(form["cedula"]);
            Cuenta cuenta = cudi.GetCuenta(cliente.idCuenta);
            List<Prestamo> prestamos = pdi.getPrestamo(cliente.id);

            cliente.cuenta = cuenta;
            cliente.prestamos = prestamos;

            return View(cliente);
        }
        public IActionResult Correcto()
        {
            return View(ViewBag);
        }
        public IActionResult Transacciones()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Transacciones(IFormCollection form)
        {
            Cliente cliente = cdi.GetCliente(form["cedula"]);
            Cuenta cuenta = cudi.GetCuenta(cliente.idCuenta);
            List<Registro> registros = rdi.getRegistros(cliente.idCuenta);

            cuenta.registros = registros;
            cliente.cuenta = cuenta;

            var model = cliente;

            return View(model);
        }
    }
}