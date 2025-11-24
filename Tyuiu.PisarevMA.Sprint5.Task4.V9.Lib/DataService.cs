using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PisarevMA.Sprint5.Task4.V9.Lib
{
    public class DataService : ISprint5Task4V9
    {
        public double LoadFromDataFile(string path)
        {
            return Math.Round((1 / Math.Sin(Convert.ToDouble(File.ReadAllText(path).Replace('.', ',')))) + Math.Pow(Convert.ToDouble(File.ReadAllText(path).Replace('.', ',')), 2), 3);
        }
    }
}
