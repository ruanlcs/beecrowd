//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

       int A = Int32.Parse(Console.ReadLine());
       int B = Int32.Parse(Console.ReadLine());
       int C = Int32.Parse(Console.ReadLine());
       int D = Int32.Parse(Console.ReadLine());
       
       int diferenca = (A*B) - (C*D);
       Console.WriteLine("DIFERENCA = " + diferenca);
    }

}
