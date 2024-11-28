namespace ifNegativeStop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int S= 0, number = 0;
            while (number >= 0)
            {
                Console.WriteLine("Enter a number:");
                number = int.Parse(Console.ReadLine());
                if (number >= 0)
                {
                    S += number;
                }
            }
            Console.WriteLine(S);
            // sertde menfi oldugun yoxlayaraqda yaza bilerik:
            //int S = 0, number = 0;
            //while (number >= 0)
            //{
            //    Console.WriteLine("Enter a number:");
            //    number = int.Parse(Console.ReadLine());
            //    if (number < 0)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        S += number;
            //    }
            //}
            //Console.WriteLine(S);
        }
    }
}
