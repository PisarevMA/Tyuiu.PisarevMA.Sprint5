using Microsoft.ApplicationInsights;
using System.IO;
using Tyuiu.PisarevMA.Sprint5.Task2.V9.Lib;
namespace Tyuiu.PisarevMA.Sprint5.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3] { { 6, 8, 3 }, { 2, 6, 8 }, { 1, 7, 1 } };

            string path = ds.SaveToFileTextData(matrix);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
