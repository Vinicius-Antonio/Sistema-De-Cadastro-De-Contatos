namespace ControleDeContatos.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }

        // Tornando a propriedade Email obrigatória
        public required string Email { get; set; }
    }
}
