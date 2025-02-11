namespace AtividadeGithub.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        public string Nome { get; set; }
        public int NomeId { get; set; } = 0;
        public string Email { get; set; }
    }
}
