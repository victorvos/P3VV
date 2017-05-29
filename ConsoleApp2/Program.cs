using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    private static int counter = 0;

    static void Main(string[] args)
    {
        String path = @"C:\Users\Eigenaar\Documents\Visual Studio 2017\Projects\ConsoleApp2\ConsoleApp2\randomtext.txt";


        foreach (String word in GetWords(path, s => s.StartsWith("b")))
        {
            Console.Write(word + " ");
        }
        Console.ReadKey();
    }

    public static IEnumerable<String> GetWords(string path, Predicate<String> lambda)
    {
        String text = "";

        try
        {
            text = System.IO.File.ReadAllText(path);
        }
        catch
        {
            Console.WriteLine("Wrong Path");
        }

        String[] list = new String[text.Split().Length];

        foreach (string woord in text.Split())
        {
            list[counter] = woord;
            counter++;
        }
        String[] listt = Array.FindAll<String>(list, lambda);

        foreach (string woord in listt)
        {
            yield return woord;
        }

    }
}
