using System;

namespace sequnciaCentena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor=ConsoleColor.DarkMagenta;
            Console.ForegroundColor=ConsoleColor.Black;
            Console.WriteLine("+---------------------+");
            Console.WriteLine("|--Sequencia Centena--|");
            Console.WriteLine("+---------------------+");
            Console.ResetColor();

            for(int i = 1 ;  i < 101 ; i++){
                
                Console.WriteLine(i);
            }
        }
    }
}
