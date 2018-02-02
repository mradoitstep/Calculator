using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            IntCalculator intCalculator = new IntCalculator();

            string line = Console.ReadLine();
            int a = Convert.ToInt32(line);
            line = Console.ReadLine();
            int b = Convert.ToInt32(line);

            int result = intCalculator.Add(a,b);
            Console.WriteLine("vysledok je{0}", result);

            result = intCalculator.Sub(a,b);
            Console.WriteLine("vysledok je{0}", result);

            FloatCalc floatCalc = new FloatCalc();


            float c = (float)Convert.ToDouble(line);
            float d = (float)Convert.ToDouble(line);
            float res = floatCalc.Add(c,d);
            Console.WriteLine("vysledok je{0:0.00}", result);

            string naformatovanyString = String.Format("vysedok je{0}", res);
            //novy csharp postup na formatovanie stringu
            string novyCSharFormat = $"vysledok je{res} a dalsi vysledok je {resut}";

            //pred riadiace znaky davam lomitko, aby to bol obyc text
            string cestaKsuboru = @"c:\\temp\\log.txt";

            //alebo pred cely retazec uvedem zavinac aby ignoroval riadici znak 
            string cestaKSuboru1 = @"c:\temp\log.txt";


            Console.WriteLine("koniec\"programu\" \a");










            Console.ReadLine();
        }
    }
}
