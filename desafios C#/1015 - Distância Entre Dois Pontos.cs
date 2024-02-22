//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

        String line1 = Console.ReadLine();
        String line2 = Console.ReadLine();
        
        string[] posX = line1.Split(' ');
        double x0 = Convert.ToDouble(posX[0]);
        double y0 = Convert.ToDouble(posX[1]);
        
        string[] posY = line2.Split(' ');
        double x1 = Convert.ToDouble(posY[0]);
        double y1 = Convert.ToDouble(posY[1]);
        
        double d = Math.Sqrt((Math.Pow((x1-x0),2))+(Math.Pow((y1-y0),2)));

        Console.WriteLine(d.ToString("F4"));
    }

}
