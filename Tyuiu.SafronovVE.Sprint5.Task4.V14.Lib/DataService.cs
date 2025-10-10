using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SafronovVE.Sprint5.Task4.V14.Lib
{
    public class DataService : ISprint5Task4V14
    {
        public double LoadFromDataFile(string path)
        {
            File.WriteAllText(path, "4.21");

            string strX = File.ReadAllText(path);
            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
            double x = double.Parse(strX, formatter);
            double res = Math.Sin(Math.Pow(x, 3)) + 2 / x;
            return Math.Round(res, 3);
        }
    }
}
