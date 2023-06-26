namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MethodOverloading.Add(1,2));
            Console.WriteLine(MethodOverloading.Add(1,2.4));
            Console.WriteLine(MethodOverloading.Add(1.1,4.5));
            Console.WriteLine(MethodOverloading.Add(1, 0, true));
            Console.WriteLine(MethodOverloading.Add(1, 2, true));
            Console.WriteLine(MethodOverloading.Add(1, 2, false));
        }
    }
}
