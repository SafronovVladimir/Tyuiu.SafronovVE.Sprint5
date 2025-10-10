using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SafronovVE.Sprint5.Task5.V5.Lib
{
    public class DataService : ISprint5Task5V5
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "-3.09 3 3 7.48 -3.22 17.29 8 -4 0.83 14.18 -6 8.15 -8.7 -3.06 20 -4 15.82 -10 9 -3");
            }

            string text = File.ReadAllText(path);
            string[] strings = text.Split(' ');
            double[] doubles = new double[20];
            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
            for (int i = 0; i < strings.Length; i++)
            {
                doubles[i] = double.Parse(strings[i], formatter);
            }
            double res = Math.Round(doubles.Max() - doubles.Min(), 3);
            return res;
        }
    }
}
