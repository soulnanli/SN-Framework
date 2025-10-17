using UnityEngine;

namespace SN.Framework
{
    public class MonoInstance<T> : MonoBehaviour where T : class,new()
    {
        private static T _instance;
        public static T Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new T();
                }
                return _instance;
            }
        }
        
        public static void CreateInstance()
        {
            _instance = new T();
        }
    }
    
    public class NonMonoInstance<T>  where T : class,new()
    {
        private static T _instance;
        public static T Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new T();
                }
                return _instance;
            }
        }
        
        public static void CreateInstance()
        {
            _instance = new T();
        }
    }
}

