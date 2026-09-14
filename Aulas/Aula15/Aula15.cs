using System;

class Aula15{
    static void Main(){

        int tempo=0;
        char escolha;
        char continuar='s';
        Console.WriteLine("Belo Horizonte/BH a Vitória/ES");
        Console.WriteLine("Escolha o transporte:[a]Avião| [o] Ônibus| [c]Carro");
        escolha=char.Parse(Console.ReadLine().ToLower());


        switch (escolha){
            case 'a':
                tempo=50;
                break;

            case 'c':
                tempo=480;
                break;

            case 'o':
                tempo=660;    
                break;
            default:  
                tempo=-1;
                break;
        }
        if(tempo < 0){
            Console.WriteLine("Transporte inválido");
        }
        else{
            Console.WriteLine("Tempo de viagem: {0} minutos",tempo);
        }

        Console.Write("Quer continuar? [s/n] ");
        continuar=char.Parse(Console.ReadLine().ToLower());        
        if (continuar=='s'){
            Main();
        }
        else{
            Console.WriteLine("Fim do programa");
        }
    }
    
}