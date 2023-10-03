namespace CadastroDois.Models
{
    public class ClienteModel
    {
        public List<ClienteModel> Cliente { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Idade { get; set; }
        public DateTime DatadeCadastro { get; set; }  

    }
}
