
//using System.Drawing;

Console.WriteLine("Hello, World!");
int totalJugador = 0;
int totalDealer = 0;

int num = 0;
int numd = 0;

string message = "";
string vCartasD = "";
string vCartasJ = "";

string switchControl = "menu";

var vBan = true;

//Reglas:
//Blackjack, Juntar 21 pidiendo, en casa de pasarte de 21 pierdes.
//cartas o en caso de tener menos
//de 21 igual tener mayor puntuación que el dealer

while (vBan)
{
    switch (switchControl)
    {
        case "menu":
            Console.WriteLine(" \n *********************** ");
            Console.WriteLine(" -- Welcome al CASINO -- ");
            Console.WriteLine(" *********************** ");
            Console.WriteLine(" Ingrese una Opción:");
            Console.WriteLine("[21] Escriba ‘21’ para jugar al 21");
            Console.WriteLine("[0] Escriba ‘0’ para salir");
            switchControl = Console.ReadLine();
            break;
        case "21":
            
            vCartasD = "";
            vCartasJ = "";
            totalJugador = 0;
            totalDealer = 0;

            do
            {
                System.Random random = new System.Random();
                
                num = random.Next(1, 12);
                vCartasJ = vCartasJ + " -> " + num;
                totalJugador = totalJugador + num;

                numd = random.Next(1, 12);
                vCartasD = vCartasD + " -> " + numd;
                totalDealer = totalDealer + numd;

                Console.WriteLine("\n");
                Console.WriteLine(" -- CASINO -- ");
                Console.WriteLine("Toma tu carta, jugador.");
                Console.WriteLine($"Te salió el número: {num} ");
                Console.WriteLine("[y] ¿Deseas otra carta ?");
            } while (Console.ReadLine() == "y");

                Console.Clear();

                if (totalJugador > totalDealer && totalJugador < 22)
                {
                    message = "\n Venciste al dealer, felicidades";
                    switchControl = "menu";
                }
                else if (totalJugador >= 22)
                {
                    message = "\n Perdiste vs el dealer, te pasaste de 21";
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
                {
                    message = "\n Perdiste vs el dealer, lo siento";
                    switchControl = "menu";
                }
                else
                {
                    message = "\n Condición no válida";
                }
            Console.WriteLine("Cartas: " + vCartasJ);
            Console.WriteLine("totalJugador: " + totalJugador);
            Console.WriteLine("\n");
            Console.WriteLine("Cartas: " + vCartasD);
            Console.WriteLine("TotalDealer: " + totalDealer);
            Console.WriteLine(message);
            break;
        case "0":
            Console.WriteLine("Salio Cierre Ventana");
            vBan = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Valor ingresa no válido en el  C A S I N O \n");
            switchControl = "menu";
            break;
    }
}