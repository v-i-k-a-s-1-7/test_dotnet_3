namespace Indexes
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyData obj = new MyData();

            obj[0] = "C";
            obj[1] = "C++";
            obj[2] = "C#";

            Console.WriteLine("The First Value is: " + obj[0]);
            Console.WriteLine("The Second Value is: " + obj[1]);
            Console.WriteLine("The Third Value is: " + obj[2]);
        }
    }
}
