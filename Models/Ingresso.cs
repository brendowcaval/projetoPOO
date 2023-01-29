using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoPOO.Models
{
    public class Ingresso : Cinema
    {
        public string HorarioEscolhido { get; set; }
        public string assento { get; set; }
        public string tipoIngresso { get; set; }
        //tipos de ingresso : Inteira 34,20  | Meia 19,20
        public string formaPagamento { get; set; }
        // tipos : cartao de credito ou debito, pix, e paypal
        private double valorIngresso;


        public void inserindoValorIngresso(string escolhendoIngresso)
        {
            if(escolhendoIngresso == "Inteira")
            {
                valorIngresso = 34.20D;
            }
            else if(escolhendoIngresso == "Meia")
            {
                valorIngresso = 19.20D;
            }
        }


        public void exibirIngressoCliente()
        {
            Console.WriteLine("          |   INGRESSO |  ");
            Console.WriteLine($" Nome: {NomeFilme}");
            Console.WriteLine($" Horário: {HorarioEscolhido}");
            Console.WriteLine($" Assento: {assento}");
            Console.WriteLine($" Preço: {string.Format("{0:0.00}",valorIngresso)}");
            Console.WriteLine($" Forma de Pagamento : {formaPagamento}  \n");
            Console.WriteLine("       * TENHA UM BOM FILME *");
        }


    }
}