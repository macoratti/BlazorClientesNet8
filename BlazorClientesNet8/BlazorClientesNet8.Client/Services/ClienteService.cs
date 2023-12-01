using BlazorClientesNet8.Shared.Entities;
using BlazorClientesNet8.Shared.Interfaces;
using System.Net.Http.Json;
using System.Text.Json;

namespace BlazorClientesNet8.Client.Services;

public class ClienteService : IClienteRepository
{
    private readonly HttpClient httpClient;
    private readonly JsonSerializerOptions _options;

    public ClienteService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        _options = new JsonSerializerOptions { 
            PropertyNameCaseInsensitive = true 
        };
    }
    public async Task<Cliente> AddClienteAsync(Cliente model)
    {
        var cliente = await httpClient.PostAsJsonAsync("api/Cliente/Add-Cliente", model);
        var response = await cliente.Content.ReadFromJsonAsync<Cliente>();
        return response!;
    }

    public async Task<Cliente> DeleteClienteAsync(int clienteId)
    {
        var cliente = await httpClient.DeleteAsync($"api/Cliente/Delete-Cliente/{clienteId}");
        var response = await cliente.Content.ReadFromJsonAsync<Cliente>();
        return response!;
    }

    public async Task<List<Cliente>> GetAllClientesAsync()
    {
        var clientes = await httpClient.GetAsync("api/Cliente/Clientes");
        var response = await clientes.Content.ReadFromJsonAsync<List<Cliente>>();
        return response!;
    }

    public async Task<Cliente> GetClienteByIdAsync(int clienteId)
    {
        var cliente = await httpClient.GetAsync($"api/Cliente/Cliente/{clienteId}");
        var response = await cliente.Content.ReadFromJsonAsync<Cliente>();
        return response!;
    }

    public async Task<Cliente> UpdateClienteAsync(Cliente model)
    {
        var cliente = await httpClient.PutAsJsonAsync("api/Cliente/Update-Cliente", model);
        var response = await cliente.Content.ReadFromJsonAsync<Cliente>();
        return response!;
    }
}
