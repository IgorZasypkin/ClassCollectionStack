using System.Collections;

namespace ClassCollectionStack
{
    public class Program
    {
        public static void Main()
        {
            var stack = new Stack("a", "b", "c");
            stack.Merge(new Stack("1", "2", "3"));

            var stackConcat1 = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));

            foreach (var item in stackConcat1)
            {
                Console.Write($"{item}, ");
            }

            foreach (var item in stack)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}