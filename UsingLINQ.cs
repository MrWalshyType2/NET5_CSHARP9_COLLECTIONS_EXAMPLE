using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    /**
     * LINQ (Language-Integrated Query) can be used to access collections.
     * 
     * A LINQ query provides the following capabilities:
     *  - Filtering,
     *  - Ordering,
     *  - Grouping
     */
    public static class UsingLINQ
    {
        internal static List<Element> Elements { get; set; }

        internal static void DoLanguageQuery()
        {
            var subset = from element in Elements
                         where element.AtomicNumber < 22
                         orderby element.Name
                         select element;

            foreach (Element element in subset)
            {
                Console.WriteLine(element.Name + " " + element.AtomicNumber);
            }
        }
        // LINQ Query
    }
}
