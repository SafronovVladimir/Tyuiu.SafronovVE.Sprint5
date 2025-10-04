using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SafronovVE.Sprint5.Task0.V2.Lib
{
    public class DataService : ISprint5Task0V2
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.tx";

            double z = Math.Exp(x) / x;

            z = Math.Round(z, 3);

            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
