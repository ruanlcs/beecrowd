//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

        int num = Convert.ToInt32(Console.ReadLine());
        double nh = num/3600;
        double nm = (num%3600)/60;
        double ns = ((num%3600)%60)/1;
        
        Console.WriteLine(nh + ":" + nm + ":" + ns);

    }

}
