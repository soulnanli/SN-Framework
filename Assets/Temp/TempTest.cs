
using SN.Framework;
using UnityEngine;

public class TempTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TestMonoInstance.Instance.SaySomething("Hello MonoInstance");
        TestMonoInstance.Instance.counter++;
        Debug.Log("Counter: " + TestMonoInstance.Instance.counter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
