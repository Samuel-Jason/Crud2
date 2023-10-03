using CadastroDois.Data;
using CadastroDois.Models;

namespace CadastroDois.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ClienteRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }


        public ClienteModel Adicionar(ClienteModel cliente)
        {
        }
    }
}
