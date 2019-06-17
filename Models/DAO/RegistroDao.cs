using System.Collections.Generic;

namespace MatematicaFinanciera.Models.DAO
{
    public interface RegistroDao
    {
        List<Registro> getRegistros(int id);
    }
}