using System.Collections.Generic;
using Newtonsoft.Json;
using NUnit.Framework;

public class Test_JsonDotNet
{
    [Test]
    public void Test_JsonDotNet_Polymorph()
    {
        var earth = new Planet() { Level = 3, Name = "MotherEarth" };
        var json = JsonConvert.SerializeObject(earth);
        var deserialized = JsonConvert.DeserializeObject<Planet>(json);
        Assert.AreEqual(3, deserialized.Level);
        Assert.AreEqual("MotherEarth", deserialized.Name);
        var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
        var mars = new Planet() { Level = 2, Name = "RedHotBall" };
        var json_mars = JsonConvert.SerializeObject(mars, settings);
        var deserialized_mars = JsonConvert.DeserializeObject<Star>(json_mars, settings);
        Assert.AreEqual(2, (deserialized_mars as Planet).Level);
        Assert.AreEqual("RedHotBall", deserialized_mars.Name);
    }

    public class Star
    {
        public string Name;
    }

    public class Planet : Star
    {
        public int Level;
    }
}