namespace MatematicaFinanciera.Models.DAO
{
    public interface CuentaDao
    {
        Cuenta GetCuenta(int id);
        bool SumarEfectivoCuenta(int idCuenta, double monto);
    }
}