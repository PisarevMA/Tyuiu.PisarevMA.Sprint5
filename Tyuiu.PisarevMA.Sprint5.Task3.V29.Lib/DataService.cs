using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PisarevMA.Sprint5.Task3.V29.Lib
{
    public class DataService : ISprint5Task3V29
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            double res = Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + 5 * x + 4;
            res = Math.Round(res, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), encoding: UTF8Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(res));
            }
            return path;
        }
    }
}
