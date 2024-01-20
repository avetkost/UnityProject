// using System.Threading;
// using JetBrains.Annotations;
// using UnityEngine.UIElements;

// namespace generic
// {
//     public class List<T>
//     {
//         private T[] _array;

        
//         public List(int capacity = 0)
//         {
//             // if(capacity == 0) return;
//             capacity = capacity == 0 ? 4 : capacity;
//             _array = new T [capacity];
//         } 
//     public void Add(T)
//     {
//         if (Count == Capacity)
//         {
//             var newArray = new T[Capacity * 2];
//             for(int i = 0; i < _array.Length; i++)
//             {
//                 newArray[i] = _array[i];
//             }
//             _array = newArray;
//         }
//         _array[Count] = item;
//         Count++;
        
//     }
//     }
// }