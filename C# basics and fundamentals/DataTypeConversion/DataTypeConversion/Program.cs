using System;
class Program
{
    static void Main()
    {
        
        int i = 100;
        float f = i;
        Console.WriteLine(f);
 
        float a = 1893.89F;
        int b = Convert.ToInt32(a);
        Console.WriteLine(b);
      
        string str = "50";
        int s = int.Parse(str);
        Console.WriteLine(s);

        string str1 = "134LJ";
        int result = 0;
        bool IfConditionIsTrue = int.TryParse(str1, out result);
        if (IfConditionIsTrue)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }
    }
}