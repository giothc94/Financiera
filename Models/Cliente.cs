using System.Collections.Generic;

namespace MatematicaFinanciera.Models
{
    public class Cliente
    {
        public int id {get;set;}
        public string nombre {get;set;}
        public string apellido {get;set;}
        public string cedula {get;set;}
        public string direccion {get;set;}
        public string telefono {get;set;}
        public int idCuenta {get;set;}
        public Cuenta cuenta {get;set;}
        public List<Prestamo> prestamos {get;set;}

        public Cliente(string nombre,string apellido,string cedula,string direccion, string telefono,Cuenta cuenta)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.direccion = direccion;
            this.telefono = telefono;
            this.cuenta = cuenta;
        }
        public Cliente(int id,string nombre,string apellido,string direccion, string cedula,string telefono, int idCuenta)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.direccion = direccion;
            this.telefono = telefono;
            this.idCuenta = idCuenta;

        }
        public Cliente(){}
    }
}