using System.Collections.Generic;

namespace MatematicaFinanciera.Models.DAO
{
    public interface PrestamoDao
    {
        int ingresarPrestamo(Prestamo prestamo);
        bool ingresarPagos(List<PagoPrestamo> listaPagos);

        List<Prestamo> getPrestamo(int idCliente);
    }
}