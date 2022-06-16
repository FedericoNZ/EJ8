using EJ8.Barajas;

Baraja baraja1 = new Baraja();
Baraja mano = new Baraja();

for(int j = 0; j < 4; j++)
{
    for (int k = 0; k < 12; k++)
    {
        if (k == 7 || k == 8)
            continue;
        var card = new Carta();
        card.Palo = $"{j}";
        card.Numero = k+1;
        baraja1.listaCartas.Add(card);
    }
}

string userOption;
do
{
    Console.WriteLine("\nCARTAS ESPAÑOLAS.");
    Console.WriteLine("\nIngrese la opción a utilizar:");
    Console.WriteLine("1- Barajar\n2- Mostrar siguiente carta\n3- Mostrar cartas disponibles\n4- Dar cartas\n5- Mostrar cartas del montón\n6- Mostrar baraja\n0- Salir");
    userOption = Console.ReadLine();
    switch (userOption)
    {
        case "1":
                baraja1.Barajar();
            break;
        case "2":
            Carta SCarta = baraja1.SiguienteCarta();
            if(SCarta == null)
            {
                Console.WriteLine("\n=====================================\nLa baraja no tiene más cartas.\n=====================================\n");
            }
            else
            {
                Console.WriteLine("\n=====================================");
                Console.WriteLine($"La siguiente carta es: {SCarta.Numero} de {SCarta.Palo}.");
                Console.WriteLine("=====================================\n");
                mano.listaCartas.Insert(0, SCarta);
            }
            break;
        case "3":
            Console.WriteLine($"\n=======================================\nHay un total de {baraja1.CartasDisponibles()} cartas disponibles.\n=======================================\n");
            break;
        case "4":
            Console.WriteLine("\nIndique la cantidad de cartas que desea extraer:");
            var cantCartas = int.Parse(Console.ReadLine());
            List<Carta> colaCartas = baraja1.DarCartas(cantCartas);
            if (colaCartas == null)
            {
                Console.WriteLine("\n=====================================\nEsa cantidad no está disponible.\n=====================================\n");
            }
            else
            {
                Console.WriteLine("\n\n========================================\nCARTAS DADAS:");
                for (int i = 0; i < cantCartas; i++)
                {
                    Carta NextCard = colaCartas[0];
                    mano.listaCartas.Insert(0, NextCard);
                    colaCartas.Remove(NextCard);
                    Console.WriteLine($"Carta {i+1}: {NextCard.Numero} de {NextCard.Palo}");
                }
                Console.WriteLine("========================================\n");
            }
            break;
        case "5":
            Console.WriteLine("\n\n==========================\nCARTAS DEL MONTÓN:");
            mano.CartasMonton();
            Console.WriteLine("==========================\n");
            break;
        case "6":
            Console.WriteLine("\n\n==========================\nCARTAS EN LA BARAJA:");
            baraja1.MostrarBaraja();
            Console.WriteLine("==========================\n");
            break;
    }
} while (userOption != "0");
