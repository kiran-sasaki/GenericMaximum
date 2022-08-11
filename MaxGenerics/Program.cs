namespace MaxGenerics
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Find Max using Generics";
            Console.WriteLine("          Find Max using Generics          ");

            
            Console.WriteLine("Integer Tests");
            TestCase.IntTest();

            Console.WriteLine("Float tests");
            TestCase.FloatTest();

            Console.WriteLine("String tests");
            TestCase.StringTest();

        }
    }
}