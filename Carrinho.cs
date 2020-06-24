namespace AulaPOOCrud
{
    using System;
    using System.Collections.Generic;
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProd (Produto produto) {
            carrinho.Add(produto);
        }

        public void RemoverProd (Produto produto) {
            carrinho.Remove(produto);
        }

        public void MostrarProdutos () {
            foreach (Produto p in carrinho)
            {
                Console.WriteLine($"Nome: {p.Nome}\nPreço: R$ {p.Preco}\n");
            }
        }

        public void MostrarTotal () {
            foreach (Produto p in carrinho)
            {
                ValorTotal = ValorTotal + p.Preco;
            }
            Console.WriteLine($"Preço Total: R$ {ValorTotal}");
        }

        public void TrocarItem (int _codigo, Produto _produtoNovo) {
            carrinho.Find(x => x.Codigo == _codigo).Nome = _produtoNovo.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _produtoNovo.Preco;
        }

    }
}