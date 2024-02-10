//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

        double number1 = Double.Parse(Console.ReadLine());
        double number2 = Double.Parse(Console.ReadLine());
        double media = (3.5*number1 + 7.5*number2)/11;
        Console.WriteLine("MEDIA = " + media.ToString("F5"));

    }

}
