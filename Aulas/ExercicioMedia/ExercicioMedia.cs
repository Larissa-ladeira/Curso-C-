using System;

class Exercicio01{
    static void Main(){
        int bimestre, resultado, media;
        int cont = 0;
        int soma = 0;

        Console.WriteLine("Quantos Bimestre são? ");
        bimestre = int.Parse(Console.ReadLine());
        while (cont < bimestre ){


        Console.WriteLine("Digite  a nota do {0}° Bimestre:",cont+1);   
        resultado = int.Parse(Console.ReadLine());
            cont++;


        soma += resultado;
        
        }

        media = soma / bimestre;


        if (soma < 20){
            Console.WriteLine("Resultado: {0} O aluno está reprovado. O aluno não atingiu o requisito de 20 pontos.", soma);
        }
        else if (soma >= 20 && soma < 60){
            Console.WriteLine("Resultado: {0} O aluno está em recuperação. O aluno precisa de 20 pontos para ser aprovado.", soma);
        }else{
            Console.WriteLine("Resultado: {0} O aluno está aprovado. O aluno atingiu o requisito de 20 pontos.", soma);
        }
        Console.WriteLine("A média do aluno é: {0}", media);
    }
}