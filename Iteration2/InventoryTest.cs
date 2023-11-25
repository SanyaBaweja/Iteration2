using Iteration2;

namespace Iteration2;

[TestFixture()]
public class InventoryTest
{
    Inventory inv;
    Item shovel, sword, computer;
    


    [SetUp()]
    public void Setup()
    {
        inv = new Inventory();
        shovel = new Item(new string[] { "shovel" }, "shovel", "");
        inv.Put(shovel);

        sword = new Item(new string[] { "sword" }, "sword", "bronze");
        inv.Put(sword);

        computer = new Item(new string[] { "pc" }, "computer", "small");
        inv.Put(computer);

        
    }
    [Test()]
    public void Test_Find_Item()
    {

        Assert.IsTrue(inv.HasItem("shovel"));
        Assert.IsTrue(inv.HasItem("sword"));
        Assert.IsTrue(inv.HasItem("pc"));
    }

    [Test()]
    public void Test_No_Item_Find()
    {
        Assert.IsFalse(inv.HasItem("food"));

        Assert.IsFalse(inv.HasItem("boat"));
    }

    [Test()]
    public void Test_Fetch_Item()
    {
        Assert.AreEqual(shovel, inv.Fetch("shovel"));
        Assert.IsTrue(inv.HasItem("shovel"));

        Assert.AreEqual(sword, inv.Fetch("sword"));
        Assert.IsTrue(inv.HasItem("sword"));

        Assert.AreEqual(computer, inv.Fetch("pc"));
        Assert.IsTrue(inv.HasItem("pc"));
    }

    [Test()]
    public void Test_Take_Item()
    {
        inv.Take("shovel");
        Assert.IsFalse(inv.HasItem("shovel"));
    }

    [Test()]
    public void Test_Item_List()
    {
        Assert.AreEqual("\ta shovel (shovel)\n\ta sword (sword)\n\ta computer (pc)\n", inv.ItemList);
    }


}