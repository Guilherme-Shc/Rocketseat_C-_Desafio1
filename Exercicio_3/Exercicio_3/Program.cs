namespace Exercicio3;

class Program
{
    static void Main()
    {
        Console.WriteLine("Os valores decimais devem ser digitados com , e não .\n\n");
        Console.Write("Digite o primeiro valor decimal: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo valor decimal: ");
        double num2 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine(num1 + num2);
        Console.WriteLine(num1 - num2);
        Console.WriteLine(num1 * num2);
        if (num2 != 0)
        {
            Console.WriteLine(num1 / num2);
        }
        else { Console.WriteLine("Divisão inválida pelo segundo número ser igual a 0");}
        Console.WriteLine((num1 + num2) / 2);

    }
}