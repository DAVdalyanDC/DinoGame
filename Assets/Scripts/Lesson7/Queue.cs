using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Lesson7
{
    public class Queue<T>
    {
        private List<T> _list;
        private int _count { get; set; }

        public Queue()
        {
            _list = new List<T>();
            _count = _list.Count;
        }

        public void Enqueue(T item)
        {
            _list.Add(item);
            _count = _list.Count;
        }

        public T Dequeue()
        {
            if (_count == 0)
            {
                Debug.Log("Queue is empty");
                return default;
            }

            T item = _list[0];
            _list.RemoveAt(0);
            _count = _list.Count;
            return item;
        }

        public bool IsEmpty()
        {
            if (_count == 0)
            {
                return true;
            }

            return false;
        }

        public void Clear()
        {
            while (_count != 0)
            {
                Dequeue();
            }
        }
    }
}