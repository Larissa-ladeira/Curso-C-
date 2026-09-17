using System;

class Aula24{
    static void Main(){
        int v1, v2,r;
        v1=Convert.ToInt32(Console.ReadLine());
        v2=Convert.ToInt32(Console.ReadLine());
        r=soma(v1,v2);
        Console.WriteLine("A soma de {0} + {1} = {2}", v1,v2,r);

        

    }

    // static void soma(int n1,int n2){
    static int soma(int n1,int n2){

        int res=n1+n2;
        return res;
        // Console.WriteLine("A soma de {0} + {1} = {2}", n1,n2,res);
 


    }

}