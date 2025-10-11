using System.Reflection;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SafronovVE.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {
            File.WriteAllText(path, "Привет, World! This моя Первая ПРограмма.");
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
            File.WriteAllText(path, res);
            return path;
        }
    }
}
