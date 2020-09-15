using System;
using Flee.PublicTypes;

namespace ExpressionPlayground
{
    public static class CustomFunctions
    {
        // Declare a function that takes a variable number of arguments
        public static int Sum(params int[] args)
        {
            int sum = 0;

            foreach (int i in args)
                sum += i;

            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ExpressionContext context = new ExpressionContext();
            context.Imports.AddType(typeof(CustomFunctions));

            IDynamicExpression e = context.CompileDynamic("sum(1,2,3,4,5,6)");
            int result = (int)e.Evaluate();

            Console.WriteLine("result: " + result);

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
