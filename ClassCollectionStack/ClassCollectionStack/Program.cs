using System.Collections;

namespace ClassCollectionStack
{
    public class Program
    {
        public static void Main()
        {
            var stack = new Stack("a", "b", "c");

            var sMerge = new Stack("a", "b", "c");
            sMerge.Merge(new Stack("1", "2", "3"));
            
            // size = 3, Top = 'c'
            Console.WriteLine($"size = {stack.Size}, Top = '{stack.Top}'");
            var deleted = stack.Pop();
            // Извлек верхний элемент 'c' Size = 2
            Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {stack.Size}");
            stack.Add("d");
            // size = 3, Top = 'd'
            Console.WriteLine($"size = {stack.Size}, Top = '{stack.Top}'");
            stack.Pop();
            stack.Pop();
            stack.Pop();
            // size = 0, Top = null
            Console.WriteLine($"size = {stack.Size}, Top = {(stack.Top == null ? "null" : stack.Top)}");
            stack.Pop();
            var sConcat = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));

            foreach (var item in sConcat)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}