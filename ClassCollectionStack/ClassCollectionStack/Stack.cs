using System.Collections;

namespace ClassCollectionStack
{
    public class Stack : IEnumerable
    {
        private readonly List<string> _list = new();

        public int Size
        { 
            get
            {
                return _list.Count;
            }
        }

        public string? Top 
        { 
            get
            {
                if (_list.Count != 0)
                 return _list.LastOrDefault();
                return null;
            }
        } 

        public Stack(params string[] elements)
        {

            foreach (var item in elements)
            {
                _list.Add(item);
            }
        }
        public void Add(string elemment)
        {
            _list.Add(elemment);
        }
        public string Pop()
        {
            string element;
            try
            {
                if (Size > 0)
                {
                    element = _list[^1];
                    _list.Remove(_list[^1]);
                }
                else
                {
                    throw new Exception("Стек пустой");
                }
                return element;
            }
            catch(Exception e) 
            {
                Console.WriteLine(e);
            }

            return "Стек пустой";
           
        }   

        public static Stack Concat(params Stack[] stacks)
        {
            var newStack = new Stack();

            foreach (var item in stacks)
            {
                var stackSize = item.Size;

                for (var i = 0; i < stackSize; i++)
                {
                    newStack.Add(item.Pop());
                }
            }
            return newStack;
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)_list).GetEnumerator();
        }

        private class StackItem
        {
            private readonly Stack _stack;

        }
    }
}