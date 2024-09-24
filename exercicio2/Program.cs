using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        int procurado = 0;

        for (int i = 0; i < frase.Length; i++)
        {
            if (frase[i] == 'a' || frase[i] == 'A')
            {
                procurado++;
            }
        }

        if (procurado > 0)
        {
            Console.WriteLine("A letra 'a'  aparece {0} vez(es) na frase.", procurado);
        }
        else
        {
            Console.WriteLine("A letra 'a'  não aparece na frase.");
        }
    }
}
