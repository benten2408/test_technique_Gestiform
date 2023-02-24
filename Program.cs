using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Générer une liste aléatoire de 50 nombres entiers
        List<int> nombres = new List<int>();
        Random rand = new Random();
        for (int i = 0; i < 50; i++)
        {
            nombres.Add(rand.Next(-1000, 1001));
        }

        // Parcourir la liste et effectuer les opérations demandées pour chaque nombre
        foreach (int n in nombres)
        {
            if (n % 3 == 0 && n % 5 == 0)
            {
                Console.WriteLine("Gestform");
            }
            else if (n % 3 == 0)
            {
                Console.WriteLine("Geste");
            }
            else if (n % 5 == 0)
            {
                Console.WriteLine("Forme");
            }
            else
            {
                Console.WriteLine(n);
            }
        }
    }
}