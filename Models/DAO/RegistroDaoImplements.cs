using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using MatematicaFinanciera.Models.BDD;

namespace MatematicaFinanciera.Models.DAO
{
    public class RegistroDaoImplements : RegistroDao
    {
        public Cliente cliente;
        public Cuenta cuenta;
        public Registro registro;
        DataBaseConnection dbc = new DataBaseConnection();


        public List<Registro> getRegistros(int id)
        {   
            var cn = dbc.getConnection();
            List<Registro> listRegistros = new List<Registro>();
            try
            {
                cn.Open();
                var sqlRegistro = "SELECT * FROM registro WHERE idCuenta = "+id;
                var cmd = new SqlCommand(sqlRegistro,cn);
                var dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var registro = new Registro(dr.GetString(1),dr.GetDouble(2),dr.GetDouble(3),dr.GetInt32(4));
                        listRegistros.Add(registro);
                    }
                }
            }
            catch (System.Exception e)
            {
                Debug.WriteLine("=========================================================");
                Debug.WriteLine("DEBUGGER::"+e.Message);
                Debug.WriteLine("DEBUGGER::"+e.StackTrace);
                Debug.WriteLine("DEBUGGER::"+e);
                Debug.WriteLine("=========================================================");
            }finally
            {
                cn.Close();
            }
            return listRegistros;
        }

        public bool ingresarRegistros(Registro registro)
        {
            var verif = false;
            var cn = dbc.getConnection();
            List<Registro> listRegistros = new List<Registro>();
            try
            {
                cn.Open();
                var sql = "INSERT INTO registro (tipo_registro,monto,total,idCuenta)VALUES('"+registro.tipoRegistro+"',"+registro.monto+","+registro.total+","+registro.idCuenta+")";
                var cmd = new SqlCommand(sql,cn);
                var nf = cmd.ExecuteNonQuery();
                if (nf > 0)
                {
                    verif = true;
                }
            }
            catch (System.Exception e)
            {
                Debug.WriteLine("=========================================================");
                Debug.WriteLine("DEBUGGER::"+e.Message);
                Debug.WriteLine("DEBUGGER::"+e.StackTrace);
                Debug.WriteLine("DEBUGGER::"+e);
                Debug.WriteLine("=========================================================");
            }finally
            {
                cn.Close();
            }
            return verif;
        }
    }
}