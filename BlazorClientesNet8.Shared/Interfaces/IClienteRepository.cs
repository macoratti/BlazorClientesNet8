using BlazorClientesNet8.Shared.Entities;

namespace BlazorClientesNet8.Shared.Interfaces;

public interface IClienteRepository
{
    Task<Cliente> AddClienteAsync(Cliente model);
    Task<Cliente> UpdateClienteAsync(Cliente model);
    Task<Cliente> DeleteClienteAsync(int clienteId);
    Task<List<Cliente>> GetAllClientesAsync();
    Task<Cliente> GetClienteByIdAsync(int clienteId);
}
