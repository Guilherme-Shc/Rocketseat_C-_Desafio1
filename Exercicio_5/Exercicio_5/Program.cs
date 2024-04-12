using System.Text;

namespace Exercicio5;

class Program
{
    static void Main()
    {
        Console.WriteLine("A placa antiga deve ser inserida nesse modelo 'ABC-1234'");

        Console.Write("Insira a Placa do Carro: ");
        string text = Console.ReadLine();

        string[] splitedText = text.Split('-');

        string letterText = splitedText[0];
        string numText = splitedText[1];

        int charNum = letterText.Length + numText.Length;
        if (charNum != 7) {
            Console.WriteLine("Placa inserida incorretamente, tente novamente");
            return;
        };

        for (int i = 0; i < 3; i++)
        {
            if (letterText[i] < 65 || letterText[i] > 90)
            {
                Console.WriteLine("O caractére de letras, na posição {0} não é uma letra, tente novamente", i + 1);
                return;
            }
        }

        for (int i = 0; i < 4; i++)
        {
            if (numText[i] < 47 || numText[i] > 58)
            {
                Console.WriteLine("O caractére de números, na posição {0} não é um número, tente novamente", i + 1);
                return;
            }
        }

        //transformando a placa antiga para o novo modelo usado no brasil
        StringBuilder newNumtext = new StringBuilder(numText);
        newNumtext[1] = (char)(numText[1] + 17); //mudando o valor de um número para letra usando os valores da tabela ASCii
        

        Console.WriteLine("\nTudo Certo com a placa");
        Console.WriteLine("Atualizando-a para o novo modelo a placa nova será: {0}{1}", letterText, newNumtext);
    }
}