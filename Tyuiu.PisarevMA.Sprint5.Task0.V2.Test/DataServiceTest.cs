using System.IO;
using Tyuiu.PisarevMA.Sprint5.Task0.V2.Lib;
namespace Tyuiu.PisarevMA.Sprint5.Task0.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            int x = 3;
            string path = ds.SaveToFileTextData(x);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
