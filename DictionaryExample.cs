using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    /**
     * The generic Dictionary collection allows value access via the key of the values element.
     * 
     * Key-retrieval is fast as the Dictionary class implements a hash table.
     */
    public static class DictionaryExample
    {
        public static void IterateThruDictionary()
        {
            Dictionary<string, Element> elements = BuildDictionary();

            foreach (KeyValuePair<string, Element> kvp in elements)
            {
                Element theElement = kvp.Value;

                Console.WriteLine("key: " + kvp.Key);
                Console.WriteLine("values: " + theElement.Symbol + " " +
                    theElement.Name + " " + theElement.AtomicNumber);
            }
        }
        internal static Dictionary<string, Element> BuildDictionary()
        {
            var elements = new Dictionary<string, Element>();

            AddToDictionary(elements, "K", "Potassium", 19);
            AddToDictionary(elements, "Ca", "Calcium", 20);
            AddToDictionary(elements, "Sc", "Scandium", 21);
            AddToDictionary(elements, "Ti", "Titanium", 22);

            return elements;
        }

        // Using a Collection initializer
        private static Dictionary<string, Element> BuildDictionary2()
        {
            return new Dictionary<string, Element>
            {
                {"K",
                    new Element() { Symbol="K", Name="Potassium", AtomicNumber=19}},
                {"Ca",
                    new Element() { Symbol="Ca", Name="Calcium", AtomicNumber=20}},
                {"Sc",
                    new Element() { Symbol="Sc", Name="Scandium", AtomicNumber=21}},
                {"Ti",
                    new Element() { Symbol="Ti", Name="Titanium", AtomicNumber=22}}
            };
        }

        private static void AddToDictionary(Dictionary<string, Element> elements, string symbol, string name, int atomicNumber)
        {
            Element newElement = new Element();

            newElement.Symbol = symbol;
            newElement.Name = name;
            newElement.AtomicNumber = atomicNumber;

            elements.Add(key: newElement.Symbol, value: newElement);
        }

        internal static void FindInDictionary(Dictionary<string, Element> elements, string symbol)
        {
            if (elements.ContainsKey(symbol) == false)
                Console.WriteLine(symbol + "Not found");
            else
            {
                Element elementFound = elements[symbol];
                Console.WriteLine("Found: " + elementFound.Name);
            }
        }

        internal static void FindInDictionary2(Dictionary<string, Element> elements, string symbol)
        {
            Element element = null;

            if (elements.TryGetValue(symbol, out element) == false)
                Console.WriteLine(symbol + " not found.");
            else
                Console.WriteLine("Found: " + element.Name);
        }
    }

    internal class Element
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public int AtomicNumber { get; set; }
    }
}
