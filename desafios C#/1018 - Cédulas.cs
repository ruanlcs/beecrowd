//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

        int num = Convert.ToInt32(Console.ReadLine());
        double n100 = num/100;
        double n50 = (num%100)/50;
        double n20 = ((num%100)%50)/20;
        double n10 = ((((num%100)%50))%20)/10;
        double n5 = (((((num%100)%50))%20)%10)/5;
        double n2 = ((((((num%100)%50))%20)%10)%5)/2;
        double n1 = (((((((num%100)%50))%20)%10)%5)%2)/1;
        
        Console.WriteLine(num);
        Console.WriteLine(n100 + " nota(s) de R$ 100,00");
        Console.WriteLine(n50 + " nota(s) de R$ 50,00");
        Console.WriteLine(n20 + " nota(s) de R$ 20,00");
        Console.WriteLine(n10 + " nota(s) de R$ 10,00");
        Console.WriteLine(n5 + " nota(s) de R$ 5,00");
        Console.WriteLine(n2 + " nota(s) de R$ 2,00");
        Console.WriteLine(n1 + " nota(s) de R$ 1,00");

    }

}
