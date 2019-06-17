using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using MatematicaFinanciera.Models.BDD;

namespace MatematicaFinanciera.Models.DAO
{
    public class PrestamoDaoImplements : PrestamoDao
    {
        DataBaseConnection dbc = new DataBaseConnection();
        Prestamo prestamo; 
        public Prestamo getPrestamoId(int idPrestamo)
        {
            var cn = dbc.getConnection();
            try
            {
                cn.Open();
                var sql = "SELECT * FROM prestamo WHERE id_prestamo = "+idPrestamo;
                var cmd = new SqlCommand(sql,cn);
                var dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        prestamo = new Prestamo(
                                                dr.GetInt32(0),
                                                dr.GetInt32(1),
                                                dr.GetDouble(2),
                                                Convert.ToDouble(dr.GetDecimal(3)),
                                                dr.GetInt32(4),
                                                dr.GetInt32(5),
                                                dr.GetDouble(6),
                                                dr.GetBoolean(7),
                                                dr.GetInt32(8),
                                                dr.GetInt32(9),
                                                dr.GetDateTime(10),
                                                dr.GetDateTime(11));
                    }
                }
                dr.Close();
                List<PagoPrestamo> pagos = new List<PagoPrestamo>();
                sql = "SELECT * FROM pagos_prestamo p WHERE p.idPrestamo = "+prestamo.id;
                var cmd2 = new SqlCommand(sql,cn);
                var dr2 = cmd2.ExecuteReader();
                if (dr2.HasRows)
                {
                    while (dr2.Read())
                    {
                        var pago = new PagoPrestamo(dr2.GetInt32(1),dr2.GetInt32(2),dr2.GetString(3),dr2.GetDouble(4),dr2.GetBoolean(5),dr2.GetDateTime(6));
                        pagos.Add(pago);
                    }
                    prestamo.pagos = pagos;
                }
                dr2.Close();

                Debug.WriteLine("===================QUERY==================");
                Debug.WriteLine(sql);
                Debug.WriteLine("===================QUERY==================");  
            }
            catch (System.Exception e)
            {
                Debug.WriteLine("===================GET PAGO PRESTAMO==================");
                Debug.WriteLine("DEBUGGER::" + e.Message);
                Debug.WriteLine("DEBUGGER::" + e.StackTrace);
                Debug.WriteLine("DEBUGGER::" + e);
                Debug.WriteLine("=========================================================");
            }finally
            {
                cn.Close();
            }

