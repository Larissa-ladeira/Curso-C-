using System;

class Aula21{
    static void Main(){

        // int num=5;

        // while (num < 5){
        //     Console.WriteLine("CFB Curso");
        // // }
        // do{
        //     Console.WriteLine("CFB Curso");

            
        // }while(num < 5);

        string senha="123";
        string senhauser;
        int tentativas = 0;

        do{
            Console.Clear();
            Console.WriteLine("Digite a senha:");
            senhauser=Console.ReadLine();
            tentativas++;

        }while(senha != senhauser);
            Console.WriteLine("Senha correta: {0}° Tentativas", tentativas);
    }
}