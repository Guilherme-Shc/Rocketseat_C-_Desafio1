using System.Text.RegularExpressions;

namespace Exercicio4;

class Program
{
    static void Main()
    {
        Console.WriteLine("Insira uma palavra ou frase: ");
        string text = Console.ReadLine();

        string newText = Regex.Replace(text, @"\s", "");
        int charNum = newText.Length;

        Console.WriteLine("O número de letras é: {0}",charNum);
    }
}