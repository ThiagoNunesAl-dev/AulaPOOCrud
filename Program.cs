using System;

namespace AulaPOOCrud
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Exanima", 27.00f);
            Produto p2 = new Produto(2, "The Elder Scrolls V: Skyrim", 66.32f);
            Produto p3 = new Produto(3, "NBA 2K20", 132.98f);
            Produto p4 = new Produto(4, "Fallout 4", 69.99f);

            Carrinho carrinho = new Carrinho(); 

            carrinho.AdicionarProd(p1);
            carrinho.AdicionarProd(p2);
            carrinho.AdicionarProd(p3);
            carrinho.AdicionarProd(p4);

            carrinho.MostrarProdutos();

            carrinho.MostrarTotal();

            carrinho.ValorTotal = 0;

            Console.WriteLine("\nLista com produto removido:\n");

            carrinho.RemoverProd(p3);

            carrinho.MostrarProdutos();

            carrinho.MostrarTotal();

            carrinho.ValorTotal = 0;

            Console.WriteLine("\nLista atualizada:\n");
            Produto p5 = new Produto(5, "Uncharted 4", 70f);

            carrinho.TrocarItem(4, p5);

            carrinho.MostrarProdutos();

            carrinho.MostrarTotal(); 
        }
    }
}
