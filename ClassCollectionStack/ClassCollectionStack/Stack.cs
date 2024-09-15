using System.Collections;

namespace ClassCollectionStack
{
    public class Stack : IEnumerable
    {
        private readonly List<string> _list = new();

        public Stack(params string[] val)
        {

            foreach (var item in val)
            {
                _list.Add(item);
            }
        }

        public string Pop()
        {
            string element;

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

        public void Add(string elem)
        {
            _list.Add(elem);
        }

        public int Size => _list.Count;

        public string Top => _list.LastOrDefault();

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
            return _list.GetEnumerator();
        }
    }
}