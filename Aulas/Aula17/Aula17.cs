using System;
using System.ComponentModel.DataAnnotations;

class Aula17{
    static void Main(){

        //int n1, n2, n3, n4;

        int[] n=new int[5]; //primeiro indice é 0
        int[] num=new int [3]{55, 77, 99};
        //int[] num={55, 77, 99,66, 88}; 
        string[] veiculos=new string[3];

        veiculos[0]="Carro";
        veiculos[1]="Avião";
        veiculos[2]="Navio";

        n[0]=11;
        n[1]=22;
        n[2]=33;
        n[3]=44;
        n[4]=55;

    Console.WriteLine("O Array tem o tamanho de: "+ num.Length);
    int posicao = Array.IndexOf(num, 55);
    Console.WriteLine("O valor 55 está na posição: " + posicao);
    }
    
}