using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text;
namespace Tyuiu.SafronovVE.Sprint5.Task3.V12.Lib
{
    public class DataService : ISprint5Task3V12
    {
        public string SaveToFileTextData(int x)
        {
            string tempPath = Path.GetTempPath();
            string filePath = Path.Combine($"{tempPath}", "OutPutFileTask3");
            double y = Math.Pow(x, 3) / (2 * Math.Pow(x + 5, 2));
            y = Math.Round(y, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return filePath;
        }
    }
}
