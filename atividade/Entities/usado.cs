using System;
using System.Collections.Generic;
using System.Text;

namespace atividade.Entities
{
    public class Usado : Comum
    {
        // encapsulamento
        public string Data { get; set; }
        //construtor padrão
        public Usado() { }
        //criação do construtor com parâmetros utilizando o da classe Comum
        public Usado(string condicao, string nome, double preco, string data)
            : base(condicao, nome, preco)
        {
            Data = data;
        }
        public override string ToString()
        {
            return Nome + " (usado) - " + Preço +("   (")+ Data+ (")");
        }
    }
}
