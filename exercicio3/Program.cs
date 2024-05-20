using System;

class Programa
{
    static void Main()
    {
        Console.Write("Entre com um número inteiro: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (EPrimo(numero))
            {
                Console.WriteLine($"{numero} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} não é um número primo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, entre com um número inteiro.");
        }
    }

    static bool EPrimo(int numero)
    {
        if (numero <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}

