using System.Collections.Generic;
using UnityEngine;

namespace Lesson7
{
    public class Stack<T>
    {
        private List<T> _list;
        private int _count;

        public void List()
        {
            _list = new List<T>();
            _count = _list.Count;
        }

        public void Push(T item)
        {
            _list.Add(item);
            _count = _list.Count;
        }

        public T Pop()
        {
            if (_count == 0)
            {
                Debug.Log("stack is empty");
                return default;
            }

            T item = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            _count = _list.Count;
            return item;
        }

        public T Pick()
        {
            T item = _list[_list.Count - 1];
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
            while (!IsEmpty())
            {
                Pop();
            }
        }
    }
}