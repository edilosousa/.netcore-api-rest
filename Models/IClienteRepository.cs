namespace api.Models
{
    public interface IClienteRepository
    {
        void Add(Cliente cliente);
         List<Cliente> GetAll();
    }
}
