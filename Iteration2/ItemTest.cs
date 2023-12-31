﻿using Iteration2;

namespace Iteration2;


    [TestFixture()]
    public class ItemUnitTest1
    {
        Item itemTest;
        

        [SetUp()]
        public void Setup()
        {
            itemTest = new Item(new string[] { "pc" }, "computer", "small computer");
            
        }

        [Test()]
        public void Test_Item_Is_Identifiable()
        {
            Assert.IsTrue(itemTest.AreYou("pc"));
        }

        [Test()]
        public void Test_Short_Description()
        {
            Assert.AreEqual("a computer (pc)", itemTest.ShortDescription);
        }

        [Test()]
        public void Test_Full_Description()
        {
            Assert.AreEqual("small computer", itemTest.FullDescription);
        }
    }

