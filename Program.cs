using System;
using AulaPOOClassesEstaticas.classes;

namespace AulaPOOClassesEstaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool respostaCorreta= false;
            float valor;
            string resposta;
            do
            {
            Console.WriteLine(@"Deseja converter o valor de que maneira?
            1- Dólar para real
            2- Real para dólar");
            resposta = Console.ReadLine();
            switch (resposta)
            {
                case "1":
                    Console.WriteLine("Digte o valor em doláres");
                    valor= conversor.dolarParaReal(float.Parse(Console.ReadLine()));
                    Console.WriteLine($"O valor em reais é igual a {valor}");
                    respostaCorreta= true;
                    break;
                case "2":
                    Console.WriteLine("Digte o valor em doláres");
                    valor= conversor.realParaDolar(float.Parse(Console.ReadLine()));
                    Console.WriteLine($"O valor em dólares é igual a {valor}");
                    respostaCorreta= true;
                    break;
                default:
                    Console.WriteLine("Resposta inválida, digite '1' para uma conversão de dólares para reais e '2' de reais para dólares");
                    respostaCorreta= false;
                    break;
            }
            } while (respostaCorreta == false);
        }
    }
}
