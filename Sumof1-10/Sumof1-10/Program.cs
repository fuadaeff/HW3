namespace Sumof1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int S = 0;
            for(int i = 1; i <= 10; i++)
            {
                S += i;
            }
            Console.WriteLine(S);
        }
    }
}
