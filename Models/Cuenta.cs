using System.Collections.Generic;

namespace MatematicaFinanciera.Models
{
    public class Cuenta
    {
        public int idCuenta {get;set;}
        public string nrCuenta {get;set;}
        public double monto {get;set;}
        public List<Registro> registros {get;set;}
        public Cuenta(string nrCuenta, double monto)
        {
            this.nrCuenta = nrCuenta;
            this.monto = monto;
        }
        public Cuenta(int idCuenta, string nrCuenta, double monto)
        {
            this.idCuenta = idCuenta;
            this.nrCuenta = nrCuenta;
            this.monto = monto;
        }
        public Cuenta(){}
    }
}