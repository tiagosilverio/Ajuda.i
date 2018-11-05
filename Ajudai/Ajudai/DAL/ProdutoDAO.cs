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
            throw new NotImplementedException();
        }

        public void ExcluirProduto(Produto produto)
        {
            throw new NotImplementedException();
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
            //if (p == null) produto.idProduto = 0;            
        }
    }
}
