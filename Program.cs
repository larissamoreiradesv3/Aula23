using System;
using System.Collections.Generic;

namespace Aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicio da lista
            // os produtos são adicionados através de instâncias com condutores
            List<Produto> produtos = new List<Produto>();          
            produtos.Add(new Produto(1, "IPhone", 1000f));
            produtos.Add(new Produto(2, "MotoE", 700f ));
            produtos.Add(new Produto(3, "Samsung", 700f));
            produtos.Add(new Produto(4, "LG", 650f));
            produtos.Add(new Produto(5, "Zenfone", 900f));

            //agora iremos mostrar a lista
            Console.WriteLine("Lista de Produtos que serão comprados:");
            foreach(Produto p in produtos){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" {p.Nome} - R$ {p.Preco} ");
                Console.ResetColor();
            }

            //Iniciaremos a lista de dados os cartões de quem irá comprar os produtos
            List<Cartao> cartao = new List<Cartao>();
            cartao.Add(new Cartao("1552", 82635482f, "2545", 205052f,"14/02"));
            cartao.Add(new Cartao("636393", 101025212f,"5526", 8521f, "21/11" ));
            cartao.Add(new Cartao("15758", 123566933f, "123", 5641f, "31/11"));
            cartao.Add(new Cartao("12352", 526555542f, "789", 9636f, "25/08"));
            cartao.Add(new Cartao("78954", 45687933f, "1232", 4568f, "16/02"));

            //agora iremos mostrar a lista
                Console.WriteLine("Informações do Cartão dos compradores dos Produtos:");
            foreach(Cartao c in cartao){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" Bandeira: {c.Bandeira} - Número: {c.Numero} - CVV: {c.Cvv} - Titular: {c.Titular} - Vencimento: {c.Vencimento}");

            }

        }
    }
}
