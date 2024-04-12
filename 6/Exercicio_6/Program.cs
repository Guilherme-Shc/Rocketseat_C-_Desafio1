using System.Globalization;

namespace Exercicio_6;

//OBS: fiquei meio confuso se o que estava pedindo era um código que pegava as datas do computador e mostrava o que o usuário selecionava
//ou se o usuário deveria inserir as datas ele mesmo, ent resolvi fazer sendo a primeira opção
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o número de acordo com a exibição desejada:");
        Console.WriteLine("1-Formato completo");
        Console.WriteLine("2-Apenas Data");
        Console.WriteLine("3-Apenas Hora");
        Console.WriteLine("4-Data em extenso");
        int number = Convert.ToInt16(Console.ReadLine());

        if (number < 1 || number > 4) { 
            Console.WriteLine("Insira um valor Válido");
            return;
        }

        DateTime dateTime = DateTime.Now;
        if (number == 1)
        {
            string date1 = dateTime.ToString("F",new CultureInfo("pt-BR"));
            Console.WriteLine(date1);
        }
        else if (number == 2)
        {
            string date2 = dateTime.ToString("d", new CultureInfo("pt-BR"));
            Console.WriteLine(date2);
        }
        else if (number == 3)
        {
            string date3 = dateTime.ToString("HH:mm", new CultureInfo("pt-BR"));
            Console.WriteLine(date3);
        }
        else
        {
            string date4 = dateTime.ToString("dd/MMMM/yyyy", new CultureInfo("pt-BR"));
            Console.WriteLine(date4);
        }
    }
}

