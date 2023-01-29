using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoPOO.Models
{
    public class Cinema
    {
        
        public string NomeFilme { get; set; }

        public string horarioFilme1 { get; set; }
        public string horarioFilme2 { get; set; }
        public string salaFilme { get; set; }
        public string tipoIdioma { get; set; }


        public void ExibirProgramacao()
        {
            Console.WriteLine($"{NomeFilme.ToUpper()}");
            Console.WriteLine($"{salaFilme}");
            Console.WriteLine($" | {horarioFilme1} |     | {horarioFilme2} |   ");
            Console.WriteLine($"Idioma : {tipoIdioma}");     
        }
    }
}