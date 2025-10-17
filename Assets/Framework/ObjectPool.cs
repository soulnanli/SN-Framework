
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace SN.Framework
{
    public class ObjectPool<T> where T : class,new()
    {
        private Queue<T> _pool;
        public ObjectPool()
        {
            _pool = new();
        }
    
        public virtual T GetNewObject(int id)
        {
            if(_pool.Count > 0)
            {
                return _pool.Dequeue();
            }
            else
            {
                return new T();
            }
        }
    
        public void RecycleObject(T obj)
        {
            _pool.Enqueue(obj);
        }
    }
}

