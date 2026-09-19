using System;

class Aula27{
    static void Main(){
        Console.WriteLine("Digite os números para somar separados por espaço (ex: 10 20 30):");      
        string entrada = Console.ReadLine();
        
        // 3. Verifica se o usuário digitou alguma coisa
        if (!string.IsNullOrEmpty(entrada)) {
        //StringSplitOptions.RemoveEmptyEntries para ignorar espaços extras ou duplos 
            string[] partes = entrada.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);            
            int[] numeros = Array.ConvertAll(partes, int.Parse);

            //Chama a função passando o array criado com os dados digitados
            soma(numeros);
        } else {
            Console.WriteLine("Nenhum valor foi digitado.");
        }
    }
    
    static void soma(params int[]n){
        int res=0;

        if(n.Length < 1){
            Console.WriteLine("Não existe valores a serem somados");
        }else if(n.Length < 2){
            Console.WriteLine("Valores insulficientes para soma");
        }
        else{
            for(int i = 0; i < n.Length; i++){
                res += n[i];

            }

            string valoresConcatenados = string.Join(" + ",n);
      

            Console.WriteLine("a Soma de {0} = {1}", valoresConcatenados,res);
        }
    }
}