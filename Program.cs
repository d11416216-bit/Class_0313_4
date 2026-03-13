namespace Class_0313_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test joe, mary;

            joe = new Test();
            mary = new Test();

            joe.SetGrade(70, 80);
            mary.SetGrade(70, 90);

            Console.WriteLine(joe.GetAvg());

            Console.WriteLine(joe.GetAvg());


        }
    }
}
