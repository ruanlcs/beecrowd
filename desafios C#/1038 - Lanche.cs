//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

        string[] valor = Console.ReadLine().Split(' ');
        int cod = Convert.ToInt32(valor[0]);
        int qtd = Convert.ToInt32(valor[1]);
        
        double preco = 0;
        
        if(cod == 1){
            preco = 4;
        }else if(cod == 2){
            preco = 4.50;
        } else if(cod == 3){
            preco = 5.00;
        } else if(cod == 4){
            preco = 2.00;
        } else if(cod == 5){
            preco = 1.50;
        }
        double total = preco * qtd;
        Console.WriteLine("Total: R$ " + total.ToString("F2"));

    }

}
