using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class DragonDamage
    {
        // A Test behaves as an ordinary method
        [Test]
        public void DragonDamageSimplePasses()
        {
			// Use the Assert class to test conditions
			
			//System.Timers.Timer(5000);
			

		}

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator DragonDamageWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
