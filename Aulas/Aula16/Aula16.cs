using System;

class Aula16{
    static void Main(){

        int tempo=0;
        char escolha;
        
        inicio:
        Console.Clear();

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
        escolha=char.Parse(Console.ReadLine().ToLower());        
        if (escolha=='s'){
            goto inicio;
        }
        else{
            Console.WriteLine("Fim do programa");
        }
        Console.WriteLine("Calcular novamente? [s/n]");
        escolha=char.Parse(Console.ReadLine().ToLower());

        if (escolha=='s'){
            goto inicio;
        }
        else{
            Console.Clear();
            Console.WriteLine("Fim do programa");
        }
    }
    
}