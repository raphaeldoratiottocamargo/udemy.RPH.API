using System.Collections.Generic;

namespace RPH.API.Data
{
    public interface IProdutoRepository
    {
        void Inserir(Produto produto);

        void Editar(Produto produto);

        void Excluir(Produto produto);

        Produto Obter(int id);

        Produto Obter(string id);

        IEnumerable<Produto> Obter();

    }
}