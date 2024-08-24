using api.Models;

namespace api.Infra
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly Connection _conn = new Connection();
        public void Add(Cliente cliente)
        {
            //throw new NotImplementedException();
            _conn.Clientes.Add(cliente);
            _conn.SaveChanges();
        }

        public List<Cliente> GetAll()
        {
            //throw new NotImplementedException();
            return _conn.Clientes.ToList();
        }
    }
}
