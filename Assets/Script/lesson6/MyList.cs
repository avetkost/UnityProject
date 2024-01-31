using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson6
{
    public class MyList<T> : MonoBehaviour
    {
        private T[] array;
        
        public int Capacity { get; private set; }
        public int Count { get; private set; }

        public MyList(int capacity = 0)
        {
            Capacity = (capacity == 0) ? 4 : capacity;
            array = new T[Capacity];
            Count = 0;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException("Index is out of range.");

                return array[index];
            }
            set
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException("Index is out of range.");

                array[index] = value;
            }
        }

        public void Add(T element)
        {
            if (Count == Capacity)
            {
                
                Capacity *= 2;
                Array.Resize(ref array, Capacity);
            }

            array[Count++] = element;
        }

        public void Remove(T element)
        {
            int index = Array.IndexOf(array, element, 0, Count);
            if (index != -1)
            {
                
                for (int i = index; i < Count - 1; i++)
                {
                    array[i] = array[i + 1];
                }

                Count--;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException("Index is out of range.");

            
            for (int i = index; i < Count - 1; i++)
            {
                array[i] = array[i + 1];
            }

            Count--;
        }

        public void AddRange(int from, MyList<T> myList)
        {
            if (from < 0 || from > Count)
                throw new IndexOutOfRangeException("Index is out of range.");

            
            while (Count + myList.Count > Capacity)
            {
                Capacity *= 2;
                Array.Resize(ref array, Capacity);
            }

            
            for (int i = Count - 1; i >= from; i--)
            {
                array[i + myList.Count] = array[i];
            }

            
            for (int i = 0; i < myList.Count; i++)
            {
                array[from + i] = myList[i];
            }

            Count += myList.Count;
        }

        public void RemoveRange(int from, int to)
        {
            if (from < 0 || from >= Count || to < from || to >= Count)
                throw new IndexOutOfRangeException("Index is out of range.");

            int rangeLength = to - from + 1;

            
            for (int i = from; i < Count - rangeLength; i++)
            {
                array[i] = array[i + rangeLength];
            }

            Count -= rangeLength;
        }

        public void Clear()
        {
            Count = 0;
        }
    }
}