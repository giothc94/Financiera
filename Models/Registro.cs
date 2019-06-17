using System.Collections.Generic;

namespace MatematicaFinanciera.Models
{
    public class Registro
    {
        public string tipoRegistro {get;set;}
        public double monto {get;set;}
        public double total {get;set;}
        public int idCuenta {get;set;}
        public Registro(string tipoRegistro, double monto, double total, int idCuenta)
        {
            this.tipoRegistro = tipoRegistro;
            this.monto = monto;
            this.total = total;
            this.idCuenta = idCuenta;
        }
    }
}