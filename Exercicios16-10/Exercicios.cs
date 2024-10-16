/*1. 
Será criada apenas uma instância.

Embora strings na linguagem C# sejam imutáveis , uma nova instância não será criada se a operação não alterar o valor da string.*/

//2

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("\n");
        }
        for (int i = 0; i <= 4; i++)
        {
            for (int j = 4; j > i; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine("\n");
        }
        Console.ReadKey();
    }
}

// 3
class Program
{
    static void Main(string[] args)
    {
        int tamanho;

        Console.WriteLine("Informe o tamanho da Matrix Identidade: ");
        tamanho = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n\n Matrix Identidade\n\n");

        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                if (i == j)
                {
                    Console.Write(1);
                }
                else
                {
                    Console.Write(0);
                }
            }
            Console.WriteLine("\n");
        }
        Console.ReadKey();
    }
}