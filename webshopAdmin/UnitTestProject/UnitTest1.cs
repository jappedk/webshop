using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using webshopAdmin;
using webshopAdmin.Service;
using webshopAdmin.Dao;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        
        public webshopAdmin.Service.Service service = new webshopAdmin.Service.Service();
        lewebshopEntities db = webshopAdmin.Dao.Database.db;


        [ClassInitialize]
        [TestMethod]
        public void createProduct()
        {
           service.createProduct("name", 20,20,"pic", 30, "country");
           foreach (var product in from p in db.Products select p)
           {
               Product pe = product;
               Assert.AreEqual("name", pe.name);
               Assert.AreEqual(20, pe.unitPrice);
               Assert.AreEqual("pic", pe.pic);
               Assert.AreEqual("country", pe.country);

           }

           

        }
    }
}
