using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    namespace CustomList
    {
        public class CustomList<T> : IEnumerable
        {
            private int count;
            private int capacity;
            public T[] array;

            public int Count { get { return count; } }
            public int Capacity { get { return capacity; } }
            public T this[int i] { get { return GrabValue(array, i); } set { DeliverArrayValue(i, value); } }

            public CustomList()
            {
                count = 0;
                capacity = 6;
                array = new T[capacity];
            }

            public void Add(T item)
            {
                if (count == capacity)
                {
                    Grow();
                }
                array[count] = item;
                count++;
            }

            public void Grow()
            {
                T[] tempArray = new T[capacity *= 2];
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = array[i];
                }
                array = tempArray;
            }

            public bool Remove(T item)
            {
                for (int i = 0; i < count; i++)
                {
                    if (item.Equals(array[i]))
                    {
                        if (array[i].Equals(array[count - 1]))
                        { array[i] = default(T); count--; return true; }
                        count--;
                        MoveIt(i);
                        return true;
                    }
                }
                return false;
            }

            public void MoveIt(int position)
            {
                for (int k = position; k < count; k++)
                {
                    array[k] = array[k + 1];
                }
                array[count] = default(T);
            }

            public CustomList<T> ZipIt(CustomList<T> secondArray)
            {
                CustomList<T> zippedArray = new CustomList<T>();
                int smallest = count <= secondArray.count ? count : secondArray.count;
                for (int i = 0; i < smallest; i++)
                {
                    zippedArray.Add(array[i]);
                    zippedArray.Add(secondArray[i]);
                }
                return zippedArray;
            }

            public static CustomList<T> operator +(CustomList<T> firstArray, CustomList<T> secondArray)
            {
                CustomList<T> thirdArray = firstArray;
                for (int i = 0; i < secondArray.count; i++)
                {
                    thirdArray.Add(secondArray[i]);
                }
                return thirdArray;
            }

            public static CustomList<T> operator -(CustomList<T> firstArray, CustomList<T> secondArray)
            {
                CustomList<T> tempArray = new CustomList<T>();
                for (int i = 0; i < firstArray.count; i++)
                {
                    tempArray[i] = firstArray[i];
                    tempArray.count++;
                }
                for (int t = 0; t < tempArray.count; t++)
                {
                    for (int k = 0; k < secondArray.count; k++)
                    {
                        if (tempArray[t].Equals(secondArray[k]))
                        {
                            tempArray.Remove(tempArray[t]);
                            t--;
                            break;
                        }
                    }
                }
                return tempArray;
            }

            public override string ToString()
            {
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < count; i++)
                {
                    stringBuilder.Append(array[i].ToString() + "\n");
                }

                return stringBuilder.ToString();
            }

            private void Swap(int indexA, int indexB)
            {
                T holder = array[indexA];
                array[indexA] = array[indexB];
                array[indexB] = holder;
            }

           
            public void DeliverArrayValue(int i, T value)
            {
                if (i >= capacity)
                {
                    while (i >= capacity)
                    {
                        Grow();
                    }
                }
                array[i] = value;
                count++;
            }

            public static T GrabValue(T[] array, int i)
            {
                try
                {
                    return array[i];
                }
                catch (IndexOutOfRangeException ex)
                {
                    ArgumentException argEx = new System.ArgumentException("Index is out of range", "index", ex);
                    throw argEx;
                }
            }

            public IEnumerator GetEnumerator()
            {
                return array.GetEnumerator();
            }
        }
    }
}
