﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

using Tyuiu.CherkashinMM.Sprint0.Task2.V0.Lib;

namespace Tyuiu.CherkashinMM.Sprint0.Task2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Максим";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Максим", res);
        }
    }
}
