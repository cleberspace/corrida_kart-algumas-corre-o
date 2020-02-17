using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace corrida_kart
{
    class ler_o_arquivo_texto
    {
        string text = System.IO.File.ReadAllText(@"C:\corrida.txt");
              
        Console.WriteLine("Contents of WriteText.txt = {0}", text);

        string[] lines = System.IO.File.ReadAllLines(@"C:\corrida.txt");
       
        System.Console.WriteLine("Contents of WriteLines2.txt = ");
        foreach (string line in lines)
        {
           
            Console.WriteLine("\t" + line);
        }

        Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();

 }
