using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MatematicaFinanciera.Models
{
    public class Prestamo
    {
        public int id { get; set; }
        public int idCliente { get; set; }
        public double efectivoSolicitado { get; set; }
        public double tasaInteres { get; set; }
        public int timpoLimite { get; set; }
        public int periodoPago { get; set; }
        public double saldoDeuda { get; set; }
        public double montoInteres { get; set; }
        public int estado { get; set; }
        public int numeroPagos { get; set; }
        public int numeroPagosCancelado { get; set; }
        public DateTime fechaSolicitado {get; set;}
        public DateTime fechaFocal {get; set;}
        public List<PagoPrestamo> pagos { get; set; }
        public Prestamo() { }
        public Prestamo(int idCliente, double efectivoSolicitado, double tasaInteres, int timpoLimite, int periodoPago, double saldoDeuda, bool estado, int numeroPagos, int numeroPagosCancelado,DateTime fechaFocal)
        {
            this.idCliente = idCliente;
            this.efectivoSolicitado = efectivoSolicitado;
            this.tasaInteres = tasaInteres;
            this.timpoLimite = timpoLimite;
            this.periodoPago = periodoPago;
            this.saldoDeuda = saldoDeuda;
            this.estado = this.boolToNumeber(estado);
            this.numeroPagos = numeroPagos;
            this.numeroPagosCancelado = numeroPagosCancelado;
            this.fechaSolicitado = Convert.ToDateTime(DateTime.Now);
            this.fechaFocal = fechaFocal;
            this.montoInteres = this.saldoDeuda - this.efectivoSolicitado;
        }

        public Prestamo(int id, int idCliente, double efectivoSolicitado, double tasaInteres, int timpoLimite, int periodoPago, double saldoDeuda, bool estado, int numeroPagos, int numeroPagosCancelado,DateTime fechaSolicitado, DateTime fechaFocal)
        {
            this.id = id;
            this.idCliente = idCliente;
            this.efectivoSolicitado = efectivoSolicitado;
            this.tasaInteres = tasaInteres;
            this.timpoLimite = timpoLimite;
            this.periodoPago = periodoPago;
            this.saldoDeuda = saldoDeuda;
            this.estado = this.boolToNumeber(estado);
            this.numeroPagos = numeroPagos;
            this.numeroPagosCancelado = numeroPagosCancelado;
            this.fechaSolicitado = fechaSolicitado;
            this.fechaFocal = fechaFocal;
            this.montoInteres = this.saldoDeuda - this.efectivoSolicitado;
        }

        public int boolToNumeber(bool val)
        {
            return val ? 1 : 0;
        }
        public bool numberToBoolean(int val)
        {
            var verif = false;
            if (val == 1)
            {
                verif = true;
            }else if(val == 0)
            {
                verif = false;
            }
            return verif;
        }

        public List<PagoPrestamo> recalculoPagos(int idPrestamo, List<DateTime> fechas, DateTime fechaFocal,double monto, double[] tIntereses = null, double tasaInteres = 0.0){
            var cont = 0;
            var mesFocal = fechaFocal.Month;
            var ti = tasaInteres;
            var capital = 0.0;
            double[] sumMes = new double[fechas.ToArray().Length];
            List<PagoPrestamo> listaNuevosPagos = new List<PagoPrestamo>();
            if(ti > 0)
            {
                var sumX = 0.0;
                cont = 0;
                foreach (DateTime fecha in fechas)
                {
                    var mes = fecha.Month;
                    mesFocal = fechaFocal.Month;

                    sumMes[cont] = (Convert.ToDouble(1)+(tasaInteres/Convert.ToDouble(100))*(((Convert.ToDouble(mesFocal) - Convert.ToDouble(mes))*(-1))/Convert.ToDouble(12)));
                    sumX += (Convert.ToDouble(1)+(tasaInteres/Convert.ToDouble(100))*(((Convert.ToDouble(mesFocal) - Convert.ToDouble(mes))*(-1))/Convert.ToDouble(12)));
                    cont++;
                }
                capital = monto/sumX;
                cont = 0;
                foreach (DateTime fecha in fechas)
                {
                    var pp = new PagoPrestamo();
                    pp.idPrestamo = idPrestamo;
                    pp.numMes = fecha.Month;
                    pp.mes = pp.NumberToMonth(fecha.Month);
                    pp.montoPagar = capital * sumMes[0];
                    pp.estado = pp.boolToNumber(true);
                    pp.fechaLimite = fecha;
                    listaNuevosPagos.Add(pp);
                    cont++;
                }
            }
            if(tIntereses != null)
            {
                var sumX = 0.0;
                cont = 0;
                foreach (DateTime fecha in fechas)
                {
                    var mes = fecha.Month;
                    mesFocal = fechaFocal.Month;
                    sumMes[cont] = (Convert.ToDouble(1)+(tIntereses[cont]/Convert.ToDouble(100))*(((Convert.ToDouble(mesFocal) - Convert.ToDouble(mes))*(-1))/Convert.ToDouble(12)));
                    sumX += (Convert.ToDouble(1)+(tIntereses[cont]/Convert.ToDouble(100))*((Convert.ToDouble(mesFocal) - Convert.ToDouble(mes))/Convert.ToDouble(12)));
                    cont++;
                }
                capital = monto/sumX;
                cont = 0;
                foreach (DateTime fecha in fechas)
                {
                    var pp = new PagoPrestamo();
                    pp.idPrestamo = idPrestamo;
                    pp.numMes = fecha.Month;
                    pp.mes = pp.NumberToMonth(fecha.Month);
                    pp.montoPagar = capital * sumMes[cont];
                    pp.estado = pp.boolToNumber(true);
                    pp.fechaLimite = fecha;
                    listaNuevosPagos.Add(pp);
                    cont++;
                }
            }

            return listaNuevosPagos;
        }
    }
}