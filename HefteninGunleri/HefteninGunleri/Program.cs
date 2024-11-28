namespace HefteninGunleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gun daxil edin:");
            int day = int.Parse(Console.ReadLine());
            switch (day) {
                case 1:
                    Console.WriteLine("Bazar Ertesi.");
                    break;
                case 2:
                    Console.WriteLine("Cersenbe Axsami.");
                    break;
                case 3:
                    Console.WriteLine("Cersenbe.");
                    break;
                case 4:
                    Console.WriteLine("Cume Axsami");
                    break;
                case 5:
                    Console.WriteLine("Cume");
                    break;
                case 6:
                    Console.WriteLine("Senbe");
                    break;
                case 7:
                    Console.WriteLine("Bazar");
                    break;
                default:
                    Console.WriteLine("1 ve 7 arasi eded daxil etmelisiniz!");
                    break;
            
            
            }
        }
    }
}
