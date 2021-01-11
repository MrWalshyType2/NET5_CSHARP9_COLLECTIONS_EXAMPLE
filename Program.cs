using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // DICTIONARY EXAMPLE //
            // DictionaryExample.IterateThruDictionary();

            var myDict = DictionaryExample.BuildDictionary();
            // DictionaryExample.FindInDictionary(myDict, "K");
            // DictionaryExample.FindInDictionary2(myDict, "K");

            // USING LINQ EXAMPLE //
            UsingLINQ.Elements = new List<Element> {
                new Element { AtomicNumber = 19, Name = "Potassium", Symbol = "K" },
                new Element { AtomicNumber = 20, Name = "Calcium", Symbol = "Ca" },
                new Element { AtomicNumber = 21, Name = "Scandium", Symbol = "Sc" },
                new Element { AtomicNumber = 22, Name = "Titanium", Symbol = "Ti" }
            };
            UsingLINQ.DoLanguageQuery();

            // SORTING COLLECTIONS EXAMPLE //
            SortingCollections.ListCars();

            // CUSTOM COLLECTION EXAMPLE //
            CustomCollection customCollection = new CustomCollection();
            
            foreach (Color color in customCollection)
            {
                Console.WriteLine(color.Name + " ");
            }
            Console.WriteLine();
        }
    }
}
