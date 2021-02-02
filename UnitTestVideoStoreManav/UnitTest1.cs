using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoStoreManav;
using System.Data;

namespace UnitTestVideoStoreManav
{
    [TestClass]
    public class UnitTest1
    {
        // test the database connection by returning database name from Database Server.
        [TestMethod]
        public void TestDBConnection()
        {
            VideoStoreManavDBClass db = new VideoStoreManavDBClass();
            Assert.AreEqual(db.ReturnDBName(), "VideoStoreDB");
        }

        // test the database connection by checking the state (if connection is open or close) on lauching the program. 
        [TestMethod]
        public void TestDBConnectionState()
        {
            VideoStoreManavDBClass db = new VideoStoreManavDBClass();
            
            Assert.AreNotEqual(db.ReturnDBConnectionState(), ConnectionState.Open);
        }
    }
}
