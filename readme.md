# Collections
Creating and managing related objects often requires grouping, this is done with arrays or collections.

Arrays are useful for creating and working with a fixed number of strongly-typed objects whereas Collections are more flexible. Collections can
dynamically shrink and grow in size.

## Using a simple Collection
The generic `List<T>` class enables working with a strongly-typed list of objects.
```
// Create a list of strings.
var salmons = new List<string>();
salmons.Add("chinook");
salmons.Add("coho");
salmons.Add("pink");
salmons.Add("sockeye");

// Iterate through the list.
foreach (var salmon in salmons)
{
    Console.Write(salmon + " ");
}
// Output: chinook coho pink sockeye
```

If the contents of a collection are known in advance, a Collection Initializer can be used.

### Collection Initializer Example
```
// Create a list of strings by using a
// collection initializer.
var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

// Iterate through the list.
foreach (var salmon in salmons)
{
    Console.Write(salmon + " ");
}
// Output: chinook coho pink sockeye
```

### Removing Elements Example
When removing elements from a list, it is important to loop in reverse and not to use the `foreach` loop.
```
var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// Remove odd numbers.
for (var index = numbers.Count - 1; index >= 0; index--)
{
    if (numbers[index] % 2 == 1)
    {
        // Remove the element by specifying
        // the zero-based index in the list.
        numbers.RemoveAt(index);
    }
}

// Iterate through the list.
// A lambda expression is placed in the ForEach method
// of the List(T) object.
numbers.ForEach(
    number => Console.Write(number + " "));
// Output: 0 2 4 6 8
```

## Kinds of Collections
### System.Collections.Generic
Using a Collection class from `System.Collections.Generic` enforces strong typing.

Some frequently used classes are:
- Dictionary<TKey, TValue>          - Collection of key/value pairs organised based on the key.
- List<T>                           - List of objects of type T, accessible by index. Provides methods to search, sort and modify lists.
- Queue<T>                          - First In, First Out (FIFO) collection.
- SortedList<TKey, TValue>          - Collection of key/value pairs sorted by key based on the associated `IComparer<T>` implementation
- Stack<T>                          - Last In, First Out (LIFO) collection.

### Systems.Collections.Concurrent
From .NET Framework 4, collections implemented in the `Concurrent` namesapce provide efficient thread-safe operations
for accessing collection items from multiple threads.

Use the classes in the `Concurrent` namespace instead of the `Generic` or `Collections` namespaces whenever a collection is concurrently accessed
by multiple threads.

Some classes are:
- BlockingCollection<T>
- ConcurrentDictionary<TKey, TValue>
- ConcurrentQueue<T>
- ConcurrentStack<T>

### Systems.Collections
The `Collections` classes store objects as the type `Object` rather than their specific types.

Whenever possible, use the `Generic` or `Concurrent` namespace instead of the legacy types
within the `Collections` namespace.

Some classes are:
- ArrayList                         - Array of objects whose size is dynamically increased as required.
- HashTable                         - Collection of key/value pairs organised based on each keys hash code.
- Queue                             - First In, First Out (FIFO) collection.
- Stack                             - Last In, First Out (LIFO) collection.

### Systems.Collections.Specialized
The `Specialized` namespace provides specialised, strongly-typed collection classes i.e. string-only collections, linked-list and hybrid dictionaries.