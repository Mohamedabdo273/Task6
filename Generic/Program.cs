namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool IsEqual1 = ClsCalculator.AreEqual(10, 20);
            // bool IsEqual = ClsCalculator.AreEqual("ABC", "ABC");
            // bool IsEqual = ClsCalculator.AreEqual(10.5, 20.5);
            if (IsEqual1)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }
            Console.ReadKey();
        
      
         /////////////////////////////

            bool IsEqual = ClsCalculator.AreEqual<int>(10, 20);
            //bool IsEqual1 = ClsCalculator.AreEqual<string>("ABC", "ABC");
            //bool IsEqual2 = ClsCalculator.AreEqual<double>(10.5, 20.5);
            bool IsEqual4 = ClsCalculator.AreEqual<Account>(new(1, "Ahmed"), new(1, "Ahmed"));
            if (IsEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }

            Console.ReadKey();
        }
    }
}
