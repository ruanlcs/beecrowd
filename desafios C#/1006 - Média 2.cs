//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

       double A = Double.Parse(Console.ReadLine());
       double B = Double.Parse(Console.ReadLine());
       double C = Double.Parse(Console.ReadLine());
       
       double media = (A*2 + B*3 + C*5)/10;
       Console.WriteLine("MEDIA = " + media.ToString("F1"));

    }

}
