using System.Collections.Generic;
using System.Linq;

namespace RPH.API.Data
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ProdutoContexto Contexto;

        public ProdutoRepository(ProdutoContexto contexto)
        {
            Contexto = contexto;
        }

        public void Editar(Produto produto)
        {
            Contexto.Produtos.Update(produto);
            Contexto.SaveChanges();
        }

        public void Excluir(Produto produto)
        {
            Contexto.Produtos.Remove(produto);
            Contexto.SaveChanges();
        }

        public void Inserir(Produto produto)
        {
            Contexto.Produtos.Add(produto);
            Contexto.SaveChanges();
        }

        public Produto Obter(int id)
        {
            return Contexto.Produtos.Find(id);
        }

        public Produto Obter(string codigo)
        {
            return Contexto.Produtos.FirstOrDefault(c => c.Codigo == codigo);
        }

        public IEnumerable<Produto> Obter()
        {
            return Contexto.Produtos.ToList();
        }
    }
}