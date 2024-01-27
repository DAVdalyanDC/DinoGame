using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Lesson7
{
    public class List<T>: IEnumerable<T>
    {
          T t;
        private T[] _array;
        public int Capacity=> _array.Length;
        public int Count {get; private set; }
        
      
        public List(int capacity = 0)
        {
            capacity= capacity==0 ? 4 : capacity;
            _array= new T[capacity];
            Count=0;
        }

        public void Add(T item)
        {
            if(Count==Capacity)
            {
                var _newArray =new T[Capacity * 2];
                for(int i=0;i<Count;i++)
                {
                    _newArray[i]=_array[i];
                }
                _array=_newArray;
            }
            _array[Count]=item;
            Count++;
        }

        public bool Remove(T item)
        {   
            int index=0;
            bool found = false;

            for(int i=0;i<=Count;i++)
            {
                if(!EqualityCompare<T>.Default.Equals(_array[i],item) )continue;
                index=i;
                found=true;
                break;

            }
            for(int i=index;i<Count;i++)
            {
                _array[i] = _array[i + 1];
            }
            return found;
        }

        public class EqualityCompare<T1>
        {
            public class Default
            {
            }
        }

        public bool RemoveAt(int index)
        {
            if(index>Count)return false;
            Count--;
            for(int i=index;i<Count; i++)
            {
                _array[i]=_array[i+1];
            }
            return true;
        }

        public void AddRange(int from, List<T> list)
        {
            var _newArray= new T[Count-from];
            
            for(int i=from;i<Count;i++)
            {
                _newArray[i - from] = _array[i];
            }
            
            Count=from;
            
            for(int i=0;i<list.Count;++i)
            {
                Add(list[i]);
            }
            for(int i=0;i<_newArray.Length;i++)
            {
                Add(_newArray[i]);
            }
        }

        public T this[int i]
        {
            get { throw new System.NotImplementedException(); }
        }

        public bool RemoveRange(int from, int to)
        {
            if(from<0 || to>Count) return false;
            
            var _newArray=new T[Count-to];
            for(int i=to;i<Count;i++)
            {
                _newArray[i-to]=_array[i];
            }
            Count= from;
            for(int i=0;i<_newArray.Length;i++)
            {
                Add(_newArray[i]);
            }
            return true;
        }

        public void Clear()
        {
            var _newArray=new T[Capacity];
            Count=0;
            _array=_newArray;
        }

        public class ForwardIterator : IEnumerator<T>
        {
            private List<T> _list;
            private int _index = -1;
            private T _item;

            public object Current => _list[_index];

            T IEnumerator<T>.Current => _item;

            public ForwardIterator(List<T> list)
            {
                _list = list;
            }

            public void Reset()
            {
                _index = -1;
            }

            public bool MoveNext()
            {
                if (_index >= _list.Count - 1) return false;
                _index++;
                return true;
            }
            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

        public class BackwardIterator :  IEnumerator<T>
        {
            private List<T> _list;
            private int _index;
            private T _item;
            
            public object Current => _list[_index];

            T IEnumerator<T>.Current => _item;

            public BackwardIterator(List<T> list)
            {
                _list = list;
            }

            public void Reset()
            {
                _index = -1;
            }

            public bool MoveNext()
            {
                if (_index <0) return false;
                _index--;
                return true;
            }
            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ForwardIterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
