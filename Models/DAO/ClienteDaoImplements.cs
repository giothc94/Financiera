using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using MatematicaFinanciera.Models.BDD;

namespace MatematicaFinanciera.Models.DAO
{
    public class ClienteDaoImplements : ClienteDao
    {
        public Cliente cliente;
        public Cuenta cuenta;

        DataBaseConnection dbc = new DataBaseConnection();
        public bool CrearCliente(Cliente cliente)
        {
            var cn = dbc.getConnection();
            bool verif = false;
            this.cliente = cliente;
            this.cuenta = this.cliente.cuenta;
            try
            {
                cn.Open();
                string sqlCuenta = "INSERT INTO cuenta (nr_cuenta,monto) VALUES ('"+this.cuenta.nrCuenta+"',"+this.cuenta.monto+") SELECT SCOPE_IDENTITY()";
                var cmd = new SqlCommand(sqlCuenta,cn);
                var newId = cmd.ExecuteScalar();
                
                string sqlCliente = "INSERT INTO cliente (nombre,apellido,direccion,cedula,telefono,idCuenta) VALUES "
                                    +" ('"+this.cliente.nombre+"',"
                                    +"'"+this.cliente.apellido+"',"
                                    +"'"+this.cliente.direccion+"',"
                                    +"'"+this.cliente.cedula+"',"
                                    +"'"+this.cliente.telefono+"',"
                                    +newId+")";
                cmd = new SqlCommand(sqlCliente,cn);
                cmd.ExecuteNonQuery();
                
                string sqlRegistro = "INSERT INTO registro (tipo_registro,monto,total,idCuenta)VALUES('APERTURA',"+this.cuenta.monto+","+this.cuenta.monto+","+newId+")";
                cmd = new SqlCommand(sqlRegistro,cn);
                cmd.ExecuteNonQuery();
                verif = true;
            }
            catch (System.Exception e)
            {
                Debug.WriteLine("=========================================================");
                Debug.WriteLine("DEBUGGER::"+e.Message);
                Debug.WriteLine("DEBUGGER::"+e.StackTrace);
                Debug.WriteLine("DEBUGGER::"+e);
                Debug.WriteLine("=========================================================");
                cn.Close();
                verif = false;
            }finally
            {
                cn.Close();
            }
            return verif;
        }

        public Cliente GetCliente(string cedula)
        {
            Cliente cliente = new Cliente();
            var cn = dbc.getConnection();
            try
            {
                cn.Open();
                string sql = "SELECT * FROM cliente WHERE cedula = '"+cedula+"'";
                var cmd = new SqlCommand(sql,cn);
                var dr= cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cliente = new Cliente(dr.GetInt32(0),dr.GetString(1),dr.GetString(2),dr.GetString(3),dr.GetString(4),dr.GetString(5),dr.GetInt32(6));
                    }
                }
            }
            catch (System.Exception e)
            {
                Debug.WriteLine("=========================================================");
                Debug.WriteLine("DEBUGGER::GETCLIENT"+e.Message);
                Debug.WriteLine("DEBUGGER::GETCLIENT"+e.StackTrace);
                Debug.WriteLine("=========================================================");

            }finally
            {
                cn.Close();
            }

            return cliente;
        }

        public Cliente GetClienteId(int idCliente)
        {
            Cliente cliente = new Cliente();
            var cn = dbc.getConnection();
            try
            {
                cn.Open();
                string sql = "SELECT * FROM cliente WHERE id_cliente = '"+idCliente+"'";
                var cmd = new SqlCommand(sql,cn);
                var dr= cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cliente = new Cliente(dr.GetInt32(0),dr.GetString(1),dr.GetString(2),dr.GetString(3),dr.GetString(4),dr.GetString(5),dr.GetInt32(6));
                    }
                }
            }
            catch (System.Exception e)
            {
                Debug.WriteLine("=========================================================");
                Debug.WriteLine("DEBUGGER::GETCLIENT"+e.Message);
                Debug.WriteLine("DEBUGGER::GETCLIENT"+e.StackTrace);
                Debug.WriteLine("=========================================================");

            }finally
            {
                cn.Close();
            }

            return cliente;
        }
       
    }
}