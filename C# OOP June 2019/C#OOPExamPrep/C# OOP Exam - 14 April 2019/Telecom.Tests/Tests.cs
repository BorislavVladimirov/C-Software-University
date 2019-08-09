using NUnit.Framework;
using System;

public class Tests
{
    private const string Make = "Huawei";
    private const string Model = "Mate";
    private Phone phone;

    [SetUp]
    public void Setup()
    {
        phone = new Phone(Make, Model);
    }

    [Test]
    public void TestMake()
    {
        Assert.AreEqual(Make, this.phone.Make);
    }

    [Test]
    public void TestModel()
    {
        Assert.AreEqual(Model, phone.Model);
    }

    [Test]
    public void TestCount()
    {
        Assert.AreEqual(0, this.phone.Count);
    }

    [Test]
    public void TestMakeException()
    {
        Assert.Throws<ArgumentException>(() => phone = new Phone("", Model));
    }

    [Test]
    public void TestModelException()
    {
        Assert.Throws<ArgumentException>(() => phone = new Phone(Make, ""));
    }

    [Test]
    public void TestBookAddCorrecly()
    {
        this.phone.AddContact("IVan", "08888888");
        Assert.AreEqual(1, this.phone.Count);
    }

    [Test]
    public void TestBookAddInCorrecly()
    {
        Assert.Throws<InvalidOperationException>(() =>
        {
            this.phone.AddContact("IVan", "08888888");
            this.phone.AddContact("IVan", "08888888");
        });
    }

    [Test]
    public void TestCall()
    {
        this.phone.AddContact("IVan", "08888888");

        var result = this.phone.Call("IVan");

        Assert.AreEqual($"Calling IVan - 08888888...", result);
    }

    [Test]
    public void TestCallThrows()
    {
        Assert.Throws<InvalidOperationException>(() =>
        {
            this.phone.AddContact("IVan", "08888888");
            var result = this.phone.Call("Pesho");

        });
    }

    //[Test]
    //public void KostaTest()
    //{
    //    this.phone.AddContact("IVan", "08888888");

    //    this.phone.Call("IVan");
    //    var result = this.phone.Call("IVan");

    //    Assert.AreEqual($"Calling IVan - 08888888...", result);

    //    Assert.Throws<InvalidOperationException>(() =>
    //   {
    //       result = this.phone.Call("Pesho");
    //   });
    //}


    //[Test]
    //public void KostaTest1()
    //{
    //    this.phone.AddContact("IVan", "08888888");
    //    Assert.AreEqual(1, this.phone.Count);

    //    Assert.Throws<InvalidOperationException>(() =>
    //    {
    //        this.phone.AddContact("IVan", "08888888");
    //    });
    //}
}