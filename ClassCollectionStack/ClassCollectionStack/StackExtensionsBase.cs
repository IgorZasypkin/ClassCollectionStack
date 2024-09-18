namespace ClassCollectionStack
{
    public static class StackExtensionsBase : Object
    {
        public static void Merge(this Stack s1, Stack s2)
        {
            var stackSize = s2.Size;

            for (var i = 0; i < stackSize; i++)
            {
                s1.Add(s2.Pop());
            }
        }
    }
}