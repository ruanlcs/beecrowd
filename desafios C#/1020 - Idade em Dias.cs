//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

        int num = Convert.ToInt32(Console.ReadLine());
        double na = num/365;
        double nm = (num%365)/30;
        double nd = ((num%365)%30)/1;
        
        Console.WriteLine(na + " ano(s)");
        Console.WriteLine(nm + " mes(es)");
        Console.WriteLine(nd + " dia(s)");

    }

}
