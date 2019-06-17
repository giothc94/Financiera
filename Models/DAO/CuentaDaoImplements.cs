using System;
using System.Data.SqlClient;
using System.Diagnostics;
using MatematicaFinanciera.Models.BDD;

namespace MatematicaFinanciera.Models.DAO
{
    public class CuentaDaoImplements : CuentaDao
    {
        public Cuenta cuenta;
        DataBaseConnection dbc = new DataBaseConnection();

        public Cuenta GetCuenta(int id)
        {
            var cuenta = new Cuenta();
            var cn = dbc.getConnection();
            try
            {
                cn.Open();
                string sql = "SELECT * FROM cuenta WHERE id_cuenta = '"+id+"'";
                var cmd = new SqlCommand(sql,cn);
                var dr= cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cuenta = new Cuenta(Convert.ToInt32(dr.GetInt32(0)),dr.GetString(1),dr.GetDouble(2));
                    }
                }
            }
            catch (System.Exception e)
            {
                Debug.WriteLine("=========================================================");
                Debug.WriteLine("DEBUGGER::GETCuenta"+e.Message);
                Debug.WriteLine("DEBUGGER::GETCuenta"+e.StackTrace);
                Debug.WriteLine("=========================================================");
            }finally
            {
                cn.Close();
            }
            return cuenta;
        }
         public bool SumarEfectivoCuenta(int idCuenta, double monto)
        {
            var verif = false;
            var cn = dbc.getConnection();
            try
            {
                cn.Open();
                string sql = "UPDATE cuenta SET monto += "+monto+" WHERE id_cuenta = "+idCuenta;
                var cmd = new SqlCommand(sql,cn);
                cmd.ExecuteNonQuery();
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
            return verif;
        }
    }
}