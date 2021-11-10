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


            //recebe o número de produtos.
            Console.WriteLine("insira o n. de produtos:");
            produtos = Convert.ToInt32(Console.ReadLine());
            //vector
            Comum[] vect = new Comum[produtos + 1];
            for (int i = 0; i< produtos; i++)
            {
                Console.WriteLine();
                Console.WriteLine("PRODUTO #" + (i + 1));
                Console.WriteLine("o produto é Comum, usado ou importado?(C, U, I?)");
                //pergunta se o produto é usado, comum ou importado no if else.
                if(Console.ReadKey().Key == ConsoleKey.C)
                {
                    string condição = "comum";
                    Console.WriteLine("Digite o nome do produto.");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite o preço do produto.");
                    int preço = Convert.ToInt32(Console.ReadLine());
                   //adiciona ao vector
                    vect[i] = new Comum(condição, nome, preço);

                }
                else if(Console.ReadKey().Key == ConsoleKey.U)
                {
                    string condição = "usado";
                    Console.WriteLine("Digite o nome do produto.");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite o preço do produto.");
                    int preço = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a data de fabricação/ (DD/MM/AAAA)");
                    string data = Console.ReadLine();

                    vect[i] = new Usado(condição, nome, preço, data);
                }
                else if(Console.ReadKey().Key == ConsoleKey.I)
                {
                    string condição  = "importado";
                    Console.WriteLine("Digite o nome do produto.");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite o preço do produto.");
                    int preço  = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("qual é a taxa de importação do produto?");
                    double taxa = Convert.ToDouble(Console.ReadLine());

                    vect[i] = new Importado(condição, nome, preço, taxa);
                }
                else{
                    Console.WriteLine("caractere inválido!");
                }


            }
            //Formatação
            Console.WriteLine("===================================");
            Console.WriteLine("");

            //mostra as etiquetas. 
            Console.WriteLine("Etiquetas: ");
            for (int i = 0; i < produtos + 1; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i]);
                }
            }
            Console.ReadKey();

        }
    }
}