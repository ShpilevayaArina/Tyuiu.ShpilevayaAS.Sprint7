using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint7.Project.V2.Lib;
using System.IO;

namespace Tyuiu.ShpilevayaAS.Sprint7.Project.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReadCsv()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\katri\source\repos\Tyuiu.ShpilevayaAS.Sprint7\Tyuiu.ShpilevayaAS.Sprint7.Project.V2.Test\bin\Debug\InPutFileProjectV2.csv"; ;

            int row = 0;
            int column = 1;
            string res = ds.ReadCsv(path, row, column);

            string wait = "1, Екатеринбург";
            Assert.AreEqual(wait, res);
        }
    }
}
