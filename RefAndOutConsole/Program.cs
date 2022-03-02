using System;
using ValueAndRefrence;

namespace RefAndOutConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
           
           
            var bytearr = new int[] { 1, 2, 3};
            bytearr.SetValue(10, 0);
            
            Console.WriteLine(bytearr.GetValue(0));

            foreach (var item in bytearr)
            {
                Console.WriteLine(item);
            }
        }

        private static void ef()
        {
            var RevAndValue = new RefrenceType();

            int a = 23, b = 55;


            Console.WriteLine($"a={a} :b={b}");
            RevAndValue.SwapByValue(a, b);
            Console.WriteLine($"a={a} :b={b}");
            RevAndValue.SwapByRef(ref a, ref b);

            RevAndValue.CheckOutKeyWordByRef(out b);
            Console.WriteLine(b);
        }
    }
}
