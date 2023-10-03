using CadastroDois.Models;

namespace CadastroDois.Repositorio
{
    public interface IClienteRepositorio
    {
        ClienteModel Adicionar(string cliente);
    }
}
