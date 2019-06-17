namespace MatematicaFinanciera.Models.DAO
{
    public interface ClienteDao
    {
         bool CrearCliente(Cliente cliente);
         Cliente GetCliente(string cedula);
    }
}