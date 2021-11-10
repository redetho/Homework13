using System;
using System.Collections.Generic;
using System.Text;

namespace atividade.Entities
{
    //criação da classe comum
    public class Comum
    {
        //declarações e encapsulamento
        public string Condição { get; private set; }
        public string Nome { get; private set; }
        //protected para alteração de valores entre classes
        public double Preço { get; protected set; }
        //construtor padrão e construtor com parâmetros
        public Comum() { }
        public Comum(string condicao, string nome, double preco)
        {
            Condição = condicao;
            Nome = nome;
            Preço = preco;
        }
        //to string para apresentar
        public override string ToString()
        {
            return Nome + " - " + Preço;
        }
    }
}
