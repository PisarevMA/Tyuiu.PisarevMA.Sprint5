using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PisarevMA.Sprint5.Task7.V6.Lib
{
    public class DataService : ISprint5Task7V6
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);

            path = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V6.txt");

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            File.WriteAllText(path, Regex.Replace(text, "[a-zA-Z]", "#"));

            return path;
        }
    }
}