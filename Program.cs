using System;

namespace Mom1LenProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eventos");
            Console.WriteLine("Tipo de evento");
            string tipo = Console.ReadLine ();
            Console.WriteLine("Evento al aire libre o bajo techo");
            string lugar = Console.ReadLine ();
            Console.WriteLine("Evento publico o privado");
            string publico = Console.ReadLine();
            Console.WriteLine("Cantidad de Participantes");
            int Participantes = int.Parse (Console.ReadLine());
        }
    }
}
