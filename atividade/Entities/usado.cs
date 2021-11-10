using System;
using System.Collections.Generic;
using System.Text;

namespace atividade.Entities
{
    public class Usado : Comum
    {
        //declaração de variáveis e encapsulamento
        public string Data { get; set; }
        //construtor padrão
        public Usado() { }
        //criação do construtor com parâmetros utilizando o da classe Conta
        public Usado(string condicao, string nome, double preco, string data)
            : base(condicao, nome, preco)
        {
            Data = data;
        }

    }
}
