
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace SN.Framework
{
    public class AssetManager : MonoInstance<AssetManager>
    {
        //private AssetManager(){}
        //TODO 优化
        public void LoadAsync<T>(string path, UnityAction<T> callback) where T : Object
        {
            StartCoroutine(LoadAssetAsync<T>(path, callback));
        }

        private IEnumerator LoadAssetAsync<T>(string path,UnityAction<T> callback) where T : Object
        {
            ResourceRequest rq = Resources.LoadAsync<T>(path);
            yield return rq;
            callback?.Invoke(rq.asset as T);
        }

        public T Load<T>(string path) where T : Object
        {
            return Resources.Load<T>(path);
        }
        
        public void UnloadUnusedAssetAsync(UnityAction callback)
        {
            StartCoroutine(UnloadAssetAsync(callback));
        }
        
        private IEnumerator UnloadAssetAsync(UnityAction callback)
        {
            AsyncOperation ao =  Resources.UnloadUnusedAssets();
            yield return ao;
            callback?.Invoke();
        }
        
        public void UnloadAsset(Object asset)
        {
            Resources.UnloadAsset(asset);
        }
    }
}