            return prestamo;
        }
        public List<Prestamo> getPrestamo(int idCliente)
        {
            List<Prestamo> prestamos = new List<Prestamo>();
            var cn = dbc.getConnection();
            try
            {
                cn.Open();
                var sql = "SELECT * FROM prestamo WHERE idCliente = "+idCliente;
                var cmd = new SqlCommand(sql,cn);
                var dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        prestamo = new Prestamo(
                                                dr.GetInt32(0),
                                                dr.GetInt32(1),
                                                dr.GetDouble(2),
                                                Convert.ToDouble(dr.GetDecimal(3)),
                                                dr.GetInt32(4),
                                                dr.GetInt32(5),
                                                dr.GetDouble(6),
                                                dr.GetBoolean(7),
                                                dr.GetInt32(8),
                                                dr.GetInt32(9),
                                                dr.GetDateTime(10),
                                                dr.GetDateTime(11));
                        prestamos.Add(prestamo);
                    }
                }
                dr.Close();
                foreach (var prestamo in prestamos)
                {
                    List<PagoPrestamo> pagos = new List<PagoPrestamo>();
                    sql = "SELECT * FROM pagos_prestamo p WHERE p.idPrestamo = "+prestamo.id;
                    var cmd2 = new SqlCommand(sql,cn);
                    var dr2 = cmd2.ExecuteReader();
                    if (dr2.HasRows)
                    {
                        while (dr2.Read())
                        {
                            var pago = new PagoPrestamo(dr2.GetInt32(1),dr2.GetInt32(2),dr2.GetString(3),dr2.GetDouble(4),dr2.GetBoolean(5),dr2.GetDateTime(6));
                            pagos.Add(pago);
                        }
                        prestamo.pagos = pagos;
                    }
                    dr2.Close();
                }

                Debug.WriteLine("===================QUERY==================");
                Debug.WriteLine(sql);
                Debug.WriteLine("===================QUERY==================");  
            }
            catch (System.Exception e)
            {
                Debug.WriteLine("===================GET PAGO PRESTAMO==================");
                Debug.WriteLine("DEBUGGER::" + e.Message);
                Debug.WriteLine("DEBUGGER::" + e.StackTrace);
                Debug.WriteLine("DEBUGGER::" + e);
                Debug.WriteLine("=========================================================");
            }finally
            {
                cn.Close();
            }

            return prestamos;
        }

        public bool ingresarPagos(List<PagoPrestamo> listaPagos)
        {
            var verif = false;
            var cn = dbc.getConnection();
            try
            {
                cn.Open();
                foreach (var pago in listaPagos)
                {
                    var sql = "INSERT INTO pagos_prestamo (idPrestamo, num_mes, mes, monto_pagar, estado, fecha_limite) VALUES ("
                                +"@idPrestamo,@numMes,@mes,@montoPagar,@estado,@fechaLimite)";
                    var cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@idPrestamo",pago.idPrestamo);
                    cmd.Parameters.AddWithValue("@numMes",pago.numMes);
                    cmd.Parameters.AddWithValue("@mes",pago.mes);
                    cmd.Parameters.AddWithValue("@montoPagar",pago.montoPagar);
                    cmd.Parameters.AddWithValue("@estado",pago.estado);
                    cmd.Parameters.AddWithValue("@fechaLimite",pago.fechaLimite);
                    cmd.ExecuteNonQuery();
                Debug.WriteLine("===================QUERY==================");
                Debug.WriteLine(sql);
                Debug.WriteLine("===================QUERY==================");                
                }
                verif = true;
            }
            catch (System.Exception e)
            {
                Debug.WriteLine("===================INSERT PAGO PRESTAMO==================");
                Debug.WriteLine("DEBUGGER::" + e.Message);
                Debug.WriteLine("DEBUGGER::" + e.StackTrace);
                Debug.WriteLine("DEBUGGER::" + e);
                Debug.WriteLine("=========================================================");
            }finally
            {
                cn.Close();
            }
            return verif;
        }

        public int ingresarPrestamo(Prestamo prestamo)
        {
            var id = 0;
            var cn = dbc.getConnection();
            try
            {
                cn.Open();
                var sql = "INSERT INTO prestamo (idCliente,efectivo_solicitado,tasa_interes,tiempo_limite_meses,periodo_pago,saldo_deuda,estado,numero_pagos,numero_pagos_cancelado,fecha_solicitado,fecha_focal) VALUES( "
                            + "@idCliente,@efectivoSolicitado,@tasaInteres,@timpoLimite,@periodoPago,@saldoDeuda,@estado,@numeroPagos,@numeroPagosCancelado,@fechaSolicitado,@fechaFocal ) SELECT SCOPE_IDENTITY()";
                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@idCliente",prestamo.idCliente);
                cmd.Parameters.AddWithValue("@efectivoSolicitado",prestamo.efectivoSolicitado);
                cmd.Parameters.AddWithValue("@tasaInteres",prestamo.tasaInteres);
                cmd.Parameters.AddWithValue("@timpoLimite",prestamo.timpoLimite);
                cmd.Parameters.AddWithValue("@periodoPago",prestamo.periodoPago);
                cmd.Parameters.AddWithValue("@saldoDeuda",prestamo.saldoDeuda);
                cmd.Parameters.AddWithValue("@estado",prestamo.estado);
                cmd.Parameters.AddWithValue("@numeroPagos",prestamo.numeroPagos);
                cmd.Parameters.AddWithValue("@numeroPagosCancelado",prestamo.numeroPagosCancelado);
                cmd.Parameters.AddWithValue("@fechaSolicitado",prestamo.fechaSolicitado);
                cmd.Parameters.AddWithValue("@fechaFocal",prestamo.fechaFocal);
                id = Convert.ToInt32(cmd.ExecuteScalar());
                Debug.WriteLine("=====================SQL INSERT PRESTAMO====================================");
                Debug.WriteLine(sql);
                Debug.WriteLine("=====================SQL INSERT PRESTAMO====================================");
            }
            catch (System.Exception e)
            {
                Debug.WriteLine("=========================================================");
                Debug.WriteLine("DEBUGGER::" + e.Message);
                Debug.WriteLine("DEBUGGER::" + e.StackTrace);
                Debug.WriteLine("DEBUGGER::" + e);
                Debug.WriteLine("=========================================================");
            }
            finally
            {
                cn.Close();
            }

            return id;
        }

        public bool removerPagos(int idPrestamo)
        {
            var verif = false;
            var cn = dbc.getConnection();
            try
            {
                cn.Open();
                var sql = "DELETE FROM pagos_prestamo WHERE idPrestamo = @idPrestamo";
                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@idPrestamo",idPrestamo);

                verif = cmd.ExecuteNonQuery() > 0 ? true:false;
            }
            catch (System.Exception e)
            {
                Debug.WriteLine("===================INSERT PAGO PRESTAMO==================");
                Debug.WriteLine("DEBUGGER::" + e.Message);
                Debug.WriteLine("DEBUGGER::" + e.StackTrace);
                Debug.WriteLine("DEBUGGER::" + e);
                Debug.WriteLine("=========================================================");
            }finally
            {
                cn.Close();
            }
            return verif;
        }
    }
}