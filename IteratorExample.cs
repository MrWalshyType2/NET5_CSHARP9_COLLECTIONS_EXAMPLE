using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    /**
     * Iterators perform a custom iteration over a collection, using a `yield return` statement to return
     * each element of the collection one at a time. Iterators can be methods or a `get` accessor.
     * 
     * Iterators are called via the `foreach` statement, each iteration calls the iterator. When a `yield return`
     * statement is reached in the iterator, and expression is returned while the current location is held in memory
     * waiting for iteration to continue.
     */
    public static class IteratorExample
    {
        internal static void ListEvenNumbers()
        {
            foreach (int number in EvenSequence(5, 18))
            {
                Console.WriteLine(number.ToString() + " ");
            }
            Console.WriteLine();
        }

        private static IEnumerable<int> EvenSequence(int firstNumber, int lastNumber)
        {
            // yield even nums in range
            for (var number = firstNumber; number <= lastNumber; number++)
            {
                if (number % 2 == 0) yield return number;
            }
        }
    }
}
