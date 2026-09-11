using System;

class Exercicio01{
    static void Main(){
        int B1, B2, B3, B4, resultado, media;

        Console.WriteLine("Digite  a nota do primeiro bimestre:");
        B1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite  a nota do segundo bimestre:");   
        B2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite  a nota do terceiro bimestre:");
        B3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite  a nota do quarto bimestre:");
        B4 = int.Parse(Console.ReadLine());

        resultado = (B1 + B2 + B3 + B4);
        media = resultado / 4;

        if (resultado < 20){
            Console.WriteLine("Resultado: {0} O aluno está reprovado. O aluno não atingiu o requisito de 20 pontos.", resultado);
        }
        else{
            Console.WriteLine("Resultado: {0} O aluno está aprovado. O aluno precisa de 20 pontos para ser aprovado.", resultado);
        }
        Console.WriteLine("A média do aluno é: {0}", media);
    }
}