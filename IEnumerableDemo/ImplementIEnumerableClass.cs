using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IEnumerableDemo
{
    class ImplementIEnumerableClass:IEnumerable
    {
        private ImplementIEnumerableClass[] Items = null;

        private int freeIndex = 0;

        public string Name { get; set; }
        public string LastName { get; set; }

        public ImplementIEnumerableClass()
        {
            Items = new ImplementIEnumerableClass[10];
        }

        public void Add(ImplementIEnumerableClass item)
        {
            Items[freeIndex] = item;
            freeIndex++;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Object o in Items)
            {
                if (o == null)
                {
                    break;
                }
                yield return o;
            }
        }
    }
}
