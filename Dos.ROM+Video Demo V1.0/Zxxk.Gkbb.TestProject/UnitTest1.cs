using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zxxk.Gkbb.BusinessLayer;

namespace Zxxk.Gkbb.TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollegeEntranceLayer layer = new CollegeEntranceLayer();
            layer.GetVideoList();
        }
    }
}
