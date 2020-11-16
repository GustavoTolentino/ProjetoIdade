using System;

namespace ProjetoIdade
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contador de idade");
            Console.WriteLine("Digite sua idade");
//       ENTRADA
                int idade = int.Parse(Console.ReadLine());
//       PROCESSAMENTO
                int meses = idade * 12;
                int dias = idade * 365;
                int horas = dias * 24;
                int minutos = horas * 60;

                Console.WriteLine("Voce ja viveu: ");
                Console.WriteLine("Meses: {0}" , meses);
                Console.WriteLine("Horas: " + horas);
                Console.WriteLine("Minutos: " + minutos);
        }
    }
}
