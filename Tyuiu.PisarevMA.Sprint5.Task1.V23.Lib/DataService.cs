using System.IO;
using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PisarevMA.Sprint5.Task1.V23.Lib
{
    public class DataService : ISprint5Task1V23
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(filePath);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(filePath);
            }
            double y;
            string strY;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i != -2)
                {
                    y = Math.Round(Math.Cos(i) + (Math.Cos(i)) / (i + 2) - 3 * i, 2);
                }
                else
                {
                    y = 0;
                }
                strY = Convert.ToString(y);
                if (i != stopValue)
                {
                    File.AppendAllText(filePath, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(filePath, strY);
                }
            }
            return filePath;
        }
    }
}
