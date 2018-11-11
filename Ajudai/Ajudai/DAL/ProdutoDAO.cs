using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ajudai.Modelo;

namespace Ajudai.DAL
{
    public class ProdutoDAO : intProdutoDAO
    {
        public String mensagem;
        AjudaiEntities produtoEntity = new AjudaiEntities();

        public void CadastrarProduto(Produto produto)
        {
            this.mensagem = "";
            produtoEntity.Produto.Add(produto);
            produtoEntity.SaveChanges();
            this.mensagem = "Cadastrado com sucesso";
        }

        public void EditarProduto(Produto produto)
        {
            this.mensagem = "";
            try
            {
                produtoEntity.Entry(produto).State = System.Data.Entity.EntityState.Modified;
                produtoEntity.SaveChanges();
                this.mensagem = "Editado com sucesso";
            }
            catch (EntryPointNotFoundException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void ExcluirProduto(Produto produto)
        {
            this.mensagem = "";
            produto = produtoEntity.Produto.Find(produto.idProduto);
            produtoEntity.Produto.Remove(produto);
            produtoEntity.SaveChanges();
            this.mensagem = "Excluído com sucesso";
        }

        public Produto PesquisarProdutoPorId(Produto produto)
        {
            try
            {
                Produto p = produtoEntity.Produto.First(c => c.idProduto == produto.idProduto);
                return p;
            }
            catch (Exception e)
            {
                this.mensagem = e.ToString();
                return null;
            }
        }

        public Produto PesquisarProdutoPorNome(Produto produto)
        {
            try
            {
                Produto p = produtoEntity.Produto.First(c => c.Nome == produto.Nome);
                return p;
            }
            catch (Exception e)
            {
                this.mensagem = e.ToString();
                return null;
            }
        }

        public List<Produto> ListarProdutos()
        {
            try
            {
                return produtoEntity.Produto.ToList();
            }
            catch (Exception e)
            {
                this.mensagem = e.ToString();
                return null;
            }
        }
    }
}
