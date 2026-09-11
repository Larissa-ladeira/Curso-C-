using System;

class Aula06{
    
    static void Main(){

        // int n1, n2, n3;

        // n1=10; n2=20; n3=30;
        // //Console.WriteLine(n1 + " , " + n2 + " , " + n3);
        // Console.Write("\nn1=\t{0}\n n2=\t{1}\n n3=\t{2}\n", n1,n2,n3);
        double valorCompra=5.50;
        double valorVenda;
        double lucro=0.1;
        string produto="Pastel";

        valorVenda = valorCompra+(valorCompra*lucro);

        Console.WriteLine("Produto........:{0,15}", produto);
        Console.WriteLine("Val.compra.....:{0,15:c}", valorCompra);
        Console.WriteLine("Lucro..........:{0,15:p}", lucro);
        Console.WriteLine("Val.venda......:{0,15:p}", valorVenda);



    }
}
