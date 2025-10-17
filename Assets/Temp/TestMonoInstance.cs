
using UnityEngine;

namespace SN.Framework
{
    public class TestMonoInstance : NonMonoInstance<TestMonoInstance>
    {
        public int counter = 0;
        public void SaySomething(string s)
        {
            Debug.Log(s);
        }
    }

}
