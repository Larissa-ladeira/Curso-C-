using System;

namespace Aula02
{
    class Program
    {
        static void Main (String[] args)
        {
            Console.WriteLine("Meu proimeiro programa em C#");
            if (args.GetLength(0) >0){
                Console.Write(args.GetValue(0));

            }
        }
    }
}

