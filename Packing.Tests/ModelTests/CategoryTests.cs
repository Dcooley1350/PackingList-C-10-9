using Microsoft.VisualStudio.TestTools.UnitTesting;
using Packs.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Packs.TestTools{
    [TestClass]
    public class CategoryTest
    {
        Category newCategory;
        string name;

        [TestInitialize]
        public void Setup()
        {
            name = "Test Category";
            newCategory = new Category(name);
        }
        [TestCleanup]
        public void TearDown()
        {
            Category.ClearAll();            
        }

        [TestMethod]
        public void CategoryConstructor_CreatesInstaceOfCategory_Category()
        {
            Assert.AreEqual(typeof(Category),newCategory.GetType());
        }
        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            string name = newCategory.Name;
            Assert.AreEqual(name, "Test Category");
        }
        [TestMethod]
        public void GetID_ReturnsID_Int()
        {
            int ID = newCategory.Id;
            Assert.AreEqual(1, ID);
        }
        [TestMethod]
        public void GetAll_ReturnsAllCategoryObjects_CategoryList()
        {
            string name2 = "School";
            Category newCategory2 = new Category(name2);
            List<Category> testList = new List<Category> {newCategory, newCategory2};
            List<Category> result = Category.GetAll(); 
            CollectionAssert.AreEqual(testList,result);
        }
        [TestMethod]
        public void Find_FindAnItemByID_Category()
        {
            int idToFind = 1;
            Category testCategory = new Category(name);
            Category foundCategory = Category.Find(idToFind);
            Assert.AreEqual(foundCategory,testCategory);
        }
    }
}