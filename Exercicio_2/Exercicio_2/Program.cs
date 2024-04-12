namespace Exercicio2;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string Name = Console.ReadLine();

        Console.Write("Digite seu sobrenome: ");
        string LastName = Console.ReadLine();


        Console.WriteLine("Olá {0} {1}.\n", Name, LastName);
    }
}