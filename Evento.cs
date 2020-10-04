using System;

namespace Mom1LenProg
{
    class Evento
    {
     public string tipo { get; set; }
     string tipoL;
        public string lugar
        {
            get
            {
                return tipoL;
            }
            set
            {
                switch (value)

                {
                    case "Aire Libre":
                        tipoL = value;
                        break;
                    case "Bajo Techo":
                        tipoL = value;
                        break;
                   default:
                        Console.WriteLine($"Lugar no existe, por favor verificar");
                        break;
                }
            }
        }
     public string publico {get; set;}
     public int participantes {get; set;}
    }
}
