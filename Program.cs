namespace Wages_App
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        { 

            Console.WriteLine("Enter your Hours");
            int Hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------");
            int WageCalc = Hours * 22;
            while (Hours > 168)
            {
                Console.WriteLine("enter a valid hour");
                Hours = Convert.ToInt32(Console.ReadLine());
            }
            {
                if (Hours > 30)
                {
                    int BonusHours = Hours + 5;
                    Console.WriteLine("you get a bonus 5 Hours!!!");
                    Console.WriteLine("-----------------------------");
                }
                Console.WriteLine("Your hourly wage Is:");
                Console.WriteLine(WageCalc);
                Console.WriteLine("-----------------------------");
                if (WageCalc > 450)
                {
                    double TaxCalcHigh = WageCalc * .9;
                    TaxCalcHigh = Math.Round(TaxCalcHigh, 2);
                    Console.WriteLine("After Tax Your income is");
                    Console.WriteLine(TaxCalcHigh);
                }
                else
                {
                    double TaxCalcLow = WageCalc * .75;
                    TaxCalcLow = Math.Round(TaxCalcLow,2);
                    Console.WriteLine("after Tax Your income is");
                    Console.WriteLine(TaxCalcLow);
                    Console.WriteLine("-----------------------------");
                }
            }
        }
    }
}
