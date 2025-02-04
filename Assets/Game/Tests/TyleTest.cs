using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TyleTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void TyleTestSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    [Test]
    public void TyleConstructorWorksWithDifferentArrays()
    {
        var terrainTypes = new Tyle.TerrainType[] {0, (Tyle.TerrainType)1, 0, 0, 0, 0, 0};
        var tyle = new Tyle(0, 0, terrainTypes);
        Assert.That(tyle.ToString(), Is.EqualTo("Field Farm Field Field Field Field Field"));
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TyleTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
