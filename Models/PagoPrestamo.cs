using System;
using System.Collections.Generic;

namespace MatematicaFinanciera.Models
{
    public class PagoPrestamo
    {
        public int id { get; set; }
        public int idPrestamo { get; set; }
        public int numMes { get; set; }
        public string mes { get; set; }
        public double montoPagar { get; set; }
        public int estado { get; set; }
        public DateTime fechaLimite { get; set; }

        public PagoPrestamo(int idPrestamo, int numMes, string mes, double montoPagar, bool estado, DateTime fechaLimite)
        {
            this.idPrestamo = idPrestamo;
            this.numMes = numMes;
            this.mes = mes;
            this.montoPagar = montoPagar;
            this.estado = boolToNumber(estado);
            this.fechaLimite = fechaLimite;
        }
        public PagoPrestamo() { }

        public List<DateTime> listarFechasIntermedias(DateTime fechaInicial, DateTime fechaFinal, int cantidadPagos,int periodo)
        {
            var cont = 0;
            var listarFechas = new List<DateTime>();
            while (DateTime.Compare(fechaInicial, fechaFinal) < 0 && cont < cantidadPagos)
            {
                fechaInicial = fechaInicial.AddMonths(periodo);
                listarFechas.Add(fechaInicial);
                cont++;
            }
            return listarFechas;
        }
        public int boolToNumber(bool estado)
        {
            return estado ? 1 : 0;
        }
        public int YearToMonth(int year)
        {
            return year * 12;
        }
        public string NumberToMonth(int numberMonth)
        {
            while (numberMonth > 12)
            {
                numberMonth -= 12;
            }
            var mes = "";
            switch (numberMonth)
            {
                case 1:
                    mes = "Enero";
                    break;
                case 2:
                    mes = "Febrero";
                    break;
                case 3:
                    mes = "Marzo";
                    break;
                case 4:
                    mes = "Abril";
                    break;
                case 5:
                    mes = "Mayo";
                    break;
                case 6:
                    mes = "Junio";
                    break;
                case 7:
                    mes = "Julio";
                    break;
                case 8:
                    mes = "Agosto";
                    break;
                case 9:
                    mes = "Septiembre";
                    break;
                case 10:
                    mes = "Octubre";
                    break;
                case 11:
                    mes = "Noviembre";
                    break;
                case 12:
                    mes = "Diciembre";
                    break;
            }
            return mes;
        }

    }
}