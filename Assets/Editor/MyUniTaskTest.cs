using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class MyUniTaskTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void MyUniTaskTestSimplePasses()
        {
            // Use the Assert class to test conditions
            Debug.Log("MyUniTaskTestSimplePasses ++++++");
            Debug.Log("MyUniTaskTestSimplePasses ------");
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator MyUniTaskTestWithEnumeratorPasses()
        {
            Debug.Log("MyUniTaskTestWithEnumeratorPasses +++");
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
            Debug.Log("MyUniTaskTestWithEnumeratorPasses ---");
        }
    }
}
