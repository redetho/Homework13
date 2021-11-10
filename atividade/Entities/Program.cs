using System;
using System.Collections.Generic;
using System.Globalization;


namespace atividade.Entities
{
    public class Program
    {
        static void Main(string[] args)
        {
            //declarações
            int produtos;
            string condição;
            string nome;
            int preço;
            string data;
            double taxa;
            
            
            //recebe o número de produtos.
            Console.WriteLine("insira o n. de produtos:");
            produtos = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i< produtos; i++)
            {
                Console.WriteLine();
                Console.WriteLine("PRODUTO #" + (i + 1));
                Console.WriteLine("o produto é Comum, usado ou importado?(C, U, I?)");
                //pergunta se o produto é usado, comum ou importado no if else.
                if(Console.ReadKey().Key == ConsoleKey.C)
                {
                    condição = "comum";
                    Console.WriteLine("Digite o nome do produto.");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite o preço do produto.");
                    preço = Convert.ToInt32(Console.ReadLine());
                    //adiciona na lista e apresenta uma etiqueta.
                    List<Comum> lista = new List<Comum>();
                    lista.Add(new Comum (condição, nome, preço));
                    Console.WriteLine();
                    Console.WriteLine("etiqueta:");
                    Console.Write(nome + "  -  ");
                    Console.Write("R$: " + preço);

                }
                else if(Console.ReadKey().Key == ConsoleKey.U)
                {
                    condição = "usado";
                    Console.WriteLine("Digite o nome do produto.");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite o preço do produto.");
                    preço = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a data de fabricação/ (DD/MM/AAAA)");
                    data = Console.ReadLine();

                    List<Usado> lista = new List<Usado>();
                    lista.Add(new Usado(condição, nome, preço, data));
                    Console.WriteLine();
                    Console.WriteLine("etiqueta:");
                    Console.Write(nome + " ");
                    Console.Write("(" + condição+ ")" + "  -  ");
                    Console.Write("R$: " +preço);
                    Console.Write("  (fabricado:" + data + ")");
                }
                else if(Console.ReadKey().Key == ConsoleKey.I)
                {
                    condição = "importado";
                    Console.WriteLine("Digite o nome do produto.");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite o preço do produto.");
                    preço = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("qual é a taxa de importação do produto?");
                    taxa = Convert.ToDouble(Console.ReadLine());

                    Importado produtoimportado = new Importado(condição, nome, preço, taxa);
                    List<Importado> lista = new List<Importado>();
                    lista.Add(new Importado(condição, nome, preço, taxa));
                    Console.WriteLine();
                    Console.WriteLine("etiqueta:");
                    Console.Write(nome + "  -  ");
                    Console.Write("R$: " + preço);
                    Console.Write("  (Taxa: " + taxa + ")");
                }
                else{
                    Console.WriteLine("caractere inválido!");
                }


            }

        }
    }
}