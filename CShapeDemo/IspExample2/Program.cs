using System.Collections;

namespace IspExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3,4,5 };
            ArrayList nums2 = new ArrayList { 1, 2, 3, 4, 5 };

            var nums3 = new ReadOnlyCollection(nums1);
            Console.WriteLine(Sum(nums1));
            Console.WriteLine(Sum(nums2));
            Console.WriteLine(Sum(nums3));
        }

        static int Sum(IEnumerable nums)
        {
            int sum = 0;

            foreach (var n in nums)
            {
                sum += (int)n;
            }
            return sum;
        }

    }

    class ReadOnlyCollection : IEnumerable
    {
        private int[] array;
        public ReadOnlyCollection(int[] array)
        {
            this.array = array;
        }

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }

        //note(guoliang): 成员类
        public class Enumerator : IEnumerator
        {
            private ReadOnlyCollection _collection;
            private int _head;
            public Enumerator(ReadOnlyCollection collection)
            {
                _collection = collection;
                _head = -1;
            }
            public object Current {
                get {
                    object o = _collection.array[_head];
                    return o;
                }
            }

            public bool MoveNext()
            {
                if(++_head < _collection.array.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                _head = -1;
            }
        }
    }

}