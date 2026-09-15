using System;

class Aula19
{
    static void Main()
    {
        // Declaração e criação de um vetor (array) de números inteiros chamado 'num'
        // 'new int[10]' reserva espaço na memória para armazenar 10 valores (índices de 0 a 9)
        int[] num = new int[10];

        // Primeiro loop 'for': usado para percorrer e inicializar cada posição do vetor
        // num.Length retorna o tamanho total do vetor (neste caso, 10).
        // Usar num.Length no lugar de um número fixo (como < 10) é uma ótima prática, 
        // pois garante que o laço percorrerá exatamente do índice 0 até o último 
        // elemento válido, evitando erros caso o tamanho do vetor mude no futuro.
    for (int i = 0; i < num.Length; i++){
            // Atribui o valor 0 para a posição atual 'i' do vetor
            // (Nota: em C# o vetor já inicia zerado, mas aqui isso é feito de forma explícita)
            num[i] = 0;            
        }
        
        // Segundo loop 'for': percorre o vetor novamente para exibir os valores armazenados
    for (int i = 0; i < 10; i++){
            // O Console.WriteLine imprime o resultado na tela
            // {0} pega o valor de 'i' (a posição/índice atual)
            // {1} pega o valor guardado dentro de 'num[i]'
            Console.WriteLine("Valor de num na posicao {0}: {1}", i, num[i]);
        }
    }
}