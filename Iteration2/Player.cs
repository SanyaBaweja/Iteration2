using System;
namespace Iteration2
{
	public class Player: Game_Object
	{
		Inventory _inventory = new Inventory();

		public Player(string name, string desc):base(new string[] {"me", "inventory"}, name, desc)
		{
			//Inventory _inventory = new() Inventory;
		}

		public Game_Object Locate(string id)  //Locate method returns the item using id and calls the Fetch method to retrieve the item.
		{
			if(AreYou(id) == true)
			{
				return this;
			}
			return _inventory.Fetch(id);
		}
		public Inventory Inv  //readonly method for Inventory
		{
			get
			{
				return _inventory;
			}
		}
        public override string FullDescription   // Full description returns the name, full description and itemlist.
        {
            get
			{
				return ("You are " + Name + " " + base.FullDescription + "." + "\nYou are carrying\n" + Inv.ItemList);
			}
        }
    }
}

