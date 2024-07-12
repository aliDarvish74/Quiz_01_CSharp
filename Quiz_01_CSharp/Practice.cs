using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_01_CSharp;

public static class Practice
{
    public static void BMI(double weight, double height)
    {
        var heightInMeter = height / 100;
        var bmi = weight / Math.Pow(heightInMeter, 2);
        switch (bmi)
        {
            case < 18.5:
                Console.WriteLine("Underweight");
                break;
            case < 25:
                Console.WriteLine("Normal");
                break;
            case < 30:
                Console.WriteLine("Overweight");
                break;
            default:
                Console.WriteLine("Fat");
                break;
        }
    }
}
