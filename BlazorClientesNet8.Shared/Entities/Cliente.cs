using System.ComponentModel.DataAnnotations;

namespace BlazorClientesNet8.Shared.Entities;

public class Cliente
{
    public int Id { get; set; }
    
    [Required]
    public string Nome { get; set; } = string.Empty;
    
    [Required]
    public string Email { get; set; } = string.Empty;

    [Required]
    public int Idade { get; set; }
}
