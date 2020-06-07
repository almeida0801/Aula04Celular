using System;

namespace Aula04Celular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular samsung = new Celular();
            samsung.modelo = "Galaxy Note 9";
            samsung.cor = "preto";
            samsung.tamanho = 7.1f;
            samsung.ligado = true;


            Console.WriteLine("Deseja um celular ligado?");
            samsung.ligado = samsung.TraduzConsole( Console.ReadLine() );

         Console.WriteLine("Seu celular poderá ligar, deligar, fazer ligação e enviar mensagem.");
         samsung.ligado = samsung.TraduzConsole( Console.ReadLine() );

            




        }
    }
}