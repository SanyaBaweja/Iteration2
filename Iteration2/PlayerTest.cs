using System;
using System.Xml.Linq;

namespace Iteration2
{
	public class PlayerTest
	{
		
		Item shovel, sword, computer;
		Player pl;
		


		[SetUp()]
		public void Constructor_PlayerTest()
		{
			
            pl = new Player("Fred", "the mighty programmer");
            shovel = new Item(new string[] { "shovel" }, "shovel", "");
            sword = new Item(new string[] { "sword" }, "sword", "bronze");
            computer = new Item(new string[] { "pc" }, "computer", "small");
			

            pl.Inv.Put(shovel);
            pl.Inv.Put(sword);
			pl.Inv.Put(computer);
            

        }
		[Test()]
		public void Test_Player_is_Identifiable()
		{
			Assert.IsTrue(pl.AreYou("me"));
		}
		[Test()]
		public void Test_Player_Locates_Items()
		{
			Assert.AreEqual(shovel, pl.Locate("shovel"));
            Assert.IsTrue(pl.Inv.HasItem("shovel"));


            Assert.AreEqual(sword, pl.Locate("sword"));
            Assert.IsTrue(pl.Inv.HasItem("sword"));


            Assert.AreEqual(computer, pl.Locate("pc"));
            Assert.IsTrue(pl.Inv.HasItem("pc"));

        }
		[Test()]
		public void Test_Player_Locates_Itself()
		{
            Assert.AreEqual(pl, pl.Locate("me"));
            Assert.AreEqual(pl, pl.Locate("inventory"));

        }
		[Test()]
		public void Test_Player_Locates_Nothing()
		{
			Assert.AreEqual(null, pl.Locate("food"));

            Assert.AreEqual(null, pl.Locate("boat"));
        }
		[Test()]
		public void Test_Player_full_Description()
		{
			Assert.AreEqual("You are Fred the mighty programmer.\n" + "You are carrying\n" + "\ta shovel (shovel)\n\ta sword (sword)\n\ta computer (pc)\n", pl.FullDescription);
		}
    }
}

