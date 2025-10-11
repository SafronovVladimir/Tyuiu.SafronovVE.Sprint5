using System.Reflection;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SafronovVE.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException("Path cannot be null or empty", nameof(path));
            }

            string? directory = Path.GetDirectoryName(path);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "Привет, World! This моя Первая ПРограмма.");
            }
            
            string str = File.ReadAllText(path);
            string res = "";
            foreach (char i in str)
            {
                if ((i >= 'а' && i <= 'я') || (i >= 'А' && i <= 'Я'))
                {
                    res += i.ToString().ToLower();
                }

                else
                {
                    res += i.ToString();
                }
            }
            return res;
        }
    }
}
