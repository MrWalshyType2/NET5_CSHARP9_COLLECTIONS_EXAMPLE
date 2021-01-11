using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    /**
     * Custom Collections are defined by implementing `IEnumerable<T>` or `IEnumerable`.
     *  - Requires the `GetEnumerator` method to be implemented
     */
    public class CustomCollection : IEnumerable
    {
        internal Color[] _colors =
        {
            new Color() { Name = "red" },
            new Color() { Name = "blue" },
            new Color() { Name = "green" }

        };

        // Could also use the array types 'GetEnumerator' method
        public IEnumerator GetEnumerator() => new ColorEnumerator(_colors);

        private class ColorEnumerator : IEnumerator
        {
            private Color[] _colors;
            private int _position = -1;

            public ColorEnumerator(Color[] colors)
            {
                _colors = colors;
            }

            public object Current
            {
                get
                {
                    return _colors[_position];
                }
            }

            public bool MoveNext()
            {
                _position++;
                return (_position < _colors.Length);
            }

            public void Reset()
            {
                _position = -1;
            }
        }
    }

    internal class Color
    {
        public string Name { get; set; }
    }
}
