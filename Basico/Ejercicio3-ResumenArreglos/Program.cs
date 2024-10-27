// Simulación para barajar y repartir cartas

string[] palos = { "Corazones", "Diamantes", "Tréboles", "Picas" };
string[] valores = { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

string[] baraja = new string[52];
for (int i = 0; i < palos.Length; i++)
{
    for (int j = 0; j < valores.Length; j++)
    {
        baraja[i * valores.Length + j] = valores[j] + " de " + palos[i];
    }
}

// Barajar las cartas 
Random rnd = new Random();
for (int i = baraja.Length - 1; i > 0; i--)
{
    int j = rnd.Next(i + 1);
    string temp = baraja[i];
    baraja[i] = baraja[j];
    baraja[j] = temp;
}

// Repartir las cartas
Console.WriteLine("Cartas repartidas: ");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(baraja[i]);
}
Console.ReadKey();
