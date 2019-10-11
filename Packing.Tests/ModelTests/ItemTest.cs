using Microsoft.VisualStudio.TestTools.UnitTesting;
using Packs.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Packs.Tests
{
    [TestClass]
    public class PacksTest
    {
        Tracking newTracking;
        string name;
        string description;

        [TestInitialize]
        public void Setup()
        {
            name = "rope";
            description = "tool";
            newTracking = new Tracking(name, description);
        }

        [TestCleanup]
        public void TearDown()
        {
            Tracking.ClearAll();
        }

        [TestMethod]
        public void Constructor_ConstructorTesting_Tracking()
        {
            Assert.AreEqual(newTracking.GetType(), typeof(Tracking));
        }
        [TestMethod]
        public void GetAll_MakeSureWeCanGetAll_List()
        {
            List<Tracking> expected = new List<Tracking> {newTracking};
            CollectionAssert.AreEqual(Tracking.GetAll(),expected);
        }

        [TestMethod]
        public void ClearAll_MakeSureThatListIsCleared_List()
        {
            List<Tracking> expected = new List<Tracking> {};
            Tracking.ClearAll();
            List<Tracking> gotAll = Tracking.GetAll();
            CollectionAssert.AreEqual(gotAll, expected);
        }
        [TestMethod]
        public void FindID_FindAnItemById_Tracking()
        {
            int result = newTracking.Id;
            Assert.AreEqual(1,result);
        }

        [TestMethod]
        public void DeleteID_DeleteSpecificID_Delete()
        {
            List<Tracking> emptyList = new List<Tracking>{};
            List<Tracking> gotAll = Tracking.GetAll();
            int id = 1;
            Tracking.DeleteItem(id);
            CollectionAssert.AreEqual(gotAll, emptyList);

        }

    }
}