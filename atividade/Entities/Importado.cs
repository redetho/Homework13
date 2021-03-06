using System;
using System.Collections.Generic;
using System.Text;

namespace atividade.Entities
{
    class Importado : Comum
    {
        //declaração de variáveis e encapsulamento
        public double Taxa { get; set;}
        //construtor padrão
        public Importado() { }
        //construtor com parâmetros
        public Importado(string condicao, string nome, double preco, double taxa)
            : base(condicao, nome, preco)
        {
            Taxa = taxa;
        }
        public override string ToString()
        {
            return Nome + " - " + Preço + "(Taxa: " +Taxa +")";
        }

    }
    
}
