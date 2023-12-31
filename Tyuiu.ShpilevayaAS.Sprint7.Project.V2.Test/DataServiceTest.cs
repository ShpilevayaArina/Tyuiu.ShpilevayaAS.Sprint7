﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint7.Project.V2.Lib;
using System.IO;
using System.Collections.Generic;

namespace Tyuiu.ShpilevayaAS.Sprint7.Project.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetDataFromFile()
        {
            string path = @"C:\Users\katri\source\repos\Tyuiu.ShpilevayaAS.Sprint7\Tyuiu.ShpilevayaAS.Sprint7.Project.V2.Lib\ListOfDepartments.csv";
            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
