namespace IsPalindromeGenericStack
{
    public class IsPalindromeStack
    {
        public bool IsPalindromic<T>(IEnumerable<T> inputSequence)
            where T : IComparable
        {
            Stack<T> buffer = new Stack<T>();

            foreach (T element in inputSequence)
            {
                buffer.Push(element);
            }

            for (int i = 0; i < inputSequence.Count(); i++)
            {
                if (buffer.Pop().CompareTo(inputSequence.ElementAt(i)) == 0)
                    continue;
                else
                    return false;
            }

            return true;
        }
    }
}