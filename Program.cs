namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,n2,s;
            Console.WriteLine("escribir un numero ");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("escribir un numero ");
            n2 = int.Parse(Console.ReadLine());
            s = n + n2;
            Console.WriteLine(s);
        }
    }
}